namespace FrbaCommerce
{
    partial class FrmbnRoles
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
            this.bnAltaRoles = new System.Windows.Forms.Button();
            this.bnConsultaRoles = new System.Windows.Forms.Button();
            this.bnModRoles = new System.Windows.Forms.Button();
            this.bnBajaRoles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnAltaRoles
            // 
            this.bnAltaRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAltaRoles.Location = new System.Drawing.Point(150, 12);
            this.bnAltaRoles.Name = "bnAltaRoles";
            this.bnAltaRoles.Size = new System.Drawing.Size(115, 55);
            this.bnAltaRoles.TabIndex = 0;
            this.bnAltaRoles.Text = "Alta";
            this.bnAltaRoles.UseVisualStyleBackColor = true;
            this.bnAltaRoles.Click += new System.EventHandler(this.bnAlta_Click);
            // 
            // bnConsultaRoles
            // 
            this.bnConsultaRoles.Location = new System.Drawing.Point(12, 12);
            this.bnConsultaRoles.Name = "bnConsultaRoles";
            this.bnConsultaRoles.Size = new System.Drawing.Size(115, 56);
            this.bnConsultaRoles.TabIndex = 1;
            this.bnConsultaRoles.Text = "Listado";
            this.bnConsultaRoles.UseVisualStyleBackColor = true;
            this.bnConsultaRoles.Click += new System.EventHandler(this.bnConsultaRoles_Click);
            // 
            // bnModRoles
            // 
            this.bnModRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnModRoles.Location = new System.Drawing.Point(150, 87);
            this.bnModRoles.Name = "bnModRoles";
            this.bnModRoles.Size = new System.Drawing.Size(115, 55);
            this.bnModRoles.TabIndex = 2;
            this.bnModRoles.Text = "Modificación";
            this.bnModRoles.UseVisualStyleBackColor = true;
            this.bnModRoles.Click += new System.EventHandler(this.bnModRoles_Click);
            // 
            // bnBajaRoles
            // 
            this.bnBajaRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnBajaRoles.Location = new System.Drawing.Point(12, 87);
            this.bnBajaRoles.Name = "bnBajaRoles";
            this.bnBajaRoles.Size = new System.Drawing.Size(115, 56);
            this.bnBajaRoles.TabIndex = 4;
            this.bnBajaRoles.Text = "Baja";
            this.bnBajaRoles.UseVisualStyleBackColor = true;
            this.bnBajaRoles.Click += new System.EventHandler(this.bnBajaRoles_Click);
            // 
            // FrmbnRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(277, 164);
            this.Controls.Add(this.bnBajaRoles);
            this.Controls.Add(this.bnModRoles);
            this.Controls.Add(this.bnConsultaRoles);
            this.Controls.Add(this.bnAltaRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmbnRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Roles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnAltaRoles;
        private System.Windows.Forms.Button bnConsultaRoles;
        private System.Windows.Forms.Button bnModRoles;
        private System.Windows.Forms.Button bnBajaRoles;
    }
}