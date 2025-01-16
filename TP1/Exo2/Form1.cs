using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo2
{
    public partial class frmVille : Form
    {
        public frmVille()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            cbbVille.Items.Add(cbbVille.Text);
            cbbVille.Text = string.Empty;
            cbbVille.Focus();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            cbbVille.Items.RemoveAt(cbbVille.SelectedIndex);
            cbbVille.Text = string.Empty;
            cbbVille.Focus();
        }

        private void btnToutSupprimer_Click(object sender, EventArgs e)
        {
            cbbVille.Items.Clear();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
