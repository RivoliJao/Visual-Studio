using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            n =int.Parse(txtN.Text);
            
            if(n > 10)
            {
                txtResposta.Text = "O numero e valido!!";
            }
            else
            {
                txtResposta.Text = "O numero é invalido!!";
            }
        }
    }
}
