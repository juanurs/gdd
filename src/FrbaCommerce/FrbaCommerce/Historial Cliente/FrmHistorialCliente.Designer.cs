namespace FrbaCommerce.Historial_Cliente
{
    partial class FrmHistorialCliente
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
            this.dataResultado = new System.Windows.Forms.DataGridView();
            this.bnCompras = new System.Windows.Forms.Button();
            this.bnOfertas = new System.Windows.Forms.Button();
            this.bnCalificacionesOtorgadas = new System.Windows.Forms.Button();
            this.bnCalificacionesRecibidas = new System.Windows.Forms.Button();
            this.bnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione lo que desea hacer";
            // 
            // dataResultado
            // 
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Location = new System.Drawing.Point(12, 58);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.Size = new System.Drawing.Size(367, 221);
            this.dataResultado.TabIndex = 1;
            // 
            // bnCompras
            // 
            this.bnCompras.Location = new System.Drawing.Point(15, 301);
            this.bnCompras.Name = "bnCompras";
            this.bnCompras.Size = new System.Drawing.Size(133, 23);
            this.bnCompras.TabIndex = 2;
            this.bnCompras.Text = "Historial Compras";
            this.bnCompras.UseVisualStyleBackColor = true;
            this.bnCompras.Click += new System.EventHandler(this.bnCompras_Click);
            // 
            // bnOfertas
            // 
            this.bnOfertas.Location = new System.Drawing.Point(211, 301);
            this.bnOfertas.Name = "bnOfertas";
            this.bnOfertas.Size = new System.Drawing.Size(133, 23);
            this.bnOfertas.TabIndex = 3;
            this.bnOfertas.Text = "Historial Ofertas Ganadas";
            this.bnOfertas.UseVisualStyleBackColor = true;
            this.bnOfertas.Click += new System.EventHandler(this.bnOfertas_Click);
            // 
            // bnCalificacionesOtorgadas
            // 
            this.bnCalificacionesOtorgadas.Location = new System.Drawing.Point(15, 341);
            this.bnCalificacionesOtorgadas.Name = "bnCalificacionesOtorgadas";
            this.bnCalificacionesOtorgadas.Size = new System.Drawing.Size(133, 23);
            this.bnCalificacionesOtorgadas.TabIndex = 4;
            this.bnCalificacionesOtorgadas.Text = "Calificaciones Otorgadas";
            this.bnCalificacionesOtorgadas.UseVisualStyleBackColor = true;
            this.bnCalificacionesOtorgadas.Click += new System.EventHandler(this.bnCalificacionesOtorgadas_Click);
            // 
            // bnCalificacionesRecibidas
            // 
            this.bnCalificacionesRecibidas.Location = new System.Drawing.Point(211, 341);
            this.bnCalificacionesRecibidas.Name = "bnCalificacionesRecibidas";
            this.bnCalificacionesRecibidas.Size = new System.Drawing.Size(133, 23);
            this.bnCalificacionesRecibidas.TabIndex = 5;
            this.bnCalificacionesRecibidas.Text = "Calificaciones Recibidas";
            this.bnCalificacionesRecibidas.UseVisualStyleBackColor = true;
            this.bnCalificacionesRecibidas.Click += new System.EventHandler(this.bnCalificacionesRecibidas_Click);
            // 
            // bnVolver
            // 
            this.bnVolver.Location = new System.Drawing.Point(103, 377);
            this.bnVolver.Name = "bnVolver";
            this.bnVolver.Size = new System.Drawing.Size(137, 23);
            this.bnVolver.TabIndex = 6;
            this.bnVolver.Text = "Volver al Menu Principal";
            this.bnVolver.UseVisualStyleBackColor = true;
            this.bnVolver.Click += new System.EventHandler(this.bnVolver_Click);
            // 
            // FrmHistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 465);
            this.Controls.Add(this.bnVolver);
            this.Controls.Add(this.bnCalificacionesRecibidas);
            this.Controls.Add(this.bnCalificacionesOtorgadas);
            this.Controls.Add(this.bnOfertas);
            this.Controls.Add(this.bnCompras);
            this.Controls.Add(this.dataResultado);
            this.Controls.Add(this.label1);
            this.Name = "FrmHistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial del Cliente";
            this.Load += new System.EventHandler(this.FrmHistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.Button bnCompras;
        private System.Windows.Forms.Button bnOfertas;
        private System.Windows.Forms.Button bnCalificacionesOtorgadas;
        private System.Windows.Forms.Button bnCalificacionesRecibidas;
        private System.Windows.Forms.Button bnVolver;
    }
}