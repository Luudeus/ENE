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
    public partial class Form2 : Form
    {
        private Form4 form4Instance;
        public Form2(Form4 form4)
        {
            InitializeComponent();
            contextMenuStripAFP.ItemClicked += contextMenuStripAFP_ItemClicked;
            contextMenuStripSalud.ItemClicked += contextMenuStripSalud_ItemClicked;
            form4Instance = form4;

        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            // No necesitas crear una nueva instancia de Form4. Usa la que pasaste al constructor.
            form4Instance.BrutoText = brutoTxt.Text;
            form4Instance.LiquidoText = liquidoTxt.Text;
        }



        private void calcularBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(trabajadasTxt.Text, out int horasTrabajadas) && int.TryParse(extraTxt.Text, out int horasExtras))
            {
                // Calcular el sueldo bruto
                double sueldoBruto = CalculadoraSueldo.CalcularSueldoBruto(horasTrabajadas, horasExtras);

                // Obtener el tipo de AFP y Salud de los textos de los botone
                string tipoAfp = afpBtn.Text;
                string tipoSalud = saludBtn.Text;

                // Calcular descuentos y bonos
                double descuentoAfp = Descuentos.CalcularDescuentoAFP(tipoAfp, sueldoBruto);
                double descuentoSalud = Descuentos.CalcularDescuentoSalud(tipoSalud, sueldoBruto);

                // Calcular el sueldo líquido
                double sueldoLiquido = sueldoBruto - descuentoAfp - descuentoSalud;
                // Mostrar ambos sueldos
                brutoTxt.Text = sueldoBruto.ToString("C");
                liquidoTxt.Text = sueldoLiquido.ToString("C");
            }
            else
            {
                // Manejo de errores si las conversiones fallaron
                MessageBox.Show("Los valores en 'Horas Trabajadas' y/u 'Horas Extras' no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            // Borrar el contenido de los TextBox
            liquidoTxt.Text = string.Empty;
            brutoTxt.Text = string.Empty;
            extraTxt.Text = string.Empty;
            trabajadasTxt.Text = string.Empty;
        }

        private void contextMenuStripAFP_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            afpBtn.Text = e.ClickedItem.Text;
            contextMenuStripAFP.Close();
        }

        private void contextMenuStripSalud_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            saludBtn.Text = e.ClickedItem.Text;
            contextMenuStripSalud.Close();
        }

        private void afpBtn_Click(object sender, EventArgs e)
        {
            contextMenuStripAFP.Show(afpBtn, new Point(0, afpBtn.Height));
        }

        private void saludBtn_Click(object sender, EventArgs e)
        {
            contextMenuStripSalud.Show(saludBtn, new Point(0, saludBtn.Height));
        }
    }
}
