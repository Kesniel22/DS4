using System;
using System.Windows.Forms;

namespace Laboratorio__12._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void exit_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void calc_Click(object sender, EventArgs e)
        {
            try
            {

                double velocidad = Convert.ToDouble(textBox3.Text);
                double tiempo = Convert.ToDouble(textBox2.Text);


                double distancia = velocidad * tiempo;


                textBox1.Text = distancia.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingresa valores válidos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void clean_Click(object sender, EventArgs e)
        {

            textBox3.Clear(); 
            textBox2.Clear(); 
            textBox1.Clear(); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
