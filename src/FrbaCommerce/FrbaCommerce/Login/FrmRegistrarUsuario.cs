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
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
            btnSiguiente.Enabled = false;

            comboBox.Items.Add("Cliente");
            comboBox.Items.Add("Empresa");

            
        }

        FrmLogin funcionesLogin = new FrmLogin(); //para poder usar funciones ya definidas en FrmLogin


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text != null)
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (!FaltanDatos())
            {
                if (funcionesLogin.ExisteUsuario(txtBoxUsuario.Text) && ContraseñasValidas()) //SI EL USUARIO NO EXISTE DEVUELVE TRUE
                {
                    MessageBox.Show("El usuario ingresado ya existe", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBoxUsuario.Focus();

                }
                else
                {
                    
                    if (comboBox.SelectedItem.ToString() == "Cliente")
                    {
                        FrmbnCliente_Alta cliente = new FrmbnCliente_Alta();
                        this.Hide();
                        cliente.ShowDialog();
                        cliente = (FrmbnCliente_Alta)this.ActiveMdiChild;
                    }
                    else
                    {
                        //Alta de empresa
                    }
                }
            }

        }

        private bool FaltanDatos()
        {
            if (txtBoxUsuario.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el Usuario.", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxUsuario.Focus();
                return true;
            }
            if (txtBoxPasswd.Text.Length == 0)
            {
                MessageBox.Show("Ingrese la contraseña.", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxPasswd.Focus();
                return true;
            }

            if (txtBoxPasswdConf.Text.Length == 0)
            {
                MessageBox.Show("Confirme la contraseña.", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxPasswdConf.Focus();
                return true;
            }

            return false;
        }

        private bool ContraseñasValidas()
        {
            if (txtBoxPasswd == txtBoxPasswdConf)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden", "Validación al registrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBoxPasswd.Focus();
                return false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            login = (FrmLogin)this.ActiveMdiChild;
        }


    }
}
