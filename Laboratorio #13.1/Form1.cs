using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laboratorio__13._1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=.\\sqlexpress;Database=Northwind;" +
        "TrustServerCertificate=true;User Id=sa;Password=12345;";

        public Form1()
        {
            InitializeComponent();
        }
        private void SQLconect_Click(object sender, EventArgs e)
        {
            using (SqlConnection conex = new SqlConnection(connectionString))
                try
                {
                    conex.Open();
                    MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos.");
                    cargarProductos(conex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conex.Close();
                    MessageBox.Show("Se cerró la conexión.");
                }
        }

        private void ListaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cargarProductos(SqlConnection conex) 
        {
            string query = "SELECT ProductName FROM [dbo].[Products]";
            SqlCommand command = new SqlCommand(query, conex);

            try
            {
                SqlDataReader read = command.ExecuteReader();
                ListaProductos.Items.Clear();

                while (read.Read())
                {
                    string productName = read["ProductName"].ToString();
                    ListaProductos.Items.Add(productName);
                }
                read.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al cargar los productos" + ex.Message);
            }
        }
    }
}
