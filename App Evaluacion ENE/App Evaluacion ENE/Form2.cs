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
            if (int.TryParse(trabajadasTxt.Text, out int horasTrabajadas) && int.TryParse(extraTxt.Text, out int horasExtras))
            {
                // Calcular y mostrar el sueldo bruto
                double sueldoBruto = CalculadoraSueldo.CalcularSueldoBruto(horasTrabajadas, horasExtras);
                brutoTxt.Text = sueldoBruto.ToString("C");

                // Suponiendo que el tipo de AFP y Salud están seleccionados mediante contextMenuStrip1 y contextMenuStrip2
                // Necesitaríamos más detalles sobre cómo se seleccionan para ajustar este código
                string tipoAfp = "CUPRUM"; // Reemplazar con la lógica de selección de AFP
                string tipoSalud = "FONASA"; // Reemplazar con la lógica de selección de Salud

                // Calcular descuentos y bonos
                double descuentoAfp = Descuentos.CalcularDescuentoAFP(tipoAfp, sueldoBruto);
                double descuentoSalud = Descuentos.CalcularDescuentoSalud(tipoSalud, sueldoBruto);
                double bonoMarzo = BonoMarzo.CalcularBono(sueldoBruto);

                // Calcular y mostrar el sueldo líquido
                double sueldoLiquido = sueldoBruto - descuentoAfp - descuentoSalud + bonoMarzo;
                liquidoTxt.Text = sueldoLiquido.ToString("C");
            }
            else
            {
                // Manejo de errores si las conversiones fallaron
                MessageBox.Show("Los valores en 'Horas Trabajadas' y/o 'Horas Extras' no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
