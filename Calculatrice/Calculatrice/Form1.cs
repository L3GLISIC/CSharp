using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class frmCalculatrice : Form
    {
        public frmCalculatrice()
        {
            InitializeComponent();
            AddButtons();
        }

        private double nombrePrec = 0;
        private double resultat = 0;
        private string operateur = string.Empty;


        private void Btn_Click(object sender, EventArgs e)
        {
            if (!(sender is Button btn))
                return;

            string buttonText = btn.Text;
            // Gestion des chiffres
            if (double.TryParse(buttonText, out double nombre))
            {
                TraiterNombre(nombre);
                return;
            }

            //if(buttonText == ".")
            //{
            //    lblSaisie.Text += buttonText;
            //    return;
            //}
            switch (buttonText)
            {
                case "+":
                case "-":
                case "*":
                case "÷":
                case "%":
                    TraiterOperateur(buttonText);
                    break;
                case "=":
                    CalculerResultat();
                    lblSaisie.Text = string.Empty;
                    break;
                case "AC":
                    ReinitialiserCalculatrice();
                    break;
                case "+/-":
                    InverserSigne();
                    break;
            }
        }

        private void TraiterNombre(double nombre)
        {
            nombrePrec = nombrePrec * 10 + nombre;
            lblSaisie.Text += nombre.ToString();
        }

        private void TraiterOperateur(string nouvelOperateur)
        {
            if (resultat == 0)
            {
                resultat = nombrePrec;
            }
            else if (nombrePrec != 0)
            {
                CalculerResultat();
            }

            operateur = nouvelOperateur;
            nombrePrec = 0;
            lblSaisie.Text += " " + nouvelOperateur + " ";
            lblResultat.Text = resultat.ToString();
        }

        private void CalculerResultat()
        {
            try
            {
                switch (operateur)
                {
                    case "+":
                        resultat += nombrePrec;
                        break;
                    case "-":
                        resultat -= nombrePrec;
                        break;
                    case "*":
                        resultat *= nombrePrec;
                        break;
                    case "÷":
                        if (nombrePrec == 0)
                            throw new DivideByZeroException("Division par zéro impossible");
                        resultat /= nombrePrec;
                        break;
                    case "%":
                        if (nombrePrec == 0)
                            throw new DivideByZeroException("Modulo par zéro impossible");
                        resultat %= nombrePrec;
                        break;
                }

                lblResultat.Text = resultat.ToString();
                //lblSaisie.Text = string.Empty;
                nombrePrec = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReinitialiserCalculatrice();
            }
        }

        private void ReinitialiserCalculatrice()
        {
            lblResultat.Text = string.Empty;
            lblSaisie.Text = string.Empty;
            resultat = 0;
            nombrePrec = 0;
            operateur = string.Empty;
        }


        private void InverserSigne()
        {
            if (nombrePrec != 0)
            {
                nombrePrec = -nombrePrec;
                string affichage = lblSaisie.Text;
                lblSaisie.Text = affichage.Substring(0, affichage.Length - nombrePrec.ToString().Length) + nombrePrec.ToString();
            }
        }

    }
}
