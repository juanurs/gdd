using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Login; //FUNCIONES GENERALES

namespace FrbaCommerce
{

    public partial class FrmPrimerLogin : Form
    {
        private int idUsuario;

        public FrmPrimerLogin(int idUsr)
        {
            InitializeComponent();
            idUsuario = idUsr;
        }

        FrmLogin fn = new FrmLogin(); //FUNCIONES GENERALES

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!FaltanDatos())
            {
                if (!UsuarioIgualAlEmail())
                {

                    if (!fn.ExisteUsuario(txtUsuario.Text))
                    {

                        Query qr = new Query("UPDATE JJRD.USUARIOS SET USERNAME = '" + txtUsuario.Text + "', CONTRASEÑA = '" + txtPasswd.Text + "' WHERE ID_USUARIO =  " + idUsuario);
                        qr.Ejecutar();

                        this.Visible = false;
                        this.Hide();
                        fn.recibirUsuario(idUsuario);

                    }
                    else
                    {
                        MessageBox.Show("Usuario existente.", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Focus();
                    }


                }
                else
                {
                   
                    MessageBox.Show("Usuario invalido." + Environment.NewLine +
                    "El usuario debe ser distinto al asignado por el sistema.  ", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();

                }
            }
        }

        private bool FaltanDatos()
        {

            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el Usuario.", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return true;
            }
            if (txtPasswd.Text.Length == 0)
            {
                MessageBox.Show("Ingrese la contraseña.", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPasswd.Focus();
                return true;
            }

            if (txtConfirmarPasswd.Text.Length == 0)
            {
                MessageBox.Show("Confirme la contraseña.", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmarPasswd.Focus();
                return true;
            }

            return false;

        }

        private bool UsuarioIgualAlEmail() //TODO - CODIGO COPIADO DE FRMLOGIN.
        {
            Query qr = new Query("SELECT TIPO_DE_USUARIO FROM JJRD.USUARIOS WHERE ID_USUARIO = " + idUsuario);
            string tipo = qr.ObtenerUnicoCampo().ToString();

            if (tipo == "C")
            {
                Query email = new Query("SELECT EMAIL FROM JJRD.CLIENTE WHERE ID_USUARIO = " + idUsuario);
                return (email.ObtenerUnicoCampo().ToString() == txtUsuario.Text);
            }
            else
            {   //TIPO ES "E"
                Query email = new Query("SELECT EMAIL FROM JJRD.EMPRESA WHERE ID_USUARIO = " + idUsuario);
                return (email.ObtenerUnicoCampo().ToString() == txtUsuario.Text);
            }
        }
    }
}
