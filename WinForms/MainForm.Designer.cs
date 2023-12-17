namespace WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            cbTeam = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            pnlFavouritePlayers = new FlowLayoutPanel();
            pnlAllPlayers = new FlowLayoutPanel();
            btnSettings = new Button();
            btnSaveFavourites = new Button();
            pnlContainer = new FlowLayoutPanel();
            btnMatches = new Button();
            btnYellowCards = new Button();
            btnTopScorers = new Button();
            btnPrint = new Button();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // cbTeam
            // 
            resources.ApplyResources(cbTeam, "cbTeam");
            cbTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeam.FormattingEnabled = true;
            cbTeam.Name = "cbTeam";
            cbTeam.SelectedIndexChanged += CbTeam_SelectedIndexChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // pnlFavouritePlayers
            // 
            resources.ApplyResources(pnlFavouritePlayers, "pnlFavouritePlayers");
            pnlFavouritePlayers.AllowDrop = true;
            pnlFavouritePlayers.BorderStyle = BorderStyle.FixedSingle;
            pnlFavouritePlayers.Name = "pnlFavouritePlayers";
            pnlFavouritePlayers.DragDrop += PnlFavouritePlayers_DragDrop;
            pnlFavouritePlayers.DragEnter += PnlPlayers_DragEnter;
            // 
            // pnlAllPlayers
            // 
            resources.ApplyResources(pnlAllPlayers, "pnlAllPlayers");
            pnlAllPlayers.AllowDrop = true;
            pnlAllPlayers.BorderStyle = BorderStyle.FixedSingle;
            pnlAllPlayers.Name = "pnlAllPlayers";
            pnlAllPlayers.DragDrop += PnlAllPlayers_DragDrop;
            pnlAllPlayers.DragEnter += PnlPlayers_DragEnter;
            // 
            // btnSettings
            // 
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Name = "btnSettings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += BtnSettings_Click;
            // 
            // btnSaveFavourites
            // 
            resources.ApplyResources(btnSaveFavourites, "btnSaveFavourites");
            btnSaveFavourites.Cursor = Cursors.Hand;
            btnSaveFavourites.Name = "btnSaveFavourites";
            btnSaveFavourites.UseVisualStyleBackColor = true;
            btnSaveFavourites.Click += BtnSaveFavourites_Click;
            // 
            // pnlContainer
            // 
            resources.ApplyResources(pnlContainer, "pnlContainer");
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Name = "pnlContainer";
            // 
            // btnMatches
            // 
            resources.ApplyResources(btnMatches, "btnMatches");
            btnMatches.Cursor = Cursors.Hand;
            btnMatches.Name = "btnMatches";
            btnMatches.UseVisualStyleBackColor = true;
            btnMatches.Click += BtnMatches_Click;
            // 
            // btnYellowCards
            // 
            resources.ApplyResources(btnYellowCards, "btnYellowCards");
            btnYellowCards.Cursor = Cursors.Hand;
            btnYellowCards.Name = "btnYellowCards";
            btnYellowCards.UseVisualStyleBackColor = true;
            btnYellowCards.Click += BtnYellowCards_Click;
            // 
            // btnTopScorers
            // 
            resources.ApplyResources(btnTopScorers, "btnTopScorers");
            btnTopScorers.Cursor = Cursors.Hand;
            btnTopScorers.Name = "btnTopScorers";
            btnTopScorers.UseVisualStyleBackColor = true;
            btnTopScorers.Click += BtnTopScorers_Click;
            // 
            // btnPrint
            // 
            resources.ApplyResources(btnPrint, "btnPrint");
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Name = "btnPrint";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += BtnPrint_Click;
            // 
            // printDocument
            // 
            printDocument.PrintPage += PrintDocument_PrintPage;
            // 
            // printPreviewDialog
            // 
            resources.ApplyResources(printPreviewDialog, "printPreviewDialog");
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Name = "printPreviewDialog";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPrint);
            Controls.Add(btnMatches);
            Controls.Add(btnYellowCards);
            Controls.Add(btnTopScorers);
            Controls.Add(pnlContainer);
            Controls.Add(btnSaveFavourites);
            Controls.Add(btnSettings);
            Controls.Add(pnlAllPlayers);
            Controls.Add(pnlFavouritePlayers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbTeam);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbTeam;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel pnlFavouritePlayers;
        private FlowLayoutPanel pnlAllPlayers;
        private Button btnSettings;
        private Button btnSaveFavourites;
        private FlowLayoutPanel pnlContainer;
        private Button btnMatches;
        private Button btnYellowCards;
        private Button btnTopScorers;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
    }
}