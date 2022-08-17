using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string f,m;
        int contM, contF;
        private void btn_Click(object sender, EventArgs e)
        {
           
            if ( txtSexo.Text == "m")
            {
                contM = contM + 1;
                txtMasculino.Text = contM.ToString();
            }
            else
            {
                contF = contF + 1;
                txtfeminino.Text = contF.ToString();
            }
            txtNome.Clear();
            txtSexo.Clear();
        }
    }
}
