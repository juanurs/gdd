﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce
{
    public partial class FrmbnCliente_Modificar : Form
    {
        public FrmbnCliente_Modificar()
        {
            InitializeComponent();
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Cliente_Cod, Cliente_Nombre, Cliente_Apellido, Cliente_tipoDoc, Cliente_doc FROM PIER.ClienteS WHERE 1=1 ";

            if (filtroNombre.Text != "" || filtroApellido.Text != "" || filtroDocumento.Text != "")
            {
                if (filtroNombre.Text != "")
                {
                    sql = sql + "AND Cliente_Nombre LIKE '%" + filtroNombre.Text + "%' ";
                }

                if (filtroApellido.Text != "")
                {
                    sql = sql + "AND Cliente_Apellido LIKE '%" + filtroApellido.Text + "%' ";
                }

                if (filtroDocumento.Text != "")
                {
                    sql = sql + "AND Cliente_doc = '" + filtroDocumento.Text + "'";
                }

                CargarConsultaEnDataGrid(sql);
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos un filtro de busqueda.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private class DatosCliente
        {
            public int Cliente_Cod { get; set; }
            public string Cliente_Nombre { get; set; }
            public string Cliente_Apellido { get; set; }
            public string Cliente_tipoDoc { get; set; }
            public int Cliente_doc { get; set; }
        }

        private void CargarConsultaEnDataGrid(string sql)
        {
            Query qry = new Query(sql);

            List<DatosCliente> datos = (from x in qry.ObtenerDataTable().AsEnumerable()
                                          select new DatosCliente
                                          {
                                              Cliente_Cod = Convert.ToInt32(x["Cliente_Cod"]),
                                              Cliente_Nombre = x["Cliente_Nombre"].ToString(),
                                              Cliente_Apellido = x["Cliente_Apellido"].ToString(),
                                              Cliente_tipoDoc = x["Cliente_tipoDoc"].ToString(),
                                              Cliente_doc = Convert.ToInt32(x["Cliente_doc"]),
                                          }).ToList();

            if (datos.Count() != 0)
            {
                dgvModificar.DataSource = datos;
            }
            else
            {
                MessageBox.Show("No existen resultados para los filtros ingresados.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void docCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Funcionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmbnCliente_Modificar_Load(object sender, EventArgs e)
        {

        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            filtroApellido.Text = null;
            filtroDocumento.Text = null;
            filtroNombre.Text = null;
        }

        private void filtroNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmbnCliente_Selec frm = new FrmbnCliente_Selec(dgvModificar.Rows[e.RowIndex].Cells["Cliente_Cod"].Value.ToString(),
                dgvModificar.Rows[e.RowIndex].Cells["Cliente_Nombre"].Value.ToString(),
                dgvModificar.Rows[e.RowIndex].Cells["Cliente_Apellido"].Value.ToString());
            frm.ShowDialog();
            this.Visible = true;
        }

        private void filtroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void filtroApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void filtroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}