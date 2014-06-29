namespace FrbaCommerce.Calificar_Vendedor
{
    partial class FrmCalificarVendedor
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
            this.bnSeleccionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstrellas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.bnVolver = new System.Windows.Forms.Button();
            this.bnCalificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compras sin calificar :";
            // 
            // dataResultado
            // 
            this.dataResultado.AllowUserToAddRows = false;
            this.dataResultado.AllowUserToDeleteRows = false;
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Location = new System.Drawing.Point(12, 29);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.ReadOnly = true;
            this.dataResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataResultado.Size = new System.Drawing.Size(410, 173);
            this.dataResultado.TabIndex = 1;
            this.dataResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResultado_CellContentClick);
            // 
            // bnSeleccionar
            // 
            this.bnSeleccionar.Location = new System.Drawing.Point(347, 208);
            this.bnSeleccionar.Name = "bnSeleccionar";
            this.bnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bnSeleccionar.TabIndex = 2;
            this.bnSeleccionar.Text = "Seleccionar";
            this.bnSeleccionar.UseVisualStyleBackColor = true;
            this.bnSeleccionar.Click += new System.EventHandler(this.bnSeleccionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de estrellas (1 a 5) :";
            // 
            // txtEstrellas
            // 
            this.txtEstrellas.Location = new System.Drawing.Point(159, 240);
            this.txtEstrellas.MaxLength = 1;
            this.txtEstrellas.Name = "txtEstrellas";
            this.txtEstrellas.Size = new System.Drawing.Size(31, 20);
            this.txtEstrellas.TabIndex = 4;
            this.txtEstrellas.TextChanged += new System.EventHandler(this.txtEstrellas_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detalle de la calificación (opcional) :";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(12, 292);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(410, 73);
            this.txtDetalle.TabIndex = 6;
            // 
            // bnVolver
            // 
            this.bnVolver.Location = new System.Drawing.Point(12, 380);
            this.bnVolver.Name = "bnVolver";
            this.bnVolver.Size = new System.Drawing.Size(75, 23);
            this.bnVolver.TabIndex = 7;
            this.bnVolver.Text = "Volver";
            this.bnVolver.UseVisualStyleBackColor = true;
            // 
            // bnCalificar
            // 
            this.bnCalificar.Location = new System.Drawing.Point(347, 380);
            this.bnCalificar.Name = "bnCalificar";
            this.bnCalificar.Size = new System.Drawing.Size(75, 23);
            this.bnCalificar.TabIndex = 8;
            this.bnCalificar.Text = "Calificar";
            this.bnCalificar.UseVisualStyleBackColor = true;
            this.bnCalificar.Click += new System.EventHandler(this.bnCalificar_Click);
            // 
            // FrmCalificarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 415);
            this.Controls.Add(this.bnCalificar);
            this.Controls.Add(this.bnVolver);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstrellas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnSeleccionar);
            this.Controls.Add(this.dataResultado);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalificarVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificar al vendedor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.Button bnSeleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstrellas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button bnVolver;
        private System.Windows.Forms.Button bnCalificar;
    }
}