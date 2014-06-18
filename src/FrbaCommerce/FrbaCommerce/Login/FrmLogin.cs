using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace FrbaCommerce.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public int idUsuario;
        public int failLogin;
        public int idRol;
        public string nombreUsuario;
       

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //VER SI FALTAN DATOS -TODO
            if (!FaltanDatos())
            {

                if (ExisteUsuario(txtBoxUsuario.Text))
                {
                    idUsuario = (int)new Query("SELECT ID_USUARIO FROM JJRD.USUARIOS WHERE USERNAME='" + txtBoxUsuario.Text + "'").ObtenerUnicoCampo();
                    Query qr = new Query("SELECT LOGIN_FALLIDOS FROM JJRD.USUARIOS WHERE ID_USUARIO=" + idUsuario);
                    failLogin = Convert.ToInt32(qr.ObtenerUnicoCampo());

                    if (puedeIngresarAlSistema(idUsuario))
                    {
                        validar();
                    }
                    else
                    {
                        MessageBox.Show("El usuario se encuentra inhabilitado.", "Error", MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ingresado no existe.", "Advertencia",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        /*Si el Login es incorrecto el usuario no podrá acceder al sistema. Se debe volver a
        mostrar el Login para que intente nuevamente. El sistema debe llevar un registro de
        cantidad intentos fallidos de login. Luego de 3 intentos fallidos en cualquier momento,
        el usuario debe ser inhabilitado. Al realizar un Login satisfactorio, el sistema deberá
        limpiar la cantidad de intentos fallidos. */

        public bool ExisteUsuario(string usuario)
        {
            return ((int)new Query("SELECT COUNT(1) FROM JJRD.USUARIOS WHERE USERNAME ='" + usuario + "'").ObtenerUnicoCampo() == 1);
        }

        public bool puedeIngresarAlSistema(int idUsuario) //MOVER A FUNCIONES GENERALES
        {
            return ((int)new Query("SELECT count(1) FROM JJRD.USUARIOS WHERE ID_USUARIO ='" + idUsuario + "' AND HABILITADO = 1").ObtenerUnicoCampo() != 0);
        }
        //TODO- ARREGLAR CONTRASEÑAS CON ESPACIOS
        private void validar()
        {
            int consValidar = (int)new Query("SELECT count(1) FROM JJRD.USUARIOS WHERE ID_USUARIO ='" + idUsuario + "' AND CONTRASEÑA ='" + txtBoxPasswd.Text + "'").ObtenerUnicoCampo();

            if (consValidar == 1)
            {
                reseteaLoginFallidos();
                
                int IdRolCant = (int)new Query("SELECT count(*) FROM JJRD.ROL_USUARIO  " +
                                           " WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo();

                switch (IdRolCant)
                {
                    case 0: MessageBox.Show("El usuario no posee ningun perfil.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                    case 1: //SETEO IDROL POR LAS DUDAS, VER SI SE NECESITA PARA DESPUES
                            idRol = (int)new Query("SELECT ID_ROL FROM JJRD.ROL_USUARIO  " +
                                          " WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo();

                            this.Visible = false;
                            recibirUsuario(txtBoxUsuario.Text, idRol, idUsuario);
                           

                            break;

                   default: seleccionarRol();
                            break;
                        
                }

            }
            else
            {
                failLogin++;
                if (failLogin < 3)
                {
                    MessageBox.Show("La contraseña ingresada es incorrecta. Intentos Fallidos : " + failLogin + " de 3.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actualizaLoginFallidos();
            }

        }

        private void reseteaLoginFallidos()
        {
            if (failLogin != 0)
            {
                new Query("UPDATE JJRD.USUARIOS SET LOGIN_FALLIDOS= '0' WHERE ID_USUARIO = " + idUsuario).Ejecutar();
                
            }
        }


        private void actualizaLoginFallidos()
        {
            if (failLogin == 3)
            {
                inhabilitarUsuario(idUsuario);
            }
            else
            {
                new Query("UPDATE JJRD.USUARIOS SET LOGIN_FALLIDOS= " + failLogin + " WHERE ID_USUARIO = " + idUsuario).Ejecutar();
            }
        }

        public void inhabilitarUsuario(int idUsuario) //MOVER A FUNCIONES GENERALES
        { 
            new Query("UPDATE JJRD.USUARIOS SET HABILITADO = '0' WHERE ID_USUARIO = " + idUsuario).Ejecutar();
            //TODO - cuando se vuelve a habilitar el usuario se resetea el campo FAIL_LOGIN a 0
            MessageBox.Show("Se ha inhabilitado el usuario.", "Advertencia",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void seleccionarRol()
        {
            this.Visible = false;
            FrmRolesLogin frm = new FrmRolesLogin(idUsuario);
            frm.ShowDialog();
            this.Visible = true;

        }

        private bool FaltanDatos()
        {
            if (txtBoxUsuario.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el Usuario.", "Validación al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxUsuario.Focus();
                return true;
            }
            if (txtBoxPasswd.Text.Length == 0)
            {
                MessageBox.Show("Ingrese la contraseña.", "Validación al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxPasswd.Focus();
                return true;
            }
            return false;
        }

        public void recibirUsuario(string nombreUsuario, int idRol, int idUsuario)
        {

            MessageBox.Show("Bienvenido a Commerce" + Environment.NewLine +
            "Usted se ha registrado como usuario: " + nombreUsuario.ToUpper(), "Bienvenido!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.cargarFrmPrincipal(nombreUsuario, idRol, idUsuario);
            frmPrincipal.ShowDialog();
                           
        }

        private void lnkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrarUsuario registrarUsr = new FrmRegistrarUsuario();
            this.Hide();
            registrarUsr.ShowDialog();
            registrarUsr = (FrmRegistrarUsuario)this.ActiveMdiChild;
        }
    }
}
