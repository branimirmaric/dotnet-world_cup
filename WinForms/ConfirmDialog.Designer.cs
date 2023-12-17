namespace WinForms
{
    partial class ConfirmDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmDialog));
            lblMessage = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            resources.ApplyResources(lblMessage, "lblMessage");
            lblMessage.Name = "lblMessage";
            // 
            // btnConfirm
            // 
            resources.ApplyResources(btnConfirm, "btnConfirm");
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.DialogResult = DialogResult.OK;
            btnConfirm.Name = "btnConfirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.KeyDown += Buttons_KeyDown;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.KeyDown += Buttons_KeyDown;
            // 
            // ConfirmDialog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblMessage);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private Button btnConfirm;
        private Button btnCancel;
    }
}