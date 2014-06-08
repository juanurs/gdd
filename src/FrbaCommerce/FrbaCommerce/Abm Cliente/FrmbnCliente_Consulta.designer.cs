namespace FrbaCommerce
{
    partial class FrmbnCliente_Consulta
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnLimpiar = new System.Windows.Forms.Button();
            this.filtroNombre = new System.Windows.Forms.TextBox();
            this.filtroApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.filtroDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota: Para ver todos los clientes existentes no ingresar filtros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filtroNombre);
            this.groupBox1.Controls.Add(this.filtroApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.filtroDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 102);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.Location = new System.Drawing.Point(12, 389);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bnLimpiar.TabIndex = 16;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.UseVisualStyleBackColor = true;
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // filtroNombre
            // 
            this.filtroNombre.Location = new System.Drawing.Point(142, 19);
            this.filtroNombre.Name = "filtroNombre";
            this.filtroNombre.Size = new System.Drawing.Size(117, 20);
            this.filtroNombre.TabIndex = 9;
            this.filtroNombre.TextChanged += new System.EventHandler(this.filtroNombre_TextChanged);
            this.filtroNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtroNombre_KeyPress);
            // 
            // filtroApellido
            // 
            this.filtroApellido.Location = new System.Drawing.Point(142, 45);
            this.filtroApellido.Name = "filtroApellido";
            this.filtroApellido.Size = new System.Drawing.Size(117, 20);
            this.filtroApellido.TabIndex = 8;
            this.filtroApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtroApellido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Documento Cliente:";
            // 
            // bnBuscar
            // 
            this.bnBuscar.Location = new System.Drawing.Point(367, 120);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(87, 29);
            this.bnBuscar.TabIndex = 2;
            this.bnBuscar.Text = "Buscar";
            this.bnBuscar.UseVisualStyleBackColor = true;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // filtroDocumento
            // 
            this.filtroDocumento.Location = new System.Drawing.Point(142, 71);
            this.filtroDocumento.Name = "filtroDocumento";
            this.filtroDocumento.Size = new System.Drawing.Size(117, 20);
            this.filtroDocumento.TabIndex = 6;
            this.filtroDocumento.TextChanged += new System.EventHandler(this.filtroDocumento_TextChanged);
            this.filtroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtroDocumento_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Apellido Cliente:";
            // 
            // dgvModificar
            // 
            this.dgvModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificar.Location = new System.Drawing.Point(12, 178);
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.Size = new System.Drawing.Size(439, 194);
            this.dgvModificar.TabIndex = 18;
            // 
            // FrmbnCliente_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(465, 424);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.dgvModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmbnCliente_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.FrmbnCliente_Consulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnLimpiar;
        private System.Windows.Forms.TextBox filtroNombre;
        private System.Windows.Forms.TextBox filtroApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.TextBox filtroDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvModificar;

    }
}