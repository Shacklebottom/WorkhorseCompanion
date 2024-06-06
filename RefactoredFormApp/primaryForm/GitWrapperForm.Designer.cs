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
            newToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            tsmiOpen = new ToolStripMenuItem();
            tsmiOpenProject = new ToolStripMenuItem();
            tsmiOpenSolution = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem2 = new ToolStripMenuItem();
            gitToolStripMenuItem = new ToolStripMenuItem();
            lblCurrentProject = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, tsmiOpen, editToolStripMenuItem, gitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projectToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(43, 20);
            newToolStripMenuItem.Text = "New";
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(111, 22);
            projectToolStripMenuItem.Text = "Project";
            projectToolStripMenuItem.Click += tsmiNewProject_clicked;
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
            tsmiOpenProject.Size = new Size(180, 22);
            tsmiOpenProject.Text = "Project";
            tsmiOpenProject.DropDownItemClicked += tsmiOpenProject_DropDownItem_clicked;
            tsmiOpenProject.Click += tsmiOpenProject_clicked;
            // 
            // tsmiOpenSolution
            // 
            tsmiOpenSolution.Name = "tsmiOpenSolution";
            tsmiOpenSolution.Size = new Size(180, 22);
            tsmiOpenSolution.Text = "Solution";
            tsmiOpenSolution.Click += tsmiOpenSolution_clicked;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projectToolStripMenuItem2 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // projectToolStripMenuItem2
            // 
            projectToolStripMenuItem2.Name = "projectToolStripMenuItem2";
            projectToolStripMenuItem2.Size = new Size(111, 22);
            projectToolStripMenuItem2.Text = "Project";
            // 
            // gitToolStripMenuItem
            // 
            gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            gitToolStripMenuItem.Size = new Size(34, 20);
            gitToolStripMenuItem.Text = "Git";
            // 
            // lblCurrentProject
            // 
            lblCurrentProject.AutoSize = true;
            lblCurrentProject.Location = new Point(122, 324);
            lblCurrentProject.Name = "lblCurrentProject";
            lblCurrentProject.Size = new Size(38, 15);
            lblCurrentProject.TabIndex = 1;
            lblCurrentProject.Text = "label1";
            // 
            // GitWrapperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurrentProject);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GitWrapperForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem tsmiOpen;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem gitToolStripMenuItem;
        private ToolStripMenuItem tsmiOpenProject;
        private ToolStripMenuItem tsmiOpenSolution;
        private ToolStripMenuItem projectToolStripMenuItem2;
        private Label lblCurrentProject;
    }
}
