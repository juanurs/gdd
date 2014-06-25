namespace FrbaCommerce.Gestion_de_Preguntas
{
    partial class FrmGestionPreguntas
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
            this.bnResponderPreguntas = new System.Windows.Forms.Button();
            this.bnVerRespuestas = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnResponderPreguntas
            // 
            this.bnResponderPreguntas.Location = new System.Drawing.Point(70, 25);
            this.bnResponderPreguntas.Name = "bnResponderPreguntas";
            this.bnResponderPreguntas.Size = new System.Drawing.Size(122, 23);
            this.bnResponderPreguntas.TabIndex = 0;
            this.bnResponderPreguntas.Text = "Responder Preguntas";
            this.bnResponderPreguntas.UseVisualStyleBackColor = true;
            this.bnResponderPreguntas.Click += new System.EventHandler(this.bnResponderPreguntas_Click);
            // 
            // bnVerRespuestas
            // 
            this.bnVerRespuestas.Location = new System.Drawing.Point(70, 70);
            this.bnVerRespuestas.Name = "bnVerRespuestas";
            this.bnVerRespuestas.Size = new System.Drawing.Size(122, 23);
            this.bnVerRespuestas.TabIndex = 1;
            this.bnVerRespuestas.Text = "Ver Respuestas";
            this.bnVerRespuestas.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmGestionPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 188);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bnVerRespuestas);
            this.Controls.Add(this.bnResponderPreguntas);
            this.Name = "FrmGestionPreguntas";
            this.Text = "Gestión de preguntas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnResponderPreguntas;
        private System.Windows.Forms.Button bnVerRespuestas;
        private System.Windows.Forms.Button button3;
    }
}