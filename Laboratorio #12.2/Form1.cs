using System;
using System.Windows.Forms;

namespace Laboratorio__12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                double nota1 = Convert.ToDouble(note1.Text);
                double nota2 = Convert.ToDouble(note2.Text);
                double nota3 = Convert.ToDouble(note3.Text);

                double promedio = (nota1 + nota2 + nota3) / 3;

               result.Text = promedio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingresa valores válidos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            note1.Clear();
            note2.Clear();
            note3.Clear();
            result.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
