using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FrbaCommerce.Editar_Publicacion
{
    public partial class FrmModificacionActiva : Form
    {
        private string idUs;
        private string publicacion;
        private string stockAnterior;
        private string estado;
        private string tipoPublicacion;

           SqlConnection conexion = new SqlConnection();
      
    
        public FrmModificacionActiva(string usuario, string idPublicacion, string stock, string estadoPublicacion, string tipoDePublicacion)
        {

           stockAnterior = stock;
           idUs = usuario;
           publicacion = idPublicacion;
           estado = estadoPublicacion;
           tipoPublicacion = tipoDePublicacion;

               InitializeComponent();
        }

        private void FrmModificacionActiva_Load(object sender, EventArgs e)
        {
            comboBoxEstado.Items.Add("Pausada");
            comboBoxEstado.Items.Add("Finalizada");

         
        }

     

           private void Actualizar_Click_1(object sender, EventArgs e)
           {
               if (tipoPublicacion == "Subasta")
               { //Mensaje de error, no se puede modificar

                   MessageBox.Show("No se puede modificar una Publicacion con estado Subasta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
               else
               {
                   if ((tipoPublicacion == "Compra Inmediata") /*&& (txtStock.Text > stockAnterior)*/)
                   {
                       
                       // FALTA controlar stock incremental
                     
                       // UPDATE de datos

                       string actualizar = "UPDATE JJRD.PUBLICACION SET  STOCK = " + txtStock.Text + ", ESTADO = '" + comboBoxEstado.Text + "' WHERE COD_PUBLICACION = " + publicacion + "";

                       new Query(actualizar).Ejecutar();

                       MessageBox.Show("Publicacion Editada Correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       this.Visible = false;

                   }
                   else
                   {
                       MessageBox.Show("No se puede decrementar el Stock Publicacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);


                   }
               }
                
           }

           private void bnVolver_Click(object sender, EventArgs e)
           {
               
           }
    }
}

