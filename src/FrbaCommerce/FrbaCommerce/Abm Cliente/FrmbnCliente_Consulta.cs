using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmbnCliente_Consulta : Form
    {
        public FrmbnCliente_Consulta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bnAnterior_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmbnCliente_Consulta_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filtroNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private class DatosCliente
        {
            public int Paciente_Cod { get; set; }
            public string Paciente_Nombre { get; set; }
            public string Paciente_Apellido { get; set; }
            public string Paciente_tipoDoc { get; set; }
            public int Paciente_doc { get; set; }
        }

        private void CargarConsultaEnCheckList(string sql)
        {
            Query qry = new Query(sql);

            List<DatosCliente> datos = (from x in qry.ObtenerDataTable().AsEnumerable()
                                          select new DatosCliente
                                          {
                                              Paciente_Cod = Convert.ToInt32(x["Paciente_Cod"]),
                                              Paciente_Nombre = x["Paciente_Nombre"].ToString(),
                                              Paciente_Apellido = x["Paciente_Apellido"].ToString(),
                                              Paciente_tipoDoc = x["Paciente_tipoDoc"].ToString(),
                                              Paciente_doc = Convert.ToInt32(x["Paciente_doc"]),
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

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Paciente_Cod, Paciente_Nombre, Paciente_Apellido, Paciente_tipoDoc, Paciente_doc FROM PIER.PACIENTES WHERE 1=1 ";

            if (filtroNombre.Text != "")
            {
                sql = sql + "AND Paciente_Nombre LIKE '%" + filtroNombre.Text + "%' ";
            }

            if (filtroApellido.Text != "")
            {
                sql = sql + "AND Paciente_Apellido LIKE '%" + filtroApellido.Text + "%' ";
            }

            if (filtroDocumento.Text != "")
            {
                sql = sql + "AND Paciente_doc = '" + filtroDocumento.Text + "'";
            }

                CargarConsultaEnCheckList(sql);
        
        }

           

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            filtroApellido.Text = null;
            filtroDocumento.Text = null;
            filtroNombre.Text = null;
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

        private void filtroDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

