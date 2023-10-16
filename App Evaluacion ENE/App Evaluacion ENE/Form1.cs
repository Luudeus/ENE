using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace App_Evaluacion_ENE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = usrTxt.Text.Trim(); // Obtener el nombre de usuario ingresado
            string contrasenaIngresada = passwdTxt.Text.Trim(); // Obtener la contraseña ingresada

            using (var db = new Database())
            {
                db.OpenConnection(); // Abrir conexion con la db

                // Preparar la consulta SQL
                string query = "SELECT * FROM Administrador WHERE Usuario = @usuario AND Contrasena = @contrasena";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@usuario", usuarioIngresado);
                cmd.Parameters.AddWithValue("@contrasena", contrasenaIngresada);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Verificar si la consulta devolvió algún resultado
                if (reader.Read())
                {
                    Form3 form3 = new Form3(); // Crea una instancia de form3
                    this.Hide(); // oculta el formulario actual
                    form3.FormClosed += (s, args) => Application.Exit(); // Cierra la aplicación cuando form3 se cierra
                    form3.ShowDialog(); // Muestra el form3
                }
                else
                {
                    // Arrojar mensaje de error en caso de que el usuario o contrasena sean incorrectos
                    MessageBox.Show("El usuario o la contraseña son incorrecto(s)", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close(); // Cerrar el reader
                db.CloseConnection(); // Cerrar conexion con la db
            }
        }
    }
}
