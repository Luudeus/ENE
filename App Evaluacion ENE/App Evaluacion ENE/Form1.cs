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
                db.OpenConnection();

                // Preparar la consulta SQL
                string query = "SELECT * FROM Administrador WHERE Usuario = @usuario AND Contrasena = @contrasena";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@usuario", usuarioIngresado);
                cmd.Parameters.AddWithValue("@contrasena", contrasenaIngresada);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Verificar si la consulta devolvió algún resultado
                if (reader.Read())
                {
                    Form2 form2 = new Form2(); // Crea una instancia de tu segundo formulario
                    this.Hide(); // Opcional: oculta el formulario actual
                    form2.ShowDialog();
                }
                else
                {
                    // No se encontraron registros que coincidan: el usuario o la contraseña son incorrectos
                    MessageBox.Show("El usuario o la contraseña son incorrecto(s)", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close(); // No olvides cerrar el MySqlDataReader
                db.CloseConnection();
            }
        }
    }
}
