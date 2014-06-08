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
            string idPaciente = txtNroCliente.Text.ToString(); ;

            if ((int)new Query("SELECT COUNT(1) FROM PIER.PACIENTES WHERE HABILITADO = 1 AND Paciente_Cod = "
                                + idPaciente).ObtenerUnicoCampo() == 1)
            {
                try
                {
                    string qry = "update PIER.PACIENTES SET HABILITADO = 0  WHERE Paciente_Cod = " + idPaciente;
                    new Query(qry).Ejecutar();
                }
                catch
                {
                    MessageBox.Show("Error al updetear tabla PIER.PACIENTES.", "Error", MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                }

                try
                {
                    string qry = "DELETE FROM PIER.TURNOS WHERE Paciente_Cod = " + idPaciente;
                    new Query(qry).Ejecutar();

                    MessageBox.Show("Paciente eliminado correctamente", "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Visible = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Paciente eliminado correctamente", "Información", MessageBoxButtons.OK,
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
