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

namespace FrbaCommerce
{
    public partial class FrmbnCliente_Baja : Form
    {
        public FrmbnCliente_Baja()
        {
            InitializeComponent();
        }

        private string qr;
        private int IdTipoDni;
        Funciones fn = new Funciones();


        private void bnBuscar_Click(object sender, EventArgs e)
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
                        txtNombre.Text == "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text != "" )
                    {

                        qr = buscarPorDosCampos(sql);
                    }
                    else
                    {
                        //BUSCAR POR TRES CAMPOS

                        if (txtNombre.Text != "" && txtApellido.Text != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" ||
                            txtNombre.Text != "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text != "" ||
                            txtNombre.Text != "" && txtApellido.Text != "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text != "" ||
                            txtNombre.Text == "" && txtApellido.Text != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" )
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
                sql = sql + " EMAIL = '" + txtEmail.Text + "'";
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

            if (txtNombre.Text.Trim() != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text.Trim() != "" )
            {
                //NOMBRE Y DOCUMENTO
                sql = sql + " NOMBRE LIKE '%" + txtNombre.Text + "%' AND ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%' ";
            }

            if (txtNombre.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                //NOMBRE Y MAIL
                sql = sql + " EMAIL = '" + txtEmail.Text + "' AND NOMBRE LIKE '%" + txtNombre.Text + "%' ";
            }

            if (txtApellido.Text.Trim() != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text.Trim() != "")
            {
                //APELLIDO Y DNI
                sql = sql + " APELLIDO LIKE '%" + txtApellido.Text + "%' AND ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%' ";
            }

            if (txtApellido.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                //APELLIDO Y MAIL
                sql = sql + " APELLIDO LIKE '%" + txtApellido.Text + "%' AND EMAIL = '" + txtEmail.Text + "'";
            }

            if (comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                //DNI Y MAIL
                sql = sql + "ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%' AND EMAIL = '" + txtEmail.Text + "'";
            }

            return sql;

        }


        private string buscarPorTresCampos(string sql)
        {
            if (txtEmail.Text.Trim() == "")
            {
                //BUSCA POR NOMBRE APELLIDO Y DNI
                sql = sql + " NOMBRE LIKE '%" + txtNombre.Text + "%' AND APELLIDO LIKE '%" + txtApellido.Text + "%' AND ID_TIPO_DOC = "+ IdTipoDni +" AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%'";

            }

            if (txtNumeroDoc.Text.Trim() == "")
            {
                //BUSCA POR NOMBRE APELLIDO Y EMAIL
                sql = sql + " NOMBRE LIKE '%" + txtNombre.Text + "%' AND APELLIDO LIKE '%" + txtApellido.Text + "%' AND EMAIL = '" + txtEmail.Text + "'";

            }

            if (txtNombre.Text.Trim() == "")
            {
                //BUSCA POR APELLIDO DNI Y EMAIL
                sql = sql + " EMAIL = '" + txtEmail.Text + "' AND APELLIDO LIKE '%" + txtApellido.Text + "%' AND ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%'";
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

        private void FrmbnCliente_Baja_Load(object sender, EventArgs e)
        {
            this.bnDarDeBaja.Enabled = false;
            
            //CARGAR COMBOBOX
            string sql = "SELECT DESCRIPCION FROM JJRD.TIPO_DOCUMENTO";


            Query qry = new Query(sql);


            foreach (DataRow dataRow in qry.ObtenerDataTable().AsEnumerable())
            {
                comboBoxTipoDoc.Items.Add(dataRow[0]);
            }
        }

        private void comboBoxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query qr = new Query("SELECT ID FROM JJRD.TIPO_DOCUMENTO WHERE DESCRIPCION = '" + comboBoxTipoDoc.Text + "'");
            IdTipoDni = Convert.ToInt32(qr.ObtenerUnicoCampo());
        }

        private string buscarPorTodosLosCampos(string sql)
        {
            sql = sql + " EMAIL = '" + txtEmail.Text + "' AND APELLIDO LIKE '%" + txtApellido.Text + "%' AND ID_TIPO_DOC = " + IdTipoDni + " AND NUMERO_DOC LIKE '%" + txtNumeroDoc.Text + "%' AND NOMBRE LIKE '%" + txtNombre.Text + "%' ";
            return sql;
        }

        private void bnDarDeBaja_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataResultado.SelectedRows[0];
            
            //IDUSUARIO A DESHABILITAR
            int id_Usr = Convert.ToInt32(fila.Cells["id_usuario"].Value.ToString());


            if (fn.puedeIngresarAlSistema(id_Usr))
            {
                fn.inhabilitarUsuario(id_Usr);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion." + Environment.NewLine + "El usuario ya se encuentra inhabilitado", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
            
        }

        private void dataResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bnDarDeBaja.Enabled = true;
        }

        
    }
}
