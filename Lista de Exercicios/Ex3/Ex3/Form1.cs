using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, n2, media;
        private void btnMedia_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtKm.Text);
            n2 = int.Parse(txtL.Text);
            media = n1/n2;
            txtMedia.Text = media.ToString();
        }
    }
}
