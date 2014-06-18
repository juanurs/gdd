﻿using System;
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
        public FrmbnCliente()
        {
            InitializeComponent();
        }

        private void FrmbnCliente_Load(object sender, EventArgs e)
        {

        }

        private void bnConsCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmbnCliente_Consulta frm = new FrmbnCliente_Consulta();
            frm.ShowDialog();
            this.Visible = true;
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
    }
}
