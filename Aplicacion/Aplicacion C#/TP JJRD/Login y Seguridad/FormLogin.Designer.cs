namespace TP_JJRD.Logueo
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
            this.TEXTO1 = new System.Windows.Forms.Label();
            this.TEXTO2 = new System.Windows.Forms.Label();
            this.texto_usuario = new System.Windows.Forms.TextBox();
            this.texto_contraseña = new System.Windows.Forms.TextBox();
            this.imagen_loguin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_loguin)).BeginInit();
            this.SuspendLayout();
            // 
            // TEXTO1
            // 
            this.TEXTO1.AutoSize = true;
            this.TEXTO1.Location = new System.Drawing.Point(148, 38);
            this.TEXTO1.Name = "TEXTO1";
            this.TEXTO1.Size = new System.Drawing.Size(46, 13);
            this.TEXTO1.TabIndex = 0;
            this.TEXTO1.Text = "Usuario:";
            // 
            // TEXTO2
            // 
            this.TEXTO2.AutoSize = true;
            this.TEXTO2.Location = new System.Drawing.Point(130, 76);
            this.TEXTO2.Name = "TEXTO2";
            this.TEXTO2.Size = new System.Drawing.Size(64, 13);
            this.TEXTO2.TabIndex = 1;
            this.TEXTO2.Text = "Contraseña:";
            // 
            // texto_usuario
            // 
            this.texto_usuario.Location = new System.Drawing.Point(197, 38);
            this.texto_usuario.Name = "texto_usuario";
            this.texto_usuario.Size = new System.Drawing.Size(100, 20);
            this.texto_usuario.TabIndex = 2;
            this.texto_usuario.TextChanged += new System.EventHandler(this.texto_usuario_TextChanged);
            // 
            // texto_contraseña
            // 
            this.texto_contraseña.Location = new System.Drawing.Point(197, 73);
            this.texto_contraseña.Name = "texto_contraseña";
            this.texto_contraseña.Size = new System.Drawing.Size(100, 20);
            this.texto_contraseña.TabIndex = 3;
            this.texto_contraseña.TextChanged += new System.EventHandler(this.texto_contraseña_TextChanged);
            // 
            // imagen_loguin
            // 
            this.imagen_loguin.Location = new System.Drawing.Point(12, 38);
            this.imagen_loguin.Name = "imagen_loguin";
            this.imagen_loguin.Size = new System.Drawing.Size(100, 50);
            this.imagen_loguin.TabIndex = 4;
            this.imagen_loguin.TabStop = false;
            this.imagen_loguin.Click += new System.EventHandler(this.imagen_loguin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 116);
            this.Controls.Add(this.imagen_loguin);
            this.Controls.Add(this.texto_contraseña);
            this.Controls.Add(this.texto_usuario);
            this.Controls.Add(this.TEXTO2);
            this.Controls.Add(this.TEXTO1);
            this.Name = "Form1";
            this.Text = "LOGIN Y SEGURIDAD";
            ((System.ComponentModel.ISupportInitialize)(this.imagen_loguin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TEXTO1;
        private System.Windows.Forms.Label TEXTO2;
        private System.Windows.Forms.TextBox texto_usuario;
        private System.Windows.Forms.TextBox texto_contraseña;
        private System.Windows.Forms.PictureBox imagen_loguin;
    }
}