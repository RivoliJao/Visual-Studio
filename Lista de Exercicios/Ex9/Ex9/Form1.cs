using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double valor,taxa,final;
        private void btnFunção_Click(object sender, EventArgs e)
        {
            valor = double.Parse(txtValor.Text);
            taxa = valor * 7/1000;
            final = taxa + valor;
            txtFinal.Text = final.ToString();
        }
    }
}
