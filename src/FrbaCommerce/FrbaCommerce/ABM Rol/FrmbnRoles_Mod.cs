using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmbnRoles_Mod : Form
    {
        string rol;

        public FrmbnRoles_Mod()
        {
            InitializeComponent();
        }

        private void FrmbnRoles_Mod_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            bnBuscar.Enabled = false;
            chkHabilitado.Enabled = false;
            txtNombreRol.Enabled = false;
            bnGuardar.Enabled = false;
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            rol = comboRol.Text.ToString();
            comboRol.Enabled = false;
            txtNombreRol.Enabled = true;
            chkHabilitado.Enabled = true;
            CargarDatosRol();
        }

        private void CargarDatosRol()
        {
            /* Setear el mismo nombre por defecto */
            txtNombreRol.Text = rol;
            
            CargarFuncionalidadesEnLista();
            string ConsultarFuncionalidades =   " SELECT f.DESCRIPCION Funcionalidad, rf.HABILITADO " +
                                                " FROM JJRD.ROL_FUNCIONALIDAD rf" +
                                                " JOIN JJRD.ROLES r ON r.ID_ROL = rf.ID_ROL" +
                                                " RIGHT JOIN JJRD.FUNCIONALIDAD f on f.ID_FUNCIONALIDAD = rf.ID_FUNCIONALIDAD" +
                                                " where rf.ID_ROL= r.ID_ROL " +
                                                " and r.ROL_NOMBRE = '" + rol + "' ";

            Query qry = new Query(ConsultarFuncionalidades);

            /* Para tildar las funcionalidades habilitadas */
            DataTable funcionalidades = qry.ObtenerDataTable();
            foreach (DataRow funcionalidad in funcionalidades.Rows)
            {
                string descripcionFuncionalidad = funcionalidad["Funcionalidad"].ToString();
                int index = Funcionalidades.FindString(descripcionFuncionalidad, 0);
                Funcionalidades.SetItemChecked(index, true);
            }

            /* Para tildar la casilla de Rol habilitado*/
            string Habilitado = "SELECT ROL_ESTADO FROM JJRD.ROLES where ROL_NOMBRE = '" + rol + "'";
            qry.pComando = Habilitado;
            chkHabilitado.Checked = (bool)qry.ObtenerUnicoCampo();

            /* Para deshabilitar el chequeo del box si el rol está habilitado 
             * para dar de baja el rol está el form de baja */
            if (chkHabilitado.Checked == true)
            {
                chkHabilitado.Enabled = false;
            }
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

        /* Habilitar el boton guardar si se cambia el nombre del rol */
        private void txtNombreRol_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreRol.Text != comboRol.Text)
            {
                bnGuardar.Enabled = true;
            }
            else
            {
                bnBuscar.Enabled = false;
            }
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarFuncionalidades();
            GuardarModificaciones();
           
            MessageBox.Show("Modificación realizada con éxito!");

            this.Visible = false;
        }

        private void ActualizarFuncionalidades()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            string consulta = "SELECT ID_ROL FROM JJRD.ROLES where ROL_NOMBRE = '" + rol + "'";
            Query qr = new Query(consulta);
            qr.pComando = consulta;
            int idRol = (int)qr .ObtenerUnicoCampo();

            for(int i = 0; i < Funcionalidades.Items.Count; i++)
            {
                string sql;
                string Funcionalidad = Funcionalidades.Items[i].ToString().Replace(']', ' ').Substring(Funcionalidades.Items[i].ToString().IndexOf(',') + 1).TrimEnd();
                if(Funcionalidades.GetItemChecked(i))
                {
                    // insertar si no existe
                    sql =   " insert into JJRD.ROL_FUNCIONALIDAD (ID_FUNCIONALIDAD, ID_ROL, HABILITADO)" +
                            " select distinct " + Funcionalidad + ", " + idRol +  ", 1 habilitada" +
                            " from JJRD.FUNCIONALIDAD" +
                            " where " + Funcionalidad + " not in ( select ID_FUNCIONALIDAD from JJRD.ROL_FUNCIONALIDAD where ID_ROL = " + idRol + ")";
                }
                else
                {
                    // borrar el registro en caso que este desmarcado (no es necesario chequear si existe)
                    sql =   " delete from JJRD.ROL_FUNCIONALIDAD" +
                            " where ID_ROL = " + idRol +
                            " and ID_FUNCIONALIDAD = " + Funcionalidad;
                }

                Query qry = new Query();
                qry.pComando = sql;
                qry.Ejecutar();
            }
        }

        private void GuardarModificaciones()
        {
            string consCambioRol = "UPDATE JJRD.ROLES SET ROL_NOMBRE = '" + txtNombreRol.Text +
                                   "',ROL_ESTADO = " + (chkHabilitado.Checked ? '1' : '0') +
                                   " WHERE ROL_NOMBRE = '" + rol + "'";
            
            new Query(consCambioRol).Ejecutar();
        }

        private void Funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
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

        /* Habilitar el boton guardar si se habilita un rol */
        private void chkHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            bnGuardar.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRol.Text.Trim() != "")
            {
                bnBuscar.Enabled = true;
            }
        }

        public void LlenarComboBox()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select ROL_NOMBRE from JJRD.ROLES", conexion);
            da.Fill(ds, "JJRD.ROLES");

            comboRol.DataSource = ds.Tables[0].DefaultView;
            comboRol.ValueMember = "ROL_NOMBRE";
            comboRol.SelectedItem = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (comboRol.Enabled == true)
            {
                comboRol.SelectedItem = null;
            }

            txtNombreRol.Text = null;

            if (chkHabilitado.Checked != true)
            {
                chkHabilitado.Checked = false;
            }

            foreach (int i in Funcionalidades.CheckedIndices)
            {
                Funcionalidades.SetItemCheckState(i, CheckState.Unchecked);
            }

            bnGuardar.Enabled = false;
        }
    }
}
