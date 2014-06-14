namespace FrbaCommerce
{
    partial class FrmbnCliente_Selec
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cPlan = new System.Windows.Forms.ComboBox();
            this.tMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.lPlan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cPlan);
            this.groupBox1.Controls.Add(this.tMail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.tDireccion);
            this.groupBox1.Controls.Add(this.lPlan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos a modificar";
            // 
            // cPlan
            // 
            this.cPlan.FormattingEnabled = true;
            this.cPlan.Location = new System.Drawing.Point(155, 118);
            this.cPlan.Name = "cPlan";
            this.cPlan.Size = new System.Drawing.Size(170, 21);
            this.cPlan.TabIndex = 8;
            // 
            // tMail
            // 
            this.tMail.Location = new System.Drawing.Point(155, 87);
            this.tMail.Name = "tMail";
            this.tMail.Size = new System.Drawing.Size(170, 20);
            this.tMail.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(155, 58);
            this.txtTelefono.Mask = "99999999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(170, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(155, 27);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(170, 20);
            this.tDireccion.TabIndex = 5;
            // 
            // lPlan
            // 
            this.lPlan.AutoSize = true;
            this.lPlan.Location = new System.Drawing.Point(16, 121);
            this.lPlan.Name = "lPlan";
            this.lPlan.Size = new System.Drawing.Size(28, 13);
            this.lPlan.TabIndex = 4;
            this.lPlan.Text = "Plan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono:";
            // 
            // bnGuardar
            // 
            this.bnGuardar.Location = new System.Drawing.Point(363, 250);
            this.bnGuardar.Name = "bnGuardar";
            this.bnGuardar.Size = new System.Drawing.Size(78, 26);
            this.bnGuardar.TabIndex = 3;
            this.bnGuardar.Text = "Guardar";
            this.bnGuardar.UseVisualStyleBackColor = true;
            this.bnGuardar.Click += new System.EventHandler(this.bnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "N° de Cliente";
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.SystemColors.Info;
            this.tId.Location = new System.Drawing.Point(117, 50);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(106, 20);
            this.tId.TabIndex = 5;
            // 
            // FrmbnCliente_Selec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 286);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmbnCliente_Selec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Seleccionado";
            this.Load += new System.EventHandler(this.FrmbnCliente_Selec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.ComboBox cPlan;
        private System.Windows.Forms.TextBox tMail;
        private System.Windows.Forms.Button bnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tId;

    }
}