using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCommerce;

namespace FrbaCommerce
{
    public partial class FrmbnRoles_Consulta : Form
    {
        public FrmbnRoles_Consulta()
        {
            InitializeComponent();
        }

        private void FrmbnRoles_Consulta_Load(object sender, EventArgs e)
        {
            bnBuscar.Enabled = false;
            LlenarComboBox();
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            string rol = comboRol.Text;
            string qry =    " SELECT f.DESCRIPCION Funcionalidad " +
                            " FROM JJRD.ROL_FUNCIONALIDAD rf, JJRD.ROLES r, JJRD.FUNCIONALIDAD f " +
                            " where rf.ID_FUNCIONALIDAD = f.ID_FUNCIONALIDAD " +
                            " and rf.ID_ROL= r.ID_ROL" +
                            " and r.ROL_NOMBRE = '" + rol + "' " +
                            " and rf.HABILITADO = 1 " +
                            " order by f.DESCRIPCION";            

            gridDatos.DataSource = new Query(qry).ObtenerDataTable();
        }

        private void bnLimpiar_click(object sender, EventArgs e)
        {
            comboRol.SelectedItem = null;
            gridDatos.DataSource = null; 
            bnBuscar.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRol.Text.Trim() != "" || comboRol.SelectedItem != null)
            {
                bnBuscar.Enabled = true;
            }
        }

        public void LlenarComboBox()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select ROL_NOMBRE from JJRD.ROLES where ROL_ESTADO = 1" , conexion);
            da.Fill(ds, "JJRD.ROLES");

            comboRol.DataSource = ds.Tables[0].DefaultView;
            comboRol.ValueMember = "ROL_NOMBRE";
            comboRol.SelectedItem = null;
        }
    }
}
