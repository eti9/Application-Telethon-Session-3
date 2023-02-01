namespace AppTelethon
{
    partial class UserControl_FindCreateCommanditaire
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
            this.grpBox_identifier = new System.Windows.Forms.GroupBox();
            this.mskTxtBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblOu = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBorder.SuspendLayout();
            this.grpBox_identifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.picLogo);
            this.pnlBorder.Controls.Add(this.grpBox_identifier);
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1199, 666);
            this.pnlBorder.TabIndex = 0;
            // 
            // grpBox_identifier
            // 
            this.grpBox_identifier.Controls.Add(this.mskTxtBoxTelephone);
            this.grpBox_identifier.Controls.Add(this.btnAjouter);
            this.grpBox_identifier.Controls.Add(this.lblOu);
            this.grpBox_identifier.Controls.Add(this.btnRechercher);
            this.grpBox_identifier.Controls.Add(this.txtBoxNom);
            this.grpBox_identifier.Controls.Add(this.txtBoxPrenom);
            this.grpBox_identifier.Controls.Add(this.lblTelephone);
            this.grpBox_identifier.Controls.Add(this.lblNom);
            this.grpBox_identifier.Controls.Add(this.lblPrenom);
            this.grpBox_identifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_identifier.Location = new System.Drawing.Point(394, 168);
            this.grpBox_identifier.Name = "grpBox_identifier";
            this.grpBox_identifier.Size = new System.Drawing.Size(420, 371);
            this.grpBox_identifier.TabIndex = 22;
            this.grpBox_identifier.TabStop = false;
            this.grpBox_identifier.Text = "Identifier le commanditaire";
            // 
            // mskTxtBoxTelephone
            // 
            this.mskTxtBoxTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTxtBoxTelephone.Location = new System.Drawing.Point(161, 121);
            this.mskTxtBoxTelephone.Mask = "(999) 000-0000";
            this.mskTxtBoxTelephone.Name = "mskTxtBoxTelephone";
            this.mskTxtBoxTelephone.Size = new System.Drawing.Size(205, 27);
            this.mskTxtBoxTelephone.TabIndex = 7;
            this.mskTxtBoxTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(24, 265);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(374, 52);
            this.btnAjouter.TabIndex = 24;
            this.btnAjouter.Text = "CREER UN COMMANDITAIRE";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblOu
            // 
            this.lblOu.AutoSize = true;
            this.lblOu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOu.Location = new System.Drawing.Point(197, 232);
            this.lblOu.Name = "lblOu";
            this.lblOu.Size = new System.Drawing.Size(36, 20);
            this.lblOu.TabIndex = 23;
            this.lblOu.Text = "OU";
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(58, 183);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(308, 33);
            this.btnRechercher.TabIndex = 6;
            this.btnRechercher.Text = "SUIVANT";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNom.Location = new System.Drawing.Point(161, 92);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(205, 27);
            this.txtBoxNom.TabIndex = 4;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrenom.Location = new System.Drawing.Point(161, 63);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(205, 27);
            this.txtBoxPrenom.TabIndex = 3;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(54, 128);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(96, 20);
            this.lblTelephone.TabIndex = 2;
            this.lblTelephone.Text = "Telephone: ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(54, 99);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom: ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(54, 63);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(77, 20);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prenom: ";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::AppTelethon.Properties.Resources.chien_dor_logo1;
            this.picLogo.Location = new System.Drawing.Point(19, 19);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(224, 147);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 24;
            this.picLogo.TabStop = false;
            // 
            // UserControl_FindCreateCommanditaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.pnlBorder);
            this.Name = "UserControl_FindCreateCommanditaire";
            this.Size = new System.Drawing.Size(1199, 666);
            this.pnlBorder.ResumeLayout(false);
            this.grpBox_identifier.ResumeLayout(false);
            this.grpBox_identifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.GroupBox grpBox_identifier;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxTelephone;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblOu;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
