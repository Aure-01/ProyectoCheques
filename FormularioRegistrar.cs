using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoCheques
{
    public partial class FormularioRegistrar : Form
    {
        public FormularioRegistrar()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego");
            FormularioRegistrar reg = new FormularioRegistrar();
            this.Close();
            Form1 formu = new Form1();
            formu.ShowDialog();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-AURE;Initial Catalog=Cheques;Persist Security Info=True;User ID=cheques;Password=1234;";
            string query = "INSERT INTO Usuarios (nombre, contrasena, correo_electronico) VALUES (@usuario, @contrasena, @correo)";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // aquí puedes realizar las operaciones de base de datos que necesites
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    command.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                    command.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Registro correcto");
                        Form1 formulario = new Form1();
                        formulario.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Registro incorrecto");
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
    }
}
