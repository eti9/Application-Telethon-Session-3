namespace AppTelethon
{
    partial class UserControl_Commanditaire
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pnlListPrix = new System.Windows.Forms.Panel();
            this.dgvListPrix = new System.Windows.Forms.DataGridView();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grpBoxInfoDonateur = new System.Windows.Forms.GroupBox();
            this.mskTxtBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblIdDonateur = new System.Windows.Forms.Label();
            this.txtIdCommanditaire = new System.Windows.Forms.TextBox();
            this.grpBoxAjouterPrix = new System.Windows.Forms.GroupBox();
            this.btnAjouterPrix = new System.Windows.Forms.Button();
            this.numUpDownQte = new System.Windows.Forms.NumericUpDown();
            this.numUpDownVal = new System.Windows.Forms.NumericUpDown();
            this.lblPrixOffert = new System.Windows.Forms.Label();
            this.cmbPrixOffert = new System.Windows.Forms.ComboBox();
            this.lblValeurPrix = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBorder.SuspendLayout();
            this.pnlListPrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPrix)).BeginInit();
            this.grpBoxInfoDonateur.SuspendLayout();
            this.grpBoxAjouterPrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.picLogo);
            this.pnlBorder.Controls.Add(this.btnRetour);
            this.pnlBorder.Controls.Add(this.pnlListPrix);
            this.pnlBorder.Controls.Add(this.lblTitre);
            this.pnlBorder.Controls.Add(this.grpBoxInfoDonateur);
            this.pnlBorder.Controls.Add(this.grpBoxAjouterPrix);
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1199, 666);
            this.pnlBorder.TabIndex = 1;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(20, 583);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(169, 56);
            this.btnRetour.TabIndex = 33;
            this.btnRetour.Text = "RETOUR";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // pnlListPrix
            // 
            this.pnlListPrix.BackColor = System.Drawing.Color.MediumVioletRed;
            this.pnlListPrix.Controls.Add(this.dgvListPrix);
            this.pnlListPrix.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlListPrix.Location = new System.Drawing.Point(899, 0);
            this.pnlListPrix.Name = "pnlListPrix";
            this.pnlListPrix.Size = new System.Drawing.Size(298, 664);
            this.pnlListPrix.TabIndex = 32;
            // 
            // dgvListPrix
            // 
            this.dgvListPrix.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.dgvListPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListPrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prix});
            this.dgvListPrix.Location = new System.Drawing.Point(4, 3);
            this.dgvListPrix.Name = "dgvListPrix";
            this.dgvListPrix.RowHeadersWidth = 51;
            this.dgvListPrix.RowTemplate.Height = 24;
            this.dgvListPrix.Size = new System.Drawing.Size(292, 658);
            this.dgvListPrix.TabIndex = 34;
            // 
            // prix
            // 
            this.prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prix.HeaderText = "Liste des prix du commanditaire";
            this.prix.MinimumWidth = 6;
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            this.prix.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitre.Location = new System.Drawing.Point(397, 33);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(228, 29);
            this.lblTitre.TabIndex = 30;
            this.lblTitre.Text = "COMMANDITAIRE";
            // 
            // grpBoxInfoDonateur
            // 
            this.grpBoxInfoDonateur.Controls.Add(this.mskTxtBoxTelephone);
            this.grpBoxInfoDonateur.Controls.Add(this.lblTelephone);
            this.grpBoxInfoDonateur.Controls.Add(this.lblPrenom);
            this.grpBoxInfoDonateur.Controls.Add(this.lblNom);
            this.grpBoxInfoDonateur.Controls.Add(this.txtPrenom);
            this.grpBoxInfoDonateur.Controls.Add(this.txtNom);
            this.grpBoxInfoDonateur.Controls.Add(this.lblIdDonateur);
            this.grpBoxInfoDonateur.Controls.Add(this.txtIdCommanditaire);
            this.grpBoxInfoDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxInfoDonateur.Location = new System.Drawing.Point(82, 192);
            this.grpBoxInfoDonateur.Name = "grpBoxInfoDonateur";
            this.grpBoxInfoDonateur.Size = new System.Drawing.Size(353, 258);
            this.grpBoxInfoDonateur.TabIndex = 29;
            this.grpBoxInfoDonateur.TabStop = false;
            this.grpBoxInfoDonateur.Text = "Information ";
            // 
            // mskTxtBoxTelephone
            // 
            this.mskTxtBoxTelephone.Enabled = false;
            this.mskTxtBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxTelephone.Location = new System.Drawing.Point(127, 189);
            this.mskTxtBoxTelephone.Mask = "(999) 000-0000";
            this.mskTxtBoxTelephone.Name = "mskTxtBoxTelephone";
            this.mskTxtBoxTelephone.Size = new System.Drawing.Size(211, 24);
            this.mskTxtBoxTelephone.TabIndex = 16;
            this.mskTxtBoxTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(7, 189);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(91, 20);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Téléphone:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(6, 83);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(72, 20);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(6, 139);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom:";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(127, 83);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(211, 24);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Enabled = false;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(127, 139);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(211, 24);
            this.txtNom.TabIndex = 2;
            // 
            // lblIdDonateur
            // 
            this.lblIdDonateur.AutoSize = true;
            this.lblIdDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDonateur.Location = new System.Drawing.Point(7, 30);
            this.lblIdDonateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdDonateur.Name = "lblIdDonateur";
            this.lblIdDonateur.Size = new System.Drawing.Size(36, 20);
            this.lblIdDonateur.TabIndex = 12;
            this.lblIdDonateur.Text = "ID: ";
            // 
            // txtIdCommanditaire
            // 
            this.txtIdCommanditaire.Enabled = false;
            this.txtIdCommanditaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCommanditaire.Location = new System.Drawing.Point(127, 34);
            this.txtIdCommanditaire.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCommanditaire.Name = "txtIdCommanditaire";
            this.txtIdCommanditaire.Size = new System.Drawing.Size(211, 24);
            this.txtIdCommanditaire.TabIndex = 13;
            // 
            // grpBoxAjouterPrix
            // 
            this.grpBoxAjouterPrix.Controls.Add(this.btnAjouterPrix);
            this.grpBoxAjouterPrix.Controls.Add(this.numUpDownQte);
            this.grpBoxAjouterPrix.Controls.Add(this.numUpDownVal);
            this.grpBoxAjouterPrix.Controls.Add(this.lblPrixOffert);
            this.grpBoxAjouterPrix.Controls.Add(this.cmbPrixOffert);
            this.grpBoxAjouterPrix.Controls.Add(this.lblValeurPrix);
            this.grpBoxAjouterPrix.Controls.Add(this.lblQuantite);
            this.grpBoxAjouterPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxAjouterPrix.Location = new System.Drawing.Point(481, 171);
            this.grpBoxAjouterPrix.Name = "grpBoxAjouterPrix";
            this.grpBoxAjouterPrix.Size = new System.Drawing.Size(370, 307);
            this.grpBoxAjouterPrix.TabIndex = 31;
            this.grpBoxAjouterPrix.TabStop = false;
            this.grpBoxAjouterPrix.Text = "Ajouter un prix";
            // 
            // btnAjouterPrix
            // 
            this.btnAjouterPrix.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAjouterPrix.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPrix.Location = new System.Drawing.Point(99, 213);
            this.btnAjouterPrix.Name = "btnAjouterPrix";
            this.btnAjouterPrix.Size = new System.Drawing.Size(169, 56);
            this.btnAjouterPrix.TabIndex = 14;
            this.btnAjouterPrix.Text = "AJOUTER UN PRIX";
            this.btnAjouterPrix.UseVisualStyleBackColor = false;
            this.btnAjouterPrix.Click += new System.EventHandler(this.btnAjouterPrix_Click);
            // 
            // numUpDownQte
            // 
            this.numUpDownQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownQte.Location = new System.Drawing.Point(192, 154);
            this.numUpDownQte.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUpDownQte.Name = "numUpDownQte";
            this.numUpDownQte.Size = new System.Drawing.Size(160, 27);
            this.numUpDownQte.TabIndex = 13;
            // 
            // numUpDownVal
            // 
            this.numUpDownVal.DecimalPlaces = 2;
            this.numUpDownVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownVal.Location = new System.Drawing.Point(192, 97);
            this.numUpDownVal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownVal.Name = "numUpDownVal";
            this.numUpDownVal.Size = new System.Drawing.Size(160, 27);
            this.numUpDownVal.TabIndex = 12;
            // 
            // lblPrixOffert
            // 
            this.lblPrixOffert.AutoSize = true;
            this.lblPrixOffert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixOffert.Location = new System.Drawing.Point(17, 49);
            this.lblPrixOffert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrixOffert.Name = "lblPrixOffert";
            this.lblPrixOffert.Size = new System.Drawing.Size(86, 20);
            this.lblPrixOffert.TabIndex = 7;
            this.lblPrixOffert.Text = "Prix Offert";
            // 
            // cmbPrixOffert
            // 
            this.cmbPrixOffert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrixOffert.FormattingEnabled = true;
            this.cmbPrixOffert.Items.AddRange(new object[] {
            "Télévision",
            "Calendrier",
            "Repas pour 2",
            "BBQ"});
            this.cmbPrixOffert.Location = new System.Drawing.Point(192, 46);
            this.cmbPrixOffert.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrixOffert.Name = "cmbPrixOffert";
            this.cmbPrixOffert.Size = new System.Drawing.Size(160, 28);
            this.cmbPrixOffert.TabIndex = 8;
            // 
            // lblValeurPrix
            // 
            this.lblValeurPrix.AutoSize = true;
            this.lblValeurPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeurPrix.Location = new System.Drawing.Point(17, 97);
            this.lblValeurPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValeurPrix.Name = "lblValeurPrix";
            this.lblValeurPrix.Size = new System.Drawing.Size(112, 20);
            this.lblValeurPrix.TabIndex = 9;
            this.lblValeurPrix.Text = "Valeur du prix";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(17, 156);
            this.lblQuantite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(72, 20);
            this.lblQuantite.TabIndex = 11;
            this.lblQuantite.Text = "Quantité";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::AppTelethon.Properties.Resources.chien_dor_logo1;
            this.picLogo.Location = new System.Drawing.Point(20, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(224, 147);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 34;
            this.picLogo.TabStop = false;
            // 
            // UserControl_Commanditaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.pnlBorder);
            this.Name = "UserControl_Commanditaire";
            this.Size = new System.Drawing.Size(1199, 666);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.pnlListPrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPrix)).EndInit();
            this.grpBoxInfoDonateur.ResumeLayout(false);
            this.grpBoxInfoDonateur.PerformLayout();
            this.grpBoxAjouterPrix.ResumeLayout(false);
            this.grpBoxAjouterPrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblValeurPrix;
        private System.Windows.Forms.ComboBox cmbPrixOffert;
        private System.Windows.Forms.Label lblPrixOffert;
        private System.Windows.Forms.GroupBox grpBoxInfoDonateur;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblIdDonateur;
        private System.Windows.Forms.TextBox txtIdCommanditaire;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox grpBoxAjouterPrix;
        private System.Windows.Forms.NumericUpDown numUpDownQte;
        private System.Windows.Forms.NumericUpDown numUpDownVal;
        private System.Windows.Forms.Panel pnlListPrix;
        private System.Windows.Forms.Button btnAjouterPrix;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dgvListPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
