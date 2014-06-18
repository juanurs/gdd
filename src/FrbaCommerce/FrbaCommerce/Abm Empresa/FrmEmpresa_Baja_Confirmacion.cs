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
    public partial class FrmEmpresa_Baja_Confirmacion : Form
    {
        private string r_social;
        public int id_usuario; 
        FrmLogin fn = new FrmLogin(); // ESTO CAMBIARLO A UNA CLASE DE FUNCIONES GENERALES


        public FrmEmpresa_Baja_Confirmacion(string razon_social, string cuit, string email)
        {
            InitializeComponent();
            r_social = razon_social;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            
            id_usuario = (int)new Query("SELECT ID_USUARIO FROM JJRD.EMPRESA WHERE RAZON_SOCIAL='" + r_social + "'").ObtenerUnicoCampo();

            if (fn.puedeIngresarAlSistema(id_usuario))
            {
                fn.inhabilitarUsuario(id_usuario);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion." + Environment.NewLine + "El usuario ya se encuentra inhabilitado", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmEmpresa_Baja_Confirmacion_Load(object sender, EventArgs e)
        {
            lblPregunta.Visible = true;
            lblPregunta.Text = " ¿Desea inhabilitar  a " + r_social.ToUpper() + " ?";
        }
    }
}
