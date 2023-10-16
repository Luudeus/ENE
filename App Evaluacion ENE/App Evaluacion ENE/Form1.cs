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
            usuarioIngresado = usuarioIngresado.Replace(".", "").Replace("-", ""); // Quitar puntos y guiones del usuario

            // Intentar convertir la cadena a un número entero
            int intUsuario;
            bool isValidNumber = int.TryParse(usuarioIngresado, out intUsuario);

            if (!isValidNumber)
            {
                // Si la conversión falla, mostrar mensaje de error salir del método.
                MessageBox.Show("El usuario o la contraseña son incorrecto(s)", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string contrasenaIngresada = passwdTxt.Text.Trim(); // Obtener la contraseña ingresada

            using (var db = new Database())
            {
                db.OpenConnection(); // Abrir conexion con la db

                // Preparar la consulta SQL
                string query = "SELECT * FROM Usuarios WHERE Usuario = @usuario AND Contrasena = @contrasena";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@usuario", usuarioIngresado);
                cmd.Parameters.AddWithValue("@contrasena", contrasenaIngresada);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Verificar si la consulta devolvió algún resultado
                if (reader.Read())
                {
                    reader.Close(); // Cerrar el reader antes de la siguiente consulta

                    // Verificar si el usuario está también en la tabla Empleados
                    string queryEmpleado = "SELECT * FROM Empleados WHERE Rut_Empleado = @usuario";
                    MySqlCommand cmdEmpleado = new MySqlCommand(queryEmpleado, db.GetConnection());
                    cmdEmpleado.Parameters.AddWithValue("@usuario", usuarioIngresado);

                    MySqlDataReader readerEmpleado = cmdEmpleado.ExecuteReader();

                    bool esEmpleado = readerEmpleado.Read(); // Será true si el usuario está en la tabla Empleados
                    readerEmpleado.Close();

                    if (esEmpleado)
                    {
                        // Si el usuario es un empleado, crea una instancia de Form3 pasando el Rut del empleado
                        Form3 form3 = new Form3(usuarioIngresado); // 'usuarioIngresado' debería ser el Rut del empleado
                        // Si el usuario es un empleado, ajustar la interfaz en Form3
                        form3.OcultarBotonesAdministrativos();
                        this.Hide();
                        form3.FormClosed += (s, args) => Application.Exit();
                        form3.ShowDialog();
                    }
                    else
                    {
                        Form3 form3 = new Form3();
                        this.Hide();
                        form3.FormClosed += (s, args) => Application.Exit();
                        form3.ShowDialog();
                    }

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
