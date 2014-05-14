using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_JJRD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
        private void BOTONBUSCAR_Click(object sender, EventArgs e)
        {
            /*INICIA UNA NUEVA BUSQUEDA EN BASE A LOS FILTROS SELECCIONADOS,
              Y CARGA LOS RESULTADOS EN LA TABLA
             
             */

            
        }

        private void BOTONLIMPIAR_Click_1(object sender, EventArgs e)
        {
            /* LIMPIA Y RESETEA LOS FILTROS DE BUSQUEDA CARGADOS,
              TAMBIEN LIMPIA LOS RESULTADOS DE LA TABLA RESULTADOS */

        }

        private void TEXTOFILTRO1_TextChanged_1(object sender, EventArgs e)
        {  
            
            /*FILTRA POR TEXTO LIBRE
            
               SELECT 1 FROM TABLE WHERE COLUMN1 LIKE %CRITERIO%
             
             */ 
             

        }

        private void TEXTOFILTRO2_TextChanged_1(object sender, EventArgs e)
        {
            /* FILTRA POR TEXTO EXACTO
              
              SELECT 1 FROM TABLE WHERE COLUMN1 = CRITERIO
             
            */
        }

        private void COMBOFILTRO3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /* EL USUARIO ELIGE UNA OPCION DE UNA LISTA DE OPCIONES */
        }

        private void BOTONSELECCIONAR_Click(object sender, EventArgs e)
        {

        }

      

    }
}
