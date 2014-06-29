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
using FrbaCommerce.Calificar_Vendedor;
using FrbaCommerce.Listado_Estadistico;


namespace FrbaCommerce
{
    public partial class frmPrincipal : Form
    {

        private int idUsuario;
        private string nombreUsuario;
        private int idRol;

        public frmPrincipal()
        {
            InitializeComponent();

            idUsuario = Globales.idUsuarioLogueado;

            this.btnRoles.Visible = false;
            this.btnClientes.Visible = false;
            this.btnEmpresa.Visible = false;
            this.btnVisibilidad.Visible = false;
            this.bnGenerarPublicacion.Visible = false;
            this.bnEditarPublicacion.Visible = false;
            this.bnGestionarPreguntas.Visible = false;
            this.bnComprarOfertar.Visible = false;
            this.bnHistorialCliente.Visible = false;
            this.bnCalificarVendedor.Visible = false;
            this.bnFacturar.Visible = false;
            this.bnListadoEstadistico.Visible = false;

            

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

            //MUESTRA EL NOMBRE Y PERFIL DEL USUARIO LOGUEADO
            lblPerfil.Visible = true;
            lblUsuarioLogueado.Text = " Usuario Conectado : " + nombreUsuario.ToUpper();
            lblUsuarioLogueado.Visible = true;
            lblUsuarioLogueado.ForeColor = System.Drawing.Color.Green;
            lblPerfil.Text = " Perfil : " + nombreRol.ToUpper();

            //MUESTRA SOLO LAS FUNCIONALIDADES PERMITIDAS PARA EL ROL LOGUEADO
            Query funcionalidades = new Query("SELECT ID_FUNCIONALIDAD FROM JJRD.ROL_FUNCIONALIDAD WHERE ID_ROL = " + idRol);

            foreach (DataRow dataRow in funcionalidades.ObtenerDataTable().AsEnumerable())
            {
                switch (Convert.ToInt32(dataRow[0]))
                {
                    //ABM ROL
                    case 1: this.btnRoles.Visible = true;
                            break;

                    //ABM CLIENTE
                    case 2: this.btnClientes.Visible = true;
                            break;

                    //ABM EMPRESA
                    case 3: this.btnEmpresa.Visible = true;
                            break;

                    //ABM VISIBILIDAD
                    case 4: this.btnVisibilidad.Visible = true;
                            break;

                    //GENERAR PUBLICACION
                    case 5: this.bnGenerarPublicacion.Visible = true;
                            break;

                    //EDITAR PUBLICACION
                    case 6: this.bnEditarPublicacion.Visible = true;
                            break;

                    //GESTIONAR PREGUNTAS
                    case 7: this.bnGestionarPreguntas.Visible = true;
                            break;

                    //COMPRAR/OFERTAR
                    case 8: this.bnComprarOfertar.Visible = true;
                            break;

                    //HISTORIAL CLIENTE
                    case 9: this.bnHistorialCliente.Visible = true;
                            break;

                    //CALIFICAR AL VENDEDOR
                    case 10: this.bnCalificarVendedor.Visible = true;
                             break;

                    //FACTURAR
                    case 11: this.bnFacturar.Visible = true;
                             break;

                    //LISTADO ESTADISTICO
                    case 12: this.bnListadoEstadistico.Visible = true;
                             break;

                    
                }
            }

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


        private void btnVisibilidad_Click(object sender, EventArgs e)
        {
            FrmVisibilidad visibilidad = new FrmVisibilidad();
            this.Hide();
            visibilidad.ShowDialog();
            visibilidad = (FrmVisibilidad)this.ActiveMdiChild;

        }

        private void bnGestionarPreguntas_Click(object sender, EventArgs e)
        {
            FrmGestionPreguntas gestionPreguntas= new FrmGestionPreguntas();
            this.Hide();
            gestionPreguntas.ShowDialog();
            gestionPreguntas = (FrmGestionPreguntas)this.ActiveMdiChild;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           nombreUsuario = new Query("SELECT USERNAME FROM JJRD.USUARIOS WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo().ToString();


           int IdRolCant = (int)new Query("SELECT count(*) FROM JJRD.ROL_USUARIO  " +
                                           " WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo();

           if (IdRolCant == 1)
           {
               idRol = (int)new Query("SELECT ID_ROL FROM JJRD.ROL_USUARIO WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo();
           }
           else
           {
               idRol = Globales.idRolElegido;
           }

           
         
                

           cargarFrmPrincipal();
        }

        private void bnHistorialCliente_Click(object sender, EventArgs e)
        {
            FrmHistorialCliente historial= new FrmHistorialCliente();
            this.Hide();
            historial.ShowDialog();
            historial = (FrmHistorialCliente)this.ActiveMdiChild;
        }

        private void bnCalificarVendedor_Click(object sender, EventArgs e)
        {
            FrmCalificarVendedor calificar = new FrmCalificarVendedor();
            this.Hide();
            calificar.ShowDialog();
            calificar = (FrmCalificarVendedor)this.ActiveMdiChild;
        }

        private void bnListadoEstadistico_Click(object sender, EventArgs e)
        {
            FrmListadoEstadistico listado = new FrmListadoEstadistico();
            this.Hide();
            listado.ShowDialog();
            listado = (FrmListadoEstadistico)this.ActiveMdiChild;
        }
       

    }
}