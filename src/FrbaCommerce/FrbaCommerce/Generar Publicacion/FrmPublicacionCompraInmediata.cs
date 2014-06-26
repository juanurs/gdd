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
    public partial class FrmPublicacionCompraInmediata : Form
    {
        SqlConnection conexion = new SqlConnection();

        private int idUsuario;

          public FrmPublicacionCompraInmediata(int id_Usr)
             {

                 idUsuario = id_Usr;
                 
            

            InitializeComponent();
            comboBoxPreguntas.Items.Add("SI");
            comboBoxPreguntas.Items.Add("NO");
            comboBoxVisibilidad.Items.Add("Platino");
            comboBoxVisibilidad.Items.Add("Oro");
            comboBoxVisibilidad.Items.Add("Plata");
            comboBoxVisibilidad.Items.Add("Bronce");
            comboBoxVisibilidad.Items.Add("Gratis");
            comboBoxTipoPublicacion.Items.Add("Compra Inmediata");
            comboBoxEstadoPublicacion.Items.Add("Borrador");
            comboBoxEstadoPublicacion.Items.Add("Activa");
            comboBoxEstadoPublicacion.Items.Add("Pausada");
            comboBoxEstadoPublicacion.Items.Add("Finalizada");


            

            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            
            
       
        }

          
     

        public void FrmPublicacion_Load(object sender, EventArgs e)
        {
                //Llena comboBox Cod_Publicacion

            string codigoPublicacion = "SELECT MAX(COD_PUBLICACION+1) FROM JJRD.PUBLICACION";
            Query qry = new Query(codigoPublicacion);

            decimal idPublicacion = (decimal)qry.ObtenerUnicoCampo();


     
            comboBoxCodPublicacion.Items.Add(idPublicacion);
            comboBoxCodPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstadoPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPreguntas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
          
            comboBoxVisibilidad.DropDownStyle = ComboBoxStyle.DropDownList;
          
            this.txtFechaInicio.Enabled = false;
        }

       


        private void bnGuardar_Click(object sender, EventArgs e)
        {

           //Controlar que los datos no sean nulos

            if ((comboBoxCodPublicacion.Text != "")&&
                (txtDescripcion.Text.Trim() != "" ) &&  
                (txtStock.Text.Trim() != "" ) &&
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
                Query qry = new Query(codigoPublicacion);

                decimal idPublicacion = (decimal)qry.ObtenerUnicoCampo();

                
             
                 
                        
                        string generar = "INSERT INTO JJRD.PUBLICACION (COD_PUBLICACION,ID_USUARIO,COD_VISIBILIDAD, DESCRIPCION, STOCK, PRECIO,FECHA_VENCIMIENTO,FECHA_INICIO, ESTADO, TIPO, PREGUNTAS) " +
                                          "  values ("+idPublicacion+","+idUsuario+","+idVisibilidad+",'"+txtDescripcion.Text+"',"+txtStock.Text+","+txtPrecio.Text+","+comboBoxFechaVencimiento.Text+",'"+txtFechaInicio.Value+"','"+comboBoxEstadoPublicacion.Text+"','"+comboBoxTipoPublicacion.Text+"','"+comboBoxPreguntas.Text+"')";

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
            txtStock.Text = "";
            comboBoxFechaVencimiento.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            comboBoxVisibilidad.Text = "";
         
            comboBoxEstadoPublicacion.Text = "";
            comboBoxTipoPublicacion.Text = "";
            comboBoxPreguntas.Text = "";
            txtFechaInicio = null;
        }

        

       
      
    }
}
