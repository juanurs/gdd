using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Login;

namespace FrbaCommerce
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();


            lblUsuarioLogueado.Visible = false;
            lblPerfil.Visible = false;

        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmbnRoles rol = new FrmbnRoles();
            rol.ShowDialog();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            login = (FrmLogin)this.ActiveMdiChild;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void cargarFrmPrincipal(string nombreUsuario, int idRol, int idUsuario)
        {
            //ACA ADENTRO CARGAR TODO PARA EL FRMPRINCIPAL
            //Query qr = new Query("SELECT distinct(Nombre) from JJRD.USUARIOS U WHERE ID_USUARIO = " + idUsuario);

            //qr.pTipoComando = CommandType.Text;
            //string nombreUsuario = qr.ObtenerUnicoCampo().ToString();

            Query qr = new Query(" SELECT ROL_NOMBRE FROM JJRD.ROLES WHERE ID_ROL = " + idRol);
            qr.pTipoComando = CommandType.Text;
            string nombreRol = qr.ObtenerUnicoCampo().ToString();

            
            lblPerfil.Visible = true;
            lblUsuarioLogueado.Text = " Usuario Conectado : " + nombreUsuario.ToUpper();
            lblUsuarioLogueado.Visible = true;
            lblUsuarioLogueado.ForeColor = System.Drawing.Color.Green;
            lblPerfil.Text = " Perfil : " + nombreRol.ToUpper();

        }

       

    }
}