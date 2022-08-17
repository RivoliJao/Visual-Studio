using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double F, C;
        private void btn_Click(object sender, EventArgs e)
        {
            C = double.Parse(txtC.Text);
            F = (9 * C + 160) / 5;
            txtF.Text = F.ToString();
        }
    }
}
