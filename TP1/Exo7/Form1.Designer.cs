namespace Exo7
{
    partial class frmEquation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEffacer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.equationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1erDegre = new System.Windows.Forms.ToolStripMenuItem();
            this.mn2emDegre = new System.Windows.Forms.ToolStripMenuItem();
            this.mn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHeure = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstResultat = new System.Windows.Forms.ListBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.equationToolStripMenuItem,
            this.mn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEffacer,
            this.mnQuitter});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // mnEffacer
            // 
            this.mnEffacer.Name = "mnEffacer";
            this.mnEffacer.Size = new System.Drawing.Size(180, 22);
            this.mnEffacer.Text = "&Effacer";
            this.mnEffacer.Click += new System.EventHandler(this.effacerToolStripMenuItem_Click);
            // 
            // mnQuitter
            // 
            this.mnQuitter.Name = "mnQuitter";
            this.mnQuitter.Size = new System.Drawing.Size(180, 22);
            this.mnQuitter.Text = "&Quitter F3";
            this.mnQuitter.Click += new System.EventHandler(this.quitterF3ToolStripMenuItem_Click);
            // 
            // equationToolStripMenuItem
            // 
            this.equationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn1erDegre,
            this.mn2emDegre});
            this.equationToolStripMenuItem.Name = "equationToolStripMenuItem";
            this.equationToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.equationToolStripMenuItem.Text = "Equation";
            // 
            // mn1erDegre
            // 
            this.mn1erDegre.Name = "mn1erDegre";
            this.mn1erDegre.Size = new System.Drawing.Size(180, 22);
            this.mn1erDegre.Text = "&1er degré";
            this.mn1erDegre.Click += new System.EventHandler(this.mn1erDegre_Click);
            // 
            // mn2emDegre
            // 
            this.mn2emDegre.Name = "mn2emDegre";
            this.mn2emDegre.Size = new System.Drawing.Size(180, 22);
            this.mn2emDegre.Text = "&2em degré";
            this.mn2emDegre.Click += new System.EventHandler(this.mn2emDegre_Click);
            // 
            // mn
            // 
            this.mn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDate,
            this.mnHeure});
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(82, 20);
            this.mn.Text = "Information";
            // 
            // mnDate
            // 
            this.mnDate.Name = "mnDate";
            this.mnDate.Size = new System.Drawing.Size(180, 22);
            this.mnDate.Text = "&Date";
            this.mnDate.Click += new System.EventHandler(this.mnDate_Click);
            // 
            // mnHeure
            // 
            this.mnHeure.Name = "mnHeure";
            this.mnHeure.Size = new System.Drawing.Size(180, 22);
            this.mnHeure.Text = "&Heure";
            this.mnHeure.Click += new System.EventHandler(this.mnHeure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(56, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(56, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "B";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(113, 94);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(133, 20);
            this.txtA.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(113, 170);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(133, 20);
            this.txtC.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(113, 132);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(133, 20);
            this.txtB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(297, 94);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(128, 59);
            this.label4.TabIndex = 7;
            this.label4.Text = "1er degré -> A, B.\r\n\r\n2em degré -> A, B, C.\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(113, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Résultats";
            // 
            // lstResultat
            // 
            this.lstResultat.FormattingEnabled = true;
            this.lstResultat.Location = new System.Drawing.Point(244, 270);
            this.lstResultat.Name = "lstResultat";
            this.lstResultat.ScrollAlwaysVisible = true;
            this.lstResultat.Size = new System.Drawing.Size(181, 95);
            this.lstResultat.TabIndex = 9;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(217, 213);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(104, 30);
            this.btnCalculer.TabIndex = 4;
            this.btnCalculer.Text = "&Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // frmEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 390);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.lstResultat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEquation";
            this.Text = "Equation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEquation_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn;
        private System.Windows.Forms.ToolStripMenuItem mnEffacer;
        private System.Windows.Forms.ToolStripMenuItem mnQuitter;
        private System.Windows.Forms.ToolStripMenuItem mn1erDegre;
        private System.Windows.Forms.ToolStripMenuItem mn2emDegre;
        private System.Windows.Forms.ToolStripMenuItem mnDate;
        private System.Windows.Forms.ToolStripMenuItem mnHeure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstResultat;
        private System.Windows.Forms.Button btnCalculer;
    }
}

