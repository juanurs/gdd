using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class FrmResponder : Form
    {
        private int idUsuario;
        private int codigoPregunta;


        public FrmResponder(int id_Usr)
        {
            InitializeComponent();

            idUsuario = id_Usr;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text != null)
            {
                bnResponder.Enabled = true;
            }

            //MUESTRA LA DESCRIPCION DE LA PUBLICACION SELECCIONADA
            Query qr = new Query("SELECT DESCRIPCION FROM JJRD.PUBLICACION WHERE COD_PUBLICACION = " + comboBox.Text);
            this.lblDescripcionPublicacion.Text = qr.ObtenerUnicoCampo().ToString();
            this.lblDescripcionPublicacion.Visible = true;
            
            MostrarResultadosDataGrid();

        }

        private void FrmResponder_Load(object sender, EventArgs e)
        {
            this.lblDescripcionPublicacion.Visible = false;
            this.txtRespuesta.Enabled = false;
            
            //CARGAR COMBOBOX CON SOLO LAS PUBLICACIONES QUE TIENEN PREGUNTAS

            Query qr = new Query("SELECT pu.COD_PUBLICACION FROM JJRD.PUBLICACION as pu " +
			                     "JOIN JJRD.PREGUNTAS as pr on pu.COD_PUBLICACION = pr.COD_PUBLICACION "+
		                         "WHERE pu.ID_USUARIO = "+ idUsuario +" AND pu.PREGUNTAS = 'SI' AND pr.RESPUESTA_DESCRIPCION is null");

            foreach (DataRow dataRow in qr.ObtenerDataTable().AsEnumerable())
            {
                comboBox.Items.Add(dataRow[0]);
            }


            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.Text = null;

        }


        private void MostrarResultadosDataGrid()
        {
            Query qr = new Query("SELECT COD_PREGUNTA, PREGUNTA_DESCRIPCION as 'PREGUNTA' FROM JJRD.PREGUNTAS WHERE COD_PUBLICACION = " + comboBox.Text + " AND RESPUESTA_DESCRIPCION IS NULL");
            dataGridView.DataSource = qr.ObtenerDataTable();
            dataGridView.Columns[1].Visible= false;  //OCULTO LA COLUMNA COD_PREGUNTA
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoPregunta = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());

            this.txtRespuesta.Enabled = true;
            txtRespuesta.Focus();
            
            
            
        }

        private void bnResponder_Click(object sender, EventArgs e)
        {
            Query qr = new Query("UPDATE JJRD.PREGUNTAS SET RESPUESTA_FECHA = '" + DateTime.Now + "', RESPUESTA_DESCRIPCION = '"+ txtRespuesta.Text +"' WHERE COD_PREGUNTA = " + codigoPregunta);
            qr.Ejecutar();

            //actualizar combobox

            //actualizar datagrid

        }



    }
}
