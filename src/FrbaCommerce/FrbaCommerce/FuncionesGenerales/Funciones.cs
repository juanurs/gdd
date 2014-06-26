
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace FrbaCommerce.FuncionesGenerales
{
    class Funciones
    {

        public bool ExisteUsuario(string usuario)
        {
            return ((int)new Query("SELECT COUNT(1) FROM JJRD.USUARIOS WHERE USERNAME ='" + usuario + "'").ObtenerUnicoCampo() == 1);
        }

        public void recibirUsuario(int idUsuario)
        {
            //VER
            string nombreUsuario = new Query("SELECT USERNAME FROM JJRD.USUARIOS WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo().ToString();

            int idRol = (int)new Query("SELECT ID_ROL FROM JJRD.ROL_USUARIO  " +
                          " WHERE ID_USUARIO = " + idUsuario).ObtenerUnicoCampo();

            MessageBox.Show("Bienvenido a Commerce" + Environment.NewLine +
            "Usted se ha registrado como usuario: " + nombreUsuario.ToUpper(), "Bienvenido!",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmPrincipal frmPrincipal = new frmPrincipal(idUsuario);
          //  frmPrincipal.cargarFrmPrincipal(nombreUsuario, idRol, idUsuario);
            frmPrincipal.ShowDialog();

        }

        public void inhabilitarUsuario(int idUsuario)
        {
            new Query("UPDATE JJRD.USUARIOS SET HABILITADO = '0' WHERE ID_USUARIO = " + idUsuario).Ejecutar();
            //TODO - cuando se vuelve a habilitar el usuario se resetea el campo FAIL_LOGIN a 0
            MessageBox.Show("Se ha inhabilitado el usuario.", "Advertencia",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool puedeIngresarAlSistema(int idUsuario) //MOVER A FUNCIONES GENERALES
        {
            return ((int)new Query("SELECT count(1) FROM JJRD.USUARIOS WHERE ID_USUARIO ='" + idUsuario + "' AND HABILITADO = 1").ObtenerUnicoCampo() != 0);
        }

        //VER SI LO USAMOS MAS ADELANTE
        public int ObtenerIdCliente(int idUsuario)
        {
            Query qr = new Query("SELECT ID_CLIENTE FROM JJRD.CLIENTE WHERE ID_USUARIO = " +idUsuario);
            return (int)qr.ObtenerUnicoCampo();
        }



    }


  
}
        