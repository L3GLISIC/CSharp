using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo10
{
    public partial class frmCompare : Form
    {
        public frmCompare()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerifier_Click(object sender, EventArgs e)
        {
            if(txtA.Text != string.Empty && txtB.Text != string.Empty)
            {
                string msg = "";
                int max;
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                if(a > b)
                {
                    max = a;
                }else if(b > a)
                {
                    max = b;
                }
                else
                {
                    msg = "Les deux valeurs sont egaux.";
                    return;
                }
                msg = $"La valeur la plus grande est {max}.";
                MessageBox.Show(msg);
            }
        }
    }
}
