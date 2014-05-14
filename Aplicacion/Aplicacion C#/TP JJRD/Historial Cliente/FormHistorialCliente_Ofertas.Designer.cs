namespace TP_JJRD.Historial_Cliente
{
    partial class form
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
            this.combo = new System.Windows.Forms.ComboBox();
            this.Ofertas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(113, 35);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(142, 21);
            this.combo.TabIndex = 1;
            // 
            // Ofertas
            // 
            this.Ofertas.FormattingEnabled = true;
            this.Ofertas.Location = new System.Drawing.Point(16, 75);
            this.Ofertas.Name = "Ofertas";
            this.Ofertas.Size = new System.Drawing.Size(239, 173);
            this.Ofertas.TabIndex = 2;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Ofertas);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.label1);
            this.Name = "form";
            this.Text = "Ofertas Realizadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.ListBox Ofertas;
    }
}