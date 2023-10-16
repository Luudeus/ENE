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
        private string rutEmpleadoIngresado; // Variable para almacenar el Rut del empleado
        public Form3(string rutEmpleado = null)
        {
            InitializeComponent();
            this.Load += Form3_Load;
            trabajadoresBtn.TextChanged += trabajadoresBtn_TextChanged;
            contextMenuStripWorker.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStripWorker_ItemClicked);
            workerDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.rutEmpleadoIngresado = rutEmpleado;

        }

        internal void LlenarDataGridView(string clavePrimaria = null)
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
                        // Si no hay filtro o el filtro es "TODOS", se seleccionan todos los empleados.
                        query = "SELECT Rut_Empleado, Nombre, Direccion, Telefono, Sueldo_Bruto, Sueldo_Liquido  FROM Empleados";
                    }
                    else
                    {
                        // Si hay un filtro, se seleccionan los empleados que coincidan con la clave primaria.
                        query = "SELECT Rut_Empleado, Nombre, Direccion, Telefono, Sueldo_Bruto, Sueldo_Liquido  FROM Empleados WHERE Rut_Empleado = @rut";
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

        private void trabajadoresBtn_TextChanged(object sender, EventArgs e)
        {
            // Cada vez que el texto cambia, actualizamos el DataGridView.
            LlenarDataGridView(trabajadoresBtn.Text);
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
            // Si 'rutEmpleadoIngresado' no es null, significa que es un empleado y no un administrador.
            if (!string.IsNullOrEmpty(rutEmpleadoIngresado))
            {
                LlenarDataGridView(rutEmpleadoIngresado); // Cargar solo el empleado específico
            }
            else
            {
                // Obtener los RUTs de los empleados de la base de datos
                List<string> rutsEmpleados = ObtenerRutsEmpleados();

                // Agregar un elemento al menú para cada RUT
                foreach (string rut in rutsEmpleados)
                {
                    ToolStripItem menuItem = new ToolStripMenuItem(rut);
                    menuItem.Click += (senderItem, eventArgs) =>
                    {

                    };
                    contextMenuStripWorker.Items.Add(menuItem);
                }

                // Cuando el formulario se carga, se llena el dgv asumiendo que 'trabajadoresBtn' tiene el texto "TODOS" al inicio.

                LlenarDataGridView(trabajadoresBtn.Text);
            }

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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (workerDgv.SelectedRows.Count > 0)
            {
                // Obtener el índice de la primera fila seleccionada
                int selectedIndex = workerDgv.SelectedRows[0].Index;

                // Obtener el Rut del empleado de la fila seleccionada, asumiendo que el Rut está en la primera columna (cambiar si es diferente)
                string employeeRut = workerDgv.Rows[selectedIndex].Cells["Rut_Empleado"].Value.ToString();

                // Confirmación antes de eliminar
                DialogResult dr = MessageBox.Show("¿Está seguro de que desea eliminar al empleado con Rut: " + employeeRut + "?", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new Database())
                        {
                            db.OpenConnection();

                            // Preparar la consulta SQL para eliminar el registro
                            string query = "DELETE FROM Empleados WHERE Rut_Empleado = @rut";
                            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                            cmd.Parameters.AddWithValue("@rut", employeeRut);

                            // Ejecutar la consulta
                            cmd.ExecuteNonQuery();

                            // Cerrar la conexión
                            db.CloseConnection();

                            // Mostrar un mensaje de éxito
                            MessageBox.Show("Empleado eliminado con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Actualizar el DataGridView y las opciones del menú contextual para reflejar la eliminación
                            LlenarDataGridView(); // Se llama al método para llenar el DataGridView.
                            ActualizarOpcionesMenuContextual(); // Se llama al método para llenar el menú contextual.
                        }
                    }
                    catch (Exception ex)
                    {
                        // Mostrar mensaje en caso de error
                        MessageBox.Show("Error al eliminar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si no hay ninguna fila seleccionada, mostrar un mensaje
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Ninguna fila seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal void ActualizarOpcionesMenuContextual()
        {
            // Limpiar las opciones existentes
            contextMenuStripWorker.Items.Clear();

            // Obtener las nuevas opciones basadas en tus datos (por ejemplo, claves primarias de la tabla Empleados)
            List<string> rutsEmpleados = ObtenerRutsEmpleados();
            // Agregar la palabra "TODOS" al inicio de la lista
            rutsEmpleados.Insert(0, "TODOS");
            // Agregar las nuevas opciones al menú contextual
            foreach (var rut in rutsEmpleados)
            {
                contextMenuStripWorker.Items.Add(rut);
            }
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (workerDgv.SelectedRows.Count > 0)
            {
                // Obtener el índice de la primera fila seleccionada
                int selectedIndex = workerDgv.SelectedRows[0].Index;

                // Obtener los datos del empleado de la fila seleccionada
                string employeeRut = workerDgv.Rows[selectedIndex].Cells["Rut_Empleado"].Value?.ToString();

                // Comprobar si la fila seleccionada tiene datos válidos
                if (string.IsNullOrWhiteSpace(employeeRut))
                {
                    // Si el "Rut_Empleado" está vacío o es nulo, probablemente la fila no tiene datos válidos.
                    MessageBox.Show("La fila seleccionada no contiene datos válidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si el "Rut_Empleado" es válido, procedemos a recoger el resto de la información.
                    string employeeNombre = workerDgv.Rows[selectedIndex].Cells["Nombre"].Value.ToString();
                    string employeeDireccion = workerDgv.Rows[selectedIndex].Cells["Direccion"].Value.ToString();
                    string employeeTelefono = workerDgv.Rows[selectedIndex].Cells["Telefono"].Value.ToString();
                    string employeeBruto = workerDgv.Rows[selectedIndex].Cells["Sueldo_Bruto"].Value.ToString();
                    string employeeLiquido = workerDgv.Rows[selectedIndex].Cells["Sueldo_Liquido"].Value.ToString();

                    // Crear una instancia de Form4
                    Form4 form4 = new Form4(this);  // Se crea una instancia de form4 pasando la instancia de form3
                    form4.Text = "Modificar Datos"; // Cambiar el nombre de la ventana
                    // Se guarda la clave primaria en una variable para saber que tupla modificar
                    form4.tuplamod = employeeRut;
                    // Establecer los valores de las TextBoxes en Form4
                    form4.RutText = employeeRut;
                    form4.NombreText = employeeNombre;
                    form4.DireccionText = employeeDireccion;
                    form4.TelefonoText = employeeTelefono;
                    form4.BrutoText = employeeBruto;
                    form4.LiquidoText = employeeLiquido;
                    if (modBtn.Text == "Cambiar Saldo")
                    {
                        form4.rutTxt.ReadOnly = true;
                        form4.nombreTxt.ReadOnly = true;
                        form4.direccionTxt.ReadOnly = true;
                        form4.telefonoTxt.ReadOnly = true;
                    }
                    // Mostrar Form4
                    form4.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para modificar.", "Ninguna fila seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void updateBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this); // Se pasa 'this' (Form3 actual) al constructor de Form4
            form4.Text = "Ingresar Datos"; // Cambiar el nombre de la ventana
            form4.saveBtn.Text = "Ingresar Datos"; // Cambiar el nombre del boton Guardar Cambios
            form4.ShowDialog(); // Mostrar el form4
        }

        public void OcultarBotonesAdministrativos()
        {
            // Cambiar texto del formulario
            this.Text = "Perfil del trabajador";
            // Ocultar etiqueta y botones de trabajadores, agregar y eliminar
            this.trabajadoresLabel.Visible = false;
            this.trabajadoresBtn.Visible = false;
            this.updateBtn.Visible = false;
            this.deleteBtn.Visible = false;

            // Deshabilitar botones de trabajadores, agregar y eliminar
            this.trabajadoresBtn.Enabled = false;
            this.updateBtn.Enabled = false;
            this.deleteBtn.Enabled = false;

            // Cambiar el nombre del botón de modificar
            this.modBtn.Text = "Cambiar Saldo";
            //Cambiar el tamaño y posicion del form y sus contenidos
            this.modBtn.Location = new Point(231, 80);
            this.workerDgv.Size = new Size(662, 46);
            this.workerDgv.Location = new Point(8, 15);
            this.Size = new Size(694, 170);

        }

    }
}
