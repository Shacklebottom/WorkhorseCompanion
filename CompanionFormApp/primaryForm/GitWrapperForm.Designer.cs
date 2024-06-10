﻿namespace CompanionFormApp
{
    partial class GitWrapperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitWrapperForm));
            GitWrapperMenuStrip = new MenuStrip();
            tsmiNew = new ToolStripMenuItem();
            tsmiNewProject = new ToolStripMenuItem();
            tsmiOpen = new ToolStripMenuItem();
            tsmiOpenProject = new ToolStripMenuItem();
            tsmiOpenSolution = new ToolStripMenuItem();
            tsmiEdit = new ToolStripMenuItem();
            tsmiEditProject = new ToolStripMenuItem();
            tsmiGit = new ToolStripMenuItem();
            tsmiGitBash = new ToolStripMenuItem();
            tsmiGitCommit = new ToolStripMenuItem();
            tsmiGitStatus = new ToolStripMenuItem();
            tsmiGitBranch = new ToolStripMenuItem();
            tsmiGitOther = new ToolStripMenuItem();
            tsmiGitOtherInit = new ToolStripMenuItem();
            tsmiGitOtherReset = new ToolStripMenuItem();
            tsmiDocumentation = new ToolStripMenuItem();
            txbxCurrentProject = new TextBox();
            txbxBashOutput_display = new TextBox();
            txbxCommandLine_input = new TextBox();
            lblDeterminationQuote = new Label();
            tsmiNewDocumentation = new ToolStripMenuItem();
            GitWrapperMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // GitWrapperMenuStrip
            // 
            GitWrapperMenuStrip.BackColor = Color.SaddleBrown;
            GitWrapperMenuStrip.Items.AddRange(new ToolStripItem[] { tsmiNew, tsmiOpen, tsmiEdit, tsmiGit, tsmiDocumentation });
            GitWrapperMenuStrip.Location = new Point(0, 0);
            GitWrapperMenuStrip.Name = "GitWrapperMenuStrip";
            GitWrapperMenuStrip.Size = new Size(874, 24);
            GitWrapperMenuStrip.TabIndex = 0;
            GitWrapperMenuStrip.Text = "menuStrip1";
            // 
            // tsmiNew
            // 
            tsmiNew.DropDownItems.AddRange(new ToolStripItem[] { tsmiNewProject, tsmiNewDocumentation });
            tsmiNew.Name = "tsmiNew";
            tsmiNew.Size = new Size(43, 20);
            tsmiNew.Text = "New";
            // 
            // tsmiNewProject
            // 
            tsmiNewProject.Name = "tsmiNewProject";
            tsmiNewProject.Size = new Size(180, 22);
            tsmiNewProject.Text = "Project";
            tsmiNewProject.Click += tsmiNewProject_Clicked;
            // 
            // tsmiOpen
            // 
            tsmiOpen.DropDownItems.AddRange(new ToolStripItem[] { tsmiOpenProject, tsmiOpenSolution });
            tsmiOpen.Name = "tsmiOpen";
            tsmiOpen.Size = new Size(48, 20);
            tsmiOpen.Text = "Open";
            // 
            // tsmiOpenProject
            // 
            tsmiOpenProject.Name = "tsmiOpenProject";
            tsmiOpenProject.Size = new Size(118, 22);
            tsmiOpenProject.Text = "Project";
            tsmiOpenProject.DropDownItemClicked += tsmiOpenProject_DropDownItem_Clicked;
            tsmiOpenProject.Click += tsmiOpenProject_Clicked;
            // 
            // tsmiOpenSolution
            // 
            tsmiOpenSolution.Name = "tsmiOpenSolution";
            tsmiOpenSolution.Size = new Size(118, 22);
            tsmiOpenSolution.Text = "Solution";
            tsmiOpenSolution.Click += tsmiOpenSolution_Clicked;
            // 
            // tsmiEdit
            // 
            tsmiEdit.DropDownItems.AddRange(new ToolStripItem[] { tsmiEditProject });
            tsmiEdit.Name = "tsmiEdit";
            tsmiEdit.Size = new Size(39, 20);
            tsmiEdit.Text = "Edit";
            // 
            // tsmiEditProject
            // 
            tsmiEditProject.Name = "tsmiEditProject";
            tsmiEditProject.Size = new Size(111, 22);
            tsmiEditProject.Text = "Project";
            tsmiEditProject.Click += tsmiEditProject_Clicked;
            // 
            // tsmiGit
            // 
            tsmiGit.DropDownItems.AddRange(new ToolStripItem[] { tsmiGitBash, tsmiGitCommit, tsmiGitStatus, tsmiGitBranch, tsmiGitOther });
            tsmiGit.Name = "tsmiGit";
            tsmiGit.Size = new Size(34, 20);
            tsmiGit.Text = "Git";
            // 
            // tsmiGitBash
            // 
            tsmiGitBash.Name = "tsmiGitBash";
            tsmiGitBash.Size = new Size(118, 22);
            tsmiGitBash.Text = "Bash";
            tsmiGitBash.Click += tsmiGitBash_Clicked;
            // 
            // tsmiGitCommit
            // 
            tsmiGitCommit.Name = "tsmiGitCommit";
            tsmiGitCommit.Size = new Size(118, 22);
            tsmiGitCommit.Text = "Commit";
            tsmiGitCommit.Click += tsmiGitCommit_Clicked;
            // 
            // tsmiGitStatus
            // 
            tsmiGitStatus.Name = "tsmiGitStatus";
            tsmiGitStatus.Size = new Size(118, 22);
            tsmiGitStatus.Text = "Status";
            tsmiGitStatus.Click += tsmiGitStatus_Clicked;
            // 
            // tsmiGitBranch
            // 
            tsmiGitBranch.Name = "tsmiGitBranch";
            tsmiGitBranch.Size = new Size(118, 22);
            tsmiGitBranch.Text = "Branch";
            tsmiGitBranch.DropDownOpening += tsmiGitBranch_DropDownOpening;
            tsmiGitBranch.DropDownItemClicked += tsmiGitBranch_DropDownItem_Clicked;
            tsmiGitBranch.Click += tsmiGitBranch_Clicked;
            // 
            // tsmiGitOther
            // 
            tsmiGitOther.DropDownItems.AddRange(new ToolStripItem[] { tsmiGitOtherInit, tsmiGitOtherReset });
            tsmiGitOther.Name = "tsmiGitOther";
            tsmiGitOther.Size = new Size(118, 22);
            tsmiGitOther.Text = "Other";
            // 
            // tsmiGitOtherInit
            // 
            tsmiGitOtherInit.Name = "tsmiGitOtherInit";
            tsmiGitOtherInit.Size = new Size(102, 22);
            tsmiGitOtherInit.Text = "Init";
            tsmiGitOtherInit.Click += tsmiGitOtherInit_Clicked;
            // 
            // tsmiGitOtherReset
            // 
            tsmiGitOtherReset.Name = "tsmiGitOtherReset";
            tsmiGitOtherReset.Size = new Size(102, 22);
            tsmiGitOtherReset.Text = "Reset";
            tsmiGitOtherReset.Click += tsmiGitOtherReset_Clicked;
            // 
            // tsmiDocumentation
            // 
            tsmiDocumentation.Name = "tsmiDocumentation";
            tsmiDocumentation.Size = new Size(102, 20);
            tsmiDocumentation.Text = "Documentation";
            tsmiDocumentation.DropDownOpening += tsmiDocumentation_DropDownOpening;
            // 
            // txbxCurrentProject
            // 
            txbxCurrentProject.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbxCurrentProject.BackColor = Color.LemonChiffon;
            txbxCurrentProject.Location = new Point(12, 27);
            txbxCurrentProject.Name = "txbxCurrentProject";
            txbxCurrentProject.ReadOnly = true;
            txbxCurrentProject.Size = new Size(850, 23);
            txbxCurrentProject.TabIndex = 2;
            txbxCurrentProject.Text = "Project:";
            // 
            // txbxBashOutput_display
            // 
            txbxBashOutput_display.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbxBashOutput_display.BackColor = Color.LemonChiffon;
            txbxBashOutput_display.Location = new Point(12, 56);
            txbxBashOutput_display.Multiline = true;
            txbxBashOutput_display.Name = "txbxBashOutput_display";
            txbxBashOutput_display.ReadOnly = true;
            txbxBashOutput_display.Size = new Size(850, 299);
            txbxBashOutput_display.TabIndex = 3;
            // 
            // txbxCommandLine_input
            // 
            txbxCommandLine_input.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbxCommandLine_input.BackColor = Color.LemonChiffon;
            txbxCommandLine_input.Location = new Point(12, 361);
            txbxCommandLine_input.Name = "txbxCommandLine_input";
            txbxCommandLine_input.Size = new Size(850, 23);
            txbxCommandLine_input.TabIndex = 4;
            txbxCommandLine_input.KeyPress += txbxCommandLine_KeyPress;
            // 
            // lblDeterminationQuote
            // 
            lblDeterminationQuote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDeterminationQuote.AutoSize = true;
            lblDeterminationQuote.Location = new Point(12, 387);
            lblDeterminationQuote.Name = "lblDeterminationQuote";
            lblDeterminationQuote.Size = new Size(22, 15);
            lblDeterminationQuote.TabIndex = 5;
            lblDeterminationQuote.Text = "---";
            // 
            // tsmiNewDocumentation
            // 
            tsmiNewDocumentation.Name = "tsmiNewDocumentation";
            tsmiNewDocumentation.Size = new Size(180, 22);
            tsmiNewDocumentation.Text = "Documentation";
            tsmiNewDocumentation.Click += tsmiNewDocumentation_Click;
            // 
            // GitWrapperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(874, 411);
            Controls.Add(lblDeterminationQuote);
            Controls.Add(txbxCommandLine_input);
            Controls.Add(txbxBashOutput_display);
            Controls.Add(txbxCurrentProject);
            Controls.Add(GitWrapperMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = GitWrapperMenuStrip;
            Name = "GitWrapperForm";
            ShowIcon = false;
            Text = "|| Workhorse Companion ||";
            Activated += GitWrapperForm_Activated;
            GitWrapperMenuStrip.ResumeLayout(false);
            GitWrapperMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip GitWrapperMenuStrip;
        private ToolStripMenuItem tsmiNew;
        private ToolStripMenuItem tsmiNewProject;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiGit;
        private ToolStripMenuItem tsmiOpenProject;
        private ToolStripMenuItem tsmiOpenSolution;
        private ToolStripMenuItem tsmiEditProject;
        private TextBox txbxCurrentProject;
        private ToolStripMenuItem tsmiGitBash;
        private ToolStripMenuItem tsmiGitCommit;
        private TextBox txbxBashOutput_display;
        private ToolStripMenuItem tsmiGitStatus;
        private ToolStripMenuItem tsmiGitBranch;
        private ToolStripMenuItem tsmiGitOther;
        private ToolStripMenuItem tsmiGitOtherInit;
        private ToolStripMenuItem tsmiGitOtherReset;
        private TextBox txbxCommandLine_input;
        private Label lblDeterminationQuote;
        private ToolStripMenuItem tsmiDocumentation;
        private ToolStripMenuItem tsmiNewDocumentation;
    }
}
