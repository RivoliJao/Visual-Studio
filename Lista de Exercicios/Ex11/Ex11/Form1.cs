﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valor, taxa, valorfinal,taxafinal;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            valor=double.Parse(txtValor.Text);
            taxa=double.Parse(txtTaxa.Text);
            taxafinal= valor*taxa / 100;
            valorfinal = valor + taxafinal;
            txtValorFinal.Text = valorfinal.ToString();
        }
    }
}
