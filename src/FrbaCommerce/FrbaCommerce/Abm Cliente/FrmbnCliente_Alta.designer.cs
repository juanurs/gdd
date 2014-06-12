namespace FrbaCommerce
{
    partial class FrmbnCliente_Alta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bnMail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.bnGuardar = new System.Windows.Forms.Button();
            this.lebel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.bnFecha = new System.Windows.Forms.DateTimePicker();
            this.bnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCod_Postal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNro_Calle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepto = new System.Windows.Forms.Label();
            this.txtDpto = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.Label();
            this.txtNumPiso = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bnNombre_KeyPress);
            // 
            // bnMail
            // 
            this.bnMail.Location = new System.Drawing.Point(108, 105);
            this.bnMail.Name = "bnMail";
            this.bnMail.Size = new System.Drawing.Size(303, 20);
            this.bnMail.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(108, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(303, 20);
            this.txtApellido.TabIndex = 10;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bnApellido_KeyPress);
            // 
            // bnGuardar
            // 
            this.bnGuardar.Location = new System.Drawing.Point(354, 263);
            this.bnGuardar.Name = "bnGuardar";
            this.bnGuardar.Size = new System.Drawing.Size(75, 23);
            this.bnGuardar.TabIndex = 15;
            this.bnGuardar.Text = "Guardar";
            this.bnGuardar.UseVisualStyleBackColor = true;
            this.bnGuardar.Click += new System.EventHandler(this.bnGuardar_Click);
            // 
            // lebel1
            // 
            this.lebel1.AutoSize = true;
            this.lebel1.Location = new System.Drawing.Point(6, 26);
            this.lebel1.Name = "lebel1";
            this.lebel1.Size = new System.Drawing.Size(47, 13);
            this.lebel1.TabIndex = 18;
            this.lebel1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo Doc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "N° Doc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha de Nac:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Telefono:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(108, 75);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(63, 21);
            this.cmbTipoDoc.TabIndex = 34;
            // 
            // bnFecha
            // 
            this.bnFecha.Location = new System.Drawing.Point(108, 210);
            this.bnFecha.Name = "bnFecha";
            this.bnFecha.Size = new System.Drawing.Size(299, 20);
            this.bnFecha.TabIndex = 37;
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.Location = new System.Drawing.Point(12, 263);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bnLimpiar.TabIndex = 42;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.UseVisualStyleBackColor = true;
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCod_Postal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNro_Calle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLocalidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDepto);
            this.groupBox1.Controls.Add(this.txtDpto);
            this.groupBox1.Controls.Add(this.txtPiso);
            this.groupBox1.Controls.Add(this.txtNumPiso);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lebel1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.cmbTipoDoc);
            this.groupBox1.Controls.Add(this.bnFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.bnMail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 245);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // txtCod_Postal
            // 
            this.txtCod_Postal.Location = new System.Drawing.Point(330, 157);
            this.txtCod_Postal.Name = "txtCod_Postal";
            this.txtCod_Postal.Size = new System.Drawing.Size(81, 20);
            this.txtCod_Postal.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "CP:";
            // 
            // txtNro_Calle
            // 
            this.txtNro_Calle.Location = new System.Drawing.Point(246, 184);
            this.txtNro_Calle.Name = "txtNro_Calle";
            this.txtNro_Calle.Size = new System.Drawing.Size(36, 20);
            this.txtNro_Calle.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Altura:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(108, 157);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(186, 20);
            this.txtLocalidad.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Localidad:";
            // 
            // txtDepto
            // 
            this.txtDepto.AutoSize = true;
            this.txtDepto.Location = new System.Drawing.Point(340, 187);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(39, 13);
            this.txtDepto.TabIndex = 51;
            this.txtDepto.Text = "Depto:";
            // 
            // txtDpto
            // 
            this.txtDpto.Location = new System.Drawing.Point(380, 184);
            this.txtDpto.Name = "txtDpto";
            this.txtDpto.Size = new System.Drawing.Size(27, 20);
            this.txtDpto.TabIndex = 50;
            // 
            // txtPiso
            // 
            this.txtPiso.AutoSize = true;
            this.txtPiso.Location = new System.Drawing.Point(282, 187);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(30, 13);
            this.txtPiso.TabIndex = 49;
            this.txtPiso.Text = "Piso:";
            // 
            // txtNumPiso
            // 
            this.txtNumPiso.Location = new System.Drawing.Point(311, 184);
            this.txtNumPiso.Name = "txtNumPiso";
            this.txtNumPiso.Size = new System.Drawing.Size(26, 20);
            this.txtNumPiso.TabIndex = 48;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(108, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(303, 20);
            this.txtTelefono.TabIndex = 47;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(240, 76);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(171, 20);
            this.txtDocumento.TabIndex = 46;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(108, 184);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Dirección:";
            // 
            // FrmbnCliente_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.bnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmbnCliente_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.FrmbnCliente_Alta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox bnMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button bnGuardar;
        private System.Windows.Forms.Label lebel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.DateTimePicker bnFecha;
        private System.Windows.Forms.Button bnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNumPiso;
        private System.Windows.Forms.Label txtPiso;
        private System.Windows.Forms.Label txtDepto;
        private System.Windows.Forms.TextBox txtDpto;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNro_Calle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCod_Postal;
        private System.Windows.Forms.Label label7;
    }
}