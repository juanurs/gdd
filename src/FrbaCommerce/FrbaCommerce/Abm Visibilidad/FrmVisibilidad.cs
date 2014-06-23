using System;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmVisibilidad : Form
    {
        public FrmVisibilidad()
        {   
            InitializeComponent();
        }

        private void bnAlta_Click(object sender, EventArgs e)
        {
           this.Visible = false;
           FrmbnVisibilidad_Alta frm = new FrmbnVisibilidad_Alta();
           frm.ShowDialog();
           this.Visible = true;
        }

        private void bnConsultaVisibilidad_Click(object sender, EventArgs e)
        {
           /* this.Visible = false;
            FrmVisibilidad_Consulta frm = new FrmVisibilidad_Consulta();
            frm.ShowDialog();
            this.Visible = true;*/
        }

        private void bnBajaVisibilidad_Click(object sender, EventArgs e)
        {
           /* this.Visible = false;
            FrmVisibilidad_Baja frm = new FrmbnVisibilidad_Baja();
            frm.ShowDialog();
            this.Visible = true;*/
        }

        private void bnModVisibilidad_Click(object sender, EventArgs e)
        {
           /* this.Visible = false;
            FrmVisibilidad_Mod frm = new FrmbnVisibilidad_Mod();
            frm.ShowDialog();
            this.Visible = true; */
        }
    }
}
