using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.FuncionesGenerales;



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
        public string nombreUsuario;
        Funciones fn = new Funciones();

   

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          

            //VER SI FALTAN DATOS -TODO
            if (!FaltanDatos())
            {

                if (fn.ExisteUsuario(txtBoxUsuario.Text))
                {
                    idUsuario = (int)new Query("SELECT ID_USUARIO FROM JJRD.USUARIOS WHERE USERNAME='" + txtBoxUsuario.Text + "'").ObtenerUnicoCampo();
                    Query qr = new Query("SELECT LOGIN_FALLIDOS FROM JJRD.USUARIOS WHERE ID_USUARIO=" + idUsuario);
                    failLogin = Convert.ToInt32(qr.ObtenerUnicoCampo()); //MOVER DE ACA

                    if (fn.puedeIngresarAlSistema(idUsuario))
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

        private void validar()
        {
            int consValidar = (int)new Query("SELECT count(1) FROM JJRD.USUARIOS WHERE ID_USUARIO ='" + idUsuario + "' AND CONTRASENIA ='" + txtBoxPasswd.Text + "'").ObtenerUnicoCampo();

            if (consValidar == 1)
            {
                reseteaLoginFallidos();
                
                int IdRolCant = (int)new Query("SELECT count(*) FROM JJRD.ROL_USUARIO  " +
                                           " WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo();

                Globales.idUsuarioLogueado = idUsuario;


                primerLogin();

                switch (IdRolCant)
                {
                    case 0: MessageBox.Show("El usuario no posee ningun perfil.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                    case 1: this.Visible = false;
                            fn.recibirUsuario(idUsuario);
                           

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
                fn.inhabilitarUsuario(idUsuario);
            }
            else
            {
                new Query("UPDATE JJRD.USUARIOS SET LOGIN_FALLIDOS= " + failLogin + " WHERE ID_USUARIO = " + idUsuario).Ejecutar();
            }
        }

        

        private void seleccionarRol()
        {
            this.Visible = false;
            FrmRolesLogin frm = new FrmRolesLogin(idUsuario);
            frm.ShowDialog();
            

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

        public void primerLogin()
        {
            if (primeraVezQueIngresaAlSistema())
            {

                FrmPrimerLogin primerlogin = new FrmPrimerLogin(idUsuario);
                this.Hide();
                primerlogin.ShowDialog();
                primerlogin = (FrmPrimerLogin)this.ActiveMdiChild;

            }
        }

        private bool primeraVezQueIngresaAlSistema() 
        {
            Query qr = new Query("SELECT TIPO_DE_USUARIO FROM JJRD.USUARIOS WHERE ID_USUARIO = " + idUsuario);
            string tipo = qr.ObtenerUnicoCampo().ToString();

            switch (tipo)
            {
                case "C":  Query emailCl = new Query("SELECT EMAIL FROM JJRD.CLIENTE WHERE ID_USUARIO = " + idUsuario);
                                return (emailCl.ObtenerUnicoCampo().ToString().ToUpper() == txtBoxUsuario.Text.ToUpper());
                                break;

                case "E":  Query emailEmp = new Query("SELECT EMAIL FROM JJRD.EMPRESA WHERE ID_USUARIO = " + idUsuario);
                                return (emailEmp.ObtenerUnicoCampo().ToString().ToUpper() == txtBoxUsuario.Text.ToUpper());
                                break;
                //"A"
                default: return false;
                                break;
            }

        }

        private void lnkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrarUsuario registrarUsr = new FrmRegistrarUsuario();
            this.Hide();
            registrarUsr.ShowDialog();
            registrarUsr = (FrmRegistrarUsuario)this.ActiveMdiChild;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
