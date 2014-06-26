using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmbnCliente : Form
    {

        private int idUsuario;

        public FrmbnCliente(int id_Usr)
        {
            InitializeComponent();

            idUsuario = id_Usr;
        }

        private void FrmbnCliente_Load(object sender, EventArgs e)
        {

        }

   
        private void bnModCliente_Click(object sender, EventArgs e)
        {
            FrmbnCliente_Modificar frm = new FrmbnCliente_Modificar();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void bnBajaCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmbnCliente_Baja frm = new FrmbnCliente_Baja();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void bnAltaCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmbnCliente_Alta frm = new FrmbnCliente_Alta(0);
            frm.ShowDialog();
            this.Visible = true;
        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(idUsuario);
            this.Hide();
            frmPrincipal.ShowDialog();
            frmPrincipal = (frmPrincipal)this.ActiveMdiChild;
        }

        
    }
}
