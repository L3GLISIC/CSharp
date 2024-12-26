using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo5
{
    public partial class frmCalculInteret : Form
    {
        public frmCalculInteret()
        {
            InitializeComponent();
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            frmAide aideForm = new frmAide();
            aideForm.Show();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            double resultat = 0;
            if (!string.IsNullOrWhiteSpace(txtCapital.Text) &&
        !string.IsNullOrWhiteSpace(txtTaux.Text) &&
        !string.IsNullOrWhiteSpace(txtDuree.Text))
            {
                try
                {
                    // Convertir les valeurs entrées
                    double capital = double.Parse(txtCapital.Text);
                    double taux = double.Parse(txtTaux.Text) / 100; // Diviser le taux par 100
                    int duree = int.Parse(txtDuree.Text);

                    // Calculer le montant total cumulé
                    resultat = capital * Math.Pow(1 + taux, duree);

                    // Afficher le résultat dans txtMTC
                    txtMTC.Text = resultat.ToString("F2"); // Formater en deux décimales
                }
                catch (FormatException)
                {
                    MessageBox.Show("Veuillez entrer des valeurs valides.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtTaux_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Vérifier si un point décimal existe déjà
            if (e.KeyChar == '.' && ((sender as TextBox).Text.Contains(".")))
            {
                e.Handled = true; // Empêcher d'ajouter un second point décimal
            }
        }

        private void txtDuree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInitialisation_Click(object sender, EventArgs e)
        {
            txtCapital.Text = string.Empty;
            txtTaux.Text = string.Empty;
            txtDuree.Text = string.Empty;
            txtMTC.Text = string.Empty;
        }
    }
}
