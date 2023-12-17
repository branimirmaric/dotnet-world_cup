namespace WinForms
{
    partial class Settings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            cbChampionship = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnConfirm = new Button();
            gbLanguage = new GroupBox();
            rbEng = new RadioButton();
            rbCro = new RadioButton();
            lblWpf = new Label();
            rbSmall = new RadioButton();
            rbMedium = new RadioButton();
            gbResolution = new GroupBox();
            rbFullScreen = new RadioButton();
            gbLanguage.SuspendLayout();
            gbResolution.SuspendLayout();
            SuspendLayout();
            // 
            // cbChampionship
            // 
            cbChampionship.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChampionship.FormattingEnabled = true;
            resources.ApplyResources(cbChampionship, "cbChampionship");
            cbChampionship.Name = "cbChampionship";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // btnConfirm
            // 
            btnConfirm.Cursor = Cursors.Hand;
            resources.ApplyResources(btnConfirm, "btnConfirm");
            btnConfirm.Name = "btnConfirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += BtnConfirm_Click;
            // 
            // gbLanguage
            // 
            gbLanguage.Controls.Add(rbEng);
            gbLanguage.Controls.Add(rbCro);
            resources.ApplyResources(gbLanguage, "gbLanguage");
            gbLanguage.Name = "gbLanguage";
            gbLanguage.TabStop = false;
            // 
            // rbEng
            // 
            resources.ApplyResources(rbEng, "rbEng");
            rbEng.Checked = true;
            rbEng.Name = "rbEng";
            rbEng.TabStop = true;
            rbEng.Tag = "en-GB";
            rbEng.UseVisualStyleBackColor = true;
            // 
            // rbCro
            // 
            resources.ApplyResources(rbCro, "rbCro");
            rbCro.Name = "rbCro";
            rbCro.Tag = "hr";
            rbCro.UseVisualStyleBackColor = true;
            // 
            // lblWpf
            // 
            resources.ApplyResources(lblWpf, "lblWpf");
            lblWpf.Name = "lblWpf";
            // 
            // rbSmall
            // 
            resources.ApplyResources(rbSmall, "rbSmall");
            rbSmall.Name = "rbSmall";
            rbSmall.Tag = "400x600";
            rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            resources.ApplyResources(rbMedium, "rbMedium");
            rbMedium.Name = "rbMedium";
            rbMedium.Tag = "700x900";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // gbResolution
            // 
            gbResolution.Controls.Add(rbFullScreen);
            gbResolution.Controls.Add(rbSmall);
            gbResolution.Controls.Add(rbMedium);
            resources.ApplyResources(gbResolution, "gbResolution");
            gbResolution.Name = "gbResolution";
            gbResolution.TabStop = false;
            // 
            // rbFullScreen
            // 
            resources.ApplyResources(rbFullScreen, "rbFullScreen");
            rbFullScreen.Name = "rbFullScreen";
            rbFullScreen.Tag = "FullScreen";
            rbFullScreen.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbResolution);
            Controls.Add(lblWpf);
            Controls.Add(gbLanguage);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbChampionship);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            gbLanguage.ResumeLayout(false);
            gbLanguage.PerformLayout();
            gbResolution.ResumeLayout(false);
            gbResolution.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbChampionship;
        private Label label1;
        private Label label2;
        private Button btnConfirm;
        private GroupBox gbLanguage;
        private RadioButton rbEng;
        private RadioButton rbCro;
        private Label lblWpf;
        private RadioButton rbSmall;
        private RadioButton rbMedium;
        private GroupBox gbResolution;
        private RadioButton rbFullScreen;
    }
}