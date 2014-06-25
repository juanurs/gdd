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

        public FrmGestionPreguntas(int id_Usr)
        {
            InitializeComponent();

            idUsuario = id_Usr;
        }

        private void bnResponderPreguntas_Click(object sender, EventArgs e)
        {
            FrmResponder responder = new FrmResponder(idUsuario);
            this.Hide();
            responder.ShowDialog();
            responder = (FrmResponder)this.ActiveMdiChild;
        }


        
    }
}
