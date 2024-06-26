﻿namespace CompanionFormApp.Git
{
    partial class GitCommitForm
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
            txbxCommitMessage = new TextBox();
            btnGitCommit = new Button();
            SuspendLayout();
            // 
            // txbxCommitMessage
            // 
            txbxCommitMessage.BackColor = Color.LemonChiffon;
            txbxCommitMessage.Location = new Point(12, 12);
            txbxCommitMessage.Name = "txbxCommitMessage";
            txbxCommitMessage.Size = new Size(432, 23);
            txbxCommitMessage.TabIndex = 0;
            txbxCommitMessage.KeyPress += txbxCommitMessage_KeyPress;
            // 
            // btnGitCommit
            // 
            btnGitCommit.BackColor = Color.LemonChiffon;
            btnGitCommit.Location = new Point(462, 12);
            btnGitCommit.Name = "btnGitCommit";
            btnGitCommit.Size = new Size(75, 23);
            btnGitCommit.TabIndex = 1;
            btnGitCommit.Text = "Commit";
            btnGitCommit.UseVisualStyleBackColor = false;
            btnGitCommit.Click += btnGitCommit_Clicked;
            // 
            // GitCommitForm
            // 
            AcceptButton = btnGitCommit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(554, 67);
            Controls.Add(btnGitCommit);
            Controls.Add(txbxCommitMessage);
            Name = "GitCommitForm";
            ShowIcon = false;
            Text = "Make A Commit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbxCommitMessage;
        private Button btnGitCommit;
    }
}