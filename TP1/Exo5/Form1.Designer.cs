namespace Exo5
{
    partial class frmCalculInteret
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
            this.lbCapital = new System.Windows.Forms.Label();
            this.lbTaux = new System.Windows.Forms.Label();
            this.lbMTC = new System.Windows.Forms.Label();
            this.lbDuree = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtTaux = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtMTC = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.btnInitialisation = new System.Windows.Forms.Button();
            this.btnAide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCapital
            // 
            this.lbCapital.AutoSize = true;
            this.lbCapital.Location = new System.Drawing.Point(16, 43);
            this.lbCapital.Name = "lbCapital";
            this.lbCapital.Size = new System.Drawing.Size(39, 13);
            this.lbCapital.TabIndex = 0;
            this.lbCapital.Text = "Capital";
            // 
            // lbTaux
            // 
            this.lbTaux.AutoSize = true;
            this.lbTaux.Location = new System.Drawing.Point(16, 95);
            this.lbTaux.Name = "lbTaux";
            this.lbTaux.Size = new System.Drawing.Size(31, 13);
            this.lbTaux.TabIndex = 0;
            this.lbTaux.Text = "Taux";
            // 
            // lbMTC
            // 
            this.lbMTC.AutoSize = true;
            this.lbMTC.Location = new System.Drawing.Point(16, 199);
            this.lbMTC.Name = "lbMTC";
            this.lbMTC.Size = new System.Drawing.Size(84, 13);
            this.lbMTC.TabIndex = 0;
            this.lbMTC.Text = "Montant Calcule";
            // 
            // lbDuree
            // 
            this.lbDuree.AutoSize = true;
            this.lbDuree.Location = new System.Drawing.Point(16, 147);
            this.lbDuree.Name = "lbDuree";
            this.lbDuree.Size = new System.Drawing.Size(36, 13);
            this.lbDuree.TabIndex = 0;
            this.lbDuree.Text = "Duree";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(202, 35);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(108, 20);
            this.txtCapital.TabIndex = 1;
            this.txtCapital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapital_KeyPress);
            // 
            // txtTaux
            // 
            this.txtTaux.Location = new System.Drawing.Point(202, 88);
            this.txtTaux.Name = "txtTaux";
            this.txtTaux.Size = new System.Drawing.Size(108, 20);
            this.txtTaux.TabIndex = 3;
            this.txtTaux.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaux_KeyPress);
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(202, 141);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(108, 20);
            this.txtDuree.TabIndex = 5;
            this.txtDuree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuree_KeyPress);
            // 
            // txtMTC
            // 
            this.txtMTC.Enabled = false;
            this.txtMTC.Location = new System.Drawing.Point(202, 194);
            this.txtMTC.Name = "txtMTC";
            this.txtMTC.Size = new System.Drawing.Size(108, 20);
            this.txtMTC.TabIndex = 7;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(384, 33);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(75, 23);
            this.btnCalculer.TabIndex = 2;
            this.btnCalculer.Text = "&Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(384, 86);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 23);
            this.btnFin.TabIndex = 4;
            this.btnFin.Text = "&Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnInitialisation
            // 
            this.btnInitialisation.Location = new System.Drawing.Point(384, 139);
            this.btnInitialisation.Name = "btnInitialisation";
            this.btnInitialisation.Size = new System.Drawing.Size(75, 23);
            this.btnInitialisation.TabIndex = 6;
            this.btnInitialisation.Text = "&Initialisation";
            this.btnInitialisation.UseVisualStyleBackColor = true;
            this.btnInitialisation.Click += new System.EventHandler(this.btnInitialisation_Click);
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(384, 192);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(75, 23);
            this.btnAide.TabIndex = 8;
            this.btnAide.Text = "&Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // frmCalculInteret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.btnInitialisation);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.txtMTC);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.txtTaux);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.lbDuree);
            this.Controls.Add(this.lbMTC);
            this.Controls.Add(this.lbTaux);
            this.Controls.Add(this.lbCapital);
            this.Name = "frmCalculInteret";
            this.Text = "Calcul d\'intérêts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCapital;
        private System.Windows.Forms.Label lbTaux;
        private System.Windows.Forms.Label lbMTC;
        private System.Windows.Forms.Label lbDuree;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtTaux;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.TextBox txtMTC;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnInitialisation;
        private System.Windows.Forms.Button btnAide;
    }
}

