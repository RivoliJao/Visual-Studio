using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, n2, n3, media;
        private void btnMedia_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtNota1.Text);
            n2 = double.Parse(txtNota2.Text);  
            n3 = double.Parse(txtNota3.Text);
            media = (n1 + n2 + n3) / 3;
            txtMedia.Text = media.ToString();
           

        }
    }
}
