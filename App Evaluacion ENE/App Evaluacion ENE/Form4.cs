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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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
            MessageBox.Show("Para ingresar valores debe presionar el botón \"Calcular Saldo\".", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sLiquidoTxt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para ingresar valores debe presionar el botón \"Calcular Saldo\".", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de guardar estos cambios?", "Guardar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
