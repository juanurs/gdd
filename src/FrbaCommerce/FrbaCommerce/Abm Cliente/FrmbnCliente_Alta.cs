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
    public partial class FrmbnCliente_Alta : Form
    {

        SqlConnection conexion = new SqlConnection();
        
        public FrmbnCliente_Alta()
        {
            InitializeComponent();

            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDpto.Text = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";
            txtMail.Text = "";
            txtCod_Postal.Text = "";
            txtNro_Calle.Text = "";
            txtNumPiso.Text = "";
            txtTelefono.Text = "";
            txtDocumento.Text = "";

            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

        }

        private void FrmbnCliente_Alta_Load(object sender, EventArgs e)
        {
            LlenarComboTipoDoc();
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            //Chequea que los datos no sean nulos

            if ((txtNombre.Text.Trim() != "") &&
                (txtApellido.Text.Trim() != "") &&
                (cmbTipoDoc.Text != "") &&
                (txtDocumento.Text.Trim() != "") &&
                (txtTelefono.Text.Trim() != "") &&
                (txtMail.Text.Trim() != ""))
            {
                string telefono = "SELECT COUNT(1) FROM JJRD.CLIENTE where TELEFONO = " + txtTelefono.Text;
                Query qry = new Query(telefono);
                int existeTelefono = (int)qry.ObtenerUnicoCampo();

                if (existeTelefono == 1)
                {
                    txtTelefono.Text = null;
                    MessageBox.Show("Telefono existente. Ingrese otro número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // preguntar por DNI y TIPO
                    string DNI = "SELECT COUNT(1) FROM JJRD.CLIENTE where NUMERO_DOC = " + txtDocumento.Text + " AND ID_TIPO_DOC = " + Convert.ToInt32(cmbTipoDoc.SelectedValue); 
                    Query qry2 = new Query(DNI);
                    int existeDNI = (int)qry2.ObtenerUnicoCampo();

                    if (existeDNI == 1)
                    {
                        txtDocumento.Text = null;
                        MessageBox.Show("DNI existente. Ingrese otro DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //preguntar por mail
                        string EMAIL = "SELECT COUNT(1) FROM JJRD.CLIENTE WHERE EMAIL = " + txtMail.Text;
                        Query qry3 = new Query(EMAIL);
                        int existeEMAIL = (int)qry.ObtenerUnicoCampo();

                        if (existeEMAIL == 1)
                        {
                            txtMail.Text = null;
                            MessageBox.Show("EMAIL existente. Ingrese otro Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            /* primero dar de alta usuario */

                            string sql = "INSERT INTO JJRD.USUARIOS (USERNAME, CONTRASEÑA, HABILITADO, LOGIN_FALLIDOS, TIPO_DE_USUARIO) values ('" + txtMail.Text + "', '" + txtDocumento.Text + "' , 1, 0, 'C' )";
                            qry.pComando = sql;
                            qry.Ejecutar();

                            string consulta = "select id_usuario FROM JJRD.USUARIOS where USERNAME= '" + txtMail.Text + "'";
                            Query qr = new Query(consulta);
                            qr.pComando = consulta;
                            int idUsuario= (int)qr.ObtenerUnicoCampo();

                            string sql2 = "INSERT INTO JJRD.CLIENTE (ID_USUARIO, NOMBRE, APELLIDO, ID_TIPO_DOC, NUMERO_DOC, EMAIL, CALLE, NUM_CALLE, PISO, DEPARTAMENTO, LOCALIDAD, COD_POSTAL,FECHA_NACIMIENTO, TELEFONO) " +
                                          "  values ("+idUsuario+",'"+txtNombre.Text+"','"+txtApellido.Text+"',"+Convert.ToInt32(cmbTipoDoc.SelectedValue)+","+txtDocumento.Text+",'"+txtMail.Text+"','"+txtDireccion.Text+"',"+txtNro_Calle.Text+","+txtNumPiso.Text+",'"+txtDpto.Text+"','"+txtLocalidad.Text+"','"+txtCod_Postal.Text+"','"+DateTime.Now+"',"+txtTelefono.Text+")";
                            qry.pComando = sql2;
                            qry.Ejecutar();

                            MessageBox.Show("Cliente dado de alta exitosamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Visible = false;
                        }
                    }
                }
            }            
            // Insertar todos los campos
            else
            {
                MessageBox.Show("Nombre, apellido, tipo documento, número y telefóno no pueden ser blancos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LlenarComboTipoDoc()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select id, descripcion from JJRD.Tipo_Documento", conexion);
            da.Fill(ds, "JJRD.Tipo_Documento");

            cmbTipoDoc.DataSource = ds.Tables[0].DefaultView;
            cmbTipoDoc.DisplayMember = "descripcion";
            cmbTipoDoc.ValueMember = "id";
            cmbTipoDoc.SelectedItem = null;

        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbTipoDoc.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            txtDireccion.Text = "";
            txtNro_Calle.Text = "";
            lblpiso.Text = "";
            lblDepto.Text = "";
            txtLocalidad.Text = "";
            txtCod_Postal.Text = "";
            bnFecha.Text = null;
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtTelefono.Select(0, 0);
        }

        private void txtDocumento_Click(object sender, EventArgs e)
        {
            txtDocumento.Select(0, 0);
        }

        private void bnNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void bnApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
