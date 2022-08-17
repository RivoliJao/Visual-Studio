using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        private void btn_Click(object sender, EventArgs e)
        {
            n = int.Parse(txtN.Text);

            if (n >= 18)
            {
                txtVerificado.Text = "Maior de idade";
            }
            else
            {
                txtVerificado.Text = "Menor de idade";
            }
        }
    }
}
