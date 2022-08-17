using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double F, D, I, P;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            F = double.Parse(txtFabrica.Text);
            D = F * 28 / 100;
            I = F * 45 / 100;
            P = F + D + I;
            txtDistribuidor.Text = D.ToString();
            txtImposto.Text = I.ToString();
            txtPreco.Text= P.ToString();
        }
    }
}
