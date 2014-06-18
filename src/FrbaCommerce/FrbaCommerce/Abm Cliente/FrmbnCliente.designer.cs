namespace FrbaCommerce
{
    partial class FrmbnCliente
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
            this.bnConsCliente = new System.Windows.Forms.Button();
            this.bnModCliente = new System.Windows.Forms.Button();
            this.bnBajaCliente = new System.Windows.Forms.Button();
            this.bnAltaCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
           
            // 
            // bnModCliente
            // 
            this.bnModCliente.Location = new System.Drawing.Point(150, 87);
            this.bnModCliente.Name = "bnModCliente";
            this.bnModCliente.Size = new System.Drawing.Size(117, 56);
            this.bnModCliente.TabIndex = 1;
            this.bnModCliente.Text = "Modificación";
            this.bnModCliente.UseVisualStyleBackColor = true;
            this.bnModCliente.Click += new System.EventHandler(this.bnModCliente_Click);
            // 
            // bnBajaCliente
            // 
            this.bnBajaCliente.Location = new System.Drawing.Point(12, 87);
            this.bnBajaCliente.Name = "bnBajaCliente";
            this.bnBajaCliente.Size = new System.Drawing.Size(115, 56);
            this.bnBajaCliente.TabIndex = 2;
            this.bnBajaCliente.Text = "Baja";
            this.bnBajaCliente.UseVisualStyleBackColor = true;
            this.bnBajaCliente.Click += new System.EventHandler(this.bnBajaCliente_Click);
            // 
            // bnAltaCliente
            // 
            this.bnAltaCliente.Location = new System.Drawing.Point(150, 12);
            this.bnAltaCliente.Name = "bnAltaCliente";
            this.bnAltaCliente.Size = new System.Drawing.Size(117, 56);
            this.bnAltaCliente.TabIndex = 3;
            this.bnAltaCliente.Text = "Alta";
            this.bnAltaCliente.UseVisualStyleBackColor = true;
            this.bnAltaCliente.Click += new System.EventHandler(this.bnAltaCliente_Click);
            // 
            // FrmbnCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 164);
            this.Controls.Add(this.bnAltaCliente);
            this.Controls.Add(this.bnBajaCliente);
            this.Controls.Add(this.bnModCliente);
            this.Controls.Add(this.bnConsCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmbnCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.FrmbnCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnConsCliente;
        private System.Windows.Forms.Button bnModCliente;
        private System.Windows.Forms.Button bnBajaCliente;
        private System.Windows.Forms.Button bnAltaCliente;
    }
}