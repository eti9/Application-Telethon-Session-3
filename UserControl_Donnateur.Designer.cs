namespace AppTelethon
{
    partial class UserControl_Donnateur
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
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.btnModifierInfo = new System.Windows.Forms.Button();
            this.lblIdDonateur = new System.Windows.Forms.Label();
            this.txtIdDonateur = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDon = new System.Windows.Forms.DataGridView();
            this.don = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxInfoDonateur = new System.Windows.Forms.GroupBox();
            this.lblAsterique = new System.Windows.Forms.Label();
            this.mskTxtBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.grpboxDon = new System.Windows.Forms.GroupBox();
            this.listViewCarteCredit = new System.Windows.Forms.ListView();
            this.numeroCarte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateExpiCarte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numUpDownMontantDon = new System.Windows.Forms.NumericUpDown();
            this.btnFaireDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectionCarte = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grpBoxPoint = new System.Windows.Forms.GroupBox();
            this.btnReclamez = new System.Windows.Forms.Button();
            this.txtBoxPts = new System.Windows.Forms.TextBox();
            this.lblPts = new System.Windows.Forms.Label();
            this.picboxDeleteCarte = new System.Windows.Forms.PictureBox();
            this.picboxModifierCarte = new System.Windows.Forms.PictureBox();
            this.picboxAjouterCarte = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).BeginInit();
            this.grpBoxInfoDonateur.SuspendLayout();
            this.grpboxDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontantDon)).BeginInit();
            this.pnlBorder.SuspendLayout();
            this.grpBoxPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDeleteCarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxModifierCarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAjouterCarte)).BeginInit();
            this.SuspendLayout();
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(7, 193);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Courriel:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(6, 250);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(91, 20);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Téléphone:";
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
            // txtCourriel
            // 
            this.txtCourriel.Enabled = false;
            this.txtCourriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourriel.Location = new System.Drawing.Point(127, 193);
            this.txtCourriel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(211, 24);
            this.txtCourriel.TabIndex = 3;
            // 
            // btnModifierInfo
            // 
            this.btnModifierInfo.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnModifierInfo.ForeColor = System.Drawing.Color.White;
            this.btnModifierInfo.Location = new System.Drawing.Point(11, 297);
            this.btnModifierInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierInfo.Name = "btnModifierInfo";
            this.btnModifierInfo.Size = new System.Drawing.Size(327, 41);
            this.btnModifierInfo.TabIndex = 9;
            this.btnModifierInfo.Text = "MODIFIER LES INFORMATIONS";
            this.btnModifierInfo.UseVisualStyleBackColor = false;
            this.btnModifierInfo.Click += new System.EventHandler(this.btnModifierInfo_Click);
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
            // txtIdDonateur
            // 
            this.txtIdDonateur.Enabled = false;
            this.txtIdDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDonateur.Location = new System.Drawing.Point(127, 34);
            this.txtIdDonateur.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdDonateur.Name = "txtIdDonateur";
            this.txtIdDonateur.Size = new System.Drawing.Size(211, 24);
            this.txtIdDonateur.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.dgvDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(900, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 666);
            this.panel1.TabIndex = 26;
            // 
            // dgvDon
            // 
            this.dgvDon.BackgroundColor = System.Drawing.Color.MediumVioletRed;
            this.dgvDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.don});
            this.dgvDon.Location = new System.Drawing.Point(3, 5);
            this.dgvDon.Name = "dgvDon";
            this.dgvDon.RowHeadersWidth = 51;
            this.dgvDon.RowTemplate.Height = 24;
            this.dgvDon.Size = new System.Drawing.Size(292, 657);
            this.dgvDon.TabIndex = 0;
            // 
            // don
            // 
            this.don.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.don.HeaderText = "Don";
            this.don.MinimumWidth = 6;
            this.don.Name = "don";
            this.don.ReadOnly = true;
            this.don.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.don.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grpBoxInfoDonateur
            // 
            this.grpBoxInfoDonateur.Controls.Add(this.lblAsterique);
            this.grpBoxInfoDonateur.Controls.Add(this.mskTxtBoxTelephone);
            this.grpBoxInfoDonateur.Controls.Add(this.lblTelephone);
            this.grpBoxInfoDonateur.Controls.Add(this.lblPrenom);
            this.grpBoxInfoDonateur.Controls.Add(this.lblNom);
            this.grpBoxInfoDonateur.Controls.Add(this.lblEmail);
            this.grpBoxInfoDonateur.Controls.Add(this.txtPrenom);
            this.grpBoxInfoDonateur.Controls.Add(this.txtNom);
            this.grpBoxInfoDonateur.Controls.Add(this.txtCourriel);
            this.grpBoxInfoDonateur.Controls.Add(this.btnModifierInfo);
            this.grpBoxInfoDonateur.Controls.Add(this.lblIdDonateur);
            this.grpBoxInfoDonateur.Controls.Add(this.txtIdDonateur);
            this.grpBoxInfoDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxInfoDonateur.Location = new System.Drawing.Point(52, 91);
            this.grpBoxInfoDonateur.Name = "grpBoxInfoDonateur";
            this.grpBoxInfoDonateur.Size = new System.Drawing.Size(353, 361);
            this.grpBoxInfoDonateur.TabIndex = 28;
            this.grpBoxInfoDonateur.TabStop = false;
            this.grpBoxInfoDonateur.Text = "Information ";
            // 
            // lblAsterique
            // 
            this.lblAsterique.AutoSize = true;
            this.lblAsterique.ForeColor = System.Drawing.Color.Red;
            this.lblAsterique.Location = new System.Drawing.Point(104, 197);
            this.lblAsterique.Name = "lblAsterique";
            this.lblAsterique.Size = new System.Drawing.Size(16, 20);
            this.lblAsterique.TabIndex = 17;
            this.lblAsterique.Text = "*";
            // 
            // mskTxtBoxTelephone
            // 
            this.mskTxtBoxTelephone.Enabled = false;
            this.mskTxtBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxTelephone.Location = new System.Drawing.Point(127, 247);
            this.mskTxtBoxTelephone.Mask = "(999) 000-0000";
            this.mskTxtBoxTelephone.Name = "mskTxtBoxTelephone";
            this.mskTxtBoxTelephone.Size = new System.Drawing.Size(211, 24);
            this.mskTxtBoxTelephone.TabIndex = 16;
            this.mskTxtBoxTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpboxDon
            // 
            this.grpboxDon.Controls.Add(this.listViewCarteCredit);
            this.grpboxDon.Controls.Add(this.numUpDownMontantDon);
            this.grpboxDon.Controls.Add(this.btnFaireDon);
            this.grpboxDon.Controls.Add(this.label1);
            this.grpboxDon.Controls.Add(this.lblSelectionCarte);
            this.grpboxDon.Controls.Add(this.picboxDeleteCarte);
            this.grpboxDon.Controls.Add(this.picboxModifierCarte);
            this.grpboxDon.Controls.Add(this.picboxAjouterCarte);
            this.grpboxDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxDon.Location = new System.Drawing.Point(427, 91);
            this.grpboxDon.Name = "grpboxDon";
            this.grpboxDon.Size = new System.Drawing.Size(465, 361);
            this.grpboxDon.TabIndex = 33;
            this.grpboxDon.TabStop = false;
            this.grpboxDon.Text = "Faire un don";
            // 
            // listViewCarteCredit
            // 
            this.listViewCarteCredit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numeroCarte,
            this.dateExpiCarte});
            this.listViewCarteCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCarteCredit.HideSelection = false;
            this.listViewCarteCredit.Location = new System.Drawing.Point(24, 58);
            this.listViewCarteCredit.MultiSelect = false;
            this.listViewCarteCredit.Name = "listViewCarteCredit";
            this.listViewCarteCredit.Size = new System.Drawing.Size(435, 105);
            this.listViewCarteCredit.TabIndex = 36;
            this.listViewCarteCredit.UseCompatibleStateImageBehavior = false;
            this.listViewCarteCredit.View = System.Windows.Forms.View.Details;
            // 
            // numeroCarte
            // 
            this.numeroCarte.Text = "Numero de carte";
            this.numeroCarte.Width = 236;
            // 
            // dateExpiCarte
            // 
            this.dateExpiCarte.Text = "Date d\'expiration";
            this.dateExpiCarte.Width = 143;
            // 
            // numUpDownMontantDon
            // 
            this.numUpDownMontantDon.DecimalPlaces = 2;
            this.numUpDownMontantDon.Location = new System.Drawing.Point(333, 226);
            this.numUpDownMontantDon.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numUpDownMontantDon.Name = "numUpDownMontantDon";
            this.numUpDownMontantDon.Size = new System.Drawing.Size(126, 27);
            this.numUpDownMontantDon.TabIndex = 35;
            // 
            // btnFaireDon
            // 
            this.btnFaireDon.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnFaireDon.ForeColor = System.Drawing.Color.White;
            this.btnFaireDon.Location = new System.Drawing.Point(88, 297);
            this.btnFaireDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnFaireDon.Name = "btnFaireDon";
            this.btnFaireDon.Size = new System.Drawing.Size(298, 37);
            this.btnFaireDon.TabIndex = 34;
            this.btnFaireDon.Text = "FAIRE UN DON";
            this.btnFaireDon.UseVisualStyleBackColor = false;
            this.btnFaireDon.Click += new System.EventHandler(this.btnFaireDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "2- Inserez un montant";
            // 
            // lblSelectionCarte
            // 
            this.lblSelectionCarte.AutoSize = true;
            this.lblSelectionCarte.Location = new System.Drawing.Point(20, 34);
            this.lblSelectionCarte.Name = "lblSelectionCarte";
            this.lblSelectionCarte.Size = new System.Drawing.Size(305, 20);
            this.lblSelectionCarte.TabIndex = 33;
            this.lblSelectionCarte.Text = "1- Selectionnez une carte de crédit";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(337, 11);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(163, 36);
            this.lblTitre.TabIndex = 34;
            this.lblTitre.Text = "Donnateur";
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.lblTitre);
            this.pnlBorder.Controls.Add(this.btnRetour);
            this.pnlBorder.Controls.Add(this.grpBoxPoint);
            this.pnlBorder.Controls.Add(this.grpBoxInfoDonateur);
            this.pnlBorder.Controls.Add(this.grpboxDon);
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1199, 666);
            this.pnlBorder.TabIndex = 35;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(52, 527);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(151, 48);
            this.btnRetour.TabIndex = 35;
            this.btnRetour.Text = "RETOUR";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // grpBoxPoint
            // 
            this.grpBoxPoint.Controls.Add(this.btnReclamez);
            this.grpBoxPoint.Controls.Add(this.txtBoxPts);
            this.grpBoxPoint.Controls.Add(this.lblPts);
            this.grpBoxPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPoint.Location = new System.Drawing.Point(438, 474);
            this.grpBoxPoint.Name = "grpBoxPoint";
            this.grpBoxPoint.Size = new System.Drawing.Size(454, 129);
            this.grpBoxPoint.TabIndex = 34;
            this.grpBoxPoint.TabStop = false;
            this.grpBoxPoint.Text = "Réclamez un prix";
            // 
            // btnReclamez
            // 
            this.btnReclamez.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnReclamez.ForeColor = System.Drawing.Color.White;
            this.btnReclamez.Location = new System.Drawing.Point(77, 64);
            this.btnReclamez.Margin = new System.Windows.Forms.Padding(4);
            this.btnReclamez.Name = "btnReclamez";
            this.btnReclamez.Size = new System.Drawing.Size(298, 37);
            this.btnReclamez.TabIndex = 35;
            this.btnReclamez.Text = "RECLAMEZ UN PRIX";
            this.btnReclamez.UseVisualStyleBackColor = false;
            this.btnReclamez.Click += new System.EventHandler(this.btnReclamez_Click);
            // 
            // txtBoxPts
            // 
            this.txtBoxPts.Enabled = false;
            this.txtBoxPts.Location = new System.Drawing.Point(221, 29);
            this.txtBoxPts.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPts.Name = "txtBoxPts";
            this.txtBoxPts.Size = new System.Drawing.Size(211, 27);
            this.txtBoxPts.TabIndex = 35;
            // 
            // lblPts
            // 
            this.lblPts.AutoSize = true;
            this.lblPts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPts.Location = new System.Drawing.Point(56, 32);
            this.lblPts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPts.Name = "lblPts";
            this.lblPts.Size = new System.Drawing.Size(146, 20);
            this.lblPts.TabIndex = 13;
            this.lblPts.Text = "Nombre de points:";
            // 
            // picboxDeleteCarte
            // 
            this.picboxDeleteCarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxDeleteCarte.Image = global::AppTelethon.Properties.Resources.supprimer;
            this.picboxDeleteCarte.Location = new System.Drawing.Point(421, 169);
            this.picboxDeleteCarte.Name = "picboxDeleteCarte";
            this.picboxDeleteCarte.Size = new System.Drawing.Size(38, 31);
            this.picboxDeleteCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxDeleteCarte.TabIndex = 32;
            this.picboxDeleteCarte.TabStop = false;
            this.picboxDeleteCarte.Click += new System.EventHandler(this.btn_carteCredit);
            // 
            // picboxModifierCarte
            // 
            this.picboxModifierCarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxModifierCarte.Image = global::AppTelethon.Properties.Resources.modifier;
            this.picboxModifierCarte.Location = new System.Drawing.Point(377, 169);
            this.picboxModifierCarte.Name = "picboxModifierCarte";
            this.picboxModifierCarte.Size = new System.Drawing.Size(38, 31);
            this.picboxModifierCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxModifierCarte.TabIndex = 30;
            this.picboxModifierCarte.TabStop = false;
            this.picboxModifierCarte.Click += new System.EventHandler(this.btn_carteCredit);
            // 
            // picboxAjouterCarte
            // 
            this.picboxAjouterCarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxAjouterCarte.Image = global::AppTelethon.Properties.Resources.ajouter;
            this.picboxAjouterCarte.Location = new System.Drawing.Point(333, 169);
            this.picboxAjouterCarte.Name = "picboxAjouterCarte";
            this.picboxAjouterCarte.Size = new System.Drawing.Size(38, 31);
            this.picboxAjouterCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxAjouterCarte.TabIndex = 31;
            this.picboxAjouterCarte.TabStop = false;
            this.picboxAjouterCarte.Click += new System.EventHandler(this.btn_carteCredit);
            // 
            // UserControl_Donnateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBorder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Donnateur";
            this.Size = new System.Drawing.Size(1199, 666);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDon)).EndInit();
            this.grpBoxInfoDonateur.ResumeLayout(false);
            this.grpBoxInfoDonateur.PerformLayout();
            this.grpboxDon.ResumeLayout(false);
            this.grpboxDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownMontantDon)).EndInit();
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.grpBoxPoint.ResumeLayout(false);
            this.grpBoxPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDeleteCarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxModifierCarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAjouterCarte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Button btnModifierInfo;
        private System.Windows.Forms.Label lblIdDonateur;
        private System.Windows.Forms.TextBox txtIdDonateur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxInfoDonateur;
        private System.Windows.Forms.PictureBox picboxModifierCarte;
        private System.Windows.Forms.PictureBox picboxAjouterCarte;
        private System.Windows.Forms.PictureBox picboxDeleteCarte;
        private System.Windows.Forms.GroupBox grpboxDon;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelephone;
        private System.Windows.Forms.Button btnFaireDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectionCarte;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox grpBoxPoint;
        private System.Windows.Forms.Button btnReclamez;
        private System.Windows.Forms.TextBox txtBoxPts;
        private System.Windows.Forms.Label lblPts;
        private System.Windows.Forms.NumericUpDown numUpDownMontantDon;
        private System.Windows.Forms.ListView listViewCarteCredit;
        private System.Windows.Forms.ColumnHeader numeroCarte;
        private System.Windows.Forms.ColumnHeader dateExpiCarte;
        private System.Windows.Forms.DataGridView dgvDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn don;
        private System.Windows.Forms.Label lblAsterique;
    }
}