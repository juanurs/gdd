using System;
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
    public partial class FrmVisibilidad_Consulta : Form
    {
        public FrmVisibilidad_Consulta()
        {
            InitializeComponent();
        }

        private void FrmVisibilidad_Consulta_Load(object sender, EventArgs e)
        {
            bnBuscar.Enabled = false;
            LlenarComboBox();
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            string visibilidad = " select CODIGO_VISIBILIDAD, PRECIO, PORCENTAJE_VENTA, DURACION"
                               + " from JJRD.VISIBILIDAD"
                               + " where HABILITADO = 1"
                               + " and DESCRIPCION = '" + cmbVisibilidad.Text + "'";

            gridDatos.DataSource = new Query(visibilidad).ObtenerDataTable();
        }

        public void LlenarComboBox()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select DESCRIPCION from JJRD.Visibilidad where HABILITADO = 1", conexion);
            da.Fill(ds, "JJRD.Visibilidad");

            cmbVisibilidad.DataSource = ds.Tables[0].DefaultView;
            cmbVisibilidad.ValueMember = "DESCRIPCION";
            cmbVisibilidad.SelectedItem = null;
        }

        private void bnLimpiar_click(object sender, EventArgs e)
        {
            cmbVisibilidad.SelectedItem = null;
            gridDatos.DataSource = null;
            bnBuscar.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVisibilidad.Text.Trim() != "" || cmbVisibilidad.SelectedItem != null)
            {
                bnBuscar.Enabled = true;
            }
        }
    }
}
