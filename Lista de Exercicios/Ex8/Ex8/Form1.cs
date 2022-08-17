using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double dolar, real, cota;
        private void btnConversao_Click(object sender, EventArgs e)
        {
            dolar = double.Parse(txtDolar.Text);
            cota =double.Parse(txtCota.Text);
            real = dolar * cota;
            txtReal.Text = real.ToString();

        }
    }
}
