namespace CompanionFormApp
{
    partial class GitStashForm
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
            txbxStashMessage = new TextBox();
            btnGitStash = new Button();
            SuspendLayout();
            // 
            // txbxStashMessage
            // 
            txbxStashMessage.Location = new Point(12, 12);
            txbxStashMessage.Name = "txbxStashMessage";
            txbxStashMessage.Size = new Size(432, 23);
            txbxStashMessage.TabIndex = 0;
            txbxStashMessage.KeyPress += txbxStashMessage_KeyPress;
            // 
            // btnGitStash
            // 
            btnGitStash.Location = new Point(462, 12);
            btnGitStash.Name = "btnGitStash";
            btnGitStash.Size = new Size(75, 23);
            btnGitStash.TabIndex = 1;
            btnGitStash.Text = "Stash";
            btnGitStash.UseVisualStyleBackColor = true;
            btnGitStash.Click += btnGitStash_Click;
            // 
            // GitStashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 67);
            Controls.Add(btnGitStash);
            Controls.Add(txbxStashMessage);
            Name = "GitStashForm";
            Text = "Git Stash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbxStashMessage;
        private Button btnGitStash;
    }
}