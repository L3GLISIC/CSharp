using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo4
{
    public partial class frmSaisieText : Form
    {
        public frmSaisieText()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCliquer_Click(object sender, EventArgs e)
        {
            txtSaisie.Visible = false;
            lbText.Visible = false;
            string text = "Bienvenue " + txtSaisie.Text;
            txtMessage.Visible = true;
            txtMessage.Text = text;
            txtSaisie.Text = string.Empty;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
