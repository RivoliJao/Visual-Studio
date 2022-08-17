using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n;
        private void btn_Click(object sender, EventArgs e)
        {
            n = double.Parse(txtN.Text);

            if (n <= 150 && n >= 10)
            {
                
                txtVerificado.Text = txtVerificado.Text+ n.ToString()+ ",";
            }
            else
            {
               
            }
        }
    }
}
