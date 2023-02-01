namespace AppTelethon
{
    partial class UserControl_ListPrix
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
            this.lblListePrix = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dgvPrix = new System.Windows.Forms.DataGridView();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListePrix
            // 
            this.lblListePrix.AutoSize = true;
            this.lblListePrix.BackColor = System.Drawing.Color.Bisque;
            this.lblListePrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePrix.Location = new System.Drawing.Point(593, 42);
            this.lblListePrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListePrix.Name = "lblListePrix";
            this.lblListePrix.Size = new System.Drawing.Size(140, 25);
            this.lblListePrix.TabIndex = 7;
            this.lblListePrix.Text = "Liste des prix";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Bisque;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(19, 555);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(222, 39);
            this.btnRetour.TabIndex = 27;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dgvPrix
            // 
            this.dgvPrix.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prix});
            this.dgvPrix.Location = new System.Drawing.Point(258, 114);
            this.dgvPrix.Name = "dgvPrix";
            this.dgvPrix.RowHeadersWidth = 51;
            this.dgvPrix.RowTemplate.Height = 24;
            this.dgvPrix.Size = new System.Drawing.Size(904, 480);
            this.dgvPrix.TabIndex = 30;
            // 
            // prix
            // 
            this.prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prix.HeaderText = "Prix";
            this.prix.MinimumWidth = 6;
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            this.prix.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppTelethon.Properties.Resources.chien_dor_logo3;
            this.pictureBox1.Location = new System.Drawing.Point(19, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl_ListPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppTelethon.Properties.Resources.chien_dor_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPrix);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblListePrix);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_ListPrix";
            this.Size = new System.Drawing.Size(1199, 666);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListePrix;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dgvPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}