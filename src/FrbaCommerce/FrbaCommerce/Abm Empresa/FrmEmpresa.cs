using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce;

namespace FrbaCommerce

{
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void bnBaja_Click(object sender, EventArgs e)
        {
            
            FrmEmpresa_Baja EmpresaBaja = new FrmEmpresa_Baja();
            this.Hide();
            EmpresaBaja.ShowDialog();
            
            this.Visible = false;
            EmpresaBaja = (FrmEmpresa_Baja)this.ActiveMdiChild;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
         /*   frmPrincipal cliente = new frmPrincipal();
            this.Hide();
            cliente.ShowDialog();
            cliente = (frmPrincipal)this.ActiveMdiChild;  */
        }

    }
}
