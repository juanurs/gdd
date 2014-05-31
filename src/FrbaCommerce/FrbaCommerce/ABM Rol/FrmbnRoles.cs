using System;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmbnRoles : Form
    {
        public FrmbnRoles()
        {
            InitializeComponent();
        }

        private void bnAlta_Click(object sender, EventArgs e)
        {
           this.Visible = false;
           FrmbnRoles_Alta frm = new FrmbnRoles_Alta();
           frm.ShowDialog();
           this.Visible = true;
        }

        private void bnConsultaRoles_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmbnRoles_Consulta frm = new FrmbnRoles_Consulta();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void bnBajaRoles_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmbnRoles_Baja frm = new FrmbnRoles_Baja();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void bnModRoles_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmbnRoles_Mod frm = new FrmbnRoles_Mod();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
