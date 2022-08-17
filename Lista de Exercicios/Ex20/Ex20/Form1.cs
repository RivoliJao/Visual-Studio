using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valor, ano, desconto, valorFinal;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtBruto.Text);
            ano = double.Parse(txtAno.Text);
            if (ano <= 2000)
            {
                desconto = valor * 12 / 100;
                valorFinal = valor - desconto;
                labDesconto.Text = desconto.ToString();
                labPreco.Text = valorFinal.ToString();
            }
            else
            {
                desconto = valor * 7 / 100;
                valorFinal = valor - desconto;
                labDesconto.Text = desconto.ToString();
                labPreco.Text = valorFinal.ToString();
            }
        }
    }
}
