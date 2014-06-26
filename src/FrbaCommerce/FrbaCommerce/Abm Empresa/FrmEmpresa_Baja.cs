using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using FrbaCommerce.Login; //ELIMINAR DESPUES DE MOVER A FUNC GENERALES

namespace FrbaCommerce
{
    public partial class FrmEmpresa_Baja : Form
    {
        public FrmEmpresa_Baja()
        {
            InitializeComponent();
        }

        private string qr;


        private void bnBuscar_Click(object sender, EventArgs e)
        {
            //PARA QUE? BORRAR
            int idUsuario = (int)new Query("SELECT ID_USUARIO FROM JJRD.EMPRESA WHERE RAZON_SOCIAL LIKE '%" + txtRazonSocial.Text + "%'").ObtenerUnicoCampo();

            if (!CamposVacios())
            {

                string sql = "SELECT RAZON_SOCIAL, CUIT, EMAIL FROM JJRD.EMPRESA WHERE ";

                if (txtRazonSocial.Text == "" && txtCuit.Text == "" && txtMail.Text != "" || txtRazonSocial.Text == "" && txtMail.Text == "" && txtCuit.Text != "" || txtMail.Text == "" && txtCuit.Text == "" && txtRazonSocial.Text != "")
                {
                    qr = buscarPorUnCampo(sql);
                }
                else
                {
                    //POR DOS CAMPOS

                    if (txtRazonSocial.Text == "" && txtCuit.Text != "" && txtMail.Text != "" || txtRazonSocial.Text != "" && txtMail.Text == "" && txtCuit.Text != "" || txtMail.Text != "" && txtCuit.Text == "" && txtRazonSocial.Text != "")
                    {
                       qr = buscarPorDosCampos(sql);
                    }
                    else
                    {
                        //POR TRES CAMPOS
                       qr = buscarPorTresCampos(sql);
                    }
                }

                mostrarResultadoDataGrid(qr);

            }
            else
            {
                    MessageBox.Show("Debe ingresar al menos un filtro de busqueda.",
                                       "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }

        }

        private string buscarPorUnCampo(string sql)
        {
                if (txtRazonSocial.Text.Trim() != "")
                {
                    sql = sql + " RAZON_SOCIAL LIKE '%" + txtRazonSocial.Text + "%' ";
                }

                if (txtCuit.Text.Trim() != "")
                {
                    sql = sql + " CUIT LIKE '%" + txtCuit.Text + "%' ";
                }

                if (txtMail.Text.Trim() != "")
                {
                    sql = sql + " EMAIL = '" + txtMail.Text + "'";
                }

                return sql;
        }

        private bool CamposVacios()
        {
            
            return (txtRazonSocial.Text == "" && txtCuit.Text == "" && txtMail.Text == "");
           
        }

        private string buscarPorDosCampos(string sql)
        {
            if (txtMail.Text.Trim() == "")
            {
                //RAZON SOCIAL Y CUIT
                sql = sql + " RAZON_SOCIAL LIKE '%" + txtRazonSocial.Text + "%' AND CUIT LIKE '%" + txtCuit.Text + "%' ";
            }

            if (txtCuit.Text.Trim() == "")
            {
                //RAZON SOCIAL Y MAIL
                sql = sql + " RAZON_SOCIAL LIKE '%" + txtRazonSocial.Text + "%' AND EMAIL = '" + txtMail.Text + "'";
            }

            if (txtRazonSocial.Text.Trim() == "")
            {
                //MAIL Y CUIT
                sql = sql + " EMAIL = '" + txtMail.Text + "' AND CUIT LIKE '%" + txtCuit.Text + "%' ";
            }

            return sql;

        }

        private string buscarPorTresCampos(string sql)
        {
            sql = sql + " RAZON_SOCIAL LIKE '%" + txtRazonSocial.Text + "%' AND CUIT LIKE '%" + txtCuit.Text + "%' AND EMAIL = '" + txtMail.Text + "'";
            return sql;
        }

        private void mostrarResultadoDataGrid(string qr)
        {
            Query resultado = new Query(qr);
            dataResultado.DataSource = resultado.ObtenerDataTable();
            dataResultado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmEmpresa_Baja_Confirmacion frm = new FrmEmpresa_Baja_Confirmacion(dataResultado.Rows[e.RowIndex].Cells["Razon_Social"].Value.ToString(),
               dataResultado.Rows[e.RowIndex].Cells["Cuit"].Value.ToString(),
               dataResultado.Rows[e.RowIndex].Cells["Email"].Value.ToString());
            frm.ShowDialog();
            this.Visible = false;
        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            FrmEmpresa cliente = new FrmEmpresa();
            this.Hide();
            cliente.ShowDialog();
            cliente = (FrmEmpresa)this.ActiveMdiChild;
        }


    }
}