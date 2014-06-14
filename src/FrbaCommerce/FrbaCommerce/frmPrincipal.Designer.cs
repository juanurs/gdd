namespace FrbaCommerce
{
    partial class frmPrincipal
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
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnRubro = new System.Windows.Forms.Button();
            this.btnVisibilidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(12, 194);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(91, 25);
            this.btnRoles.TabIndex = 0;
            this.btnRoles.Text = "ABM Rol";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(133, 181);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 22);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(133, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 25);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "COMMERCE";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(21, 74);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(100, 13);
            this.lblUsuarioLogueado.TabIndex = 4;
            this.lblUsuarioLogueado.Text = "Usuario Logueado :";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(21, 87);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(36, 13);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil :";
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 132);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(91, 25);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Text = "ABM Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(12, 163);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(91, 25);
            this.btnEmpresa.TabIndex = 7;
            this.btnEmpresa.Text = "ABM Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnRubro
            // 
            this.btnRubro.Location = new System.Drawing.Point(12, 225);
            this.btnRubro.Name = "btnRubro";
            this.btnRubro.Size = new System.Drawing.Size(91, 23);
            this.btnRubro.TabIndex = 8;
            this.btnRubro.Text = "ABM Rubro";
            this.btnRubro.UseVisualStyleBackColor = true;
            // 
            // btnVisibilidad
            // 
            this.btnVisibilidad.Location = new System.Drawing.Point(12, 254);
            this.btnVisibilidad.Name = "btnVisibilidad";
            this.btnVisibilidad.Size = new System.Drawing.Size(91, 23);
            this.btnVisibilidad.TabIndex = 9;
            this.btnVisibilidad.Text = "ABM Visibilidad";
            this.btnVisibilidad.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 354);
            this.Controls.Add(this.btnVisibilidad);
            this.Controls.Add(this.btnRubro);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblUsuarioLogueado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRoles);
            this.Name = "frmPrincipal";
            this.Text = "Commerce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnRubro;
        private System.Windows.Forms.Button btnVisibilidad;
    }
}

