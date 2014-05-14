namespace TP_JJRD
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TEXTOFILTRO1 = new System.Windows.Forms.TextBox();
            this.TEXTOFILTRO2 = new System.Windows.Forms.TextBox();
            this.COMBOFILTRO3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BOTONLIMPIAR = new System.Windows.Forms.Button();
            this.BOTONSELECCIONAR = new System.Windows.Forms.Button();
            this.BOTONBUSCAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro de Busqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtro 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtro 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filtro 3";
            // 
            // TEXTOFILTRO1
            // 
            this.TEXTOFILTRO1.Location = new System.Drawing.Point(68, 39);
            this.TEXTOFILTRO1.Name = "TEXTOFILTRO1";
            this.TEXTOFILTRO1.Size = new System.Drawing.Size(121, 20);
            this.TEXTOFILTRO1.TabIndex = 4;
            this.TEXTOFILTRO1.TextChanged += new System.EventHandler(this.TEXTOFILTRO1_TextChanged_1);
            // 
            // TEXTOFILTRO2
            // 
            this.TEXTOFILTRO2.Location = new System.Drawing.Point(68, 68);
            this.TEXTOFILTRO2.Name = "TEXTOFILTRO2";
            this.TEXTOFILTRO2.Size = new System.Drawing.Size(121, 20);
            this.TEXTOFILTRO2.TabIndex = 5;
            this.TEXTOFILTRO2.TextChanged += new System.EventHandler(this.TEXTOFILTRO2_TextChanged_1);
            // 
            // COMBOFILTRO3
            // 
            this.COMBOFILTRO3.FormattingEnabled = true;
            this.COMBOFILTRO3.Location = new System.Drawing.Point(284, 39);
            this.COMBOFILTRO3.Name = "COMBOFILTRO3";
            this.COMBOFILTRO3.Size = new System.Drawing.Size(121, 21);
            this.COMBOFILTRO3.TabIndex = 6;
            this.COMBOFILTRO3.SelectedIndexChanged += new System.EventHandler(this.COMBOFILTRO3_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Filtro 2";
            // 
            // BOTONLIMPIAR
            // 
            this.BOTONLIMPIAR.Location = new System.Drawing.Point(79, 111);
            this.BOTONLIMPIAR.Name = "BOTONLIMPIAR";
            this.BOTONLIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.BOTONLIMPIAR.TabIndex = 8;
            this.BOTONLIMPIAR.Text = "Limpiar";
            this.BOTONLIMPIAR.UseVisualStyleBackColor = true;
            this.BOTONLIMPIAR.Click += new System.EventHandler(this.BOTONLIMPIAR_Click_1);
            // 
            // BOTONSELECCIONAR
            // 
            this.BOTONSELECCIONAR.Location = new System.Drawing.Point(429, 68);
            this.BOTONSELECCIONAR.Name = "BOTONSELECCIONAR";
            this.BOTONSELECCIONAR.Size = new System.Drawing.Size(75, 23);
            this.BOTONSELECCIONAR.TabIndex = 9;
            this.BOTONSELECCIONAR.Text = "Seleccionar";
            this.BOTONSELECCIONAR.UseVisualStyleBackColor = true;
            this.BOTONSELECCIONAR.Click += new System.EventHandler(this.BOTONSELECCIONAR_Click);
            // 
            // BOTONBUSCAR
            // 
            this.BOTONBUSCAR.Location = new System.Drawing.Point(312, 111);
            this.BOTONBUSCAR.Name = "BOTONBUSCAR";
            this.BOTONBUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BOTONBUSCAR.TabIndex = 10;
            this.BOTONBUSCAR.Text = "Buscar";
            this.BOTONBUSCAR.UseVisualStyleBackColor = true;
            this.BOTONBUSCAR.Click += new System.EventHandler(this.BOTONBUSCAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 194);
            this.Controls.Add(this.BOTONBUSCAR);
            this.Controls.Add(this.BOTONSELECCIONAR);
            this.Controls.Add(this.BOTONLIMPIAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.COMBOFILTRO3);
            this.Controls.Add(this.TEXTOFILTRO2);
            this.Controls.Add(this.TEXTOFILTRO1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Listado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TEXTOFILTRO1;
        private System.Windows.Forms.TextBox TEXTOFILTRO2;
        private System.Windows.Forms.ComboBox COMBOFILTRO3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BOTONLIMPIAR;
        private System.Windows.Forms.Button BOTONSELECCIONAR;
        private System.Windows.Forms.Button BOTONBUSCAR;
    }
}

