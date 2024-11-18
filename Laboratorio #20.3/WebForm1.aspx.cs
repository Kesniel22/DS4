using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Laboratorio__20._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Productos"].ConnectionString;
        bool nuevo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResetForm();
            }
        }

        protected void tsbNuevo_Click(object sender, EventArgs e)
        {
            ResetForm(); 
            EnableForm(); 
            nuevo = true; 
        }

        protected void tsbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || !decimal.TryParse(txtPrecio.Text, out decimal precio) || !int.TryParse(txtStock.Text, out int stock))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Por favor ingrese valores válidos.');", true);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sql;

                    if (nuevo)
                    {
                        sql = "INSERT INTO Laptops (Nombre, Precio, Stock) VALUES (@Nombre, @Precio, @Stock)";
                    }
                    else
                    {
                        sql = "UPDATE Laptops SET Nombre = @Nombre, Precio = @Precio, Stock = @Stock WHERE id = @Id";
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Stock", stock);

                        if (!nuevo) 
                        {
                            cmd.Parameters.AddWithValue("@Id", txtId.Text);
                        }

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                ResetForm();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('Error: {ex.Message}');", true);
            }
        }


        protected void tsbCancelar_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        protected void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sql = "DELETE FROM Laptops WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtId.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                ResetForm();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('Error: {ex.Message}');", true);
            }
        }

        protected void tsbBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tstId.Text))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Por favor ingrese un Id para buscar.');", true);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Laptops WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", tstId.Text);
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtId.Text = reader["id"].ToString();
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtPrecio.Text = reader["Precio"].ToString();
                            txtStock.Text = reader["Stock"].ToString();

                            EnableForm();
                            nuevo = false;
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se encontró ningún registro con ese Id.');", true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('Error: {ex.Message}');", true);
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        private void ResetForm()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;

            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;
            tstId.Text = "";
        }

        private void EnableForm()
        {
            txtId.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;

            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = nuevo ? false : true;
        }
    }
}
