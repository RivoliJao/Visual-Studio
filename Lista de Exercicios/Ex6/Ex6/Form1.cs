﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n1, n2, n3;
        private void button1_Click(object sender, EventArgs e)
        {
            n1= int.Parse(txtA.Text);
            n2= int.Parse(txtB.Text);
            n3 = n1;
            n1 = n2;
            n2 = n3;
            txtAB.Text = n1.ToString();
            txtBA.Text = n2.ToString();
        }
    }
}
