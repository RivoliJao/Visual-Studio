using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }
        double n1, n2, soma, divisao, subtracao, multiplicacao;
        private void btnResultado_Click(object sender, EventArgs e)
        {
            n1= int.Parse(txtN1.Text);
            n2= int.Parse(txtN2.Text);
            soma = n1 + n2;
            subtracao = n1 - n2;
            divisao = n1/n2;
            multiplicacao = n1*n2;

            txtSoma.Text = soma.ToString();
            txtSubtracao.Text = subtracao.ToString();
            txtDivisao.Text = divisao.ToString();
            txtMultiplicacao.Text = multiplicacao.ToString();

        }
    }
}
