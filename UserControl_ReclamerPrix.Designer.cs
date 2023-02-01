namespace AppTelethon
{
    partial class UserControl_ReclamerPrix
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
            this.dgvListPrix = new System.Windows.Forms.DataGridView();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitre = new System.Windows.Forms.Label();
            this.grpBoxPrix = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxPoints = new System.Windows.Forms.TextBox();
            this.lblNbPts = new System.Windows.Forms.Label();
            this.btnReclamerPrix = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPrix)).BeginInit();
            this.grpBoxPrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.picLogo);
            this.pnlBorder.Controls.Add(this.lblTitre);
            this.pnlBorder.Controls.Add(this.grpBoxPrix);
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(1199, 666);
            this.pnlBorder.TabIndex = 0;
            // 
            // dgvListPrix
            // 
            this.dgvListPrix.BackgroundColor = System.Drawing.Color.White;
            this.dgvListPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListPrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prix});
            this.dgvListPrix.Location = new System.Drawing.Point(6, 26);
            this.dgvListPrix.Name = "dgvListPrix";
            this.dgvListPrix.RowHeadersWidth = 51;
            this.dgvListPrix.RowTemplate.Height = 24;
            this.dgvListPrix.Size = new System.Drawing.Size(615, 369);
            this.dgvListPrix.TabIndex = 23;
            // 
            // prix
            // 
            this.prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prix.HeaderText = "";
            this.prix.MinimumWidth = 6;
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            this.prix.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblTitre.Location = new System.Drawing.Point(443, 27);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(345, 29);
            this.lblTitre.TabIndex = 22;
            this.lblTitre.Text = "MENU RECLAMER UN PRIX";
            // 
            // grpBoxPrix
            // 
            this.grpBoxPrix.Controls.Add(this.dgvListPrix);
            this.grpBoxPrix.Controls.Add(this.button1);
            this.grpBoxPrix.Controls.Add(this.txtBoxPoints);
            this.grpBoxPrix.Controls.Add(this.lblNbPts);
            this.grpBoxPrix.Controls.Add(this.btnReclamerPrix);
            this.grpBoxPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPrix.Location = new System.Drawing.Point(308, 81);
            this.grpBoxPrix.Name = "grpBoxPrix";
            this.grpBoxPrix.Size = new System.Drawing.Size(632, 514);
            this.grpBoxPrix.TabIndex = 0;
            this.grpBoxPrix.TabStop = false;
            this.grpBoxPrix.Text = "Liste des prix disponibles";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(115, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 43);
            this.button1.TabIndex = 23;
            this.button1.Text = "ANNULER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxPoints
            // 
            this.txtBoxPoints.Enabled = false;
            this.txtBoxPoints.Location = new System.Drawing.Point(377, 417);
            this.txtBoxPoints.Name = "txtBoxPoints";
            this.txtBoxPoints.Size = new System.Drawing.Size(153, 27);
            this.txtBoxPoints.TabIndex = 3;
            // 
            // lblNbPts
            // 
            this.lblNbPts.AutoSize = true;
            this.lblNbPts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbPts.Location = new System.Drawing.Point(111, 404);
            this.lblNbPts.Name = "lblNbPts";
            this.lblNbPts.Size = new System.Drawing.Size(146, 40);
            this.lblNbPts.TabIndex = 2;
            this.lblNbPts.Text = "Nombre de points \r\ndisponible:";
            this.lblNbPts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReclamerPrix
            // 
            this.btnReclamerPrix.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnReclamerPrix.ForeColor = System.Drawing.Color.White;
            this.btnReclamerPrix.Location = new System.Drawing.Point(335, 465);
            this.btnReclamerPrix.Name = "btnReclamerPrix";
            this.btnReclamerPrix.Size = new System.Drawing.Size(222, 43);
            this.btnReclamerPrix.TabIndex = 1;
            this.btnReclamerPrix.Text = "RECLAMER LE PRIX";
            this.btnReclamerPrix.UseVisualStyleBackColor = false;
            this.btnReclamerPrix.Click += new System.EventHandler(this.btnReclamerPrix_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::AppTelethon.Properties.Resources.chien_dor_logo1;
            this.picLogo.Location = new System.Drawing.Point(31, 40);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(224, 147);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 25;
            this.picLogo.TabStop = false;
            // 
            // UserControl_ReclamerPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.pnlBorder);
            this.Name = "UserControl_ReclamerPrix";
            this.Size = new System.Drawing.Size(1199, 666);
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPrix)).EndInit();
            this.grpBoxPrix.ResumeLayout(false);
            this.grpBoxPrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.GroupBox grpBoxPrix;
        private System.Windows.Forms.Label lblNbPts;
        private System.Windows.Forms.Button btnReclamerPrix;
        private System.Windows.Forms.TextBox txtBoxPoints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgvListPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
