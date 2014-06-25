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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodPublicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEstadoPublicacion = new System.Windows.Forms.ComboBox();
            this.dataResultado = new System.Windows.Forms.DataGridView();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.bnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Publicacion";
            // 
            // txtCodPublicacion
            // 
            this.txtCodPublicacion.Location = new System.Drawing.Point(161, 25);
            this.txtCodPublicacion.Name = "txtCodPublicacion";
            this.txtCodPublicacion.Size = new System.Drawing.Size(122, 20);
            this.txtCodPublicacion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado de Publicacion";
            // 
            // comboBoxEstadoPublicacion
            // 
            this.comboBoxEstadoPublicacion.FormattingEnabled = true;
            this.comboBoxEstadoPublicacion.Location = new System.Drawing.Point(449, 24);
            this.comboBoxEstadoPublicacion.Name = "comboBoxEstadoPublicacion";
            this.comboBoxEstadoPublicacion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstadoPublicacion.TabIndex = 3;
            // 
            // dataResultado
            // 
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Location = new System.Drawing.Point(12, 71);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.Size = new System.Drawing.Size(609, 150);
            this.dataResultado.TabIndex = 4;
            // 
            // bnBuscar
            // 
            this.bnBuscar.Location = new System.Drawing.Point(368, 251);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bnBuscar.TabIndex = 5;
            this.bnBuscar.Text = "Buscar";
            this.bnBuscar.UseVisualStyleBackColor = true;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // bnVolver
            // 
            this.bnVolver.Location = new System.Drawing.Point(161, 251);
            this.bnVolver.Name = "bnVolver";
            this.bnVolver.Size = new System.Drawing.Size(75, 23);
            this.bnVolver.TabIndex = 6;
            this.bnVolver.Text = "Volver";
            this.bnVolver.UseVisualStyleBackColor = true;
            // 
            // FrmEditarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 374);
            this.Controls.Add(this.bnVolver);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.dataResultado);
            this.Controls.Add(this.comboBoxEstadoPublicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodPublicacion);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarPublicacion";
            this.Text = "Editar Publicacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodPublicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEstadoPublicacion;
        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.Button bnVolver;
    }
}