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




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text != null)
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "Empresa")
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            login = (FrmLogin)this.ActiveMdiChild;
        }


    }
}
