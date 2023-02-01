namespace AppTelethon
{
    partial class FormLogin
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
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.lblMotPasse = new System.Windows.Forms.Label();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMotPasse = new System.Windows.Forms.TextBox();
            this.btnEntrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.picMotPasse = new System.Windows.Forms.PictureBox();
            this.picUtilisateur = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picLogo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMotPasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilisateur.Location = new System.Drawing.Point(392, 223);
            this.lblUtilisateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(96, 20);
            this.lblUtilisateur.TabIndex = 0;
            this.lblUtilisateur.Text = "Utilisateur";
            // 
            // lblMotPasse
            // 
            this.lblMotPasse.AutoSize = true;
            this.lblMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotPasse.Location = new System.Drawing.Point(392, 329);
            this.lblMotPasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotPasse.Name = "lblMotPasse";
            this.lblMotPasse.Size = new System.Drawing.Size(122, 20);
            this.lblMotPasse.TabIndex = 1;
            this.lblMotPasse.Text = "Mot de passe";
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(644, 217);
            this.txtUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(239, 22);
            this.txtUtilisateur.TabIndex = 2;
            this.txtUtilisateur.TextChanged += new System.EventHandler(this.txtUtilisateur_TextChanged);
            // 
            // txtMotPasse
            // 
            this.txtMotPasse.Location = new System.Drawing.Point(644, 329);
            this.txtMotPasse.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotPasse.Name = "txtMotPasse";
            this.txtMotPasse.Size = new System.Drawing.Size(226, 22);
            this.txtMotPasse.TabIndex = 3;
            this.txtMotPasse.TextChanged += new System.EventHandler(this.txtMotPasse_changed);
            // 
            // btnEntrer
            // 
            this.btnEntrer.Location = new System.Drawing.Point(797, 466);
            this.btnEntrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrer.Name = "btnEntrer";
            this.btnEntrer.Size = new System.Drawing.Size(100, 28);
            this.btnEntrer.TabIndex = 4;
            this.btnEntrer.Text = "Valider";
            this.btnEntrer.UseVisualStyleBackColor = true;
            this.btnEntrer.Click += new System.EventHandler(this.btnEntrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(625, 466);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitre.Location = new System.Drawing.Point(587, 57);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(160, 29);
            this.lblTitre.TabIndex = 11;
            this.lblTitre.Text = "BIENVENUE";
            // 
            // picMotPasse
            // 
            this.picMotPasse.Image = global::AppTelethon.Properties.Resources.icons8_Password_Key;
            this.picMotPasse.Location = new System.Drawing.Point(535, 312);
            this.picMotPasse.Margin = new System.Windows.Forms.Padding(4);
            this.picMotPasse.Name = "picMotPasse";
            this.picMotPasse.Size = new System.Drawing.Size(41, 37);
            this.picMotPasse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMotPasse.TabIndex = 10;
            this.picMotPasse.TabStop = false;
            // 
            // picUtilisateur
            // 
            this.picUtilisateur.Image = global::AppTelethon.Properties.Resources.icons8_user;
            this.picUtilisateur.Location = new System.Drawing.Point(535, 202);
            this.picUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.picUtilisateur.Name = "picUtilisateur";
            this.picUtilisateur.Size = new System.Drawing.Size(41, 37);
            this.picUtilisateur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUtilisateur.TabIndex = 9;
            this.picUtilisateur.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppTelethon.Properties.Resources.eye_24px;
            this.pictureBox2.Location = new System.Drawing.Point(887, 329);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picLogo2
            // 
            this.picLogo2.Image = global::AppTelethon.Properties.Resources.chien_dor_logo;
            this.picLogo2.Location = new System.Drawing.Point(35, 22);
            this.picLogo2.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo2.Name = "picLogo2";
            this.picLogo2.Size = new System.Drawing.Size(244, 150);
            this.picLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo2.TabIndex = 7;
            this.picLogo2.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1229, 683);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.picMotPasse);
            this.Controls.Add(this.picUtilisateur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picLogo2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEntrer);
            this.Controls.Add(this.txtMotPasse);
            this.Controls.Add(this.txtUtilisateur);
            this.Controls.Add(this.lblMotPasse);
            this.Controls.Add(this.lblUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.picMotPasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Label lblMotPasse;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.TextBox txtMotPasse;
        private System.Windows.Forms.Button btnEntrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.PictureBox picLogo2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picUtilisateur;
        private System.Windows.Forms.PictureBox picMotPasse;
        private System.Windows.Forms.Label lblTitre;
    }
}

