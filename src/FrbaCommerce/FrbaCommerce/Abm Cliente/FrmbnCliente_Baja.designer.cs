namespace FrbaCommerce
{
    partial class FrmbnCliente_Baja
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
            this.bnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.labellll = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dataResultado = new System.Windows.Forms.DataGridView();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.bnMenuPrincipal = new System.Windows.Forms.Button();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // bnEliminar
            // 
            this.bnEliminar.Location = new System.Drawing.Point(331, 348);
            this.bnEliminar.Name = "bnEliminar";
            this.bnEliminar.Size = new System.Drawing.Size(75, 23);
            this.bnEliminar.TabIndex = 3;
            this.bnEliminar.TabStop = false;
            this.bnEliminar.Text = "Eliminar";
            this.bnEliminar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº de Doc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Doc";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(86, 34);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(306, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(86, 61);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(50, 21);
            this.comboBoxTipoDoc.TabIndex = 13;
            this.comboBoxTipoDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDoc_SelectedIndexChanged);
            // 
            // labellll
            // 
            this.labellll.AutoSize = true;
            this.labellll.Location = new System.Drawing.Point(12, 90);
            this.labellll.Name = "labellll";
            this.labellll.Size = new System.Drawing.Size(32, 13);
            this.labellll.TabIndex = 16;
            this.labellll.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // dataResultado
            // 
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Location = new System.Drawing.Point(12, 133);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.Size = new System.Drawing.Size(543, 150);
            this.dataResultado.TabIndex = 18;
            // 
            // bnBuscar
            // 
            this.bnBuscar.Location = new System.Drawing.Point(228, 348);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bnBuscar.TabIndex = 19;
            this.bnBuscar.Text = "Buscar";
            this.bnBuscar.UseVisualStyleBackColor = true;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // bnMenuPrincipal
            // 
            this.bnMenuPrincipal.Location = new System.Drawing.Point(109, 348);
            this.bnMenuPrincipal.Name = "bnMenuPrincipal";
            this.bnMenuPrincipal.Size = new System.Drawing.Size(88, 23);
            this.bnMenuPrincipal.TabIndex = 20;
            this.bnMenuPrincipal.Text = "Menu Principal";
            this.bnMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(203, 60);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(189, 20);
            this.txtNumeroDoc.TabIndex = 14;
            // 
            // FrmbnCliente_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 423);
            this.Controls.Add(this.bnMenuPrincipal);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.dataResultado);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labellll);
            this.Controls.Add(this.txtNumeroDoc);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmbnCliente_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Cliente";
            this.Load += new System.EventHandler(this.FrmbnCliente_Baja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.Label labellll;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.Button bnMenuPrincipal;
        private System.Windows.Forms.TextBox txtNumeroDoc;
    }
}