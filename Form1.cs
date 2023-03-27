using System;
using System.Data;
using System.Data.Odbc;
namespace ProyectoCheques
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void txtBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContrasenia_TextChanged(object sender, EventArgs e)
        {

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
                registrar.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=cheques;uid=cheques;app=MyApplication;wsid=PC-GAMER-AURE;database=Cheques");
                OdbcCommand cmd = new OdbcCommand("SELECT COUNT(*) FROM Usuarios WHERE nombre = ? AND contrasena = ?", con);
                cmd.Parameters.AddWithValue("?", usuario);
                cmd.Parameters.AddWithValue("?", contrasena);

                con.Open();
                int resultado = (int)cmd.ExecuteScalar();
                Console.WriteLine("Usuario: " + usuario);
                Console.WriteLine("Contraseña: " + contrasena);
                Console.WriteLine("Resultado: " + resultado);

                con.Close();

                if (resultado == 1)
                {
                    // Permitir el acceso al sistema
                    this.Hide(); // Ocultar el formulario actual
                    FormularioBase formularioBase = new FormularioBase();
                    formularioBase.Show(); // Mostrar el formulario base
                }
                else
                {
                    // Mostrar mensaje de error al usuario
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Ocurrió un error al intentar conectarse a la base de datos. Verifique la cadena de conexión y la consulta SQL.");
            }

        }
    }
}