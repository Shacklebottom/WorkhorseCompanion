namespace CompanionFormApp.PrimaryForms
{
    partial class JournalSystemForm
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
            txbxCurrentProject = new TextBox();
            txbxCommitsToDate = new TextBox();
            txbxLinesToDate = new TextBox();
            cmbbxJournalEntries = new ComboBox();
            btnNewEntry = new Button();
            txbxJournalEntry_display = new TextBox();
            txbxCommitsAtEntry = new TextBox();
            txbxLinesAtEntry = new TextBox();
            SuspendLayout();
            // 
            // txbxCurrentProject
            // 
            txbxCurrentProject.BackColor = Color.LemonChiffon;
            txbxCurrentProject.Location = new Point(12, 12);
            txbxCurrentProject.Name = "txbxCurrentProject";
            txbxCurrentProject.ReadOnly = true;
            txbxCurrentProject.Size = new Size(220, 23);
            txbxCurrentProject.TabIndex = 0;
            txbxCurrentProject.Text = "Project:";
            // 
            // txbxCommitsToDate
            // 
            txbxCommitsToDate.BackColor = Color.LemonChiffon;
            txbxCommitsToDate.Location = new Point(238, 12);
            txbxCommitsToDate.Name = "txbxCommitsToDate";
            txbxCommitsToDate.ReadOnly = true;
            txbxCommitsToDate.Size = new Size(163, 23);
            txbxCommitsToDate.TabIndex = 1;
            txbxCommitsToDate.Text = "Commits To Date:";
            // 
            // txbxLinesToDate
            // 
            txbxLinesToDate.BackColor = Color.LemonChiffon;
            txbxLinesToDate.Location = new Point(407, 12);
            txbxLinesToDate.Name = "txbxLinesToDate";
            txbxLinesToDate.ReadOnly = true;
            txbxLinesToDate.Size = new Size(163, 23);
            txbxLinesToDate.TabIndex = 2;
            txbxLinesToDate.Text = "Lines To Date:";
            // 
            // cmbbxJournalEntries
            // 
            cmbbxJournalEntries.BackColor = Color.LemonChiffon;
            cmbbxJournalEntries.FormattingEnabled = true;
            cmbbxJournalEntries.Location = new Point(12, 41);
            cmbbxJournalEntries.Name = "cmbbxJournalEntries";
            cmbbxJournalEntries.Size = new Size(130, 23);
            cmbbxJournalEntries.TabIndex = 3;
            cmbbxJournalEntries.Text = "Select Entry";
            // 
            // btnNewEntry
            // 
            btnNewEntry.BackColor = Color.LemonChiffon;
            btnNewEntry.Location = new Point(157, 41);
            btnNewEntry.Name = "btnNewEntry";
            btnNewEntry.Size = new Size(75, 23);
            btnNewEntry.TabIndex = 4;
            btnNewEntry.Text = "New Entry";
            btnNewEntry.UseVisualStyleBackColor = false;
            // 
            // txbxJournalEntry_display
            // 
            txbxJournalEntry_display.BackColor = Color.LemonChiffon;
            txbxJournalEntry_display.Location = new Point(12, 70);
            txbxJournalEntry_display.Multiline = true;
            txbxJournalEntry_display.Name = "txbxJournalEntry_display";
            txbxJournalEntry_display.ReadOnly = true;
            txbxJournalEntry_display.Size = new Size(558, 410);
            txbxJournalEntry_display.TabIndex = 5;
            // 
            // txbxCommitsAtEntry
            // 
            txbxCommitsAtEntry.BackColor = Color.LemonChiffon;
            txbxCommitsAtEntry.Location = new Point(238, 41);
            txbxCommitsAtEntry.Name = "txbxCommitsAtEntry";
            txbxCommitsAtEntry.ReadOnly = true;
            txbxCommitsAtEntry.Size = new Size(163, 23);
            txbxCommitsAtEntry.TabIndex = 6;
            txbxCommitsAtEntry.Text = "CommitsAtEntry";
            // 
            // txbxLinesAtEntry
            // 
            txbxLinesAtEntry.BackColor = Color.LemonChiffon;
            txbxLinesAtEntry.Location = new Point(407, 42);
            txbxLinesAtEntry.Name = "txbxLinesAtEntry";
            txbxLinesAtEntry.ReadOnly = true;
            txbxLinesAtEntry.Size = new Size(163, 23);
            txbxLinesAtEntry.TabIndex = 7;
            txbxLinesAtEntry.Text = "Lines At Entry";
            // 
            // JournalSystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(582, 492);
            Controls.Add(txbxLinesAtEntry);
            Controls.Add(txbxCommitsAtEntry);
            Controls.Add(txbxJournalEntry_display);
            Controls.Add(btnNewEntry);
            Controls.Add(cmbbxJournalEntries);
            Controls.Add(txbxLinesToDate);
            Controls.Add(txbxCommitsToDate);
            Controls.Add(txbxCurrentProject);
            Name = "JournalSystemForm";
            ShowIcon = false;
            Text = "Workhorse Companion: Journal System";
            Activated += PopulateToDateInformationWhen_JournalSystemForm_Activated;
            FormClosing += JournalSystemForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbxCurrentProject;
        private TextBox txbxCommitsToDate;
        private TextBox txbxLinesToDate;
        private ComboBox cmbbxJournalEntries;
        private Button btnNewEntry;
        private TextBox txbxJournalEntry_display;
        private TextBox txbxCommitsAtEntry;
        private TextBox txbxLinesAtEntry;
    }
}