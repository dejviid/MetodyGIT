﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodyGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text.ToString());
            double b = Convert.ToInt32(textBox2.Text.ToString());
            double soucin = a * b;
            MessageBox.Show("Soucin je: " + soucin.ToString());
        }
    }
}
