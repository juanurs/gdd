using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmbnEmpresa_Alta : Form
    {
       
        SqlConnection conexion = new SqlConnection();

        public FrmbnEmpresa_Alta()
        {
            InitializeComponent();
        }
  
        private void bnGuardar_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            if((txtRazonSocial.Text.Trim() != "") && (txtEmail.Text.Trim() != "")  && (txtCuit.Text.Trim() != ""))

            {
                //controla que cuit no este repetido= '" + txtEmail.Text + "')";
                string cuit = "SELECT COUNT(1) FROM JJRD.EMPRESA where CUIT = '" + txtCuit.Text + "'";
                Query qry = new Query(cuit);
                int existeCuit = (int)qry.ObtenerUnicoCampo();
                    
                    if (existeCuit == 1)
                    {    
                        txtCuit.Text = null;
                        MessageBox.Show("Cuit existente", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
        
                    else
                    { 
                        //controla que razon_social no este repetido
                        string razon_social = "SELECT COUNT(1) FROM JJRD.EMPRESA where RAZON_SOCIAL = " + txtRazonSocial.Text;
                        Query qry2 = new Query(razon_social);
                        int existeRazonSocial = (int)qry.ObtenerUnicoCampo();

                            if (existeRazonSocial == 1)
                            {    
                                txtCuit.Text = null;
                                MessageBox.Show("Razon Social existente", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                            /* Primero da alta a Usuario */

                                string sql = "INSERT INTO JJRD.USUARIOS (USERNAME, CONTRASEÑA, HABILITADO, LOGIN_FALLIDOS, TIPO_DE_USUARIO) values ("+txtEmail.Text+", "+txtCuit.Text+", 1, 0, 'E' )";
                                qry.pComando = sql;
                                qry.Ejecutar();
                            
                            /* Da de alta empresa*/
                                string id_usuario = "(SELECT ID_USUARIO from jjrd.usuarios where USERNAME = '" + txtEmail.Text + "')";
                                string sql2 = "INSERT INTO JJRD.EMPRESA (USERNAME, CUIT, RAZON_SOCIAL, CIUDAD, NOMBRE_CONTACTO, EMAIL, CALLE, NUM_CALLE, PISO, DEPARTAMENTO, LOCALIDAD, COD_POSTAL, TELEFONO ) values (" +  id_usuario + ","+txtCuit.Text+" , "+txtRazonSocial.Text+", '', "+txtNomContacto.Text+" , "+txtEmail.Text+", "+txtDireccion.Text+", "+txtNumCalle.Text+", "+txtPiso.Text+",  "+txtDepto.Text+", "+txtLocalidad.Text+", "+txtCodPost.Text+", "+txtTel.Text+")";
                                qry.pComando = sql2;
                                qry.Ejecutar();

                                MessageBox.Show("Se dio de alta la Empresa correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Visible = false;
                            
                            }


                    }
            }
            else
                {
                    MessageBox.Show("Cuit y Razon Social no pueden estar vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
             
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            txtDireccion.Text = "";
            txtNumCalle.Text = "";
            txtPiso.Text = "";
            txtDepto.Text = "";
            txtLocalidad.Text = "";
            txtCodPost.Text = "";
            txtCiudad.Text = "";
            txtCuit.Text = "";
            txtNomContacto.Text = "";
            txtFecCreacion.Text = "";
        }

    }

}

        


   



      