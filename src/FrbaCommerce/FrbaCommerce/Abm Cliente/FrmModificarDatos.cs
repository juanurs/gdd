using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class FrmModificarDatos : Form
    {
        private int idUsuario;
       
        public FrmModificarDatos(int id)
        {
            idUsuario = id;
            InitializeComponent();
        }


        private bool camposVacios()
        {
            //CAMPOS DISTINTOS DE VACIO
                
            return (txtDpto.Text.Trim() != "" && txtLocalidad.Text.Trim() != "" && txtTelefono.Text.Trim() != "" && txtDireccion.Text.Trim() != "" && txtCodigoPostal.Text.Trim() != "" && txtAltura.Text != "".Trim());
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            if (camposVacios())
            {
                //UPDATEAR LA TABLA CLIENTE

                Query consulta = new Query("update jjrd.CLIENTE SET LOCALIDAD = '" + txtLocalidad.Text + "', CALLE = '" + txtDireccion.Text + "', TELEFONO = " + txtTelefono.Text + ", COD_POSTAL = '" + txtCodigoPostal.Text + "', NUM_CALLE = " + txtAltura.Text + ", PISO = " + txtPiso.Text + ", DEPARTAMENTO = '" + txtDpto.Text + "'  WHERE ID_USUARIO= " + idUsuario + "");

                consulta.Ejecutar();

                MessageBox.Show("Cliente Modificado Correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            


            }
            else
            {
                MessageBox.Show("No se pueden ingresar campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            
            }

            //FALTA IR A MENU PRINCIPAL



     
        }

      
    }
}
