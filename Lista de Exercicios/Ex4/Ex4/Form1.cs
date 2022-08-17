using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double venda,fixo,vendas,soma;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            venda = int.Parse(txtVendas.Text);
            fixo = int.Parse(txtFixo.Text);
            vendas = venda * 15 / 100;
            soma = fixo + vendas;
            txtFim.Text = soma.ToString();

        }
    }
}
