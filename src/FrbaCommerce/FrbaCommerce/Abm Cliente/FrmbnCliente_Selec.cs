using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaCommerce
{
    public partial class FrmbnCliente_Selec : Form
    {
        public string codigo;

        public FrmbnCliente_Selec(string Cliente_Cod, string Cliente_Nombre, string Cliente_Apellido)
        {
            InitializeComponent();
            label1.Text = Cliente_Nombre + " " + Cliente_Apellido;
            cargarDatosCliente(Cliente_Cod);
        }

        private void FrmbnCliente_Selec_Load(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarDatosCliente(string codigo)
        {
            tId.Text = codigo;

            string Cliente_Direccion = "select Cliente_Direccion from PIER.ClienteS where Cliente_Cod =" + codigo;
            Query qry = new Query(Cliente_Direccion);
            qry.pComando = Cliente_Direccion;
            tDireccion.Text = qry.ObtenerUnicoCampo().ToString();

            string Cliente_Telefono = "select Cliente_Telefono from PIER.ClienteS where Cliente_Cod =" + codigo;
            Query qry2 = new Query(Cliente_Telefono);
            qry2.pComando = Cliente_Telefono;
            txtTelefono.Text = qry2.ObtenerUnicoCampo().ToString();

            string Cliente_Mail = "select Cliente_Mail from PIER.ClienteS where Cliente_Cod =" + codigo;
            Query qry3 = new Query(Cliente_Mail);
            qry3.pComando = Cliente_Mail;
            tMail.Text = qry3.ObtenerUnicoCampo().ToString();

            LlenarComboPlan(codigo);
        }

        private void LlenarComboPlan(string codigo)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select Plan_Med_Descripcion from PIER.PLANES", conexion);
            da.Fill(ds, "PIER.PLANES");

            cPlan.DataSource = ds.Tables[0].DefaultView;
            cPlan.ValueMember = "Plan_Med_Descripcion";

            string Cliente_Plan = "select Plan_Med_Codigo from PIER.ClienteS where Cliente_Cod =" + codigo;
            Query qry = new Query(Cliente_Plan);
            qry.pComando = Cliente_Plan;
            int plan = Convert.ToInt32(qry.ObtenerUnicoCampo());
            cPlan.SelectedIndex = plan - 555555;
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            string UpdPac = "PIER.UpdateCliente";

            int IdPlan = (int)new Query("select Plan_Med_Codigo from PIER.PLANES where Plan_Med_Descripcion = '" + cPlan.Text + "'").ObtenerUnicoCampo();

            Query qr = new Query(UpdPac);

            qr.pTipoComando = CommandType.StoredProcedure;
            SqlParameter parametro1 = new SqlParameter("@direccion", SqlDbType.NVarChar);
            parametro1.Value = tDireccion.Text;
            SqlParameter parametro2 = new SqlParameter("@telefono", SqlDbType.Int);
            parametro2.Value = txtTelefono.Text;
            SqlParameter parametro3 = new SqlParameter("@mail", SqlDbType.NVarChar);
            parametro3.Value = tMail.Text;
            SqlParameter parametro4 = new SqlParameter("@plan", SqlDbType.Int);
            parametro4.Value = IdPlan;
            SqlParameter parametro5 = new SqlParameter("@codigp", SqlDbType.Int);
            parametro5.Value = tId.Text;
            qr.pParametros.Add(parametro1);
            qr.pParametros.Add(parametro2);
            qr.pParametros.Add(parametro3);
            qr.pParametros.Add(parametro4);
            qr.pParametros.Add(parametro5);

            qr.Ejecutar();


            MessageBox.Show("Los cambios se han realizado correctamente.", "Información", MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            this.Visible = false;
        }
    }
}
