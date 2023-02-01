namespace AppTelethon
{
    partial class UserControl_AddDonateur
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.grpBoxInfoDonateur = new System.Windows.Forms.GroupBox();
            this.lblAsterique = new System.Windows.Forms.Label();
            this.mskTxtBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.btnAjouterDonnateur = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBorder.SuspendLayout();
            this.grpBoxInfoDonateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.Bisque;
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.picLogo);
            this.pnlBorder.Controls.Add(this.btnRetour);
            this.pnlBorder.Controls.Add(this.lblTitre);
            this.pnlBorder.Controls.Add(this.grpBoxInfoDonateur);
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
            this.btnRetour.Location = new System.Drawing.Point(29, 598);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(177, 41);
            this.btnRetour.TabIndex = 31;
            this.btnRetour.Text = "RETOUR";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitre.Location = new System.Drawing.Point(488, 82);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(241, 29);
            this.lblTitre.TabIndex = 30;
            this.lblTitre.Text = "Ajouter un donateur";
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
            this.grpBoxInfoDonateur.Controls.Add(this.btnAjouterDonnateur);
            this.grpBoxInfoDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxInfoDonateur.Location = new System.Drawing.Point(437, 160);
            this.grpBoxInfoDonateur.Name = "grpBoxInfoDonateur";
            this.grpBoxInfoDonateur.Size = new System.Drawing.Size(353, 361);
            this.grpBoxInfoDonateur.TabIndex = 29;
            this.grpBoxInfoDonateur.TabStop = false;
            this.grpBoxInfoDonateur.Text = "Information du nouveau donateur";
            // 
            // lblAsterique
            // 
            this.lblAsterique.AutoSize = true;
            this.lblAsterique.ForeColor = System.Drawing.Color.Red;
            this.lblAsterique.Location = new System.Drawing.Point(104, 162);
            this.lblAsterique.Name = "lblAsterique";
            this.lblAsterique.Size = new System.Drawing.Size(16, 20);
            this.lblAsterique.TabIndex = 17;
            this.lblAsterique.Text = "*";
            // 
            // mskTxtBoxTelephone
            // 
            this.mskTxtBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxTelephone.Location = new System.Drawing.Point(127, 214);
            this.mskTxtBoxTelephone.Name = "mskTxtBoxTelephone";
            this.mskTxtBoxTelephone.Size = new System.Drawing.Size(211, 24);
            this.mskTxtBoxTelephone.TabIndex = 16;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(6, 217);
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
            this.lblPrenom.Location = new System.Drawing.Point(6, 50);
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
            this.lblNom.Location = new System.Drawing.Point(6, 106);
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
            this.lblEmail.Location = new System.Drawing.Point(7, 160);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Courriel:";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(127, 50);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(211, 24);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(127, 106);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(211, 24);
            this.txtNom.TabIndex = 2;
            // 
            // txtCourriel
            // 
            this.txtCourriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourriel.Location = new System.Drawing.Point(127, 160);
            this.txtCourriel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(211, 24);
            this.txtCourriel.TabIndex = 3;
            // 
            // btnAjouterDonnateur
            // 
            this.btnAjouterDonnateur.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAjouterDonnateur.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDonnateur.Location = new System.Drawing.Point(11, 297);
            this.btnAjouterDonnateur.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterDonnateur.Name = "btnAjouterDonnateur";
            this.btnAjouterDonnateur.Size = new System.Drawing.Size(327, 41);
            this.btnAjouterDonnateur.TabIndex = 9;
            this.btnAjouterDonnateur.Text = "CONFIRMER";
            this.btnAjouterDonnateur.UseVisualStyleBackColor = false;
            this.btnAjouterDonnateur.Click += new System.EventHandler(this.btnAjouterDonnateur_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::AppTelethon.Properties.Resources.chien_dor_logo1;
            this.picLogo.Location = new System.Drawing.Point(29, 34);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(224, 147);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 32;
            this.picLogo.TabStop = false;
            // 
            // UserControl_AddDonateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.pnlBorder);
            this.Name = "UserControl_AddDonateur";
            this.Size = new System.Drawing.Size(1199, 666);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.grpBoxInfoDonateur.ResumeLayout(false);
            this.grpBoxInfoDonateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.GroupBox grpBoxInfoDonateur;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Button btnAjouterDonnateur;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblAsterique;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
