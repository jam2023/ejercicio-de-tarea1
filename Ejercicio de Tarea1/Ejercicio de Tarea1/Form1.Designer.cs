namespace Ejercicio_de_Tarea1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numerotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParImpar = new System.Windows.Forms.TextBox();
            this.txtPositivoNega = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(293, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Numero";
            // 
            // numerotextBox
            // 
            this.numerotextBox.Location = new System.Drawing.Point(298, 136);
            this.numerotextBox.Name = "numerotextBox";
            this.numerotextBox.Size = new System.Drawing.Size(163, 22);
            this.numerotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "resultado si es Par o Impar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "resultado si es Positivo o Negativo\r\n";
            // 
            // txtParImpar
            // 
            this.txtParImpar.Location = new System.Drawing.Point(391, 230);
            this.txtParImpar.Name = "txtParImpar";
            this.txtParImpar.Size = new System.Drawing.Size(177, 22);
            this.txtParImpar.TabIndex = 4;
            // 
            // txtPositivoNega
            // 
            this.txtPositivoNega.Location = new System.Drawing.Point(391, 288);
            this.txtPositivoNega.Name = "txtPositivoNega";
            this.txtPositivoNega.Size = new System.Drawing.Size(177, 22);
            this.txtPositivoNega.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPositivoNega);
            this.Controls.Add(this.txtParImpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numerotextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numerotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParImpar;
        private System.Windows.Forms.TextBox txtPositivoNega;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

