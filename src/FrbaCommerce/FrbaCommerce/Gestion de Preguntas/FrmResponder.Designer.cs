namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class FrmResponder
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bnResponder = new System.Windows.Forms.Button();
            this.bnVolver = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescripcionPublicacion = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(141, 9);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(236, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Publicación :";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(58, 382);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(319, 152);
            this.txtRespuesta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Respuesta :";
            // 
            // bnResponder
            // 
            this.bnResponder.Location = new System.Drawing.Point(302, 564);
            this.bnResponder.Name = "bnResponder";
            this.bnResponder.Size = new System.Drawing.Size(75, 23);
            this.bnResponder.TabIndex = 5;
            this.bnResponder.Text = "Responder";
            this.bnResponder.UseVisualStyleBackColor = true;
            this.bnResponder.Click += new System.EventHandler(this.bnResponder_Click);
            // 
            // bnVolver
            // 
            this.bnVolver.Location = new System.Drawing.Point(58, 564);
            this.bnVolver.Name = "bnVolver";
            this.bnVolver.Size = new System.Drawing.Size(75, 23);
            this.bnVolver.TabIndex = 6;
            this.bnVolver.Text = "Volver";
            this.bnVolver.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridView.Location = new System.Drawing.Point(58, 195);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(319, 150);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción :";
            // 
            // lblDescripcionPublicacion
            // 
            this.lblDescripcionPublicacion.AutoSize = true;
            this.lblDescripcionPublicacion.Location = new System.Drawing.Point(138, 44);
            this.lblDescripcionPublicacion.Name = "lblDescripcionPublicacion";
            this.lblDescripcionPublicacion.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcionPublicacion.TabIndex = 9;
            this.lblDescripcionPublicacion.Text = "label3";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Text = "Responder";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // FrmResponder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 599);
            this.Controls.Add(this.lblDescripcionPublicacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bnVolver);
            this.Controls.Add(this.bnResponder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Name = "FrmResponder";
            this.Text = "Responder preguntas";
            this.Load += new System.EventHandler(this.FrmResponder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnResponder;
        private System.Windows.Forms.Button bnVolver;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescripcionPublicacion;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}