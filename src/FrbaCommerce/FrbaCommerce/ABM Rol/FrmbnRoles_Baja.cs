using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmbnRoles_Baja : Form
    {
        public FrmbnRoles_Baja()
        {
            InitializeComponent();
        }

        private void FrmbnRoles_Baja_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            comboRol.Text = null;
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            string detalle = comboRol.Text.ToString();
            string qry =    " update JJRD.ROLES " +
                            " set ROL_ESTADO= 0  " +
                            " where ROL_NOMBRE = '" + detalle + "'";
            new Query(qry).Ejecutar();

            // se deshabilita el rol de los usuarios que tenian asignado el mismo
            string bajaRol = "   update ru " +
                             "   set ru.Habilitado = 0" +
                             "   from JJRD.ROL_USUARIO ru, JJRD.ROLES r" +
                             "   where r.ID_ROL = ru.ID_ROL" +
                             "   and r.ROL_NOMBRE = '" + detalle + "'";
            new Query(bajaRol).Ejecutar();

            MessageBox.Show("Rol inhabilitado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
        }

        public void LlenarComboBox()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select ROL_NOMBRE from JJRD.ROLES where ROL_ESTADO = 1", conexion);
            da.Fill(ds, "JJRD.ROLES");

            comboRol.DataSource = ds.Tables[0].DefaultView;
            comboRol.ValueMember = "ROL_NOMBRE";
            comboRol.SelectedItem = null;
        }
    }
}
