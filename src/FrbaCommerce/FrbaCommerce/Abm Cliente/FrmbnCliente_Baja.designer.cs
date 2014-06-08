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
            this.label1 = new System.Windows.Forms.Label();
            this.bnEliminar = new System.Windows.Forms.Button();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar n° del Cliente";
            // 
            // bnEliminar
            // 
            this.bnEliminar.Location = new System.Drawing.Point(154, 49);
            this.bnEliminar.Name = "bnEliminar";
            this.bnEliminar.Size = new System.Drawing.Size(75, 23);
            this.bnEliminar.TabIndex = 3;
            this.bnEliminar.TabStop = false;
            this.bnEliminar.Text = "Eliminar";
            this.bnEliminar.UseVisualStyleBackColor = true;
            this.bnEliminar.Click += new System.EventHandler(this.bnEliminar_Click);
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(129, 11);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNroCliente.TabIndex = 6;
            this.txtNroCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroCliente_KeyPress);
            // 
            // FrmbnCliente_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 83);
            this.Controls.Add(this.txtNroCliente);
            this.Controls.Add(this.bnEliminar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmbnCliente_Baja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnEliminar;
        private System.Windows.Forms.TextBox txtNroCliente;
    }
}