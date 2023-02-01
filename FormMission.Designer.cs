namespace AppTelethon
{
    partial class frmMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMission));
            this.btnRetour = new System.Windows.Forms.Button();
            this.picHope = new System.Windows.Forms.PictureBox();
            this.picDame = new System.Windows.Forms.PictureBox();
            this.pnlTexte = new System.Windows.Forms.Panel();
            this.lblHistoire = new System.Windows.Forms.Label();
            this.richTxtHistoire = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picHope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDame)).BeginInit();
            this.pnlTexte.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Bisque;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(22, 737);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(177, 41);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // picHope
            // 
            this.picHope.Image = global::AppTelethon.Properties.Resources.Hope;
            this.picHope.Location = new System.Drawing.Point(22, 12);
            this.picHope.Name = "picHope";
            this.picHope.Size = new System.Drawing.Size(345, 227);
            this.picHope.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHope.TabIndex = 1;
            this.picHope.TabStop = false;
            // 
            // picDame
            // 
            this.picDame.Image = global::AppTelethon.Properties.Resources.oldwoman;
            this.picDame.Location = new System.Drawing.Point(296, 203);
            this.picDame.Name = "picDame";
            this.picDame.Size = new System.Drawing.Size(275, 219);
            this.picDame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDame.TabIndex = 2;
            this.picDame.TabStop = false;
            // 
            // pnlTexte
            // 
            this.pnlTexte.BackColor = System.Drawing.Color.Bisque;
            this.pnlTexte.Controls.Add(this.lblHistoire);
            this.pnlTexte.Controls.Add(this.richTxtHistoire);
            this.pnlTexte.Location = new System.Drawing.Point(549, 12);
            this.pnlTexte.Name = "pnlTexte";
            this.pnlTexte.Size = new System.Drawing.Size(614, 777);
            this.pnlTexte.TabIndex = 4;
            // 
            // lblHistoire
            // 
            this.lblHistoire.AutoSize = true;
            this.lblHistoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoire.Location = new System.Drawing.Point(111, 15);
            this.lblHistoire.Name = "lblHistoire";
            this.lblHistoire.Size = new System.Drawing.Size(353, 20);
            this.lblHistoire.TabIndex = 1;
            this.lblHistoire.Text = "LA NOUVELLE VIE DE MARIE ET HOPE";
            // 
            // richTxtHistoire
            // 
            this.richTxtHistoire.BackColor = System.Drawing.Color.Bisque;
            this.richTxtHistoire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtHistoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtHistoire.Location = new System.Drawing.Point(40, 58);
            this.richTxtHistoire.Name = "richTxtHistoire";
            this.richTxtHistoire.Size = new System.Drawing.Size(559, 689);
            this.richTxtHistoire.TabIndex = 0;
            this.richTxtHistoire.Text = resources.GetString("richTxtHistoire.Text");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppTelethon.Properties.Resources.Rainbow;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 801);
            this.panel1.TabIndex = 5;
            // 
            // frmMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppTelethon.Properties.Resources.Rainbow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 801);
            this.Controls.Add(this.picDame);
            this.Controls.Add(this.pnlTexte);
            this.Controls.Add(this.picHope);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMission";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picHope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDame)).EndInit();
            this.pnlTexte.ResumeLayout(false);
            this.pnlTexte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.PictureBox picHope;
        private System.Windows.Forms.PictureBox picDame;
        private System.Windows.Forms.Panel pnlTexte;
        private System.Windows.Forms.RichTextBox richTxtHistoire;
        private System.Windows.Forms.Label lblHistoire;
        private System.Windows.Forms.Panel panel1;
    }
}