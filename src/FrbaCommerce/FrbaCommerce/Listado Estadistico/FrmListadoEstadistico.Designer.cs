namespace FrbaCommerce.Listado_Estadistico
{
    partial class FrmListadoEstadistico
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
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.bnMayorCantProdNoVendidos = new System.Windows.Forms.Button();
            this.bnVendMayorFact = new System.Windows.Forms.Button();
            this.bnVendMayorCalifi = new System.Windows.Forms.Button();
            this.bnCliMayorCantPublSinCalificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bnVolver = new System.Windows.Forms.Button();
            this.lblVisibilidad = new System.Windows.Forms.Label();
            this.comboBoxVisibilidad = new System.Windows.Forms.ComboBox();
            this.lblMesAnio = new System.Windows.Forms.Label();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.bnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar trimestre :";
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Location = new System.Drawing.Point(129, 39);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(151, 21);
            this.comboBoxTrimestre.TabIndex = 1;
            this.comboBoxTrimestre.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrimestre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar año (AAAA) :";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(129, 9);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(83, 20);
            this.txtAnio.TabIndex = 3;
            this.txtAnio.TextChanged += new System.EventHandler(this.txtAnio_TextChanged);
            // 
            // bnMayorCantProdNoVendidos
            // 
            this.bnMayorCantProdNoVendidos.Location = new System.Drawing.Point(15, 76);
            this.bnMayorCantProdNoVendidos.Name = "bnMayorCantProdNoVendidos";
            this.bnMayorCantProdNoVendidos.Size = new System.Drawing.Size(88, 73);
            this.bnMayorCantProdNoVendidos.TabIndex = 4;
            this.bnMayorCantProdNoVendidos.Text = "Vendedores con mayor cantidad de productos no vendidos";
            this.bnMayorCantProdNoVendidos.UseVisualStyleBackColor = true;
            this.bnMayorCantProdNoVendidos.Click += new System.EventHandler(this.bnMayorCantProdNoVendidos_Click);
            // 
            // bnVendMayorFact
            // 
            this.bnVendMayorFact.Location = new System.Drawing.Point(109, 76);
            this.bnVendMayorFact.Name = "bnVendMayorFact";
            this.bnVendMayorFact.Size = new System.Drawing.Size(88, 73);
            this.bnVendMayorFact.TabIndex = 5;
            this.bnVendMayorFact.Text = "Vendedores con mayor facturación";
            this.bnVendMayorFact.UseVisualStyleBackColor = true;
            // 
            // bnVendMayorCalifi
            // 
            this.bnVendMayorCalifi.Location = new System.Drawing.Point(203, 76);
            this.bnVendMayorCalifi.Name = "bnVendMayorCalifi";
            this.bnVendMayorCalifi.Size = new System.Drawing.Size(88, 73);
            this.bnVendMayorCalifi.TabIndex = 6;
            this.bnVendMayorCalifi.Text = "Vendedores con mayores calificaciones";
            this.bnVendMayorCalifi.UseVisualStyleBackColor = true;
            // 
            // bnCliMayorCantPublSinCalificar
            // 
            this.bnCliMayorCantPublSinCalificar.Location = new System.Drawing.Point(297, 76);
            this.bnCliMayorCantPublSinCalificar.Name = "bnCliMayorCantPublSinCalificar";
            this.bnCliMayorCantPublSinCalificar.Size = new System.Drawing.Size(88, 73);
            this.bnCliMayorCantPublSinCalificar.TabIndex = 7;
            this.bnCliMayorCantPublSinCalificar.Text = "Clientes con mayor cantidad de publicaciones sin calificar";
            this.bnCliMayorCantPublSinCalificar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(370, 112);
            this.dataGridView1.TabIndex = 8;
            // 
            // bnVolver
            // 
            this.bnVolver.Location = new System.Drawing.Point(160, 332);
            this.bnVolver.Name = "bnVolver";
            this.bnVolver.Size = new System.Drawing.Size(75, 23);
            this.bnVolver.TabIndex = 9;
            this.bnVolver.Text = "Volver";
            this.bnVolver.UseVisualStyleBackColor = true;
            this.bnVolver.Click += new System.EventHandler(this.bnVolver_Click);
            // 
            // lblVisibilidad
            // 
            this.lblVisibilidad.AutoSize = true;
            this.lblVisibilidad.Location = new System.Drawing.Point(12, 166);
            this.lblVisibilidad.Name = "lblVisibilidad";
            this.lblVisibilidad.Size = new System.Drawing.Size(59, 13);
            this.lblVisibilidad.TabIndex = 10;
            this.lblVisibilidad.Text = "Visibilidad :";
            // 
            // comboBoxVisibilidad
            // 
            this.comboBoxVisibilidad.FormattingEnabled = true;
            this.comboBoxVisibilidad.Location = new System.Drawing.Point(76, 166);
            this.comboBoxVisibilidad.Name = "comboBoxVisibilidad";
            this.comboBoxVisibilidad.Size = new System.Drawing.Size(92, 21);
            this.comboBoxVisibilidad.TabIndex = 11;
            // 
            // lblMesAnio
            // 
            this.lblMesAnio.AutoSize = true;
            this.lblMesAnio.Location = new System.Drawing.Point(188, 166);
            this.lblMesAnio.Name = "lblMesAnio";
            this.lblMesAnio.Size = new System.Drawing.Size(36, 13);
            this.lblMesAnio.TabIndex = 12;
            this.lblMesAnio.Text = "Mes  :";
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Location = new System.Drawing.Point(230, 166);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(88, 21);
            this.comboBoxMes.TabIndex = 13;
            // 
            // bnVer
            // 
            this.bnVer.Location = new System.Drawing.Point(333, 161);
            this.bnVer.Name = "bnVer";
            this.bnVer.Size = new System.Drawing.Size(52, 23);
            this.bnVer.TabIndex = 14;
            this.bnVer.Text = "Ver";
            this.bnVer.UseVisualStyleBackColor = true;
            this.bnVer.Click += new System.EventHandler(this.bnVer_Click);
            // 
            // FrmListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 367);
            this.Controls.Add(this.bnVer);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.lblMesAnio);
            this.Controls.Add(this.comboBoxVisibilidad);
            this.Controls.Add(this.lblVisibilidad);
            this.Controls.Add(this.bnVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bnCliMayorCantPublSinCalificar);
            this.Controls.Add(this.bnVendMayorCalifi);
            this.Controls.Add(this.bnVendMayorFact);
            this.Controls.Add(this.bnMayorCantProdNoVendidos);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTrimestre);
            this.Controls.Add(this.label1);
            this.Name = "FrmListadoEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado estadístico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button bnMayorCantProdNoVendidos;
        private System.Windows.Forms.Button bnVendMayorFact;
        private System.Windows.Forms.Button bnVendMayorCalifi;
        private System.Windows.Forms.Button bnCliMayorCantPublSinCalificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bnVolver;
        private System.Windows.Forms.Label lblVisibilidad;
        private System.Windows.Forms.ComboBox comboBoxVisibilidad;
        private System.Windows.Forms.Label lblMesAnio;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Button bnVer;
    }
}