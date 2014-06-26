namespace FrbaCommerce.Editar_Publicacion
{
    partial class FrmEditarPublicacion
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
            this.dataResultado = new System.Windows.Forms.DataGridView();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.bnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataResultado
            // 
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bnEditar});
            this.dataResultado.Location = new System.Drawing.Point(12, 53);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.Size = new System.Drawing.Size(654, 233);
            this.dataResultado.TabIndex = 4;
            this.dataResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResultado_CellContentClick);
            // 
            // bnBuscar
            // 
            this.bnBuscar.Location = new System.Drawing.Point(432, 325);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bnBuscar.TabIndex = 5;
            this.bnBuscar.Text = "Buscar";
            this.bnBuscar.UseVisualStyleBackColor = true;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // bnVolver
            // 
            this.bnVolver.Location = new System.Drawing.Point(96, 325);
            this.bnVolver.Name = "bnVolver";
            this.bnVolver.Size = new System.Drawing.Size(75, 23);
            this.bnVolver.TabIndex = 6;
            this.bnVolver.Text = "Volver";
            this.bnVolver.UseVisualStyleBackColor = true;
            this.bnVolver.Click += new System.EventHandler(this.bnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione Buscar para Editar una Publicacion ";
            // 
            // bnEditar
            // 
            this.bnEditar.HeaderText = "Editar";
            this.bnEditar.Name = "bnEditar";
            this.bnEditar.Text = "Editar Publicacion";
            this.bnEditar.UseColumnTextForButtonValue = true;
            // 
            // FrmEditarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnVolver);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.dataResultado);
            this.Name = "FrmEditarPublicacion";
            this.Text = "Editar Publicacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.Button bnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn bnEditar;
    }
}