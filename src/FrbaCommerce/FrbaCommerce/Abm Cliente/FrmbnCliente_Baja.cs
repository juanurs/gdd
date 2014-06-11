using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class FrmbnCliente_Baja : Form
    {
        public FrmbnCliente_Baja()
        {
            InitializeComponent();
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            string idCliente = txtNroCliente.Text.ToString(); ;

            if ((int)new Query("SELECT COUNT(1) FROM PIER.ClienteS WHERE HABILITADO = 1 AND Cliente_Cod = "
                                + idCliente).ObtenerUnicoCampo() == 1)
            {
                try
                {
                    string qry = "update PIER.ClienteS SET HABILITADO = 0  WHERE Cliente_Cod = " + idCliente;
                    new Query(qry).Ejecutar();
                }
                catch
                {
                    MessageBox.Show("Error al updetear tabla PIER.ClienteS.", "Error", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                }

                try
                {
                    string qry = "DELETE FROM PIER.TURNOS WHERE Cliente_Cod = " + idCliente;
                    new Query(qry).Ejecutar();

                    MessageBox.Show("Cliente eliminado correctamente", "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Visible = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Cliente eliminado correctamente", "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No existe numero de Cliente.", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
