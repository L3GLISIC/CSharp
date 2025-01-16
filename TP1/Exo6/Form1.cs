using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo6
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void rbRouge_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRouge.Checked )
            {
                rbRouge.BackColor = Color.Red;
            }
            else
            {
                rbRouge.BackColor = Color.Yellow;
            }
        }

        private void rbVert_CheckedChanged(object sender, EventArgs e)
        {
            if(rbVert.Checked)
            {
                rbVert.BackColor = Color.Green;
            }
            else
            {
                rbVert.BackColor = Color.Yellow;
            }
        }

        private void rbBleu_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBleu.Checked)
            {
                rbBleu.BackColor = Color.Blue;
            }
            else
            {
                rbBleu.BackColor= Color.Yellow;
            }
        }
    }
}
