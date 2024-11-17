namespace Laboratorio__12._2
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
            this.calc = new System.Windows.Forms.Button();
            this.note1 = new System.Windows.Forms.TextBox();
            this.note2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.timeMov = new System.Windows.Forms.Label();
            this.velMov = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.note3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(39, 223);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(81, 30);
            this.calc.TabIndex = 20;
            this.calc.Text = "Promedio";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // note1
            // 
            this.note1.Location = new System.Drawing.Point(168, 84);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(165, 20);
            this.note1.TabIndex = 19;
            // 
            // note2
            // 
            this.note2.Location = new System.Drawing.Point(168, 131);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(165, 20);
            this.note2.TabIndex = 18;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(168, 281);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(165, 20);
            this.result.TabIndex = 17;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(252, 223);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 30);
            this.exit.TabIndex = 16;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(147, 223);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(81, 30);
            this.clean.TabIndex = 15;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(36, 281);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(123, 24);
            this.Resultado.TabIndex = 14;
            this.Resultado.Text = "Resultado";
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeMov
            // 
            this.timeMov.Location = new System.Drawing.Point(33, 127);
            this.timeMov.Name = "timeMov";
            this.timeMov.Size = new System.Drawing.Size(126, 27);
            this.timeMov.TabIndex = 13;
            this.timeMov.Text = "Nota #2";
            this.timeMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // velMov
            // 
            this.velMov.Location = new System.Drawing.Point(33, 84);
            this.velMov.Name = "velMov";
            this.velMov.Size = new System.Drawing.Size(129, 27);
            this.velMov.TabIndex = 12;
            this.velMov.Text = "Nota #1";
            this.velMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(122, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(134, 26);
            this.Titulo.TabIndex = 11;
            this.Titulo.Text = "Promedio Notas";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nota #3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // note3
            // 
            this.note3.Location = new System.Drawing.Point(168, 174);
            this.note3.Name = "note3";
            this.note3.Size = new System.Drawing.Size(165, 20);
            this.note3.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 353);
            this.Controls.Add(this.note3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.note1);
            this.Controls.Add(this.note2);
            this.Controls.Add(this.result);
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

        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.TextBox note1;
        private System.Windows.Forms.TextBox note2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label timeMov;
        private System.Windows.Forms.Label velMov;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox note3;
    }
}

