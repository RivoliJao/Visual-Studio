using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int n1, n2;
        private void btnVer_Click(object sender, EventArgs e)
        {
            n1=int.Parse(txtN1.Text);
            n2=int.Parse(txtn2.Text);
            if (n1 > n2)
            {
                txtMaior.Text=n1.ToString(); 
            }
            else
            {
                txtMaior.Text=n2.ToString();
            }


        }
    }
}
