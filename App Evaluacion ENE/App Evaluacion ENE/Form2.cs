﻿using System;
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
            contextMenuStrip1.Show(saludBtn, new Point(0, button1.Height));
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(afpBtn, new Point(0, button1.Height));
        }
    }
}
