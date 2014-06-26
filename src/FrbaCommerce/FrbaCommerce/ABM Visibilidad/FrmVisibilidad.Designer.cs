namespace FrbaCommerce
{
    partial class FrmVisibilidad
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
            this.bnAltaVisibilidad = new System.Windows.Forms.Button();
            this.bnConsultaVisibilidad = new System.Windows.Forms.Button();
            this.bnModVisibilidad = new System.Windows.Forms.Button();
            this.bnBajaVisibilidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnAltaVisibilidad
            // 
            this.bnAltaVisibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAltaVisibilidad.Location = new System.Drawing.Point(150, 12);
            this.bnAltaVisibilidad.Name = "bnAltaVisibilidad";
            this.bnAltaVisibilidad.Size = new System.Drawing.Size(115, 55);
            this.bnAltaVisibilidad.TabIndex = 0;
            this.bnAltaVisibilidad.Text = "Alta";
            this.bnAltaVisibilidad.UseVisualStyleBackColor = true;
            this.bnAltaVisibilidad.Click += new System.EventHandler(this.bnAlta_Click);
            // 
            // bnConsultaVisibilidad
            // 
            this.bnConsultaVisibilidad.Location = new System.Drawing.Point(12, 12);
            this.bnConsultaVisibilidad.Name = "bnConsultaVisibilidad";
            this.bnConsultaVisibilidad.Size = new System.Drawing.Size(115, 56);
            this.bnConsultaVisibilidad.TabIndex = 1;
            this.bnConsultaVisibilidad.Text = "Listado";
            this.bnConsultaVisibilidad.UseVisualStyleBackColor = true;
            this.bnConsultaVisibilidad.Click += new System.EventHandler(this.bnConsultaVisibilidad_Click);
            // 
            // bnModVisibilidad
            // 
            this.bnModVisibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnModVisibilidad.Location = new System.Drawing.Point(150, 87);
            this.bnModVisibilidad.Name = "bnModVisibilidad";
            this.bnModVisibilidad.Size = new System.Drawing.Size(115, 55);
            this.bnModVisibilidad.TabIndex = 2;
            this.bnModVisibilidad.Text = "Modificación";
            this.bnModVisibilidad.UseVisualStyleBackColor = true;
            this.bnModVisibilidad.Click += new System.EventHandler(this.bnModVisibilidad_Click);
            // 
            // bnBajaVisibilidad
            // 
            this.bnBajaVisibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnBajaVisibilidad.Location = new System.Drawing.Point(12, 87);
            this.bnBajaVisibilidad.Name = "bnBajaVisibilidad";
            this.bnBajaVisibilidad.Size = new System.Drawing.Size(115, 56);
            this.bnBajaVisibilidad.TabIndex = 4;
            this.bnBajaVisibilidad.Text = "Baja";
            this.bnBajaVisibilidad.UseVisualStyleBackColor = true;
            this.bnBajaVisibilidad.Click += new System.EventHandler(this.bnBajaVisibilidad_Click);
            // 
            // FrmbnVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 164);
            this.Controls.Add(this.bnBajaVisibilidad);
            this.Controls.Add(this.bnModVisibilidad);
            this.Controls.Add(this.bnConsultaVisibilidad);
            this.Controls.Add(this.bnAltaVisibilidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmbnVisibilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Visibilidad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnAltaVisibilidad;
        private System.Windows.Forms.Button bnConsultaVisibilidad;
        private System.Windows.Forms.Button bnModVisibilidad;
        private System.Windows.Forms.Button bnBajaVisibilidad;
    }
}