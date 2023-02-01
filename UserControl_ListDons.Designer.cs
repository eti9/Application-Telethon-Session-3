namespace AppTelethon
{
    partial class UserControl_ListDons
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
            this.lblListeDons = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dgvDons = new System.Windows.Forms.DataGridView();
            this.dons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListeDons
            // 
            this.lblListeDons.AutoSize = true;
            this.lblListeDons.BackColor = System.Drawing.Color.Bisque;
            this.lblListeDons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeDons.Location = new System.Drawing.Point(561, 32);
            this.lblListeDons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListeDons.Name = "lblListeDons";
            this.lblListeDons.Size = new System.Drawing.Size(138, 25);
            this.lblListeDons.TabIndex = 1;
            this.lblListeDons.Text = "Liste des dons";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Bisque;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(14, 544);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(222, 39);
            this.btnRetour.TabIndex = 27;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dgvDons
            // 
            this.dgvDons.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvDons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dons});
            this.dgvDons.Location = new System.Drawing.Point(266, 103);
            this.dgvDons.Name = "dgvDons";
            this.dgvDons.RowHeadersWidth = 51;
            this.dgvDons.RowTemplate.Height = 24;
            this.dgvDons.Size = new System.Drawing.Size(904, 480);
            this.dgvDons.TabIndex = 29;
            // 
            // dons
            // 
            this.dons.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dons.HeaderText = "Dons";
            this.dons.MinimumWidth = 6;
            this.dons.Name = "dons";
            this.dons.ReadOnly = true;
            this.dons.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dons.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppTelethon.Properties.Resources.chien_dor_logo3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl_ListDons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppTelethon.Properties.Resources.chien_dor_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDons);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblListeDons);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_ListDons";
            this.Size = new System.Drawing.Size(1199, 666);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListeDons;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dgvDons;
        private System.Windows.Forms.DataGridViewTextBoxColumn dons;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}