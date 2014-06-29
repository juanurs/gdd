using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class FrmHistorialCliente : Form
    {
        private int idUsuario;

        public FrmHistorialCliente()
        {
            idUsuario = Globales.idUsuarioLogueado;

            InitializeComponent();
        }

        private void FrmHistorialCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void bnCompras_Click(object sender, EventArgs e)
        {
            //compras realizadas por el usuario

            Query qr = new Query("SELECT DISTINCT ID_COMPRA, COD_PUBLICACION, ID_CLIENTE,COD_CALIFICACION,FECHA,CANTIDAD FROM JJRD.COMPRAS  WHERE ID_CLIENTE = '" + idUsuario + "'");
            dataResultado.DataSource = qr.ObtenerDataTable();
            dataResultado.Columns[2].Visible = false;
            dataResultado.Columns[0].Visible = false;
            dataResultado.Columns[3].Visible = false;
        }

        private void bnCalificacionesOtorgadas_Click(object sender, EventArgs e)
        {
          //calificaciones otorgadas por el usuario (se fija en las compras que hizo el cliente y que esten calificadas)

            Query qry = new Query("SELECT DISTINCT ID_CLIENTE, CO.COD_PUBLICACION, CO.COD_CALIFICACION,CA.CANTIDAD_ESTRELLAS, CA.DESCRIPCION from jjrd.COMPRAS as CO, jjrd.CALIFICACIONES as CA where ID_CLIENTE =  '" + idUsuario + "' AND CO.COD_CALIFICACION = CA.COD_CALIFICACION AND CO.COD_CALIFICACION IS NOT NULL");
            dataResultado.DataSource = qry.ObtenerDataTable();
            dataResultado.Columns[0].Visible = false;
            dataResultado.Columns[2].Visible = false;
          
          
        }

        private void bnCalificacionesRecibidas_Click(object sender, EventArgs e)
        {

            //calificaciones recibidas (se fija en las publicaciones que hizo el cliente y que esten calificadas)

            Query qry1 = new Query("SELECT DISTINCT P.COD_PUBLICACION, P.ID_USUARIO, COM.COD_CALIFICACION, CAL.CANTIDAD_ESTRELLAS, CAL.DESCRIPCION FROM JJRD.PUBLICACION AS P, JJRD.COMPRAS AS COM, JJRD.CALIFICACIONES AS CAL WHERE ( P.ID_USUARIO =  '" + idUsuario + "' )AND (P.COD_PUBLICACION = COM.COD_PUBLICACION) AND (COM.COD_CALIFICACION = CAL.COD_CALIFICACION)");
            dataResultado.DataSource = qry1.ObtenerDataTable(); 
            dataResultado.Columns[1].Visible = false;
            dataResultado.Columns[2].Visible = false;


        }

        private void bnOfertas_Click(object sender, EventArgs e)
        {

            //ofertas realizadas (se fija en las ofertas y si fue comprada falta termirar si gano la subasta q no se como hacerlo 
             // o sea si fue comprada, la gano, por ende creo que estas serian las ganadas)

            Query qry2 = new Query("select DISTINCT O.COD_PUBLICACION,O.ID_CLIENTE, MONTO, O.FECHA from jjrd.OFERTAS AS O, JJRD.PUBLICACION AS P, JJRD.COMPRAS AS C WHERE O.COD_PUBLICACION = P.COD_PUBLICACION AND O.ID_CLIENTE = '" + idUsuario + "' AND C.COD_PUBLICACION = O.COD_PUBLICACION");
            dataResultado.DataSource = qry2.ObtenerDataTable(); 
            dataResultado.Columns[1].Visible = false;
        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal publicacion = new frmPrincipal();
            this.Hide();
            publicacion.ShowDialog();
            publicacion = (frmPrincipal)this.ActiveMdiChild;
        }

       
    }
}
