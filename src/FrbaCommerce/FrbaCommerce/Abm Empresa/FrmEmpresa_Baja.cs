using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.FuncionesGenerales;

namespace FrbaCommerce
{
    public partial class FrmEmpresa_Baja : Form
    {
        public FrmEmpresa_Baja(int id_Usr)
        {
            InitializeComponent();
            idUsuario = id_Usr;
        }

        private string qr;
        Funciones fn = new Funciones();
        private int idUsuario; //ID USUARIO LOGUEADO

        private void bnBuscar_Click(object sender, EventArgs e)
        {

            if (!CamposVacios())
            {

                string sql = "SELECT id_usuario, RAZON_SOCIAL as 'Razon social', Cuit, Email FROM JJRD.EMPRESA WHERE ";

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
            dataResultado.Columns["id_usuario"].Visible = false;  //OCULTO LA COLUMNA
            dataResultado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bnDarDeBaja.Enabled = true;
        }

        private void bnVolver_Click(object sender, EventArgs e)
        {
            FrmEmpresa cliente = new FrmEmpresa(idUsuario);
            this.Hide();
            cliente.ShowDialog();
            cliente = (FrmEmpresa)this.ActiveMdiChild;
        }

        private void bnDarDeBaja_Click(object sender, EventArgs e)
        {

            DataGridViewRow fila = dataResultado.SelectedRows[0];

            //IDUSUARIO A DESHABILITAR
            int id_Usr = Convert.ToInt32(fila.Cells["id_usuario"].Value.ToString());


            if (fn.puedeIngresarAlSistema(id_Usr))
            {
                fn.inhabilitarUsuario(id_Usr);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion." + Environment.NewLine + "El usuario ya se encuentra inhabilitado", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmEmpresa_Baja_Load(object sender, EventArgs e)
        {
            this.bnDarDeBaja.Enabled = false;
        }


    }
}