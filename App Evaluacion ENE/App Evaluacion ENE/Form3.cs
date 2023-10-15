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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Load += Form3_Load;
            trabajadoresBtn.TextChanged += trabajadoresBtn_TextChanged;
            contextMenuStripWorker.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStripWorker_ItemClicked);

        }

        private void LlenarDataGridView(string clavePrimaria = null)
        {
            try
            {
                using (var db = new Database())
                {
                    db.OpenConnection();

                    string query;
                    MySqlCommand cmd = new MySqlCommand();

                    if (string.IsNullOrEmpty(clavePrimaria) || clavePrimaria == "TODOS")
                    {
                        // Si no hay filtro o el filtro es "TODOS", seleccionamos todos los empleados.
                        query = "SELECT Rut_Empleado, Nombre, Direccion, Telefono, Sueldo_Liquido, Sueldo_Bruto FROM Empleados";
                    }
                    else
                    {
                        // Si hay un filtro, seleccionamos los empleados que coincidan con la clave primaria.
                        query = "SELECT Rut_Empleado, Nombre, Direccion, Telefono, Sueldo_Liquido, Sueldo_Bruto FROM Empleados WHERE Rut_Empleado = @rut";
                        cmd.Parameters.AddWithValue("@rut", clavePrimaria); // Buscar empleados que coincidan con la clave primaria
                    }

                    cmd.Connection = db.GetConnection();
                    cmd.CommandText = query;

                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dataTable);

                    // Asignar los datos al DataGridView
                    workerDgv.DataSource = dataTable;

                    // Ajustar el modo de las columnas para que no queden espacios a los lados
                    foreach (DataGridViewColumn column in workerDgv.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    // Calcular cuántas filas en blanco se necesitan para que no queden espacios abajo del dgv
                    int heightOfOneRow = workerDgv.RowTemplate.Height; // Altura de una fila
                    int totalVisibleHeight = workerDgv.Height; // Altura total del DataGridView
                    int currentRowsHeight = workerDgv.Rows.Count * heightOfOneRow; // Altura total de las filas actuales

                    // Si la altura total de las filas actuales es menor que la altura visible, se agregan filas en blanco
                    while (currentRowsHeight < totalVisibleHeight)
                    {
                        dataTable.Rows.Add(); // Agregar una fila en blanco al final
                        currentRowsHeight += heightOfOneRow; // Actualizar la altura total de las filas
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
            }
        }


        private List<string> ObtenerRutsEmpleados()
        {
            List<string> ruts = new List<string>();

            using (var db = new Database())
            {
                db.OpenConnection();

                string query = "SELECT Rut_Empleado FROM Empleados";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ruts.Add(reader["Rut_Empleado"].ToString());
                }

                reader.Close();
                db.CloseConnection();
            }

            return ruts;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Obtener los RUTs de los empleados de la base de datos
            List<string> rutsEmpleados = ObtenerRutsEmpleados();

            // Agregar un elemento al menú para cada RUT
            foreach (string rut in rutsEmpleados)
            {
                ToolStripItem menuItem = new ToolStripMenuItem(rut);
                menuItem.Click += (senderItem, eventArgs) => // Cambié 'sender' y 'e' a 'senderItem' y 'eventArgs'
                {
                    // Aquí puedes manejar el evento click del elemento, si es necesario.
                    // Por ejemplo, podrías querer cargar detalles del empleado cuando se haga clic en su RUT.
                };
                contextMenuStripWorker.Items.Add(menuItem);
            }

            // Cuando el formulario se carga, se llena el dgv asumiendo que 'trabajadoresBtn' tiene el texto "TODOS" al inicio.

            LlenarDataGridView(trabajadoresBtn.Text);
        }


        private void trabajadoresBtn_TextChanged(object sender, EventArgs e)
        {
            // Cada vez que el texto cambia, actualizamos el DataGridView.
            LlenarDataGridView(trabajadoresBtn.Text);
        }

        private void trabajadoresBtn_Click(object sender, EventArgs e)
        {
            contextMenuStripWorker.Show(trabajadoresBtn, new Point(0, trabajadoresBtn.Height));
        }
        private void contextMenuStripWorker_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            trabajadoresBtn.Text = e.ClickedItem.Text;
            contextMenuStripWorker.Close();
        }

    }
}
