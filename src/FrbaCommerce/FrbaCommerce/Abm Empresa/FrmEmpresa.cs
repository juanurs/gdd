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
        private int idUsuario;

        public FrmEmpresa(int id_Usr)
        {
            InitializeComponent();

            idUsuario = id_Usr;
        }

        private void bnBaja_Click(object sender, EventArgs e)
        {
            
            FrmEmpresa_Baja EmpresaBaja = new FrmEmpresa_Baja(idUsuario);
            this.Hide();
            EmpresaBaja.ShowDialog();
            
            this.Visible = false;
            EmpresaBaja = (FrmEmpresa_Baja)this.ActiveMdiChild;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal= new frmPrincipal(idUsuario);
            this.Hide();
            frmPrincipal.ShowDialog();
            frmPrincipal = (frmPrincipal)this.ActiveMdiChild;
        }

        private void bnAlta_Click(object sender, EventArgs e)
        {
            FrmEmpresa_Alta alta = new FrmEmpresa_Alta(idUsuario);
            this.Hide();
            alta.ShowDialog();
            alta = (FrmEmpresa_Alta)this.ActiveMdiChild;
        }

    }
}
