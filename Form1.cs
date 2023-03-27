using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoCheques
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormularioRegistrar registrar = new FormularioRegistrar();
            registrar.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-AURE;Initial Catalog=Cheques;Persist Security Info=True;User ID=cheques;Password=1234;";
            string query = "SELECT COUNT(*) FROM Usuarios WHERE nombre = @usuario AND contrasena = @contrasena";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // aquí puedes realizar las operaciones de base de datos que necesites
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    command.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                    int result = (int)command.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("Bienvenido " + txtUsuario.Text + "!");
                        FormularioBase formulario = new FormularioBase();
                        formulario.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("Ocurrió un error al intentar conectarse a la base de datos. Verifique la cadena de conexión y la consulta SQL.");
                    // aquí puedes manejar las excepciones que puedan ocurrir durante la conexión a la base de datos
                }
            }
        }
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}