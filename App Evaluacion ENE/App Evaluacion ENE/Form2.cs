using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Evaluacion_ENE
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(saludBtn, new Point(0, calcularBtn.Height));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(afpBtn, new Point(0, calcularBtn.Height));
        }

        private void trabajadasTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void extraTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {

        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            // Intentamos analizar el valor de trabajadasTxt
            if (int.TryParse(trabajadasTxt.Text, out int horasTrabajadas))
            {
                // La conversión fue exitosa, asignamos el valor
                // Aquí puedes realizar los cálculos o acciones que desees
            }
            else
            {
                // La conversión falló, asignamos "ERROR!" y mostramos un mensaje de error
                trabajadasTxt.Text = "ERROR!";
                MessageBox.Show("El valor en 'Horas Trabajadas' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Hacemos lo mismo para extraTxt
            if (int.TryParse(extraTxt.Text, out int horasExtras))
            {
                // La conversión fue exitosa, asignamos el valor
                // Aquí puedes realizar los cálculos o acciones que desees
            }
            else
            {
                // La conversión falló, asignamos "ERROR!" y mostramos un mensaje de error
                extraTxt.Text = "ERROR!";
                MessageBox.Show("El valor en 'Horas Extras' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            // Borra el contenido de los TextBox
            liquidoTxt.Text = string.Empty;
            brutoTxt.Text = string.Empty;
            extraTxt.Text = string.Empty;
            trabajadasTxt.Text = string.Empty;
        }

        private void brutoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void liquidoTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
