using System.Drawing;
using System.Windows.Forms;

namespace Calculatrice
{
    partial class frmCalculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblSaisie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultat
            // 
            this.lblResultat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblResultat.Location = new System.Drawing.Point(7, 7);
            this.lblResultat.Margin = new System.Windows.Forms.Padding(0);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(360, 60);
            this.lblResultat.TabIndex = 0;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaisie
            // 
            this.lblSaisie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaisie.ForeColor = System.Drawing.Color.White;
            this.lblSaisie.Location = new System.Drawing.Point(7, 67);
            this.lblSaisie.Margin = new System.Windows.Forms.Padding(0);
            this.lblSaisie.Name = "lblSaisie";
            this.lblSaisie.Size = new System.Drawing.Size(360, 60);
            this.lblSaisie.TabIndex = 1;
            this.lblSaisie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCalculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(374, 611);
            this.Controls.Add(this.lblSaisie);
            this.Controls.Add(this.lblResultat);
            this.Name = "frmCalculatrice";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Ajouter les boutons dans le formulaire.
        /// </summary>
        private void AddButtons()
        {
            int startX = 10;
            int startY = 150;
            int buttonSize = 80;
            int spacing = 10;

            string[,] buttons = {
                {"AC", "+/-", "%", "÷"},
                {"7", "8", "9", "*"},
                {"4", "5", "6", "-"},
                {"1", "2", "3", "+"},
                {"0", "", ".", "="}
            };

            Color[,] colors = {
                {Color.LightGray, Color.LightGray, Color.LightGray, Color.Orange},
                {Color.DimGray, Color.DimGray, Color.DimGray, Color.Orange},
                {Color.DimGray, Color.DimGray, Color.DimGray, Color.Orange},
                {Color.DimGray, Color.DimGray, Color.DimGray, Color.Orange},
                {Color.DimGray, Color.DimGray, Color.DimGray, Color.Orange}
            };

            for (int row = 0; row < buttons.GetLength(0); row++)
            {
                for (int col = 0; col < buttons.GetLength(1); col++)
                {
                    if (string.IsNullOrEmpty(buttons[row, col])) continue;
                    int x = startX + col * (buttonSize + spacing);
                    int y = startY + row * (buttonSize + spacing);

                    Button btn = new Button
                    {
                        Text = buttons[row, col],
                        Size = new Size(buttonSize, buttonSize),
                        Location = new Point(x, y),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = colors[row, col],
                        ForeColor = colors[row, col] == Color.Orange ? Color.White : Color.Black,
                        Font = new Font("Arial Rounded MT Bold", 20),
                        Name = $"btn{row}{col}"
                    };

                    if (buttons[row, col] == "0")
                    {
                        btn.Size = new Size(buttonSize * 2 + spacing, buttonSize);
                        col++; 
                    }

                    btn.Click += Btn_Click;

                    this.Controls.Add(btn);
                }
            }
        }


        #endregion

        private System.Windows.Forms.Label lblResultat;
        private Label lblSaisie;
    }
}

