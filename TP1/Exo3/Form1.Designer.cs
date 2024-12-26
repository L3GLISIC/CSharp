namespace Exo3
{
    partial class frmPersonne
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
            this.ccbNom = new System.Windows.Forms.CheckBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.ccbPrenom = new System.Windows.Forms.CheckBox();
            this.txtLDN = new System.Windows.Forms.TextBox();
            this.ccbLDN = new System.Windows.Forms.CheckBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.ccbTel = new System.Windows.Forms.CheckBox();
            this.txtDDN = new System.Windows.Forms.TextBox();
            this.ccbDDN = new System.Windows.Forms.CheckBox();
            this.lstPersonne = new System.Windows.Forms.ListBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ccbNom
            // 
            this.ccbNom.AutoSize = true;
            this.ccbNom.Location = new System.Drawing.Point(17, 44);
            this.ccbNom.Name = "ccbNom";
            this.ccbNom.Size = new System.Drawing.Size(48, 17);
            this.ccbNom.TabIndex = 0;
            this.ccbNom.Text = "Nom";
            this.ccbNom.UseVisualStyleBackColor = true;
            this.ccbNom.CheckedChanged += new System.EventHandler(this.ccbNom_CheckedChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(138, 44);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(160, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(138, 80);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(160, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // ccbPrenom
            // 
            this.ccbPrenom.AutoSize = true;
            this.ccbPrenom.Location = new System.Drawing.Point(17, 80);
            this.ccbPrenom.Name = "ccbPrenom";
            this.ccbPrenom.Size = new System.Drawing.Size(62, 17);
            this.ccbPrenom.TabIndex = 2;
            this.ccbPrenom.Text = "Prénom";
            this.ccbPrenom.UseVisualStyleBackColor = true;
            this.ccbPrenom.CheckedChanged += new System.EventHandler(this.ccbPrenom_CheckedChanged);
            // 
            // txtLDN
            // 
            this.txtLDN.Location = new System.Drawing.Point(138, 152);
            this.txtLDN.Name = "txtLDN";
            this.txtLDN.Size = new System.Drawing.Size(160, 20);
            this.txtLDN.TabIndex = 7;
            // 
            // ccbLDN
            // 
            this.ccbLDN.AutoSize = true;
            this.ccbLDN.Location = new System.Drawing.Point(17, 152);
            this.ccbLDN.Name = "ccbLDN";
            this.ccbLDN.Size = new System.Drawing.Size(112, 17);
            this.ccbLDN.TabIndex = 6;
            this.ccbLDN.Text = "Lieu de naissance";
            this.ccbLDN.UseVisualStyleBackColor = true;
            this.ccbLDN.CheckedChanged += new System.EventHandler(this.ccbLDN_CheckedChanged);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(138, 188);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(160, 20);
            this.txtTel.TabIndex = 9;
            // 
            // ccbTel
            // 
            this.ccbTel.AutoSize = true;
            this.ccbTel.Location = new System.Drawing.Point(17, 188);
            this.ccbTel.Name = "ccbTel";
            this.ccbTel.Size = new System.Drawing.Size(41, 17);
            this.ccbTel.TabIndex = 8;
            this.ccbTel.Text = "Tél";
            this.ccbTel.UseVisualStyleBackColor = true;
            this.ccbTel.CheckedChanged += new System.EventHandler(this.ccbTel_CheckedChanged);
            // 
            // txtDDN
            // 
            this.txtDDN.Location = new System.Drawing.Point(138, 116);
            this.txtDDN.Name = "txtDDN";
            this.txtDDN.Size = new System.Drawing.Size(160, 20);
            this.txtDDN.TabIndex = 5;
            // 
            // ccbDDN
            // 
            this.ccbDDN.AutoSize = true;
            this.ccbDDN.Location = new System.Drawing.Point(17, 116);
            this.ccbDDN.Name = "ccbDDN";
            this.ccbDDN.Size = new System.Drawing.Size(115, 17);
            this.ccbDDN.TabIndex = 4;
            this.ccbDDN.Text = "Date de naissance";
            this.ccbDDN.UseVisualStyleBackColor = true;
            this.ccbDDN.CheckedChanged += new System.EventHandler(this.ccbDDN_CheckedChanged);
            // 
            // lstPersonne
            // 
            this.lstPersonne.FormattingEnabled = true;
            this.lstPersonne.Location = new System.Drawing.Point(17, 233);
            this.lstPersonne.Name = "lstPersonne";
            this.lstPersonne.Size = new System.Drawing.Size(281, 121);
            this.lstPersonne.TabIndex = 10;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(107, 376);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 11;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 463);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lstPersonne);
            this.Controls.Add(this.txtDDN);
            this.Controls.Add(this.ccbDDN);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.ccbTel);
            this.Controls.Add(this.txtLDN);
            this.Controls.Add(this.ccbLDN);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.ccbPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.ccbNom);
            this.Name = "frmPersonne";
            this.Text = "Gestion Personne";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ccbNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.CheckBox ccbPrenom;
        private System.Windows.Forms.TextBox txtLDN;
        private System.Windows.Forms.CheckBox ccbLDN;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.CheckBox ccbTel;
        private System.Windows.Forms.TextBox txtDDN;
        private System.Windows.Forms.CheckBox ccbDDN;
        private System.Windows.Forms.ListBox lstPersonne;
        private System.Windows.Forms.Button btnQuitter;
    }
}

