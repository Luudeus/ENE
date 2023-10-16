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
    public partial class Form4 : Form
    {
        private Form3 form3Instance;
        public Form4(Form3 form3)
        {
            InitializeComponent();
            form3Instance = form3;
        }
        public string RutText
        {
            set { rutTxt.Text = value; }
        }

        public string NombreText
        {
            set { nombreTxt.Text = value; }
        }

        public string DireccionText
        {
            set { direccionTxt.Text = value; }
        }

        public string TelefonoText
        {
            set { telefonoTxt.Text = value; }
        }

        public string BrutoText
        {
            set { sBrutoTxt.Text = value; }
        }

        public string LiquidoText
        {
            set { sLiquidoTxt.Text = value; }
        }
        private void saldoBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); // Pasar esta instancia de Form4
            form2.ShowDialog();
        }


        private void sBrutoTxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para ingresar valores en Sueldo Bruto y Sueldo Líquido debe presionar el botón \"Calcular Saldo\".", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sLiquidoTxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para ingresar valores en Sueldo Bruto y Sueldo Líquido debe presionar el botón \"Calcular Saldo\".", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación antes de proceder
            DialogResult dr = MessageBox.Show("¿Está seguro de ingresar estos datos?", "Ingresar Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Si el usuario confirma la acción...
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string bruto = sBrutoTxt.Text;
                    string liquido = sLiquidoTxt.Text;
                    bruto = bruto.Replace("$", "").Replace(".", "").Replace(",", ".");
                    liquido = liquido.Replace("$", "").Replace(".", "").Replace(",", ".");
                    using (var db = new Database())
                    {
                        db.OpenConnection();

                        // Preparar la consulta SQL utilizando parámetros para prevenir la inyección de SQL
                        string query = "INSERT INTO Empleados(Rut_Empleado, Nombre, Direccion, Telefono, Sueldo_Bruto, Sueldo_Liquido) VALUES (@Rut, @Nombre, @Direccion, @Telefono, @SueldoBruto, @SueldoLiquido)";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.GetConnection()))
                        {
                            // Convertir los valores de los campos de texto y asignarlos a los parámetros
                            cmd.Parameters.AddWithValue("@Rut", rutTxt.Text);
                            cmd.Parameters.AddWithValue("@Nombre", nombreTxt.Text);
                            cmd.Parameters.AddWithValue("@Direccion", direccionTxt.Text);
                            cmd.Parameters.AddWithValue("@Telefono", telefonoTxt.Text);
                            cmd.Parameters.AddWithValue("@SueldoBruto", Convert.ToDecimal(bruto));
                            cmd.Parameters.AddWithValue("@SueldoLiquido", Convert.ToDecimal(liquido));

                            // Ejecutar la consulta
                            cmd.ExecuteNonQuery();
                        }

                        // Cerrar la conexión después de ejecutar la consulta
                        db.CloseConnection();

                        // Opcional: Mostrar un mensaje de éxito
                        MessageBox.Show("Datos ingresados exitosamente.");
                        form3Instance.LlenarDataGridView(); // Se llama al método para llenar el DataGridView.
                        form3Instance.ActualizarOpcionesMenuContextual(); // Se llama al método para llenar el menú contextual.
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, mostrar un mensaje al usuario
                    MessageBox.Show("Error al ingresar datos: " + ex.Message);
                }
            }
        }



    }
}
