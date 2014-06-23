using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class FrmTipoDePublicacion : Form
    {
        private int idUsuario;

        public FrmTipoDePublicacion(int id_Usr)
        {
            idUsuario = id_Usr;
            InitializeComponent();
        }

        private void bnCompraInmediata_Click(object sender, EventArgs e)
        {
            FrmPublicacionCompraInmediata publicacion = new FrmPublicacionCompraInmediata(idUsuario);
            this.Hide();
            publicacion.ShowDialog();
            publicacion = (FrmPublicacionCompraInmediata)this.ActiveMdiChild;
        }

        private void bnSubasta_Click(object sender, EventArgs e)
        {
            FrmPublicacionSubasta publicacionSub = new FrmPublicacionSubasta(idUsuario);
            this.Hide();
            publicacionSub.ShowDialog();
            publicacionSub = (FrmPublicacionSubasta)this.ActiveMdiChild;

        }

        private void FrmTipoDePublicacion_Load(object sender, EventArgs e)
        {

        }
    }
}
