namespace Exo4
{
    partial class frmSaisieText
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
            this.lbText = new System.Windows.Forms.Label();
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.btnCliquer = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.Location = new System.Drawing.Point(45, 79);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(141, 32);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Entrer votre nom et \r\nprénom SVP ";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbText.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSaisie
            // 
            this.txtSaisie.Location = new System.Drawing.Point(203, 90);
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(216, 20);
            this.txtSaisie.TabIndex = 1;
            // 
            // btnCliquer
            // 
            this.btnCliquer.Location = new System.Drawing.Point(111, 215);
            this.btnCliquer.Name = "btnCliquer";
            this.btnCliquer.Size = new System.Drawing.Size(85, 33);
            this.btnCliquer.TabIndex = 2;
            this.btnCliquer.Text = "&Cliquez";
            this.btnCliquer.UseVisualStyleBackColor = true;
            this.btnCliquer.Click += new System.EventHandler(this.btnCliquer_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(254, 215);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(85, 33);
            this.btnFin.TabIndex = 3;
            this.btnFin.Text = "&Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(48, 165);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(371, 20);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Visible = false;
            // 
            // frmSaisieText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 273);
            this.ControlBox = false;
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnCliquer);
            this.Controls.Add(this.txtSaisie);
            this.Controls.Add(this.lbText);
            this.Name = "frmSaisieText";
            this.Text = "Saisie Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.Button btnCliquer;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

