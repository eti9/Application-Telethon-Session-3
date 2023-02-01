namespace AppTelethon
{
    partial class UserControl_CarteCredit
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
            this.grpTypeCarte = new System.Windows.Forms.GroupBox();
            this.dtpDateExpiration = new System.Windows.Forms.DateTimePicker();
            this.mskTextBoxCCV = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtBoxNumberCard = new System.Windows.Forms.MaskedTextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.rdoAmex = new System.Windows.Forms.RadioButton();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.rdoMasterCard = new System.Windows.Forms.RadioButton();
            this.lblNombreSecret = new System.Windows.Forms.Label();
            this.rdoVisa = new System.Windows.Forms.RadioButton();
            this.lblNumeroCarte = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picbxAmex = new System.Windows.Forms.PictureBox();
            this.picbxMC = new System.Windows.Forms.PictureBox();
            this.picbxVisa = new System.Windows.Forms.PictureBox();
            this.grpTypeCarte.SuspendLayout();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAmex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxVisa)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTypeCarte
            // 
            this.grpTypeCarte.Controls.Add(this.dtpDateExpiration);
            this.grpTypeCarte.Controls.Add(this.mskTextBoxCCV);
            this.grpTypeCarte.Controls.Add(this.mskTxtBoxNumberCard);
            this.grpTypeCarte.Controls.Add(this.picbxAmex);
            this.grpTypeCarte.Controls.Add(this.picbxMC);
            this.grpTypeCarte.Controls.Add(this.btnAnnuler);
            this.grpTypeCarte.Controls.Add(this.picbxVisa);
            this.grpTypeCarte.Controls.Add(this.btnEnregistrer);
            this.grpTypeCarte.Controls.Add(this.rdoAmex);
            this.grpTypeCarte.Controls.Add(this.lblExpiration);
            this.grpTypeCarte.Controls.Add(this.rdoMasterCard);
            this.grpTypeCarte.Controls.Add(this.lblNombreSecret);
            this.grpTypeCarte.Controls.Add(this.rdoVisa);
            this.grpTypeCarte.Controls.Add(this.lblNumeroCarte);
            this.grpTypeCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTypeCarte.Location = new System.Drawing.Point(299, 212);
            this.grpTypeCarte.Margin = new System.Windows.Forms.Padding(4);
            this.grpTypeCarte.Name = "grpTypeCarte";
            this.grpTypeCarte.Padding = new System.Windows.Forms.Padding(4);
            this.grpTypeCarte.Size = new System.Drawing.Size(579, 258);
            this.grpTypeCarte.TabIndex = 0;
            this.grpTypeCarte.TabStop = false;
            this.grpTypeCarte.Text = "Information carte de credit";
            this.grpTypeCarte.Enter += new System.EventHandler(this.grpTypeCarte_Enter);
            // 
            // dtpDateExpiration
            // 
            this.dtpDateExpiration.CustomFormat = "MM/yyy";
            this.dtpDateExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateExpiration.Location = new System.Drawing.Point(452, 148);
            this.dtpDateExpiration.Name = "dtpDateExpiration";
            this.dtpDateExpiration.ShowUpDown = true;
            this.dtpDateExpiration.Size = new System.Drawing.Size(118, 27);
            this.dtpDateExpiration.TabIndex = 16;
            // 
            // mskTextBoxCCV
            // 
            this.mskTextBoxCCV.Location = new System.Drawing.Point(505, 103);
            this.mskTextBoxCCV.Mask = "000";
            this.mskTextBoxCCV.Name = "mskTextBoxCCV";
            this.mskTextBoxCCV.Size = new System.Drawing.Size(53, 27);
            this.mskTextBoxCCV.TabIndex = 15;
            this.mskTextBoxCCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskTxtBoxNumberCard
            // 
            this.mskTxtBoxNumberCard.Location = new System.Drawing.Point(170, 103);
            this.mskTxtBoxNumberCard.Mask = "0000-0000-0000-0000";
            this.mskTxtBoxNumberCard.Name = "mskTxtBoxNumberCard";
            this.mskTxtBoxNumberCard.Size = new System.Drawing.Size(224, 27);
            this.mskTxtBoxNumberCard.TabIndex = 14;
            this.mskTxtBoxNumberCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(444, 205);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(127, 30);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(264, 204);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(172, 31);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "ENREGISTRER";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // rdoAmex
            // 
            this.rdoAmex.AutoSize = true;
            this.rdoAmex.Location = new System.Drawing.Point(482, 47);
            this.rdoAmex.Margin = new System.Windows.Forms.Padding(4);
            this.rdoAmex.Name = "rdoAmex";
            this.rdoAmex.Size = new System.Drawing.Size(76, 24);
            this.rdoAmex.TabIndex = 2;
            this.rdoAmex.Text = "Amex";
            this.rdoAmex.UseVisualStyleBackColor = true;
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiration.Location = new System.Drawing.Point(353, 148);
            this.lblExpiration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(83, 20);
            this.lblExpiration.TabIndex = 6;
            this.lblExpiration.Text = "Expiration";
            // 
            // rdoMasterCard
            // 
            this.rdoMasterCard.AutoSize = true;
            this.rdoMasterCard.Checked = true;
            this.rdoMasterCard.Location = new System.Drawing.Point(236, 47);
            this.rdoMasterCard.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMasterCard.Name = "rdoMasterCard";
            this.rdoMasterCard.Size = new System.Drawing.Size(128, 24);
            this.rdoMasterCard.TabIndex = 1;
            this.rdoMasterCard.TabStop = true;
            this.rdoMasterCard.Text = "MasterCard";
            this.rdoMasterCard.UseVisualStyleBackColor = true;
            // 
            // lblNombreSecret
            // 
            this.lblNombreSecret.AutoSize = true;
            this.lblNombreSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSecret.Location = new System.Drawing.Point(426, 110);
            this.lblNombreSecret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreSecret.Name = "lblNombreSecret";
            this.lblNombreSecret.Size = new System.Drawing.Size(49, 20);
            this.lblNombreSecret.TabIndex = 7;
            this.lblNombreSecret.Text = "CCV:";
            // 
            // rdoVisa
            // 
            this.rdoVisa.AutoSize = true;
            this.rdoVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVisa.Location = new System.Drawing.Point(60, 47);
            this.rdoVisa.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVisa.Name = "rdoVisa";
            this.rdoVisa.Size = new System.Drawing.Size(67, 24);
            this.rdoVisa.TabIndex = 0;
            this.rdoVisa.Text = "Visa\r\n";
            this.rdoVisa.UseVisualStyleBackColor = true;
            // 
            // lblNumeroCarte
            // 
            this.lblNumeroCarte.AutoSize = true;
            this.lblNumeroCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCarte.Location = new System.Drawing.Point(14, 110);
            this.lblNumeroCarte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCarte.Name = "lblNumeroCarte";
            this.lblNumeroCarte.Size = new System.Drawing.Size(139, 20);
            this.lblNumeroCarte.TabIndex = 3;
            this.lblNumeroCarte.Text = "# Carte de crédit:";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitre.Location = new System.Drawing.Point(369, 110);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(460, 29);
            this.lblTitre.TabIndex = 14;
            this.lblTitre.Text = "Ajouter ou modifier une carte de crédit";
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.picLogo);
            this.pnlBorder.Controls.Add(this.grpTypeCarte);
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1199, 666);
            this.pnlBorder.TabIndex = 15;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::AppTelethon.Properties.Resources.chien_dor_logo1;
            this.picLogo.Location = new System.Drawing.Point(33, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(224, 147);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 24;
            this.picLogo.TabStop = false;
            // 
            // picbxAmex
            // 
            this.picbxAmex.Image = global::AppTelethon.Properties.Resources.icons8_American_Express;
            this.picbxAmex.Location = new System.Drawing.Point(430, 36);
            this.picbxAmex.Name = "picbxAmex";
            this.picbxAmex.Size = new System.Drawing.Size(35, 35);
            this.picbxAmex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxAmex.TabIndex = 5;
            this.picbxAmex.TabStop = false;
            // 
            // picbxMC
            // 
            this.picbxMC.Image = global::AppTelethon.Properties.Resources.icons8_mastercard;
            this.picbxMC.Location = new System.Drawing.Point(194, 36);
            this.picbxMC.Name = "picbxMC";
            this.picbxMC.Size = new System.Drawing.Size(35, 35);
            this.picbxMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxMC.TabIndex = 4;
            this.picbxMC.TabStop = false;
            // 
            // picbxVisa
            // 
            this.picbxVisa.Image = global::AppTelethon.Properties.Resources.icons8_visa;
            this.picbxVisa.Location = new System.Drawing.Point(18, 36);
            this.picbxVisa.Name = "picbxVisa";
            this.picbxVisa.Size = new System.Drawing.Size(35, 35);
            this.picbxVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxVisa.TabIndex = 3;
            this.picbxVisa.TabStop = false;
            // 
            // UserControl_CarteCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pnlBorder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_CarteCredit";
            this.Size = new System.Drawing.Size(1199, 666);
            this.grpTypeCarte.ResumeLayout(false);
            this.grpTypeCarte.PerformLayout();
            this.pnlBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAmex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxVisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTypeCarte;
        private System.Windows.Forms.RadioButton rdoAmex;
        private System.Windows.Forms.RadioButton rdoMasterCard;
        private System.Windows.Forms.RadioButton rdoVisa;
        private System.Windows.Forms.Label lblNumeroCarte;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblNombreSecret;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox picbxAmex;
        private System.Windows.Forms.PictureBox picbxMC;
        private System.Windows.Forms.PictureBox picbxVisa;
        private System.Windows.Forms.MaskedTextBox mskTextBoxCCV;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxNumberCard;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.DateTimePicker dtpDateExpiration;
        private System.Windows.Forms.PictureBox picLogo;
    }
}