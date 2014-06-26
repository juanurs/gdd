using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.FuncionesGenerales;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class FrmVerRespuestas : Form
    {
        private int idUsuario;
        Funciones fn = new Funciones();

        public FrmVerRespuestas(int id_Usr)
        {
            InitializeComponent();

            idUsuario = id_Usr;
            
        }

        private void FrmVerRespuestas_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {

            Query qr = new Query("select PR.COD_PREGUNTA, PR.COD_PUBLICACION as 'Codigo Publicación', PREGUNTA_DESCRIPCION as 'Pregunta' from JJRD.PREGUNTAS as PR " +
								            "JOIN JJRD.PUBLICACION as PU ON Pr.COD_PUBLICACION = PU.COD_PUBLICACION " +
											"where pu.ID_USUARIO = " + idUsuario + " AND PR.RESPUESTA_DESCRIPCION IS NOT NULL");
            
            dataGridView.DataSource = qr.ObtenerDataTable();
            dataGridView.Columns[1].Visible = false;  //OCULTO LA COLUMNA COD_PREGUNTA
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); //LAS COLUMNAS SE ACOMODAN SOLAS


        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigoPregunta = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());

            int cod_publicacion = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Codigo Publicación"].Value.ToString());

            //MUESTRA DESCRIPCION DE LA PUBLICACION
            Query qr = new Query("SELECT DESCRIPCION FROM JJRD.PUBLICACION WHERE COD_PUBLICACION = " + cod_publicacion);
            txtPublicacion.Text = qr.ObtenerUnicoCampo().ToString();
            

            //MUESTRA LA RESPUESTA
            Query qr1 = new Query("SELECT RESPUESTA_DESCRIPCION FROM JJRD.PREGUNTAS WHERE COD_PREGUNTA = " + codigoPregunta);
            txtRespuesta.Text = qr1.ObtenerUnicoCampo().ToString();
            

        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            FrmGestionPreguntas gestionPreguntas = new FrmGestionPreguntas(idUsuario);
            this.Hide();
            gestionPreguntas.ShowDialog();
            gestionPreguntas = (FrmGestionPreguntas)this.ActiveMdiChild;
        }
    }
}
