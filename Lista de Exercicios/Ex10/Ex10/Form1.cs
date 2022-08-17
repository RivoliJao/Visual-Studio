using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valor, prestacao;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtValor.Text);
            prestacao = valor / 5;

            txtPrestacao.Text = prestacao.ToString(); 
        }
    }
}
