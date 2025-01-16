using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo1
{
    public partial class frmVille : Form
    {
        public frmVille()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lstVille.Items.Add(txtVille.Text);
            txtVille.Text = string.Empty;
            txtVille.Focus();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            lstVille.Items.RemoveAt(lstVille.SelectedIndex);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
