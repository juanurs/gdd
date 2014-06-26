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
    public partial class FrmVisibilidad_Modificacion : Form
    {
        public FrmVisibilidad_Modificacion()
        {
            InitializeComponent();
        }

        private void FrmVisibilidad_Modificacion_Load(object sender, EventArgs e)
        {
            bnBuscar.Enabled = false;
            LlenarComboBox();
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            string visibilidad = " select PRECIO, PORCENTAJE_VENTA, DURACION"
                               + " from JJRD.VISIBILIDAD"
                               + " where HABILITADO = 1"
                               + " and DESCRIPCION = '" + cmbVisibilidad.Text + "'";
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
            bnBuscar.Enabled = false;
        }
    }
}
