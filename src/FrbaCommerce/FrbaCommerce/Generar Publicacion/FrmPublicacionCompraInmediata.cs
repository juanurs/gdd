﻿using System;
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
    public partial class FrmPublicacionCompraInmediata : Form
    {
        SqlConnection conexion = new SqlConnection();

        private int idUsuario;

          public FrmPublicacionCompraInmediata(int id_Usr)
             {

                 idUsuario = id_Usr;
        
            InitializeComponent();
            comboBoxPreguntas.Items.Add("SI");
            comboBoxPreguntas.Items.Add("NO");
    
        }

          
     

        public void FrmPublicacion_Load(object sender, EventArgs e)
        {
                //Llena comboBox Cod_Publicacion

            string codigoPublicacion = "SELECT MAX(COD_PUBLICACION+1) FROM JJRD.PUBLICACION";
            Query qry = new Query(codigoPublicacion);

            decimal idPublicacion = (decimal)qry.ObtenerUnicoCampo();


            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;



            //Llenar comboBoxVisibilidad

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select DESCRIPCION from JJRD.Visibilidad where HABILITADO = 1", conexion);
            da.Fill(ds, "JJRD.Visibilidad");

            comboBoxVisibilidad.DataSource = ds.Tables[0].DefaultView;
            comboBoxVisibilidad.ValueMember = "DESCRIPCION";
            comboBoxVisibilidad.SelectedItem = null;


            //Llenar comboBoxEstado

            string sql = "SELECT DESCRIPCION FROM JJRD.ESTADO_PUBLICACION";


            Query estado = new Query(sql);


            foreach (DataRow dataRow in estado.ObtenerDataTable().AsEnumerable())
            {
                comboBoxEstadoPublicacion.Items.Add(dataRow[0]);
            }


     
            comboBoxCodPublicacion.Items.Add(idPublicacion);
            comboBoxCodPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstadoPublicacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPreguntas.DropDownStyle = ComboBoxStyle.DropDownList;
          
          
            comboBoxVisibilidad.DropDownStyle = ComboBoxStyle.DropDownList;
          
            this.txtFechaInicio.Enabled = false;
        }

       


        private void bnGuardar_Click(object sender, EventArgs e)
        {

           //Controlar que los datos no sean nulos

            if ((comboBoxCodPublicacion.Text != "")&&
                (txtDescripcion.Text.Trim() != "" ) &&  
                (txtStock.Text.Trim() != "" ) &&
                (comboBoxFechaVencimiento.Text != "" ) &&
                (txtPrecio.Text.Trim() != "" ) &&
                (txtDescripcion.Text.Trim() != "" ) &&
                (comboBoxVisibilidad.Text != "" ) &&
               
                (comboBoxEstadoPublicacion.Text != "") &&
               
                (comboBoxPreguntas.Text != ""))

 
            {
                //Busca codigo de visibilidad y se lo guarda
                 
                string visibilidad = "SELECT COD_VISIBILIDAD FROM JJRD.VISIBILIDAD WHERE DESCRIPCION = '" + comboBoxVisibilidad.Text + "'";
                Query qr = new Query(visibilidad);
                
                decimal idVisibilidad = (decimal)qr.ObtenerUnicoCampo();


                //Busca codigo de publicacion y se lo guarda

                string codigoPublicacion = "SELECT MAX(COD_PUBLICACION+1) FROM JJRD.PUBLICACION";
                Query qry = new Query(codigoPublicacion);

                decimal idPublicacion = (decimal)qry.ObtenerUnicoCampo();

                
             
                 //Busca codigo de estado y se lo guarda

                string consultaEstado = "SELECT ID FROM JJRD.ESTADO_PUBLICACION WHERE DESCRIPCION = '" + comboBoxEstadoPublicacion.Text + "'";

                Query qry3 = new Query(consultaEstado);


                int idEstado = (int)qry3.ObtenerUnicoCampo();


                        string generar = "INSERT INTO JJRD.PUBLICACION (COD_PUBLICACION,ID_USUARIO,COD_VISIBILIDAD, DESCRIPCION, STOCK, PRECIO,FECHA_VENCIMIENTO,FECHA_INICIO, ID_ESTADO_PUBLICACION, ID_TIPO_PUBLICACION, PREGUNTAS) " +
                                          "  values ("+idPublicacion+","+idUsuario+","+idVisibilidad+",'"+txtDescripcion.Text+"',"+txtStock.Text+","+txtPrecio.Text+","+comboBoxFechaVencimiento.Text+",'"+txtFechaInicio.Value+"',"+idEstado+",'"+1+"','"+comboBoxPreguntas.Text+"')";

                         Query qry2 = new Query(generar);
                         qry2.Ejecutar();
                         
                  


                         MessageBox.Show("Publicacion Realizada Correctamente" , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                         
                
                //Ir al menu principal


                frmPrincipal publicacion = new frmPrincipal();
                this.Hide();
                publicacion.ShowDialog();
                publicacion = (frmPrincipal)this.ActiveMdiChild;


           
            }else

                    {
                        MessageBox.Show("No se pueden Ingresar Campos Vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

        }

        private void bnVolver_Click(object sender, EventArgs e)
        {

            frmPrincipal cliente = new frmPrincipal();
            this.Hide();
            cliente.ShowDialog();
            cliente = (frmPrincipal)this.ActiveMdiChild;
        

        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {

            comboBoxCodPublicacion.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = "";
            comboBoxFechaVencimiento.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            comboBoxVisibilidad.Text = "";
         
            comboBoxEstadoPublicacion.Text = "";
           
            comboBoxPreguntas.Text = "";
            txtFechaInicio = null;
        }

        private void comboBoxFechaVencimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

       
      
    }
}
