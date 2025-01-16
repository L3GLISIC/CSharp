using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo11
{
    public partial class frmCalcule : Form
    {
        public frmCalcule()
        {
            InitializeComponent();
        }

        private void frmCalcule_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            if(txtCA.Text != string.Empty)
            {
                int ca = int.Parse(txtCA.Text);
                int sm = int.Parse(txtSal.Text);
                double commission = 0;
                if(ca >= 0 && ca <= 1000)
                {
                    commission = ca * 0.05;
                }else if(ca <= 3000)
                {
                    commission = ca * 0.1;
                }
                else if(ca > 3000)
                {
                    commission = ca * 0.014;
                }
                double mtt = sm + commission;
                txtMT.Text = mtt.ToString();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
