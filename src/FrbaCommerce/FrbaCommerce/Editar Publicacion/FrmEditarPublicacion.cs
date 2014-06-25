using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class FrmEditarPublicacion : Form
    {

        private int idUsuario;
        public FrmEditarPublicacion(int id_Usr)
        {
            idUsuario = id_Usr;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            

                Query qr = new Query( "SELECT COD_PUBLICACION, DESCRIPCION,ID_USUARIO, STOCK,FECHA_VENCIMIENTO,FECHA_INICIO,PRECIO,ESTADO,TIPO,PREGUNTAS FROM JJRD.PUBLICACION  WHERE ID_USUARIO = '"+idUsuario+"'");
                dataResultado.DataSource = qr.ObtenerDataTable();
                dataResultado.Columns[3].Visible = false;
              //  dataResultado.Columns[1].Visible = false; 

           

            
        }

        private void dataResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


           dataResultado.Rows[e.RowIndex].Cells["Cod_Publicacion"].Value.ToString();
           dataResultado.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
           dataResultado.Rows[e.RowIndex].Cells["Id_Usuario"].Value.ToString();
           dataResultado.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
           dataResultado.Rows[e.RowIndex].Cells["Fecha_Vencimiento"].Value.ToString();
           dataResultado.Rows[e.RowIndex].Cells["Fecha_Inicio"].Value.ToString();
           dataResultado.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
           dataResultado.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
           dataResultado.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
           dataResultado.Rows[e.RowIndex].Cells["Fecha_Vencimiento"].Value.ToString();



           this.Visible = true;
           string estadoPublicacion;
           string tipoDePublicacion;
           string usuario;
           string idPublicacion;
           string stock;
          
           estadoPublicacion = Convert.ToString(dataResultado.Rows[e.RowIndex].Cells[8].Value.ToString());
           tipoDePublicacion = Convert.ToString(dataResultado.Rows[e.RowIndex].Cells[9].Value.ToString());
           usuario = Convert.ToString(dataResultado.Rows[e.RowIndex].Cells[3].Value.ToString());
           idPublicacion = Convert.ToString(dataResultado.Rows[e.RowIndex].Cells[1].Value.ToString());
           stock = Convert.ToString(dataResultado.Rows[e.RowIndex].Cells[4].Value.ToString());
            
            


             switch (estadoPublicacion)
             {
                 case "Borrador"://modificar forma total

                     this.Hide();
                     FrmModificacionTotal frmModificacionTotal = new FrmModificacionTotal(usuario, idPublicacion, stock);
                     frmModificacionTotal.ShowDialog();
                         
                         break;

                 case "Publicada":  //solo permite incrementar el stock y descripcion de producto

                         this.Hide();
                         FrmModificacionActiva frmModificacionActiva = new FrmModificacionActiva(usuario, idPublicacion, stock,estadoPublicacion,tipoDePublicacion);
                         frmModificacionActiva.ShowDialog();



                     break;

              


                 case "Finalizada":  //No se puede modificar

                      MessageBox.Show("No se puede modificar una Publicacion Finalizada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        


                     break;

                 case "Pausada":  //No se puede modificar

                     MessageBox.Show("No se puede modificar una Publicacion Pausada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);



                     break;
                 
                 default:
                     break;

             }
           

        }
    }
}
