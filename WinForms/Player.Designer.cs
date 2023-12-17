namespace WinForms
{
    partial class Player
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
            lblName = new Label();
            lblShirtNumber = new Label();
            lblPosition = new Label();
            lblCaptain = new Label();
            pbFavourite = new PictureBox();
            pbIcon = new PictureBox();
            lblFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFavourite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(3, 119);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 17);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblShirtNumber
            // 
            lblShirtNumber.AutoSize = true;
            lblShirtNumber.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblShirtNumber.ForeColor = Color.White;
            lblShirtNumber.Location = new Point(3, 169);
            lblShirtNumber.Name = "lblShirtNumber";
            lblShirtNumber.Size = new Size(45, 17);
            lblShirtNumber.TabIndex = 1;
            lblShirtNumber.Text = "label2";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPosition.ForeColor = Color.White;
            lblPosition.Location = new Point(3, 144);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(45, 17);
            lblPosition.TabIndex = 2;
            lblPosition.Text = "label3";
            // 
            // lblCaptain
            // 
            lblCaptain.AutoSize = true;
            lblCaptain.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaptain.ForeColor = Color.White;
            lblCaptain.Location = new Point(108, 169);
            lblCaptain.Name = "lblCaptain";
            lblCaptain.Size = new Size(45, 17);
            lblCaptain.TabIndex = 3;
            lblCaptain.Text = "label4";
            lblCaptain.TextAlign = ContentAlignment.TopRight;
            // 
            // pbFavourite
            // 
            pbFavourite.Image = Properties.Resources.star;
            pbFavourite.Location = new Point(159, 162);
            pbFavourite.Name = "pbFavourite";
            pbFavourite.Size = new Size(25, 25);
            pbFavourite.SizeMode = PictureBoxSizeMode.Zoom;
            pbFavourite.TabIndex = 4;
            pbFavourite.TabStop = false;
            // 
            // pbIcon
            // 
            pbIcon.Dock = DockStyle.Top;
            pbIcon.ErrorImage = Properties.Resources.person;
            pbIcon.Location = new Point(0, 0);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(187, 116);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 5;
            pbIcon.TabStop = false;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilter.ForeColor = Color.White;
            lblFilter.Location = new Point(139, 144);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(45, 17);
            lblFilter.TabIndex = 6;
            lblFilter.Text = "label5";
            lblFilter.TextAlign = ContentAlignment.TopRight;
            // 
            // Player
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            Controls.Add(pbFavourite);
            Controls.Add(lblFilter);
            Controls.Add(pbIcon);
            Controls.Add(lblCaptain);
            Controls.Add(lblPosition);
            Controls.Add(lblShirtNumber);
            Controls.Add(lblName);
            Name = "Player";
            Size = new Size(187, 191);
            MouseDown += Player_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbFavourite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblShirtNumber;
        private Label lblPosition;
        private Label lblCaptain;
        private PictureBox pbFavourite;
        private PictureBox pbIcon;
        private Label lblFilter;
    }
}
