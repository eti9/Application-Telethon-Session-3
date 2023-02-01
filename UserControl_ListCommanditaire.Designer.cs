namespace AppTelethon
{
    partial class UserControl_ListCommanditaire
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
            this.lblListeComm = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dgvCommanditaire = new System.Windows.Forms.DataGridView();
            this.commanditaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommanditaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListeComm
            // 
            this.lblListeComm.AutoSize = true;
            this.lblListeComm.BackColor = System.Drawing.Color.Bisque;
            this.lblListeComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeComm.Location = new System.Drawing.Point(499, 26);
            this.lblListeComm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListeComm.Name = "lblListeComm";
            this.lblListeComm.Size = new System.Drawing.Size(287, 29);
            this.lblListeComm.TabIndex = 5;
            this.lblListeComm.Text = "Liste des commanditaires";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Bisque;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(22, 559);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(222, 39);
            this.btnRetour.TabIndex = 26;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dgvCommanditaire
            // 
            this.dgvCommanditaire.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvCommanditaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCommanditaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommanditaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commanditaire});
            this.dgvCommanditaire.Location = new System.Drawing.Point(266, 118);
            this.dgvCommanditaire.Name = "dgvCommanditaire";
            this.dgvCommanditaire.RowHeadersWidth = 51;
            this.dgvCommanditaire.RowTemplate.Height = 24;
            this.dgvCommanditaire.Size = new System.Drawing.Size(889, 480);
            this.dgvCommanditaire.TabIndex = 27;
            // 
            // commanditaire
            // 
            this.commanditaire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commanditaire.HeaderText = "Commanditaire";
            this.commanditaire.MinimumWidth = 6;
            this.commanditaire.Name = "commanditaire";
            this.commanditaire.ReadOnly = true;
            this.commanditaire.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.commanditaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppTelethon.Properties.Resources.chien_dor_logo3;
            this.pictureBox1.Location = new System.Drawing.Point(20, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl_ListCommanditaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppTelethon.Properties.Resources.chien_dor_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvCommanditaire);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblListeComm);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_ListCommanditaire";
            this.Size = new System.Drawing.Size(1199, 666);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommanditaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListeComm;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dgvCommanditaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn commanditaire;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}