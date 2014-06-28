using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmEmpresa_Alta : Form
    {
       
        SqlConnection conexion = new SqlConnection();

        private int idUsuario;

        public FrmEmpresa_Alta(int id_Usr)
        {
            InitializeComponent();

            txtTel.Text = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";
            txtCodPost.Text = "";
            txtNomContacto.Text = "";
            dataFecha.Text = "";
            txtNumCalle.Text = "";
            txtPiso.Text = String.Empty;
            txtDepto.Text = String.Empty;


            idUsuario = id_Usr;

            conexion.ConnectionString = Settings.Default.CadenaDeConexion;
        }
  
        private void bnGuardar_Click(object sender, EventArgs e)
        {
           

            if((txtRazonSocial.Text.Trim() != "") && (txtCuit.Text.Trim() != "") && (txtEmail.Text.Trim()!= ""))

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
                        string razon_social = "SELECT COUNT(1) FROM JJRD.EMPRESA where RAZON_SOCIAL = '" + txtRazonSocial.Text+"'";
                        Query qry2 = new Query(razon_social);
                        int existeRazonSocial = (int)qry2.ObtenerUnicoCampo();



                            if (existeRazonSocial == 1)
                            {    
                                txtRazonSocial.Text = null;
                                MessageBox.Show("Razon Social existente", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                            /* Primero da alta a Usuario */

                                if (idUsuario == 0)
                                {


                                    string sql = "INSERT INTO JJRD.USUARIOS (USERNAME, CONTRASENIA, HABILITADO, LOGIN_FALLIDOS, TIPO_DE_USUARIO) values ('" + txtEmail.Text + "', '" + txtCuit.Text + "', 1, 0, 'E' )";
                                    qry.pComando = sql;
                                    qry.Ejecutar();

                                    /* Da de alta empresa*/


                                    string consulta = "select id_usuario FROM JJRD.USUARIOS where USERNAME=  '" + txtEmail.Text + "'";
                                    Query qr = new Query(consulta);
                                    qr.pComando = consulta;
                                    idUsuario = (int)qr.ObtenerUnicoCampo();
                                }
                                
                                string sql2 = "INSERT INTO JJRD.EMPRESA (ID_USUARIO,CUIT,RAZON_SOCIAL,CIUDAD,NOMBRE_CONTACTO,EMAIL,CALLE,NUM_CALLE,PISO,DEPARTAMENTO,LOCALIDAD,COD_POSTAL,FECHA_CREACION,TELEFONO)"+
                                " values ("+idUsuario+",'"+txtCuit.Text+"','"+txtRazonSocial.Text+"','"+txtLocalidad.Text+"','"+txtNomContacto.Text+"','"+txtEmail.Text+"','"+txtDireccion.Text+"',"+txtNumCalle.Text+","+txtPiso.Text+",'"+txtDepto.Text+"','"+txtLocalidad.Text+"','"+txtCodPost.Text+"','"+dataFecha.Value+"',"+txtTel.Text+")";
                                qry.pComando = sql2;                                                                                                                                                             
                                qry.Ejecutar();

                                MessageBox.Show("Se dio de alta la Empresa correctamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                                this.Visible = false;

                               
                            
                            }


                    }
            }
            else
                {
                    MessageBox.Show("Cuit, Razon Social y Email no pueden ser campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtLocalidad.Text = "";
            txtCuit.Text = "";
            txtNomContacto.Text = "";
            dataFecha.Text = "";
        }

    
    }

}

        


   



      