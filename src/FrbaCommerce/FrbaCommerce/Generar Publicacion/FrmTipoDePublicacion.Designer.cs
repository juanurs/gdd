namespace FrbaCommerce.Generar_Publicacion
{
    partial class FrmTipoDePublicacion
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
            this.bnCompraInmediata = new System.Windows.Forms.Button();
            this.bnSubasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnCompraInmediata
            // 
            this.bnCompraInmediata.Location = new System.Drawing.Point(67, 44);
            this.bnCompraInmediata.Name = "bnCompraInmediata";
            this.bnCompraInmediata.Size = new System.Drawing.Size(107, 52);
            this.bnCompraInmediata.TabIndex = 0;
            this.bnCompraInmediata.Text = "Compra Inmediata";
            this.bnCompraInmediata.UseVisualStyleBackColor = true;
            this.bnCompraInmediata.Click += new System.EventHandler(this.bnCompraInmediata_Click);
            // 
            // bnSubasta
            // 
            this.bnSubasta.Location = new System.Drawing.Point(67, 120);
            this.bnSubasta.Name = "bnSubasta";
            this.bnSubasta.Size = new System.Drawing.Size(107, 55);
            this.bnSubasta.TabIndex = 1;
            this.bnSubasta.Text = "Subasta";
            this.bnSubasta.UseVisualStyleBackColor = true;
            this.bnSubasta.Click += new System.EventHandler(this.bnSubasta_Click);
            // 
            // FrmTipoDePublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(233, 235);
            this.Controls.Add(this.bnSubasta);
            this.Controls.Add(this.bnCompraInmediata);
            this.Name = "FrmTipoDePublicacion";
            this.Text = "Tipo De Publicacion";
            this.Load += new System.EventHandler(this.FrmTipoDePublicacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnCompraInmediata;
        private System.Windows.Forms.Button bnSubasta;
    }
}