namespace Exo9
{
    partial class frmClock
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
            this.clockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDate = new System.Windows.Forms.ToolStripMenuItem();
            this.lbClock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(297, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clockToolStripMenuItem
            // 
            this.clockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTime,
            this.mnDate});
            this.clockToolStripMenuItem.Name = "clockToolStripMenuItem";
            this.clockToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.clockToolStripMenuItem.Text = "Clock";
            // 
            // mnTime
            // 
            this.mnTime.Name = "mnTime";
            this.mnTime.Size = new System.Drawing.Size(180, 22);
            this.mnTime.Text = "Time";
            this.mnTime.Click += new System.EventHandler(this.mnTime_Click);
            // 
            // mnDate
            // 
            this.mnDate.Name = "mnDate";
            this.mnDate.Size = new System.Drawing.Size(180, 22);
            this.mnDate.Text = "Date";
            this.mnDate.Click += new System.EventHandler(this.mnDate_Click);
            // 
            // lbClock
            // 
            this.lbClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbClock.AutoSize = true;
            this.lbClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(135, 90);
            this.lbClock.Name = "lbClock";
            this.lbClock.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.lbClock.Size = new System.Drawing.Size(42, 42);
            this.lbClock.TabIndex = 1;
            this.lbClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClock.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbClock);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 210);
            this.panel1.TabIndex = 2;
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 238);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmClock";
            this.Text = "Clock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnTime;
        private System.Windows.Forms.ToolStripMenuItem mnDate;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Panel panel1;
    }
}

