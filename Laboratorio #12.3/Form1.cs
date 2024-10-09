using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio__12._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcSemi_Click(object sender, EventArgs e)
        {
            try
            {
                double lado1 = Convert.ToDouble(side1.Text);
                double lado2 = Convert.ToDouble(side2.Text);
                double lado3 = Convert.ToDouble(side3.Text);

                double semiPer = (lado1 + lado2 + lado3) / 2;

                resultSemi.Text = semiPer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingresa valores válidos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcArea_Click(object sender, EventArgs e)
        {
            try
            {
                double lado1 = Convert.ToDouble(side1.Text);
                double lado2 = Convert.ToDouble(side2.Text);
                double lado3 = Convert.ToDouble(side3.Text);

                double area = lado1 + lado2 + lado3;

                resultArea.Text = area.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingresa valores válidos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            side1.Clear();
            side2.Clear();
            side3.Clear();
            resultSemi.Clear();
            resultArea.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
