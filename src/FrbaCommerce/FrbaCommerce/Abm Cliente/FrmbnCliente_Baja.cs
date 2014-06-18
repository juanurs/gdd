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
    public partial class FrmbnCliente_Baja : Form
    {
        public FrmbnCliente_Baja()
        {
            InitializeComponent();
        }



        private void bnBuscar_Click(object sender, EventArgs e)
        { 
            //CHEQUEA QUE TODOS LOS CAMPOS NO SEAN VACIOS

            if ((txtNombre.Text.Trim() != "") ||
                (txtApellido.Text.Trim() != "") ||
                (comboBoxTipoDoc.Text.Trim() != "") ||
                (txtNumeroDoc.Text.Trim() != "") ||
                (txtEmail.Text.Trim() != ""))
            {
                //BUSCA POR NOMBRE

                if (txtNombre.Text != "")
                {

                    //HACER JOIN DE TIPO DE DOCUMENTO


                    Query qr = new Query("SELECT NOMBRE, APELLIDO, ID_TIPO_DOC, NUMERO_DOC, EMAIL FROM JJRD.CLIENTE WHERE NOMBRE LIKE  '%" + txtNombre.Text + "%'");
                    dataResultado.DataSource = qr.ObtenerDataTable();

                }
                else
                {
                    //BUSCA POR APELLIDO

                    if (txtApellido.Text.Trim() != "")
                    {

                        Query qr = new Query("SELECT NOMBRE, APELLIDO, ID_TIPO_DOC, NUMERO_DOC, EMAIL FROM JJRD.CLIENTE WHERE APELLIDO LIKE  '%" + txtApellido.Text + "%'");
                        dataResultado.DataSource = qr.ObtenerDataTable();
                    }
                    else
                    {
                        //BUSCA POR TIPO Y NUMERO DE DOCUMENTO

                        if ((comboBoxTipoDoc.Text.Trim() != "") && (txtNumeroDoc.Text.Trim() != ""))
                        {

                            Query qr = new Query("SELECT NOMBRE, APELLIDO, ID_TIPO_DOC, NUMERO_DOC, EMAIL FROM JJRD.CLIENTE WHERE NUMERO_DOC LIKE  '%+comboBoxTipoDoc.SelectedValue+%' AND NUMERO_DOC LIKE '%+txtNumeroDoc+%'");
                            dataResultado.DataSource = qr.ObtenerDataTable();
                        }
                        else
                        { 
                            //BUSCA POR EMAIL

                            if (txtEmail.Text.Trim() != "")
                            {
                                Query qr = new Query("SELECT NOMBRE, APELLIDO, ID_TIPO_DOC, NUMERO_DOC, EMAIL FROM JJRD.CLIENTE WHERE EMAIL LIKE  '%" + txtEmail.Text + "%'");
                                dataResultado.DataSource = qr.ObtenerDataTable();
                            }
                        }


                    }





                }

            }
            else
            {
                //TIRA ERROR SI TODOS LOS CAMPOS SON VACIOS

                MessageBox.Show("Todos los datos no pueden ser nulos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }








        }

     



    }
}
