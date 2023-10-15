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
