using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Login;
using FrbaCommerce.Generar_Publicacion;
using FrbaCommerce.Editar_Publicacion;

namespace FrbaCommerce
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();


            lblUsuarioLogueado.Visible = false;
            lblPerfil.Visible = false;
            bnGenerarPublicacion.Visible = false;
            bnEditarPublicacion.Visible = false;
          
           /* DESPUES TERMINO ESTA PARTE
            btnRoles.Visible = false;
            btnClientes.Visible = false;
            btnEmpresa.Visible = false;
            btnRubro.Visible = false;
            btnVisibilidad.Visible = false;
           */

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

            Query qr = new Query(" SELECT ROL_NOMBRE FROM JJRD.ROLES WHERE ID_ROL = " + idRol);
            qr.pTipoComando = CommandType.Text;
            string nombreRol = qr.ObtenerUnicoCampo().ToString();

            
            lblPerfil.Visible = true;
            lblUsuarioLogueado.Text = " Usuario Conectado : " + nombreUsuario.ToUpper();
            lblUsuarioLogueado.Visible = true;
            lblUsuarioLogueado.ForeColor = System.Drawing.Color.Green;
            lblPerfil.Text = " Perfil : " + nombreRol.ToUpper();

            btnLogin.Visible = false;
            bnGenerarPublicacion.Visible = true;
            bnEditarPublicacion.Visible = true;

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmbnCliente cliente = new FrmbnCliente();
            this.Hide();
            cliente.ShowDialog();
            cliente = (FrmbnCliente)this.ActiveMdiChild;
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresa cliente = new FrmEmpresa();
            this.Hide();
            cliente.ShowDialog();
            cliente = (FrmEmpresa)this.ActiveMdiChild;
        }

        private void bnGenerarPublicacion_Click(object sender, EventArgs e)
        {
            FrmTipoDePublicacion publicacion = new FrmTipoDePublicacion();
            this.Hide();
            publicacion.ShowDialog();
            publicacion = (FrmTipoDePublicacion)this.ActiveMdiChild;

        }

        private void bnEditarPublicacion_Click(object sender, EventArgs e)
        {
            FrmEditarPublicacion editar = new FrmEditarPublicacion();
            this.Hide();
            editar.ShowDialog();
            editar = (FrmEditarPublicacion)this.ActiveMdiChild;
        }

     
       

    }
}