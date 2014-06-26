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
    public partial class FrmVisibilidad_Baja : Form
    {
        public FrmVisibilidad_Baja()
        {
            InitializeComponent();
        }

        private void FrmVisibilidad_Baja_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }     
        
        private void bnEliminar_Click(object sender, EventArgs e)
        {
            string unaVisibilidad = cmbVisibilidad.Text.ToString();
            string bajaVisibilidad =    " update JJRD.VISIBILIDAD " +
                                        " set HABILITADO = 0  " +
                                        " where DESCRIPCION = '" + unaVisibilidad + "'";
            new Query(bajaVisibilidad).Ejecutar();

            MessageBox.Show("Visibilidad inhabilitada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
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
    }
}
