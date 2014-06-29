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
    public partial class FrmGestionPreguntas : Form
    {
        private int idUsuario;

        public FrmGestionPreguntas()
        {
            InitializeComponent();

            idUsuario = Globales.idUsuarioLogueado;
        }

        private void bnResponderPreguntas_Click(object sender, EventArgs e)
        {
            FrmResponder responder = new FrmResponder(idUsuario);
            this.Hide();
            responder.ShowDialog();
            responder = (FrmResponder)this.ActiveMdiChild;
        }

        private void bnVerRespuestas_Click(object sender, EventArgs e)
        {
            FrmVerRespuestas verRespuestas = new FrmVerRespuestas(idUsuario);
            this.Hide();
            verRespuestas.ShowDialog();
            verRespuestas = (FrmVerRespuestas)this.ActiveMdiChild;
        }

        private void bnVolver_Click_1(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.ShowDialog();
            frmPrincipal = (frmPrincipal)this.ActiveMdiChild;
        }



        
    }
}
