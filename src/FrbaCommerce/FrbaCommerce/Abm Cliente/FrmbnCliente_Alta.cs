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
        }

        private void FrmbnCliente_Alta_Load(object sender, EventArgs e)
        {
            LlenarComboTipoDoc();
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            if ((txtNombre.Text.Trim() != "") &&
                (txtApellido.Text.Trim() != "") &&
                // (cmbTipoDoc.Text.Trim() != "") &&
                (txtDocumento.Text.Trim() != "") &&
                (txtTelefono.Text.Trim() != ""))




            {
                string telefono = "SELECT COUNT(1) FROM JJRD.CLIENTE where TELEFONO = " + txtTelefono.Text;
                Query qry = new Query(telefono);
                int existeTelefono = (int)qry.ObtenerUnicoCampo();

                if (existeTelefono == 1)
                {
                    txtTelefono.Text = null;
                    MessageBox.Show("Telefono existente. Ingrese otro número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    // preguntar por DNI y TIpo
                    string DNI = "SELECT COUNT(1) FROM JJRD.CLIENTE where DNI = " + txtDocumento.Text; // AGREGAR TIPO DNI
                    Query qry2 = new Query(DNI);
                    int existeDNI = (int)qry.ObtenerUnicoCampo();

                    if (existeDNI == 1)
                    {
                        txtDocumento.Text = null;
                        MessageBox.Show("DNI existente. Ingrese otro DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    } else {


                        /* primero dar de alta usuario */

                        string sql = "INSERT INTO JJRD.USUARIOS (USERNAME, CONTRASEÑA, HABILITADO, LOGIN_FALLIDOS, TIPO_DE_USUARIO) values ('', '', 1, 0, 'C' )";
                        qry.pComando = sql;
                        qry.Ejecutar();


                        string sql2 = "INSERT INTO JJRD.CLIENTE (ID_USUARIO,NOMBRE, APELLIDO, NUMERO_DOC, EMAIL, CALLE, NUM_CALLE, PISO, DEPARTAMENTO, LOCALIDAD, COD_POSTAL, TELEFONO) values (SELECT ID_USUARIO FROM JJRD.USUARIOS WHERE USERNAME = '"+ bnMail.Text +"', '" + txtNombre.Text + "', '" + txtApellido.Text + "','" + txtDocumento.Text +"' , '" + bnMail.Text + "', '" + txtDireccion.Text + "', ' + txtNro_Calle +', ' + txtPiso.Text + ', '" + txtDpto.Text + "', '" + txtLocalidad.Text+"', ' + txtCod_Postal.Text + ', ' + txtTelefono.Text +')";
                        qry.pComando = sql2;
                        qry.Ejecutar();
                        
                    
                    }
                }
                

                // insertar todos los campos
            }
            else
            {
                MessageBox.Show("Nombre, apellido, tipo documento, número y telefóno no pueden ser blancos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void LlenarComboTipoDoc()
        {

        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbTipoDoc.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
            bnMail.Text = "";
            txtDireccion.Text= "";
            txtNro_Calle.Text = "";
            txtPiso.Text ="";
            txtDepto.Text = "";
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