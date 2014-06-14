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
    public partial class FrmbnCliente_Baja : Form
    {
        public FrmbnCliente_Baja()
        {
            InitializeComponent();
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
