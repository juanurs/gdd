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

        SqlConnection conexion = new SqlConnection();

        private void FrmVisibilidad_Modificacion_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            string visibilidad = " select COD_VISIBILIDAD, PRECIO, PORCENTAJE_VENTA, DURACION"
                               + " from JJRD.VISIBILIDAD"
                               + " where HABILITADO = 1"
                               + " and DESCRIPCION = '" + cmbVisibilidad.Text + "'";

            txtDescripcion.Text = cmbVisibilidad.Text;
            conexion.Open();

            SqlCommand command = new SqlCommand(visibilidad, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                IDataRecord resultado = (IDataRecord)reader;
                txtCodigo.Text = resultado[0].ToString();
                txtPrecio.Text = resultado[1].ToString();
                txtPorcentaje.Text = resultado[2].ToString();
                txtDuracion.Text = resultado[3].ToString();
            }
            conexion.Close();
        }

        public void LlenarComboBox()
        {
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
            txtCodigo.Text = null;
            txtDescripcion.Text = null;
            txtPrecio.Text = null;
            txtPorcentaje.Text = null;
            txtDuracion.Text = null;
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            string updateVisibilidad = "update JJRD.VISIBILIDAD "
                                     + "set DESCRIPCION = '" + txtDescripcion.Text + "'"
                                     + " ,	PRECIO = " + txtPrecio.Text.Replace(",", ".")
                                     + " ,	PORCENTAJE_VENTA = " + txtPorcentaje.Text.Replace(",", ".")
                                     + " ,	DURACION = " + txtDuracion.Text
                                     + " where COD_VISIBILIDAD = " + txtCodigo.Text;
            
            new Query(updateVisibilidad).Ejecutar();
            MessageBox.Show("Modificación realizada con éxito!");
            this.Visible = false;
        }
    }
}
