namespace AppTelethon
{
    partial class UserControl_ListDonateur
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
            this.lblInfoDonateur = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dgvDonnateur = new System.Windows.Forms.DataGridView();
            this.donateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoDonateur
            // 
            this.lblInfoDonateur.AutoSize = true;
            this.lblInfoDonateur.BackColor = System.Drawing.Color.Bisque;
            this.lblInfoDonateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDonateur.Location = new System.Drawing.Point(455, 20);
            this.lblInfoDonateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoDonateur.Name = "lblInfoDonateur";
            this.lblInfoDonateur.Size = new System.Drawing.Size(359, 20);
            this.lblInfoDonateur.TabIndex = 0;
            this.lblInfoDonateur.Text = "Affichage des informations des donateurs";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Bisque;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(18, 552);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(222, 39);
            this.btnRetour.TabIndex = 27;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dgvDonnateur
            // 
            this.dgvDonnateur.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvDonnateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonnateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonnateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donateur});
            this.dgvDonnateur.Location = new System.Drawing.Point(267, 111);
            this.dgvDonnateur.Name = "dgvDonnateur";
            this.dgvDonnateur.RowHeadersWidth = 51;
            this.dgvDonnateur.RowTemplate.Height = 24;
            this.dgvDonnateur.Size = new System.Drawing.Size(889, 480);
            this.dgvDonnateur.TabIndex = 28;
            // 
            // donateur
            // 
            this.donateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donateur.HeaderText = "Donnateurs";
            this.donateur.MinimumWidth = 6;
            this.donateur.Name = "donateur";
            this.donateur.ReadOnly = true;
            this.donateur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.donateur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppTelethon.Properties.Resources.chien_dor_logo3;
            this.pictureBox1.Location = new System.Drawing.Point(16, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl_ListDonateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::AppTelethon.Properties.Resources.chien_dor_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDonnateur);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblInfoDonateur);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_ListDonateur";
            this.Size = new System.Drawing.Size(1199, 666);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoDonateur;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dgvDonnateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn donateur;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}