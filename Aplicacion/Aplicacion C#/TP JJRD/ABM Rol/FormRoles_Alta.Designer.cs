namespace TP_JJRD.ABM_Rol
{
    partial class FormRoles_Alta
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
            this.texto_rol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Funcionalidades = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre del nuevo Rol:";
            // 
            // texto_rol
            // 
            this.texto_rol.Location = new System.Drawing.Point(197, 22);
            this.texto_rol.Name = "texto_rol";
            this.texto_rol.Size = new System.Drawing.Size(153, 20);
            this.texto_rol.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione lista de Funcionalidades:";
            // 
            // Funcionalidades
            // 
            this.Funcionalidades.FormattingEnabled = true;
            this.Funcionalidades.Location = new System.Drawing.Point(31, 86);
            this.Funcionalidades.Name = "Funcionalidades";
            this.Funcionalidades.Size = new System.Drawing.Size(293, 139);
            this.Funcionalidades.TabIndex = 3;
            this.Funcionalidades.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormRoles_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Funcionalidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texto_rol);
            this.Controls.Add(this.label1);
            this.Name = "FormRoles_Alta";
            this.Text = "Alta de Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texto_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Funcionalidades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}