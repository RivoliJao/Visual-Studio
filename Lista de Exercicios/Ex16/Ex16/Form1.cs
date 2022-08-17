using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1, n2, n3, media;
        private void btnResuldado_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);

            media = (n1 + n2 + n3) / 3;
            
            if (media >= 7)
            {
                txtSituacao.Text = ("Aprovado");
            }
            else
            {
                if (media >= 5.1 && media <= 6.9)
                {
                    txtSituacao.Text = ("Recuperação");
                }
                else
                {
                    txtSituacao.Text = ("Reprovado");
                }
                                          
            } 

        }
    }
}
