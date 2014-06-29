namespace FrbaCommerce
{
    partial class FrmbnCliente_Modificar
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
            this.bnBuscar = new System.Windows.Forms.Button();
            this.filtroDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filtroApellido = new System.Windows.Forms.TextBox();
            this.filtroNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnLimpiar = new System.Windows.Forms.Button();
            this.dgvModificar = new System.Windows.Forms.DataGridView();
            this.bnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bnGuardar = new System.Windows.Forms.Button();
            this.dataResultado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.bnVolver = new System.Windows.Forms.Button();
            this.bnHabilitar = new System.Windows.Forms.Button();
            this.bnDeshabilitar = new System.Windows.Forms.Button();
            this.bnModificarDatos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // bnBuscar
            // 
            this.bnBuscar.Location = new System.Drawing.Point(308, 44);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(87, 29);
            this.bnBuscar.TabIndex = 2;
            this.bnBuscar.Text = "Buscar";
            this.bnBuscar.UseVisualStyleBackColor = true;
            // 
            // filtroDocumento
            // 
            this.filtroDocumento.Location = new System.Drawing.Point(0, 0);
            this.filtroDocumento.Name = "filtroDocumento";
            this.filtroDocumento.Size = new System.Drawing.Size(100, 20);
            this.filtroDocumento.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Documento Cliente:";
            // 
            // filtroApellido
            // 
            this.filtroApellido.Location = new System.Drawing.Point(0, 0);
            this.filtroApellido.Name = "filtroApellido";
            this.filtroApellido.Size = new System.Drawing.Size(100, 20);
            this.filtroApellido.TabIndex = 2;
            // 
            // filtroNombre
            // 
            this.filtroNombre.Location = new System.Drawing.Point(0, 0);
            this.filtroNombre.Name = "filtroNombre";
            this.filtroNombre.Size = new System.Drawing.Size(100, 20);
            this.filtroNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Apellido Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Modifique los campos deseados:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnLimpiar);
            this.groupBox1.Controls.Add(this.filtroNombre);
            this.groupBox1.Controls.Add(this.filtroApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bnBuscar);
            this.groupBox1.Controls.Add(this.filtroDocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 136);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.Location = new System.Drawing.Point(0, 0);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bnLimpiar.TabIndex = 0;
            // 
            // dgvModificar
            // 
            this.dgvModificar.Location = new System.Drawing.Point(0, 0);
            this.dgvModificar.Name = "dgvModificar";
            this.dgvModificar.Size = new System.Drawing.Size(240, 150);
            this.dgvModificar.TabIndex = 0;
            // 
            // bnSeleccionar
            // 
            this.bnSeleccionar.DataPropertyName = "Modificar";
            this.bnSeleccionar.HeaderText = "Seleccionar";
            this.bnSeleccionar.Name = "bnSeleccionar";
            this.bnSeleccionar.Text = "Modificar";
            this.bnSeleccionar.ToolTipText = "Modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tipo de Doc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Numero de Doc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email";
            // 
            // bnGuardar
            // 
            this.bnGuardar.Location = new System.Drawing.Point(312, 344);
            this.bnGuardar.Name = "bnGuardar";
            this.bnGuardar.Size = new System.Drawing.Size(75, 23);
            this.bnGuardar.TabIndex = 5;
            this.bnGuardar.Text = "Buscar";
            this.bnGuardar.UseVisualStyleBackColor = true;
            this.bnGuardar.Click += new System.EventHandler(this.bnGuardar_Click);
            // 
            // dataResultado
            // 
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataResultado.Location = new System.Drawing.Point(24, 151);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.Size = new System.Drawing.Size(480, 150);
            this.dataResultado.TabIndex = 6;
            this.dataResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResultado_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Text = "Editar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(93, 71);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(136, 21);
            this.comboBoxTipoDoc.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(93, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(136, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(323, 74);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDoc.TabIndex = 11;
            // 
            // bnVolver
            // 
            this.bnVolver.Location = new System.Drawing.Point(12, 344);
            this.bnVolver.Name = "bnVolver";
            this.bnVolver.Size = new System.Drawing.Size(75, 23);
            this.bnVolver.TabIndex = 12;
            this.bnVolver.Text = "Volver";
            this.bnVolver.UseVisualStyleBackColor = true;
            this.bnVolver.Click += new System.EventHandler(this.bnVolver_Click);
            // 
            // bnHabilitar
            // 
            this.bnHabilitar.Location = new System.Drawing.Point(114, 344);
            this.bnHabilitar.Name = "bnHabilitar";
            this.bnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.bnHabilitar.TabIndex = 13;
            this.bnHabilitar.Text = "Habilitar";
            this.bnHabilitar.UseVisualStyleBackColor = true;
            this.bnHabilitar.Click += new System.EventHandler(this.bnHabilitar_Click);
            // 
            // bnDeshabilitar
            // 
            this.bnDeshabilitar.Location = new System.Drawing.Point(214, 344);
            this.bnDeshabilitar.Name = "bnDeshabilitar";
            this.bnDeshabilitar.Size = new System.Drawing.Size(75, 23);
            this.bnDeshabilitar.TabIndex = 14;
            this.bnDeshabilitar.Text = "Deshabilitar";
            this.bnDeshabilitar.UseVisualStyleBackColor = true;
            this.bnDeshabilitar.Click += new System.EventHandler(this.bnDeshabilitar_Click);
            // 
            // bnModificarDatos
            // 
            this.bnModificarDatos.Location = new System.Drawing.Point(403, 343);
            this.bnModificarDatos.Name = "bnModificarDatos";
            this.bnModificarDatos.Size = new System.Drawing.Size(101, 23);
            this.bnModificarDatos.TabIndex = 15;
            this.bnModificarDatos.Text = "Modificar Datos";
            this.bnModificarDatos.UseVisualStyleBackColor = true;
            this.bnModificarDatos.Click += new System.EventHandler(this.bnModificarDatos_Click);
            // 
            // FrmbnCliente_Modificar
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 401);
            this.Controls.Add(this.bnModificarDatos);
            this.Controls.Add(this.bnDeshabilitar);
            this.Controls.Add(this.bnHabilitar);
            this.Controls.Add(this.bnVolver);
            this.Controls.Add(this.txtNumeroDoc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.dataResultado);
            this.Controls.Add(this.bnGuardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FrmbnCliente_Modificar";
            this.Load += new System.EventHandler(this.FrmbnCliente_Modificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.TextBox filtroDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filtroApellido;
        private System.Windows.Forms.TextBox filtroNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnLimpiar;
        private System.Windows.Forms.DataGridView dgvModificar;
        private System.Windows.Forms.DataGridViewButtonColumn bnSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bnGuardar;
        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Button bnVolver;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button bnHabilitar;
        private System.Windows.Forms.Button bnDeshabilitar;
        private System.Windows.Forms.Button bnModificarDatos;
    }
}