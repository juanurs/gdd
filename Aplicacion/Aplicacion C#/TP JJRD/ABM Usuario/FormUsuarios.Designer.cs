namespace TP_JJRD.ABM
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
            this.boton_alta = new System.Windows.Forms.Button();
            this.boton_listado = new System.Windows.Forms.Button();
            this.boton_baja = new System.Windows.Forms.Button();
            this.boton_modificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_alta
            // 
            this.boton_alta.Location = new System.Drawing.Point(48, 48);
            this.boton_alta.Name = "boton_alta";
            this.boton_alta.Size = new System.Drawing.Size(75, 48);
            this.boton_alta.TabIndex = 0;
            this.boton_alta.Text = "Alta";
            this.boton_alta.UseVisualStyleBackColor = true;
            this.boton_alta.Click += new System.EventHandler(this.boton_alta_Click);
            // 
            // boton_listado
            // 
            this.boton_listado.Location = new System.Drawing.Point(172, 48);
            this.boton_listado.Name = "boton_listado";
            this.boton_listado.Size = new System.Drawing.Size(75, 48);
            this.boton_listado.TabIndex = 1;
            this.boton_listado.Text = "Listado";
            this.boton_listado.UseVisualStyleBackColor = true;
            this.boton_listado.Click += new System.EventHandler(this.boton_listado_Click);
            // 
            // boton_baja
            // 
            this.boton_baja.Location = new System.Drawing.Point(48, 121);
            this.boton_baja.Name = "boton_baja";
            this.boton_baja.Size = new System.Drawing.Size(75, 46);
            this.boton_baja.TabIndex = 2;
            this.boton_baja.Text = "Baja";
            this.boton_baja.UseVisualStyleBackColor = true;
            this.boton_baja.Click += new System.EventHandler(this.boton_baja_Click);
            // 
            // boton_modificacion
            // 
            this.boton_modificacion.Location = new System.Drawing.Point(172, 121);
            this.boton_modificacion.Name = "boton_modificacion";
            this.boton_modificacion.Size = new System.Drawing.Size(75, 46);
            this.boton_modificacion.TabIndex = 3;
            this.boton_modificacion.Text = "Modificación";
            this.boton_modificacion.UseVisualStyleBackColor = true;
            this.boton_modificacion.Click += new System.EventHandler(this.boton_modificacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 225);
            this.Controls.Add(this.boton_modificacion);
            this.Controls.Add(this.boton_baja);
            this.Controls.Add(this.boton_listado);
            this.Controls.Add(this.boton_alta);
            this.Name = "Form1";
            this.Text = "ABM USUARIO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button boton_alta;
        private System.Windows.Forms.Button boton_listado;
        private System.Windows.Forms.Button boton_baja;
        private System.Windows.Forms.Button boton_modificacion;
    }
}