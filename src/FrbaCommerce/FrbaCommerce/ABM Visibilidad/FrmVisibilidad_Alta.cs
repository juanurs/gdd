using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmbnVisibilidad_Alta : Form
    {
        SqlConnection conexion = new SqlConnection();

        public FrmbnVisibilidad_Alta()
        {
            InitializeComponent();
        }

        private void FrmbnVisibilidad_Alta_Load(object sender, EventArgs e)
        {
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            if (txtCodigo.Text.Trim() != ""
                && txtDescripcion.Text.Trim() != ""
                && txtPrecio.Text.Trim() != ""
                && txtPorcentaje.Text.Trim() != ""
                && txtVigencia.Text.Trim() != "")
            {
                string codigo = "SELECT COUNT(1) FROM JJRD.Visibilidad where COD_VISIBILIDAD = " + txtCodigo.Text;
                Query qry = new Query(codigo);
                qry.pComando = codigo;
                int existeCodigo = (int)qry.ObtenerUnicoCampo();

                if (existeCodigo == 1)
                {
                    txtCodigo.Text = null;
                    MessageBox.Show("Codigo de visibilidad existente. Ingrese otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql = "INSERT INTO JJRD.Visibilidad (COD_VISIBILIDAD, DESCRIPCION, PRECIO, PORCENTAJE_VENTA, DURACION, HABILITADO)" 
                                +"values (" + txtCodigo.Text + ", '" + txtDescripcion.Text + "', " + txtPrecio.Text + ", " + txtPorcentaje.Text+ ", " + txtVigencia.Text + ", 1)";
                    qry.pComando = sql;
                    qry.Ejecutar();

                    MessageBox.Show("Visibilidad dada de alta exitosamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Todos los campos tienen que estar cargados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtPorcentaje.Clear();
            txtVigencia.Clear();
        }


    }
}
