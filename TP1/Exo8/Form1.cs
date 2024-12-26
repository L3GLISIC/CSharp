using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo8
{
    public partial class frmAnalyse : Form
    {
        public frmAnalyse()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtChaine.Text = string.Empty;
            txtMessage.Text = string.Empty;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResultat_Click(object sender, EventArgs e)
        {
            if(txtChaine.Text != string.Empty)
                
            {
                string chaine = txtChaine.Text.ToUpper();
                int n = 0;
                if(cbbType.SelectedItem != null)
                {
                    if (cbbType.SelectedItem.ToString() == "Consonnes")
                    {

                        foreach (char c in chaine)
                        {
                            if (!"AEIOU".Contains(c) && char.IsLetter(c))
                            {
                                n++;
                            }
                        }
                        txtMessage.Text = "Il y a " + n + " consonnes.";
                    }
                    else if (cbbType.SelectedItem.ToString() == "Voyelles")
                    {
                        foreach (char c in chaine)
                        {
                            if ("AEIOU".Contains(c) && char.IsLetter(c)) 
                            {
                                n++;
                            }
                        }
                        txtMessage.Text = "Il y a " + n + " voyelles.";

                    }
                }
            }
        }
    }
}
