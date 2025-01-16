using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo7
{
    public partial class frmEquation : Form
    {
        public frmEquation()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void effacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
            lstResultat.Items.Clear();

        }

        private void quitterF3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmEquation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                Application.Exit();
            }
        }

        private void mn1erDegre_Click(object sender, EventArgs e)
        {
            txtC.Enabled = false;

        }

        private void mn2emDegre_Click(object sender, EventArgs e)
        {
            txtC.Enabled = true;
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            if(txtC.Text == string.Empty)
            {
                double x = int.Parse(txtB.Text) / int.Parse(txtA.Text);
                lstResultat.Items.Add(x);
            }
            else
            {
                int b = int.Parse(txtB.Text);
                int a = int.Parse(txtA.Text);
                int c = int.Parse(txtC.Text);
                double delta = Math.Pow(-b,2) - 4 * a *  c;
                string rs = "";
                if(delta > 0)
                {
                    double x1 = (-(b) - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-(b) + Math.Sqrt(delta)) / (2 * a);
                    rs = "x1=" + x1 + "; x2=" + x2 + ".";
                }
                else if(delta == 0)
                {
                    double x0 = -b / 2 * a;
                    rs = "x0=" + x0 +".";

                }
                else
                {
                     rs = "L'equation n'admet pas de solution dans R.";
                }

                lstResultat.Items.Add(rs);
            }
        }

        private void mnDate_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(dateTime.ToString("dd/MM/yyyy"), "Date du jour");
        }

        private void mnHeure_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(dateTime.ToShortTimeString(), "Heure");
        }
    }
}
