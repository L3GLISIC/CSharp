namespace LocationEtudiant
{
    partial class frmAppartement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcAll = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAppartementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseAppartementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capaciteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appartementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbAdresse = new System.Windows.Forms.RichTextBox();
            this.nudNombrePiece = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProprietaire = new System.Windows.Forms.ComboBox();
            this.nudCapacite = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSurface = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcAll.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartementBindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombrePiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacite)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAll
            // 
            this.tcAll.Controls.Add(this.tabPage1);
            this.tcAll.Controls.Add(this.tabPage2);
            this.tcAll.Location = new System.Drawing.Point(0, 0);
            this.tcAll.Name = "tcAll";
            this.tcAll.SelectedIndex = 0;
            this.tcAll.Size = new System.Drawing.Size(1022, 545);
            this.tcAll.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appartement";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(333, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 507);
            this.panel4.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAppartementDataGridViewTextBoxColumn,
            this.adresseAppartementDataGridViewTextBoxColumn,
            this.surfaceDataGridViewTextBoxColumn,
            this.nombrePieceDataGridViewTextBoxColumn,
            this.capaciteDataGridViewTextBoxColumn,
            this.idProprietaireDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appartementBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // idAppartementDataGridViewTextBoxColumn
            // 
            this.idAppartementDataGridViewTextBoxColumn.DataPropertyName = "IdAppartement";
            this.idAppartementDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idAppartementDataGridViewTextBoxColumn.Name = "idAppartementDataGridViewTextBoxColumn";
            // 
            // adresseAppartementDataGridViewTextBoxColumn
            // 
            this.adresseAppartementDataGridViewTextBoxColumn.DataPropertyName = "AdresseAppartement";
            this.adresseAppartementDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseAppartementDataGridViewTextBoxColumn.Name = "adresseAppartementDataGridViewTextBoxColumn";
            // 
            // surfaceDataGridViewTextBoxColumn
            // 
            this.surfaceDataGridViewTextBoxColumn.DataPropertyName = "Surface";
            this.surfaceDataGridViewTextBoxColumn.HeaderText = "Surface";
            this.surfaceDataGridViewTextBoxColumn.Name = "surfaceDataGridViewTextBoxColumn";
            // 
            // nombrePieceDataGridViewTextBoxColumn
            // 
            this.nombrePieceDataGridViewTextBoxColumn.DataPropertyName = "NombrePiece";
            this.nombrePieceDataGridViewTextBoxColumn.HeaderText = "Nombre de Piece";
            this.nombrePieceDataGridViewTextBoxColumn.Name = "nombrePieceDataGridViewTextBoxColumn";
            // 
            // capaciteDataGridViewTextBoxColumn
            // 
            this.capaciteDataGridViewTextBoxColumn.DataPropertyName = "Capacite";
            this.capaciteDataGridViewTextBoxColumn.HeaderText = "Capacite";
            this.capaciteDataGridViewTextBoxColumn.Name = "capaciteDataGridViewTextBoxColumn";
            // 
            // idProprietaireDataGridViewTextBoxColumn
            // 
            this.idProprietaireDataGridViewTextBoxColumn.DataPropertyName = "IdProprietaire";
            this.idProprietaireDataGridViewTextBoxColumn.HeaderText = "Proprietaire";
            this.idProprietaireDataGridViewTextBoxColumn.Name = "idProprietaireDataGridViewTextBoxColumn";
            // 
            // appartementBindingSource1
            // 
            this.appartementBindingSource1.DataSource = typeof(LocationEtudiant.Model.Appartement);
            this.appartementBindingSource1.CurrentChanged += new System.EventHandler(this.appartementBindingSource1_CurrentChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 507);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rtbAdresse);
            this.panel3.Controls.Add(this.nudNombrePiece);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbProprietaire);
            this.panel3.Controls.Add(this.nudCapacite);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbSurface);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(14, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 426);
            this.panel3.TabIndex = 15;
            // 
            // rtbAdresse
            // 
            this.rtbAdresse.Location = new System.Drawing.Point(3, 40);
            this.rtbAdresse.Name = "rtbAdresse";
            this.rtbAdresse.Size = new System.Drawing.Size(279, 72);
            this.rtbAdresse.TabIndex = 1;
            this.rtbAdresse.Text = "";
            // 
            // nudNombrePiece
            // 
            this.nudNombrePiece.Location = new System.Drawing.Point(3, 238);
            this.nudNombrePiece.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNombrePiece.Name = "nudNombrePiece";
            this.nudNombrePiece.Size = new System.Drawing.Size(279, 20);
            this.nudNombrePiece.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capacité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de piece";
            // 
            // cbProprietaire
            // 
            this.cbProprietaire.FormattingEnabled = true;
            this.cbProprietaire.Location = new System.Drawing.Point(3, 384);
            this.cbProprietaire.Name = "cbProprietaire";
            this.cbProprietaire.Size = new System.Drawing.Size(279, 21);
            this.cbProprietaire.TabIndex = 9;
            // 
            // nudCapacite
            // 
            this.nudCapacite.Location = new System.Drawing.Point(3, 311);
            this.nudCapacite.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCapacite.Name = "nudCapacite";
            this.nudCapacite.Size = new System.Drawing.Size(279, 20);
            this.nudCapacite.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surface";
            // 
            // tbSurface
            // 
            this.tbSurface.Location = new System.Drawing.Point(3, 165);
            this.tbSurface.Name = "tbSurface";
            this.tbSurface.Size = new System.Drawing.Size(261, 20);
            this.tbSurface.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Propriétaire";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Location = new System.Drawing.Point(14, 450);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(298, 40);
            this.panel1.TabIndex = 13;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(3, 11);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(207, 11);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(105, 11);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmAppartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 541);
            this.ControlBox = false;
            this.Controls.Add(this.tcAll);
            this.Name = "frmAppartement";
            this.Text = "Appartement";
            this.tcAll.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appartementBindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombrePiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacite)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAll;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtbAdresse;
        private System.Windows.Forms.NumericUpDown nudNombrePiece;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProprietaire;
        private System.Windows.Forms.NumericUpDown nudCapacite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSurface;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAppartementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseAppartementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capaciteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appartementBindingSource1;
    }
}