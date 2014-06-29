using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class FrmListadoEstadistico : Form
    {
        public FrmListadoEstadistico()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAnio.Focus();
            
            //CARGA COMBOBOX TRIMESTRE
            comboBoxTrimestre.Items.Add("Enero-Febrero-Marzo");
            comboBoxTrimestre.Items.Add("Abril-Mayo-Junio");
            comboBoxTrimestre.Items.Add("Julio-Agosto-Septiembre");
            comboBoxTrimestre.Items.Add("Octubre-Noviembre-Diciembre");

            //ESCONDER LABELS Y TEXTBOX
            this.lblVisibilidad.Visible = false;
            this.lblMesAnio.Visible = false;
            this.comboBoxVisibilidad.Visible = false;
            this.comboBoxMes.Visible = false;
            this.bnVer.Visible = false;

            //ESCONDER BOTONES
            this.bnCliMayorCantPublSinCalificar.Enabled = false;
            this.bnMayorCantProdNoVendidos.Enabled = false;
            this.bnVendMayorCalifi.Enabled = false;
            this.bnVendMayorFact.Enabled = false;


        }

        private void bnMayorCantProdNoVendidos_Click(object sender, EventArgs e)
        {
            //MOSTRAR LABELS Y TEXTBOX
            this.lblVisibilidad.Visible = true;
            this.lblMesAnio.Visible = true;
            this.comboBoxVisibilidad.Visible = true;
            this.comboBoxMes.Visible = true;
            this.bnVer.Visible = true;  

        }

        private void cargarComboBoxMes()
        {
            this.comboBoxMes.Text = "";
            this.comboBoxMes.Items.Clear();
            
                switch (comboBoxTrimestre.SelectedIndex)
                {
                    //"Enero-Febrero-Marzo"
                    case 0: comboBoxMes.Items.Add("Enero");
                            comboBoxMes.Items.Add("Febrero");
                            comboBoxMes.Items.Add("Marzo");
                            break;

                    //Abril-Mayo-Junio
                    case 1: comboBoxMes.Items.Add("Abril");
                            comboBoxMes.Items.Add("Mayo");
                            comboBoxMes.Items.Add("Junio");
                            break;

                    //Julio-Agosto-Septiembre
                    case 2: comboBoxMes.Items.Add("Julio");
                            comboBoxMes.Items.Add("Agosto");
                            comboBoxMes.Items.Add("Septiembre");
                            break;

                    //Octubre-Noviembre-Diciembre
                    case 3: comboBoxMes.Items.Add("Octubre");
                            comboBoxMes.Items.Add("Noviembre");
                            comboBoxMes.Items.Add("Diciembre");
                            break;

                }
        }

        private void cargarComboBoxVisibilidad()
        {

            this.comboBoxVisibilidad.Text = "";
            this.comboBoxVisibilidad.Items.Clear();
            
            
            string sql = "SELECT DESCRIPCION FROM JJRD.VISIBILIDAD ORDER BY PRECIO";


            Query qry = new Query(sql);


            foreach (DataRow dataRow in qry.ObtenerDataTable().AsEnumerable())
            {
                comboBoxVisibilidad.Items.Add(dataRow[0]);
            }
        }

        private void bnVer_Click(object sender, EventArgs e)
        {
            if (!FaltaElegirVisibilidadYMes())
            {
                //LIMPIA LOS CAMPOS
                //this.comboBoxMes.Items.Clear();
                


                //HACER QUERY Y MOSTRAR RESULTADO

            }
            else
            {
                MessageBox.Show("Debe seleccionar visibilidad y mes a filtrar", "Advertencia",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool FaltaElegirVisibilidadYMes()
        {
            return (comboBoxVisibilidad.Text == "" && comboBoxMes.Text == "");
        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {
            if (txtAnio.Text.Trim() != "" && comboBoxTrimestre.Text != "")
            {
                this.bnCliMayorCantPublSinCalificar.Enabled = true;
                this.bnMayorCantProdNoVendidos.Enabled = true;
                this.bnVendMayorCalifi.Enabled = true;
                this.bnVendMayorFact.Enabled = true;
            }
        }

        private void comboBoxTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAnio.Text.Trim() != "" && comboBoxTrimestre.Text != "")
            {
                this.bnCliMayorCantPublSinCalificar.Enabled = true;
                this.bnMayorCantProdNoVendidos.Enabled = true;
                this.bnVendMayorCalifi.Enabled = true;
                this.bnVendMayorFact.Enabled = true;
            }

            //SETEAR COMBOBOXMES
            cargarComboBoxMes();

            //CARGAR COMBOBOXVISIBILIDAD
            cargarComboBoxVisibilidad();

            //ESCONDER LABELS Y TEXTBOX
            this.lblVisibilidad.Visible = false;
            this.lblMesAnio.Visible = false;
            this.comboBoxVisibilidad.Visible = false;
            this.comboBoxMes.Visible = false;
            this.bnVer.Visible = false;


        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.ShowDialog();
            frmPrincipal = (frmPrincipal)this.ActiveMdiChild;
        }

        

    }
}
