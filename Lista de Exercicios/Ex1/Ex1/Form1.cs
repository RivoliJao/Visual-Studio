using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }
        int n1, n2, resultado;

        private void txtN2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);
            resultado = n1 + n2  ;
            txtResultado.visor = resultado.ToString();
        }
    }
}
