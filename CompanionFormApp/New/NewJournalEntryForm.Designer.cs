namespace CompanionFormApp.New
{
    partial class NewJournalEntryForm
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
            btnAcceptNewJournalEntry = new Button();
            txbxJournalEntry = new TextBox();
            SuspendLayout();
            // 
            // btnAcceptNewJournalEntry
            // 
            btnAcceptNewJournalEntry.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAcceptNewJournalEntry.Location = new Point(348, 316);
            btnAcceptNewJournalEntry.Name = "btnAcceptNewJournalEntry";
            btnAcceptNewJournalEntry.Size = new Size(75, 23);
            btnAcceptNewJournalEntry.TabIndex = 0;
            btnAcceptNewJournalEntry.Text = "&Accept";
            btnAcceptNewJournalEntry.UseVisualStyleBackColor = true;
            btnAcceptNewJournalEntry.Click += btnAcceptNewJournalEntry_Clicked;
            // 
            // txbxJournalEntry
            // 
            txbxJournalEntry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbxJournalEntry.BackColor = Color.LemonChiffon;
            txbxJournalEntry.Location = new Point(12, 12);
            txbxJournalEntry.Multiline = true;
            txbxJournalEntry.Name = "txbxJournalEntry";
            txbxJournalEntry.Size = new Size(411, 298);
            txbxJournalEntry.TabIndex = 1;
            // 
            // NewJournalEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(435, 351);
            Controls.Add(txbxJournalEntry);
            Controls.Add(btnAcceptNewJournalEntry);
            Name = "NewJournalEntryForm";
            ShowIcon = false;
            Text = "Create New Journal Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceptNewJournalEntry;
        private TextBox txbxJournalEntry;
    }
}