namespace Exo6
{
    partial class frmColor
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
            this.rbRouge = new System.Windows.Forms.RadioButton();
            this.rbBleu = new System.Windows.Forms.RadioButton();
            this.rbVert = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbRouge
            // 
            this.rbRouge.AutoSize = true;
            this.rbRouge.BackColor = System.Drawing.SystemColors.Info;
            this.rbRouge.Location = new System.Drawing.Point(68, 38);
            this.rbRouge.Name = "rbRouge";
            this.rbRouge.Size = new System.Drawing.Size(57, 17);
            this.rbRouge.TabIndex = 0;
            this.rbRouge.TabStop = true;
            this.rbRouge.Text = "Rouge";
            this.rbRouge.UseVisualStyleBackColor = false;
            this.rbRouge.CheckedChanged += new System.EventHandler(this.rbRouge_CheckedChanged);
            // 
            // rbBleu
            // 
            this.rbBleu.AutoSize = true;
            this.rbBleu.BackColor = System.Drawing.SystemColors.Info;
            this.rbBleu.Location = new System.Drawing.Point(68, 120);
            this.rbBleu.Name = "rbBleu";
            this.rbBleu.Size = new System.Drawing.Size(46, 17);
            this.rbBleu.TabIndex = 1;
            this.rbBleu.TabStop = true;
            this.rbBleu.Text = "Bleu";
            this.rbBleu.UseVisualStyleBackColor = false;
            this.rbBleu.CheckedChanged += new System.EventHandler(this.rbBleu_CheckedChanged);
            // 
            // rbVert
            // 
            this.rbVert.AutoSize = true;
            this.rbVert.BackColor = System.Drawing.SystemColors.Info;
            this.rbVert.Location = new System.Drawing.Point(68, 79);
            this.rbVert.Name = "rbVert";
            this.rbVert.Size = new System.Drawing.Size(44, 17);
            this.rbVert.TabIndex = 2;
            this.rbVert.TabStop = true;
            this.rbVert.Text = "Vert";
            this.rbVert.UseVisualStyleBackColor = false;
            this.rbVert.CheckedChanged += new System.EventHandler(this.rbVert_CheckedChanged);
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 187);
            this.Controls.Add(this.rbVert);
            this.Controls.Add(this.rbBleu);
            this.Controls.Add(this.rbRouge);
            this.Name = "frmColor";
            this.Text = "Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRouge;
        private System.Windows.Forms.RadioButton rbBleu;
        private System.Windows.Forms.RadioButton rbVert;
    }
}

