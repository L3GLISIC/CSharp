using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo3
{
    public partial class frmPersonne : Form
    {
        public frmPersonne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ccbNom_CheckedChanged(object sender, EventArgs e)
        {
            if (ccbNom.Checked)
            {
                lstPersonne.Items.Add(txtNom.Text);
            }
            else
            {
                lstPersonne.Items.Remove(txtNom.Text);
                txtNom.Text = string.Empty;
            }
        }
        private void ccbPrenom_CheckedChanged(object sender, EventArgs e)
        {
            if (ccbPrenom.Checked)
            {
                lstPersonne.Items.Add(txtPrenom.Text);
            }
            else
            {
                lstPersonne.Items.Remove(txtPrenom.Text);
                txtPrenom.Text = string.Empty;
            }
        }

        private void ccbDDN_CheckedChanged(object sender, EventArgs e)
        {
            if (ccbDDN.Checked)
            {
                lstPersonne.Items.Add(txtDDN.Text);
            }
            else
            {
                lstPersonne.Items.Remove(txtDDN.Text);
                txtDDN.Text = string.Empty;
            }
        }

        


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ccbLDN_CheckedChanged(object sender, EventArgs e)
        {
            if (ccbLDN.Checked)
            {
                lstPersonne.Items.Add(txtLDN.Text);
            }
            else
            {
                lstPersonne.Items.Remove(txtLDN.Text);
                txtLDN.Text = string.Empty;
            }
        }

        private void ccbTel_CheckedChanged(object sender, EventArgs e)
        {
            if (ccbTel.Checked)
            {
                lstPersonne.Items.Add(txtTel.Text);
            }
            else
            {
                lstPersonne.Items.Remove(txtTel.Text);
                txtTel.Text = string.Empty;
            }
        }
    }
}
