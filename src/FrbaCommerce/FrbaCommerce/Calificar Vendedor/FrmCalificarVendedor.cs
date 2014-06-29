using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.FuncionesGenerales;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class FrmCalificarVendedor : Form
    {
        private int idCliente;

        Funciones fn = new Funciones();
        private int idUsuario;

        private int idCompra;


        public FrmCalificarVendedor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bnSeleccionar.Enabled = false;
            this.bnCalificar.Enabled = false;
            this.txtEstrellas.Enabled = false;
            this.txtDetalle.Enabled = false;

            idUsuario = Globales.idUsuarioLogueado;

            idCliente = fn.ObtenerIdCliente(idUsuario);
            
            //CARGA DATAGRID CON LAS COMPRAS NO CALIFICADAS HECHAS POR EL CLIENTE.
            Query qr = new Query("select CO.ID_COMPRA , PU.DESCRIPCION as 'Descripción' from JJRD.PUBLICACION as PU join JJRD.COMPRAS as CO on co.COD_PUBLICACION = Pu.COD_PUBLICACION where CO.ID_CLIENTE = "+ idCliente +" and CO.COD_CALIFICACION is null");

            dataResultado.DataSource = qr.ObtenerDataTable();

            dataResultado.Columns["ID_COMPRA"].Visible = false;  //OCULTO LA COLUMNA
            dataResultado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void bnSeleccionar_Click(object sender, EventArgs e)
        {
            this.txtEstrellas.Enabled = true;
            this.txtDetalle.Enabled = true;

            DataGridViewRow fila = dataResultado.SelectedRows[0];

            //IDUSUARIO A DESHABILITAR
            idCompra = Convert.ToInt32(fila.Cells["ID_COMPRA"].Value.ToString());

            
            
            
            
            
            
            
            txtEstrellas.Focus();




        }

        private void dataResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bnSeleccionar.Enabled = true;
        }

        private void txtEstrellas_TextChanged(object sender, EventArgs e)
        {
            if (txtEstrellas.Text != "")
            {
                this.bnCalificar.Enabled = true;
            }
        }

        private void bnCalificar_Click(object sender, EventArgs e)
        {
            if (txtEstrellas.Text != "")
            {
                //OBTENER ULTIMO CODIGO DE CALIFICACION, E INCREMENTAR EN UNO PARA INSERTAR
                Query qr = new Query("SELECT MAX(COD_CALIFICACION) FROM JJRD.CALIFICACIONES");
                int ultimoCodCalificacion = Convert.ToInt32(qr.ObtenerUnicoCampo());
                ultimoCodCalificacion++;

                //TRIGGER PARA INSERT EN CALIFICACIONES

                Query qr2 = new Query("INSERT INTO JJRD.CALIFICACIONES (COD_CALIFICACION, CANTIDAD_ESTRELLAS, DESCRIPCION) "+
                                        " VALUES ("+ ultimoCodCalificacion +", " + Convert.ToInt32(txtEstrellas.Text) + ", '" + txtDetalle.Text + "' )");
                qr2.Ejecutar();

                Query qr3 = new Query("UPDATE JJRD.COMPRAS SET COD_CALIFICACION = " + ultimoCodCalificacion + " WHERE ID_COMPRA = " + idCompra);
                qr3.Ejecutar();

                MessageBox.Show("Hecho.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No ha otorgado estrellas al vendedor.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEstrellas.Focus();
            }
        }
    }
}
