namespace Laboratorio__13._1
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
            this.SQLconect = new System.Windows.Forms.Button();
            this.ListaProductos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SQLconect
            // 
            this.SQLconect.Location = new System.Drawing.Point(43, 40);
            this.SQLconect.Name = "SQLconect";
            this.SQLconect.Size = new System.Drawing.Size(297, 47);
            this.SQLconect.TabIndex = 0;
            this.SQLconect.Text = "Conectar y Desconectar de SQL Server";
            this.SQLconect.UseVisualStyleBackColor = true;
            this.SQLconect.Click += new System.EventHandler(this.SQLconect_Click);
            // 
            // ListaProductos
            // 
            this.ListaProductos.FormattingEnabled = true;
            this.ListaProductos.Location = new System.Drawing.Point(104, 103);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(180, 199);
            this.ListaProductos.TabIndex = 1;
            this.ListaProductos.SelectedIndexChanged += new System.EventHandler(this.ListaProductos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 358);
            this.Controls.Add(this.ListaProductos);
            this.Controls.Add(this.SQLconect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SQLconect;
        private System.Windows.Forms.ListBox ListaProductos;
    }
}

