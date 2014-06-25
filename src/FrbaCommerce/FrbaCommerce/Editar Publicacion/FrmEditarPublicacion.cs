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
            comboBoxEstadoPublicacion.Items.Add("Borrada");
            comboBoxEstadoPublicacion.Items.Add("Activa");
            comboBoxEstadoPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
        

        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxEstadoPublicacion.Text != "")
            { 
                //Buscar 

                Query qr = new Query( "SELECT DESCRIPCION,STOCK,FECHA_VENCIMIENTO,FECHA_INICIO,PRECIO,ESTADO,TIPO,PREGUNTAS FROM JJRD.PUBLICACION  WHERE ID_USUARIO = '"+idUsuario+"'  AND ESTADO = '" + comboBoxEstadoPublicacion.Text + "'");
                dataResultado.DataSource = qr.ObtenerDataTable();
                dataResultado.Visible = true;


            }

               // if(comboBoxEstadoPublicacion.SelectedValue() == "")

            else 
            {
                //No se pueden insertar campos vacios


                MessageBox.Show("No se pueden Ingresar Campos Vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
