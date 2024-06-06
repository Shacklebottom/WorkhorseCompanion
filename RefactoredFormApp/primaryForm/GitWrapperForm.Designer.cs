namespace RefactoredFormApp
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
            menuStrip1 = new MenuStrip();
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
            txbxCurrentProject = new TextBox();
            txbxBashOutput_display = new TextBox();
            txbxCommandLine_input = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DimGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiNew, tsmiOpen, tsmiEdit, tsmiGit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiNew
            // 
            tsmiNew.DropDownItems.AddRange(new ToolStripItem[] { tsmiNewProject });
            tsmiNew.Name = "tsmiNew";
            tsmiNew.Size = new Size(43, 20);
            tsmiNew.Text = "New";
            // 
            // tsmiNewProject
            // 
            tsmiNewProject.Name = "tsmiNewProject";
            tsmiNewProject.Size = new Size(111, 22);
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
            // txbxCurrentProject
            // 
            txbxCurrentProject.Location = new Point(12, 27);
            txbxCurrentProject.Name = "txbxCurrentProject";
            txbxCurrentProject.ReadOnly = true;
            txbxCurrentProject.Size = new Size(770, 23);
            txbxCurrentProject.TabIndex = 2;
            txbxCurrentProject.Text = "Project:";
            // 
            // txbxBashOutput_display
            // 
            txbxBashOutput_display.Location = new Point(12, 56);
            txbxBashOutput_display.Multiline = true;
            txbxBashOutput_display.Name = "txbxBashOutput_display";
            txbxBashOutput_display.ReadOnly = true;
            txbxBashOutput_display.Size = new Size(770, 299);
            txbxBashOutput_display.TabIndex = 3;
            // 
            // txbxCommandLine_input
            // 
            txbxCommandLine_input.Location = new Point(12, 361);
            txbxCommandLine_input.Name = "txbxCommandLine_input";
            txbxCommandLine_input.Size = new Size(770, 23);
            txbxCommandLine_input.TabIndex = 4;
            txbxCommandLine_input.KeyPress += txbxCommandLine_KeyPress;
            // 
            // GitWrapperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(794, 502);
            Controls.Add(txbxCommandLine_input);
            Controls.Add(txbxBashOutput_display);
            Controls.Add(txbxCurrentProject);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GitWrapperForm";
            Text = "|| Workhorse Companion ||";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
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
    }
}
