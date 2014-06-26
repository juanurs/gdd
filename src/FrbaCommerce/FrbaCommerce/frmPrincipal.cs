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
using FrbaCommerce.Gestion_de_Preguntas;
using FrbaCommerce.Historial_Cliente;

namespace FrbaCommerce
{
    public partial class frmPrincipal : Form
    {

        private int idUsuario;
        private string nombreUsuario;
        private int idRol;

        public frmPrincipal(int id_Usr)
        {
            InitializeComponent();

            idUsuario = id_Usr;

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void cargarFrmPrincipal()
        {
            //ACA ADENTRO CARGAR TODO PARA EL FRMPRINCIPAL
            //idUsuario = id_Usr;


            Query qr = new Query(" SELECT ROL_NOMBRE FROM JJRD.ROLES WHERE ID_ROL = " + idRol);
            qr.pTipoComando = CommandType.Text;
            string nombreRol = qr.ObtenerUnicoCampo().ToString();

            
            lblPerfil.Visible = true;
            lblUsuarioLogueado.Text = " Usuario Conectado : " + nombreUsuario.ToUpper();
            lblUsuarioLogueado.Visible = true;
            lblUsuarioLogueado.ForeColor = System.Drawing.Color.Green;
            lblPerfil.Text = " Perfil : " + nombreRol.ToUpper();

            
            bnGenerarPublicacion.Visible = true;
            bnEditarPublicacion.Visible = true;

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmbnCliente cliente = new FrmbnCliente(idUsuario);
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
            FrmTipoDePublicacion publicacion = new FrmTipoDePublicacion(idUsuario);
            this.Hide();
            publicacion.ShowDialog();
            publicacion = (FrmTipoDePublicacion)this.ActiveMdiChild;

        }

        private void bnEditarPublicacion_Click(object sender, EventArgs e)
        {
            FrmEditarPublicacion editar = new FrmEditarPublicacion(idUsuario);
            this.Hide();
            editar.ShowDialog();
            editar = (FrmEditarPublicacion)this.ActiveMdiChild;
        }


        private void btnVisibilidad_Click(object sender, EventArgs e)
        {
            FrmVisibilidad visibilidad = new FrmVisibilidad();
            this.Hide();
            visibilidad.ShowDialog();
            visibilidad = (FrmVisibilidad)this.ActiveMdiChild;

        }

        private void bnGestionarPreguntas_Click(object sender, EventArgs e)
        {
            FrmGestionPreguntas gestionPreguntas= new FrmGestionPreguntas(idUsuario);
            this.Hide();
            gestionPreguntas.ShowDialog();
            gestionPreguntas = (FrmGestionPreguntas)this.ActiveMdiChild;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           nombreUsuario = new Query("SELECT USERNAME FROM JJRD.USUARIOS WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo().ToString();

           idRol = (int)new Query("SELECT ID_ROL FROM JJRD.ROL_USUARIO WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo();

           cargarFrmPrincipal();
        }

        private void bnHistorialCliente_Click(object sender, EventArgs e)
        {
            FrmHistorialCliente historial= new FrmHistorialCliente(idUsuario);
            this.Hide();
            historial.ShowDialog();
            historial = (FrmHistorialCliente)this.ActiveMdiChild;
        }
       

    }
}