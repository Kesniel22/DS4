namespace Laboratorio__12._3
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
            this.side3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcSemi = new System.Windows.Forms.Button();
            this.side1 = new System.Windows.Forms.TextBox();
            this.side2 = new System.Windows.Forms.TextBox();
            this.resultSemi = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.calcArea = new System.Windows.Forms.Button();
            this.Semi = new System.Windows.Forms.Label();
            this.timeMov = new System.Windows.Forms.Label();
            this.velMov = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.resultArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // side3
            // 
            this.side3.Location = new System.Drawing.Point(195, 178);
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(165, 20);
            this.side3.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(60, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lado C";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcSemi
            // 
            this.calcSemi.Location = new System.Drawing.Point(63, 227);
            this.calcSemi.Name = "calcSemi";
            this.calcSemi.Size = new System.Drawing.Size(81, 30);
            this.calcSemi.TabIndex = 32;
            this.calcSemi.Text = "Semiperimetro";
            this.calcSemi.UseVisualStyleBackColor = true;
            this.calcSemi.Click += new System.EventHandler(this.calcSemi_Click);
            // 
            // side1
            // 
            this.side1.Location = new System.Drawing.Point(195, 88);
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(165, 20);
            this.side1.TabIndex = 31;
            // 
            // side2
            // 
            this.side2.Location = new System.Drawing.Point(195, 135);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(165, 20);
            this.side2.TabIndex = 30;
            // 
            // resultSemi
            // 
            this.resultSemi.Location = new System.Drawing.Point(195, 285);
            this.resultSemi.Name = "resultSemi";
            this.resultSemi.Size = new System.Drawing.Size(165, 20);
            this.resultSemi.TabIndex = 29;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(391, 227);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 30);
            this.exit.TabIndex = 28;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // calcArea
            // 
            this.calcArea.Location = new System.Drawing.Point(173, 227);
            this.calcArea.Name = "calcArea";
            this.calcArea.Size = new System.Drawing.Size(81, 30);
            this.calcArea.TabIndex = 27;
            this.calcArea.Text = "Area";
            this.calcArea.UseVisualStyleBackColor = true;
            this.calcArea.Click += new System.EventHandler(this.calcArea_Click);
            // 
            // Semi
            // 
            this.Semi.Location = new System.Drawing.Point(63, 285);
            this.Semi.Name = "Semi";
            this.Semi.Size = new System.Drawing.Size(123, 24);
            this.Semi.TabIndex = 26;
            this.Semi.Text = "Semiperimetro";
            this.Semi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeMov
            // 
            this.timeMov.Location = new System.Drawing.Point(60, 131);
            this.timeMov.Name = "timeMov";
            this.timeMov.Size = new System.Drawing.Size(126, 27);
            this.timeMov.TabIndex = 25;
            this.timeMov.Text = "Lado B";
            this.timeMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // velMov
            // 
            this.velMov.Location = new System.Drawing.Point(60, 88);
            this.velMov.Name = "velMov";
            this.velMov.Size = new System.Drawing.Size(129, 27);
            this.velMov.TabIndex = 24;
            this.velMov.Text = "Lado A";
            this.velMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(192, 27);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(134, 26);
            this.Titulo.TabIndex = 23;
            this.Titulo.Text = "Laboratorio #12.3";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultArea
            // 
            this.resultArea.Location = new System.Drawing.Point(195, 327);
            this.resultArea.Name = "resultArea";
            this.resultArea.Size = new System.Drawing.Size(165, 20);
            this.resultArea.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(63, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Area";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(279, 227);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(81, 30);
            this.clean.TabIndex = 37;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 379);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.resultArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.side3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcSemi);
            this.Controls.Add(this.side1);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.resultSemi);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calcArea);
            this.Controls.Add(this.Semi);
            this.Controls.Add(this.timeMov);
            this.Controls.Add(this.velMov);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox side3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcSemi;
        private System.Windows.Forms.TextBox side1;
        private System.Windows.Forms.TextBox side2;
        private System.Windows.Forms.TextBox resultSemi;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button calcArea;
        private System.Windows.Forms.Label Semi;
        private System.Windows.Forms.Label timeMov;
        private System.Windows.Forms.Label velMov;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox resultArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clean;
    }
}

