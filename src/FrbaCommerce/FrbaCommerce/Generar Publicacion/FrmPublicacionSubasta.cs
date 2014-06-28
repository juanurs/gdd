using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class FrmPublicacionSubasta : Form
    {

        SqlConnection conexion = new SqlConnection();

    private int idUsuario;


        public FrmPublicacionSubasta(int id_Usr)
        {
            
            idUsuario = id_Usr;
            InitializeComponent();


            comboBoxPreguntas.Items.Add("SI");
            comboBoxPreguntas.Items.Add("NO");
           
            comboBoxTipoPublicacion.Items.Add("Subasta");
            comboBoxEstadoPublicacion.Items.Add("Pausada");
            comboBoxEstadoPublicacion.Items.Add("Activa");
            comboBoxEstadoPublicacion.Items.Add("Borrador");
            comboBoxEstadoPublicacion.Items.Add("Finalizada");
            comboBoxStock.Items.Add("1");
            
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

        }




        private void FrmPublicacionSubasta_Load_1(object sender, EventArgs e)
        {

            //Llena comboBox Cod_Publicacion

            string codPublicacion = "SELECT MAX(COD_PUBLICACION +1) FROM JJRD.PUBLICACION";
            Query qry11 = new Query(codPublicacion);
            decimal idPublicacion1 = (decimal)qry11.ObtenerUnicoCampo();

            comboBoxCodPublicacion.Items.Add(idPublicacion1);
            
            
            //Llenar comboBox visibilidad

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select DESCRIPCION from JJRD.Visibilidad where HABILITADO = 1", conexion);
            da.Fill(ds, "JJRD.Visibilidad");

            comboBoxVisibilidad.DataSource = ds.Tables[0].DefaultView;
            comboBoxVisibilidad.ValueMember = "DESCRIPCION";
            comboBoxVisibilidad.SelectedItem = null;



            //Bloquear comandos

            comboBoxCodPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstadoPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPreguntas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStock.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFechaInicio.Enabled = false;
            comboBoxVisibilidad.DropDownStyle = ComboBoxStyle.DropDownList;

        }


   



        private void bnGuardar_Click(object sender, EventArgs e)
        {
             //Controlar que los datos no sean nulos

            if ((comboBoxCodPublicacion.Text != "")&&
                (txtDescripcion.Text.Trim() != "" ) &&  
                (comboBoxStock.Text.Trim() != "" ) &&
                (comboBoxFechaVencimiento.Text != "" ) &&
                (txtPrecio.Text.Trim() != "" ) &&
                (txtDescripcion.Text.Trim() != "" ) &&
                (comboBoxVisibilidad.Text != "" ) &&
                
                (comboBoxEstadoPublicacion.Text != "") &&
                (comboBoxTipoPublicacion.Text != "") &&
                (comboBoxPreguntas.Text != ""))

 
            {
                //Busca codigo de visibilidad y se lo guarda
                 
                string visibilidad = "SELECT COD_VISIBILIDAD FROM JJRD.VISIBILIDAD WHERE DESCRIPCION = '" + comboBoxVisibilidad.Text + "'";
                Query qr = new Query(visibilidad);
                
                decimal idVisibilidad = (decimal)qr.ObtenerUnicoCampo();

                
                //Busca codigo de publicacion y se lo guarda



                string codigoPublicacion = "SELECT MAX(COD_PUBLICACION+1) FROM JJRD.PUBLICACION";
                Query qry8 = new Query(codigoPublicacion);

                decimal idPublicacion = (decimal)qry8.ObtenerUnicoCampo();

                
             
                        
                        string generar = "INSERT INTO JJRD.PUBLICACION (COD_PUBLICACION,ID_USUARIO,COD_VISIBILIDAD, DESCRIPCION, STOCK, PRECIO,FECHA_VENCIMIENTO,FECHA_INICIO, ESTADO, TIPO, PREGUNTAS) " +
                                          "  values ("+idPublicacion+","+idUsuario+","+idVisibilidad+",'"+txtDescripcion.Text+"',"+comboBoxStock.Text+","+txtPrecio.Text+","+comboBoxFechaVencimiento.Text+",'"+txtFechaInicio.Value+"','"+comboBoxEstadoPublicacion.Text+"','"+comboBoxTipoPublicacion.Text+"','"+comboBoxPreguntas.Text+"')";

                         Query qry2 = new Query(generar);
                         qry2.Ejecutar();
                         
                  



                         MessageBox.Show("Publicacion Realizada Correctamente" , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                
                //Ir al menu principal


                        frmPrincipal publicacion = new frmPrincipal(idUsuario);
                         this.Hide();
                         publicacion.ShowDialog();
                         publicacion = (frmPrincipal)this.ActiveMdiChild;


            }else

                    {
                        MessageBox.Show("No se pueden Ingresar Campos Vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal cliente = new frmPrincipal(idUsuario);
            this.Hide();
            cliente.ShowDialog();
            cliente = (frmPrincipal)this.ActiveMdiChild;
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {

           
            comboBoxCodPublicacion.Text = "";
            txtDescripcion.Text = "";
            comboBoxStock.Text = "";
            comboBoxFechaVencimiento.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            comboBoxVisibilidad.Text = "";
           
            comboBoxEstadoPublicacion.Text = "";
            comboBoxTipoPublicacion.Text = "";
            comboBoxPreguntas.Text = "";
            txtFechaInicio = null;
            listaRubros = null;

        }

      
       
      

       
        }
     
    }

