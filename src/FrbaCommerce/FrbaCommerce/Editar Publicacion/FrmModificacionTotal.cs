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
    public partial class FrmModificacionTotal : Form
    {
        SqlConnection conexion = new SqlConnection();
      
        private string idUs;
        private string publicacion;
        private int stockAnterior;

        public FrmModificacionTotal(string usuario, string idPublicacion, int stock)
        {
            stockAnterior = stock;
            idUs = usuario;
            publicacion = idPublicacion ;
            InitializeComponent();

        }

        private void FrmModificacionTotal_Load(object sender, EventArgs e)
        {
         
            comboBoxPreguntas.Items.Add("SI");
            comboBoxPreguntas.Items.Add("NO");
            comboBoxCodPublicacion.Items.Add(publicacion);
            comboBoxEstado.Items.Add("Activa");
            comboBoxEstado.Items.Add("Pausada");
            comboBoxEstado.Items.Add("Borrador");
            comboBoxEstado.Items.Add("Finalizada");
            comboBoxTipo.Items.Add("Compra Inmediata");
            comboBoxTipo.Items.Add("Subasta");
            comboBoxVisibilidad.Items.Add("Insertar");


            comboBoxPreguntas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCodPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            dateTimeFechaInicio.Enabled = false;
           

            conexion.ConnectionString = Settings.Default.CadenaDeConexion;


        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {

            if((comboBoxCodPublicacion.Text != "") &&
                (comboBoxEstado.Text != "") &&
                (comboBoxFechaVencimiento.Text != "") &&
                (comboBoxPreguntas.Text != "") &&
                (comboBoxVisibilidad.Text != "") &&
                (txtDescripcion.Text != "") &&
                (txtPrecio.Text != "") &&
                (txtStock.Text != "") &&
                (comboBoxTipo.Text != ""))
                

            {

            string actualizar = "UPDATE JJRD.PUBLICACION SET COD_PUBLICACION = "+publicacion+", ID_USUARIO = "+idUs+", COD_VISIBILIDAD = "+ comboBoxVisibilidad.Text +", DESCRIPCION = '"+txtDescripcion.Text+"', STOCK = "+txtStock.Text+", FECHA_VENCIMIENTO = '"+comboBoxFechaVencimiento.Text+"', FECHA_INICIO = '"+dateTimeFechaInicio.Value+"', PRECIO = "+txtPrecio.Text+", ESTADO = '"+comboBoxEstado.Text+"', TIPO = '"+comboBoxTipo.Text+"', PREGUNTAS = '"+comboBoxPreguntas.Text+"'  WHERE COD_PUBLICACION = " + publicacion+ "";

            new Query(actualizar).Ejecutar();

            MessageBox.Show("Publicacion Editada Correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

           /* frmPrincipal publicaciones = new frmPrincipal(idUs);
            this.Hide();
            publicaciones.ShowDialog();
            publicaciones = (frmPrincipal)this.ActiveMdiChild; */

            }else 
             { // No se pueden ingresar campos vacios
                 MessageBox.Show("No se pueden ingresar campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
           /* frmPrincipal publicacion = new frmPrincipal(idUs);
            this.Hide();
            publicacion.ShowDialog();
            publicacion = (frmPrincipal)this.ActiveMdiChild; */
        }
    }
}
