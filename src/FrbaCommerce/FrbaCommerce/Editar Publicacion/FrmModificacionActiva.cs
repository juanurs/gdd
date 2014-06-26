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
        private int stockAnterior;
        private string estado;
        private string tipoPublicacion;

           SqlConnection conexion = new SqlConnection();
      
    
        public FrmModificacionActiva(string usuario, string idPublicacion, int stock, string estadoPublicacion, string tipoDePublicacion)
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
               if ((comboBoxEstado.Text != "") && (txtStock.Text != ""))
               {

                   if (tipoPublicacion == "Subasta")
                   { //Mensaje de error, no se puede modificar

                       MessageBox.Show("No se puede modificar una Publicacion con estado Subasta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   }
                   else
                   {
                       if ((tipoPublicacion == "Compra Inmediata") /*&& ((txtStock.Text) > stockAnterior)*/)
                       {


                           // UPDATE de datos

                           string actualizar = "UPDATE JJRD.PUBLICACION SET  STOCK = " + txtStock.Text + ", ESTADO = '" + comboBoxEstado.Text + "' WHERE COD_PUBLICACION = " + publicacion + "";

                           new Query(actualizar).Ejecutar();

                           MessageBox.Show("Publicacion Editada Correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      /*     frmPrincipal publicaciones = new frmPrincipal(idUs);
                           this.Hide();
                           publicaciones.ShowDialog();
                           publicaciones = (frmPrincipal)this.ActiveMdiChild;  */

                       }
                       else
                       {
                           MessageBox.Show("No se puede decrementar el Stock de la Publicacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);


                       }
                   }
               }
               else 
                { // Error de campos vacios 
                    MessageBox.Show("No se pueden ingresar campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
           }

           private void bnVolver_Click(object sender, EventArgs e)
           {
               /* frmPrincipal publicacion = new frmPrincipal();
               this.Hide();
               publicacion.ShowDialog();
               publicacion = (frmPrincipal)this.ActiveMdiChild; */
           }

        
    }
}

