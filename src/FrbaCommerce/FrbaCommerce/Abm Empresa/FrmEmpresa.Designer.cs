namespace FrbaCommerce
{
    partial class FrmEmpresa
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
            this.bnModificar = new System.Windows.Forms.Button();
            this.bnListado = new System.Windows.Forms.Button();
            this.bnAlta = new System.Windows.Forms.Button();
            this.bnBaja = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnModificar
            // 
            this.bnModificar.Location = new System.Drawing.Point(93, 122);
            this.bnModificar.Name = "bnModificar";
            this.bnModificar.Size = new System.Drawing.Size(84, 30);
            this.bnModificar.TabIndex = 2;
            this.bnModificar.Text = "Modificar";
            this.bnModificar.UseVisualStyleBackColor = true;
            // 
            // bnListado
            // 
            this.bnListado.Location = new System.Drawing.Point(94, 86);
            this.bnListado.Name = "bnListado";
            this.bnListado.Size = new System.Drawing.Size(81, 30);
            this.bnListado.TabIndex = 4;
            this.bnListado.Text = "Listado";
            this.bnListado.UseVisualStyleBackColor = true;
            // 
            // bnAlta
            // 
            this.bnAlta.Location = new System.Drawing.Point(93, 15);
            this.bnAlta.Name = "bnAlta";
            this.bnAlta.Size = new System.Drawing.Size(84, 29);
            this.bnAlta.TabIndex = 5;
            this.bnAlta.Text = "Alta";
            this.bnAlta.UseVisualStyleBackColor = true;
            // 
            // bnBaja
            // 
            this.bnBaja.Location = new System.Drawing.Point(93, 50);
            this.bnBaja.Name = "bnBaja";
            this.bnBaja.Size = new System.Drawing.Size(82, 30);
            this.bnBaja.TabIndex = 6;
            this.bnBaja.Text = "Baja";
            this.bnBaja.UseVisualStyleBackColor = true;
            this.bnBaja.Click += new System.EventHandler(this.bnBaja_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(93, 180);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 30);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 222);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.bnBaja);
            this.Controls.Add(this.bnAlta);
            this.Controls.Add(this.bnListado);
            this.Controls.Add(this.bnModificar);
            this.Name = "FrmEmpresa";
            this.Text = "ABM Empresa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnModificar;
        private System.Windows.Forms.Button bnListado;
        private System.Windows.Forms.Button bnAlta;
        private System.Windows.Forms.Button bnBaja;
        private System.Windows.Forms.Button btnVolver;

    }
}