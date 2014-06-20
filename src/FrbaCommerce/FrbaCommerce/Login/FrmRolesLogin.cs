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
    public partial class FrmRolesLogin : Form
    {


        public int idUsuario;

        public FrmRolesLogin(int idUsr)
        {
            InitializeComponent();
            idUsuario = idUsr;
           
            btnIngresar.Enabled = false;
        }

        private void FrmRolesLogin_Load(object sender, EventArgs e)
        {
            cargarRoles();
        }


        public void cargarRoles()
        {
            //string sql = "select r.DETALLE rol, r.idrol idRol from PIER.ROLES r, PIER.USUARIOS_ROLES ur where ur.IDROL = r.IDROL and ur.IDUSUARIO = " + IdUsuario;
            string sql = "SELECT r.ROL_NOMBRE rol FROM JJRD.ROLES r, JJRD.ROL_USUARIO ur where ur.ID_ROL = r.ID_ROL and ur.ID_USUARIO = " + idUsuario;


            Query qry = new Query(sql);
            //qry.Ejecutar();

            foreach (DataRow dataRow in qry.ObtenerDataTable().AsEnumerable())
            {
                comboBox.Items.Add(dataRow[0]);
            }

            //comboBox.DataSource = datos;
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.Text = null;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text != null)
            {
                btnIngresar.Enabled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //SETEO IDROL POR LAS DUDAS, VER SI SE NECESITA PARA DESPUES
            int idRol = (int)new Query("SELECT ID_ROL FROM JJRD.ROLES  " +
                                   " WHERE ROL_NOMBRE = '" + comboBox.SelectedItem.ToString() + "'").ObtenerUnicoCampo();
            Query qr = new Query("SELECT distinct(Nombre) from JJRD.USUARIOS U WHERE ID_USUARIO = " + idUsuario);

            qr.pTipoComando = CommandType.Text;
            string nombreUsuario = qr.ObtenerUnicoCampo().ToString();

            this.Visible = false;
            FrmLogin login = new FrmLogin();
            login.recibirUsuario(idUsuario);

            
           

        }

      

     
    }
}
