namespace Laboratorio__12._1
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
            this.Titulo = new System.Windows.Forms.Label();
            this.velMov = new System.Windows.Forms.Label();
            this.timeMov = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(111, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(134, 26);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Recorrido de un Auto";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // velMov
            // 
            this.velMov.Location = new System.Drawing.Point(22, 75);
            this.velMov.Name = "velMov";
            this.velMov.Size = new System.Drawing.Size(129, 27);
            this.velMov.TabIndex = 1;
            this.velMov.Text = "Velocidad del Auto";
            this.velMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeMov
            // 
            this.timeMov.Location = new System.Drawing.Point(25, 126);
            this.timeMov.Name = "timeMov";
            this.timeMov.Size = new System.Drawing.Size(126, 27);
            this.timeMov.TabIndex = 2;
            this.timeMov.Text = "Tiempo Usado";
            this.timeMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(25, 238);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(123, 24);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "Resultado";
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(136, 180);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(81, 30);
            this.clean.TabIndex = 5;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(241, 180);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 30);
            this.exit.TabIndex = 6;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(28, 180);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(81, 30);
            this.calc.TabIndex = 10;
            this.calc.Text = "Calcular";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 313);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.timeMov);
            this.Controls.Add(this.velMov);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label velMov;
        private System.Windows.Forms.Label timeMov;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button calc;
    }
}

