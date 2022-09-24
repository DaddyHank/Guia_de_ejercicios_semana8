
namespace Guia_de_ejercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.btnMensaje1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMensaje2 = new System.Windows.Forms.Button();
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.Location = new System.Drawing.Point(24, 69);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(199, 20);
            this.txtMensaje1.TabIndex = 0;
            // 
            // btnMensaje1
            // 
            this.btnMensaje1.Location = new System.Drawing.Point(136, 145);
            this.btnMensaje1.Name = "btnMensaje1";
            this.btnMensaje1.Size = new System.Drawing.Size(106, 23);
            this.btnMensaje1.TabIndex = 1;
            this.btnMensaje1.Text = "Enviar mensaje1";
            this.btnMensaje1.UseVisualStyleBackColor = true;
            this.btnMensaje1.Click += new System.EventHandler(this.btnMensaje1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "por favor, ingrese un mensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "por favor, ingrese un mensaje";
            // 
            // btnMensaje2
            // 
            this.btnMensaje2.Location = new System.Drawing.Point(381, 145);
            this.btnMensaje2.Name = "btnMensaje2";
            this.btnMensaje2.Size = new System.Drawing.Size(106, 23);
            this.btnMensaje2.TabIndex = 4;
            this.btnMensaje2.Text = "Enviar mensaje2";
            this.btnMensaje2.UseVisualStyleBackColor = true;
            this.btnMensaje2.Click += new System.EventHandler(this.btnMensaje2_Click);
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Location = new System.Drawing.Point(269, 69);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(199, 20);
            this.txtMensaje2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMensaje2);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMensaje1);
            this.Controls.Add(this.txtMensaje1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.Button btnMensaje1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMensaje2;
        private System.Windows.Forms.TextBox txtMensaje2;
    }
}

