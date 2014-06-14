using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmbnRoles_Alta : Form
    {
        int idRol;
        SqlConnection conexion = new SqlConnection();

        public FrmbnRoles_Alta()
        {
            InitializeComponent();
        }

        /* Cuando se haya chequeado algun objeto se habilitara el boton de guardar */
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Funcionalidades.CheckedItems.Count > 0)
            {
                bnGuardar.Enabled = true;
            }
            else
            {
                bnGuardar.Enabled = false;
            }
        }

        /* Seteo de botones al inicio del formulario */
        private void FrmbnRoles_Alta_Load(object sender, EventArgs e)
        {
            bnGuardar.Enabled = false;
            btnLimpiar.Enabled = true;
        }

        /* Se cargan las funcionalidades de la tabla en check list*/
        private void CargarFuncionalidadesEnLista()
        {
            string sql = "select DESCRIPCION, ID_FUNCIONALIDAD from JJRD.FUNCIONALIDAD";
            Query qry = new Query(sql);
            List<KeyValuePair<string, int>> datos = (from x in qry.ObtenerDataTable().AsEnumerable()
                                                     select new
                                                     KeyValuePair<string, int>(x["DESCRIPCION"].ToString(), Convert.ToInt32(x["ID_FUNCIONALIDAD"]))).ToList();

            Funcionalidades.DataSource = datos;
            Funcionalidades.DisplayMember = "Key";
            Funcionalidades.ValueMember = "Value";
        }

        /* El boton guardar insertara todas las funcionalidades chequeadas */
        private void bnGuardar_Click(object sender, EventArgs e)
        {

            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            if (txtNombre.Text.Trim() != "")
            {
                string Habilitado = "SELECT COUNT(1) FROM JJRD.ROLES where ROL_NOMBRE = '" + txtNombre.Text + "'";
                Query qry = new Query(Habilitado);
                qry.pComando = Habilitado;
                int existeRol = (int)qry.ObtenerUnicoCampo();

                if (existeRol == 1)
                {
                    txtNombre.Text = null;
                    MessageBox.Show("Nombre de rol existente - Ingresar nuevo nombre"
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sql = "INSERT INTO JJRD.ROLES (ROL_NOMBRE, ROL_ESTADO) values ('" + txtNombre.Text + "', 1)";
                    qry.pComando = sql;
                    qry.Ejecutar();

                    string consulta = "SELECT ID_ROL FROM JJRD.ROLES where ROL_NOMBRE= '" + txtNombre.Text + "'";
                    Query qr = new Query(consulta);
                    qr.pComando = consulta;
                    idRol = (int)qr.ObtenerUnicoCampo();

                    foreach (var checkedItem in Funcionalidades.CheckedItems)
                    {
                        string sql2 = "insert into JJRD.ROL_FUNCIONALIDAD (ID_FUNCIONALIDAD, ID_ROL, HABILITADO) " +
                                     "select ID_FUNCIONALIDAD, " + idRol + ", 1 habilitado " +
                                     "from JJRD.FUNCIONALIDAD where DESCRIPCION = '" + checkedItem.ToString().Replace('[', ' ').Substring(1, checkedItem.ToString().IndexOf(',') - 1).TrimStart() + "'";

                        Query qry2 = new Query();
                        qry2.pComando = sql2;
                        qry2.Ejecutar();
                    }

                    MessageBox.Show("Rol dado de alta exitosamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;
                }
            }
        }

        /* Se limpiaran las funcionalidades luego de creado el rol
         * el nombre del rol solo se limpiara cuando este no haya sido creado */
        private void limpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();

            {
                foreach (int i in Funcionalidades.CheckedIndices)
                {
                    Funcionalidades.SetItemCheckState(i, CheckState.Unchecked);
                }
                bnGuardar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                CargarFuncionalidadesEnLista();
                bnGuardar.Enabled = true;
            }
        }
    }
}
