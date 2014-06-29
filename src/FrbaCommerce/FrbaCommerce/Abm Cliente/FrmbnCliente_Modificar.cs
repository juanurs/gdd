using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCommerce.FuncionesGenerales;
using FrbaCommerce.Abm_Cliente;

namespace FrbaCommerce
{
    public partial class FrmbnCliente_Modificar : Form
    {
        public FrmbnCliente_Modificar()
        {
            InitializeComponent();
        }
        private int id;
        private string qr;
        private int IdTipoDni;
        Funciones fn = new Funciones();


        private void bnGuardar_Click(object sender, EventArgs e)
        {
            //CHEQUEA QUE TODOS LOS CAMPOS NO SEAN VACIOS

            if (!CamposVacios())
            {

                string sql = "SELECT id_usuario, Nombre, Apellido, Email, NUMERO_DOC as 'Documento' FROM JJRD.CLIENTE WHERE ";

                if (txtNombre.Text != "" && txtApellido.Text == "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text == "" ||
                    txtNombre.Text == "" && txtApellido.Text != "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text == "" ||
                    txtNombre.Text == "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" ||
                    txtNombre.Text == "" && txtApellido.Text == "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text != "")
                {

                    //buscar por un campo
                    qr = buscarPorUnCampo(sql);

                }
                else
                {
                    //BUSCAR POR DOS CAMPOS

                    if (txtNombre.Text != "" && txtApellido.Text != "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text == "" ||
                        txtNombre.Text != "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" ||
                        txtNombre.Text != "" && txtApellido.Text == "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text != "" ||
                        txtNombre.Text == "" && txtApellido.Text != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" ||
                        txtNombre.Text == "" && txtApellido.Text != "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text != "" ||
                        txtNombre.Text == "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text != "")
                    {

                        qr = buscarPorDosCampos(sql);
                    }
                    else
                    {
                        //BUSCAR POR TRES CAMPOS

                        if (txtNombre.Text != "" && txtApellido.Text != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" ||
                            txtNombre.Text != "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text != "" ||
                            txtNombre.Text != "" && txtApellido.Text != "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text != "" ||
                            txtNombre.Text == "" && txtApellido.Text != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "")
                        {

                            qr = buscarPorTresCampos(sql);
                        }
                        else
                        {
                            qr = buscarPorTodosLosCampos(sql);

                        }
                    }
                }

                mostrarResultadoDataGrid(qr);

            }
            else
            {
                //TIRA ERROR SI TODOS LOS CAMPOS SON VACIOS

                MessageBox.Show("Todos los datos no pueden ser nulos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





        }

        private bool CamposVacios()
        {
            return (txtNombre.Text.Trim() == "" && txtApellido.Text.Trim() == "" && comboBoxTipoDoc.Text == ""
                    && txtNumeroDoc.Text.Trim() == "" && txtEmail.Text.Trim() == "");
        }


        private string buscarPorUnCampo(string sql)
        {
            if (txtNombre.Text.Trim() != "")
            {
                sql = sql + " NOMBRE LIKE '%" + txtNombre.Text + "%' ";
            }

            if (txtApellido.Text.Trim() != "")
            {
                sql = sql + " APELLIDO LIKE '%" + txtApellido.Text + "%' ";
            }

            if (txtEmail.Text.Trim() != "")
            {
                sql = sql + " EMAIL LIKE '%" + txtEmail.Text + "%'";
            }

            if (txtNumeroDoc.Text.Trim() != "" && comboBoxTipoDoc.Text != "")
            {
                sql = sql + " NUMERO_DOC = '" + txtNumeroDoc.Text + "'";
            }

            return sql;
        }


        private string buscarPorDosCampos(string sql)
        {
            if (txtNombre.Text.Trim() != "" && txtApellido.Text.Trim() != "")
            {
                //NOMBRE Y APELLIDO
                sql = sql + " NOMBRE LIKE '%" + txtNombre.Text + "%' AND APELLIDO LIKE '%" + txtApellido.Text + "%' ";
            }

            if (txtNombre.Text.Trim() != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text.Trim() != "")
            {
                //NOMBRE Y DOCUMENTO
                sql = sql + " NOMBRE LIKE '%" + txtNombre.Text + "%' AND ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%' ";
            }

            if (txtNombre.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                //NOMBRE Y MAIL
                sql = sql + " EMAIL LIKE '%" + txtEmail.Text + "%' AND NOMBRE LIKE '%" + txtNombre.Text + "%' ";
            }

            if (txtApellido.Text.Trim() != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text.Trim() != "")
            {
                //APELLIDO Y DNI
                sql = sql + " APELLIDO LIKE '%" + txtApellido.Text + "%' AND ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%' ";
            }

            if (txtApellido.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                //APELLIDO Y MAIL
                sql = sql + " APELLIDO LIKE '%" + txtApellido.Text + "%' AND EMAIL LIKE '%" + txtEmail.Text + "%'";
            }

            if (comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                //DNI Y MAIL
                sql = sql + "ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%' AND EMAIL LIKE '%" + txtEmail.Text + "%'";
            }

            return sql;

        }

        private string buscarPorTresCampos(string sql)
        {
            if (txtEmail.Text.Trim() == "")
            {
                //BUSCA POR NOMBRE APELLIDO Y DNI
                sql = sql + " NOMBRE LIKE '%" + txtNombre.Text + "%' AND APELLIDO LIKE '%" + txtApellido.Text + "%' AND ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%'";

            }

            if (txtNumeroDoc.Text.Trim() == "")
            {
                //BUSCA POR NOMBRE APELLIDO Y EMAIL
                sql = sql + " NOMBRE LIKE '%" + txtNombre.Text + "%' AND APELLIDO LIKE '%" + txtApellido.Text + "%' AND EMAIL LIKE '%" + txtEmail.Text + "%'";

            }

            if (txtNombre.Text.Trim() == "")
            {
                //BUSCA POR APELLIDO DNI Y EMAIL
                sql = sql + " EMAIL LIKE '%" + txtEmail.Text + "%' AND APELLIDO LIKE '%" + txtApellido.Text + "%' AND ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%'";
            }

            return sql;
        }

        //REPITE CODIGO CON BAJA EMPRESA, MOVER A FUNCIONES GENERALES
        private void mostrarResultadoDataGrid(string qr)
        {
            Query resultado = new Query(qr);
            dataResultado.DataSource = resultado.ObtenerDataTable();
            dataResultado.Columns["id_usuario"].Visible = false;  //OCULTO LA COLUMNA
            dataResultado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void FrmbnCliente_Modificar_Load(object sender, EventArgs e)
        {
            //CARGAR COMBOBOX
            string sql = "SELECT DESCRIPCION FROM JJRD.TIPO_DOCUMENTO";


            Query qry = new Query(sql);


            foreach (DataRow dataRow in qry.ObtenerDataTable().AsEnumerable())
            {
                comboBoxTipoDoc.Items.Add(dataRow[0]);
            }

            bnHabilitar.Enabled = false;
            bnDeshabilitar.Enabled = false;
        }


        private void comboBoxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query qr = new Query("SELECT ID FROM JJRD.TIPO_DOCUMENTO WHERE DESCRIPCION = '" + comboBoxTipoDoc.Text + "'");
            IdTipoDni = Convert.ToInt32(qr.ObtenerUnicoCampo());
        }

        private string buscarPorTodosLosCampos(string sql)
        {
            sql = sql + " EMAIL LIKE '%" + txtEmail.Text + "%' AND APELLIDO LIKE '%" + txtApellido.Text + "%' AND ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%' AND NOMBRE LIKE '%" + txtNombre.Text + "%' ";
            return sql;
        }

        public void dataResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataResultado.Rows[e.RowIndex].Cells["id_usuario"].Value.ToString();
            id = Convert.ToInt32(dataResultado.Rows[e.RowIndex].Cells[1].Value.ToString());

            bnHabilitar.Enabled = true;
            bnDeshabilitar.Enabled = true;


        }

        public bool puedeIngresarAlSistema(int idUsuario) //MOVER A FUNCIONES GENERALES
        {
            return ((int)new Query("SELECT count(1) FROM JJRD.USUARIOS WHERE ID_USUARIO ='" + idUsuario + "' AND HABILITADO = 1").ObtenerUnicoCampo() != 0);
        }

        private void bnHabilitar_Click(object sender, EventArgs e)
        {


            if (!puedeIngresarAlSistema(id))
            {
                new Query("UPDATE JJRD.USUARIOS SET HABILITADO = '1' WHERE ID_USUARIO = " + id).Ejecutar();

                MessageBox.Show("Usuario Habilitado Correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("El Usuario ya se encuentra Habilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        private void bnDeshabilitar_Click(object sender, EventArgs e)
        {

            if (puedeIngresarAlSistema(id))
            {
                new Query("UPDATE JJRD.USUARIOS SET HABILITADO = '0' WHERE ID_USUARIO = " + id).Ejecutar();

                MessageBox.Show("Usuario Deshabilitado Correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("El Usuario ya se encuentra Deshabilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void bnModificarDatos_Click(object sender, EventArgs e)
        {
            FrmModificarDatos modificar = new FrmModificarDatos(id);
            this.Hide();
            modificar.ShowDialog();
            modificar = (FrmModificarDatos)this.ActiveMdiChild;
        }

        private void bnVolver_Click(object sender, EventArgs e)
        {

        }

    }
}