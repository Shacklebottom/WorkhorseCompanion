namespace CompanionFormApp
{
    partial class MainForm
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
            tsmiFile = new ToolStripMenuItem();
            tsmiAddProject = new ToolStripMenuItem();
            tsmiSelectProject = new ToolStripMenuItem();
            tsmiEdit = new ToolStripMenuItem();
            editProjectToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            solutionToolStripMenuItem = new ToolStripMenuItem();
            gitBashToolStripMenuItem = new ToolStripMenuItem();
            lblCurrentProject = new Label();
            lstbxProjectTickets = new ListBox();
            btnNewTicket = new Button();
            txbxTicketDescription_display = new TextBox();
            lblCurrentTicket = new Label();
            lblTicketPriorty = new Label();
            lblTicketType = new Label();
            lblDateStart = new Label();
            lblDateEnd = new Label();
            btnEditTicket = new Button();
            btnActiveTickets = new Button();
            btnCompletedTickets = new Button();
            panel1 = new Panel();
            btnGitPush = new Button();
            btnGitPull = new Button();
            btnGitStatus = new Button();
            btnCommitProject = new Button();
            btnAllTickets = new Button();
            lblDeterminationQuote = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFile, tsmiEdit, openToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            tsmiFile.DropDownItems.AddRange(new ToolStripItem[] { tsmiAddProject, tsmiSelectProject });
            tsmiFile.Name = "tsmiFile";
            tsmiFile.Size = new Size(37, 20);
            tsmiFile.Text = "File";
            // 
            // tsmiAddProject
            // 
            tsmiAddProject.Name = "tsmiAddProject";
            tsmiAddProject.Size = new Size(145, 22);
            tsmiAddProject.Text = "Add Project";
            tsmiAddProject.Click += tsmiAddProject_clicked;
            // 
            // tsmiSelectProject
            // 
            tsmiSelectProject.Name = "tsmiSelectProject";
            tsmiSelectProject.Size = new Size(145, 22);
            tsmiSelectProject.Text = "Select Project";
            tsmiSelectProject.Click += tsmiSelectProject_clicked;
            // 
            // tsmiEdit
            // 
            tsmiEdit.DropDownItems.AddRange(new ToolStripItem[] { editProjectToolStripMenuItem });
            tsmiEdit.Name = "tsmiEdit";
            tsmiEdit.Size = new Size(39, 20);
            tsmiEdit.Text = "Edit";
            // 
            // editProjectToolStripMenuItem
            // 
            editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
            editProjectToolStripMenuItem.Size = new Size(134, 22);
            editProjectToolStripMenuItem.Text = "Edit Project";
            editProjectToolStripMenuItem.Click += tsmiEditProject_clicked;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { solutionToolStripMenuItem, gitBashToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(48, 20);
            openToolStripMenuItem.Text = "Open";
            // 
            // solutionToolStripMenuItem
            // 
            solutionToolStripMenuItem.Name = "solutionToolStripMenuItem";
            solutionToolStripMenuItem.Size = new Size(118, 22);
            solutionToolStripMenuItem.Text = "Solution";
            solutionToolStripMenuItem.Click += tsmiOpenSolution_clicked;
            // 
            // gitBashToolStripMenuItem
            // 
            gitBashToolStripMenuItem.Name = "gitBashToolStripMenuItem";
            gitBashToolStripMenuItem.Size = new Size(118, 22);
            gitBashToolStripMenuItem.Text = "Git Bash";
            gitBashToolStripMenuItem.Click += tsmiOpenGitBash_clicked;
            // 
            // lblCurrentProject
            // 
            lblCurrentProject.AutoSize = true;
            lblCurrentProject.Location = new Point(12, 31);
            lblCurrentProject.Name = "lblCurrentProject";
            lblCurrentProject.Size = new Size(47, 15);
            lblCurrentProject.TabIndex = 1;
            lblCurrentProject.Text = "Project:";
            // 
            // lstbxProjectTickets
            // 
            lstbxProjectTickets.BackColor = Color.GhostWhite;
            lstbxProjectTickets.FormattingEnabled = true;
            lstbxProjectTickets.ItemHeight = 15;
            lstbxProjectTickets.Location = new Point(12, 188);
            lstbxProjectTickets.Name = "lstbxProjectTickets";
            lstbxProjectTickets.Size = new Size(215, 184);
            lstbxProjectTickets.TabIndex = 2;
            lstbxProjectTickets.SelectedIndexChanged += lstbxProjectTickets_SelectedIndexChanged;
            // 
            // btnNewTicket
            // 
            btnNewTicket.Location = new Point(12, 161);
            btnNewTicket.Name = "btnNewTicket";
            btnNewTicket.Size = new Size(40, 23);
            btnNewTicket.TabIndex = 3;
            btnNewTicket.Text = "New Ticket";
            btnNewTicket.UseVisualStyleBackColor = true;
            btnNewTicket.Click += btnNewTicket_clicked;
            // 
            // txbxTicketDescription_display
            // 
            txbxTicketDescription_display.BackColor = Color.GhostWhite;
            txbxTicketDescription_display.Location = new Point(233, 186);
            txbxTicketDescription_display.Multiline = true;
            txbxTicketDescription_display.Name = "txbxTicketDescription_display";
            txbxTicketDescription_display.ReadOnly = true;
            txbxTicketDescription_display.Size = new Size(555, 156);
            txbxTicketDescription_display.TabIndex = 4;
            // 
            // lblCurrentTicket
            // 
            lblCurrentTicket.AutoSize = true;
            lblCurrentTicket.Location = new Point(238, 165);
            lblCurrentTicket.Name = "lblCurrentTicket";
            lblCurrentTicket.Size = new Size(41, 15);
            lblCurrentTicket.TabIndex = 5;
            lblCurrentTicket.Text = "Ticket:";
            // 
            // lblTicketPriorty
            // 
            lblTicketPriorty.AutoSize = true;
            lblTicketPriorty.Location = new Point(438, 165);
            lblTicketPriorty.Name = "lblTicketPriorty";
            lblTicketPriorty.Size = new Size(48, 15);
            lblTicketPriorty.TabIndex = 6;
            lblTicketPriorty.Text = "Priority:";
            // 
            // lblTicketType
            // 
            lblTicketType.AutoSize = true;
            lblTicketType.Location = new Point(625, 164);
            lblTicketType.Name = "lblTicketType";
            lblTicketType.Size = new Size(34, 15);
            lblTicketType.TabIndex = 7;
            lblTicketType.Text = "Type:";
            // 
            // lblDateStart
            // 
            lblDateStart.AutoSize = true;
            lblDateStart.Location = new Point(306, 353);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(98, 15);
            lblDateStart.TabIndex = 9;
            lblDateStart.Text = "Submission Date:";
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
            lblDateEnd.Location = new Point(479, 353);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(100, 15);
            lblDateEnd.TabIndex = 10;
            lblDateEnd.Text = "Completion Date:";
            // 
            // btnEditTicket
            // 
            btnEditTicket.Enabled = false;
            btnEditTicket.Location = new Point(233, 349);
            btnEditTicket.Name = "btnEditTicket";
            btnEditTicket.Size = new Size(53, 23);
            btnEditTicket.TabIndex = 11;
            btnEditTicket.Text = "Edit";
            btnEditTicket.UseVisualStyleBackColor = true;
            btnEditTicket.Click += btnEditTicket_clicked;
            // 
            // btnActiveTickets
            // 
            btnActiveTickets.Location = new Point(97, 160);
            btnActiveTickets.Name = "btnActiveTickets";
            btnActiveTickets.Size = new Size(49, 23);
            btnActiveTickets.TabIndex = 12;
            btnActiveTickets.Text = "Active";
            btnActiveTickets.UseVisualStyleBackColor = true;
            btnActiveTickets.Click += btnActiveTickets_clicked;
            // 
            // btnCompletedTickets
            // 
            btnCompletedTickets.Location = new Point(152, 161);
            btnCompletedTickets.Name = "btnCompletedTickets";
            btnCompletedTickets.Size = new Size(75, 23);
            btnCompletedTickets.TabIndex = 13;
            btnCompletedTickets.Text = "Completed";
            btnCompletedTickets.UseVisualStyleBackColor = true;
            btnCompletedTickets.Click += btnCompletedTicket_clicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnGitPush);
            panel1.Controls.Add(btnGitPull);
            panel1.Controls.Add(btnGitStatus);
            panel1.Controls.Add(btnCommitProject);
            panel1.Location = new Point(535, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 119);
            panel1.TabIndex = 14;
            // 
            // btnGitPush
            // 
            btnGitPush.Location = new Point(3, 90);
            btnGitPush.Name = "btnGitPush";
            btnGitPush.Size = new Size(78, 23);
            btnGitPush.TabIndex = 5;
            btnGitPush.Text = "Git Push";
            btnGitPush.UseVisualStyleBackColor = true;
            btnGitPush.Click += btnGitPush_clicked;
            // 
            // btnGitPull
            // 
            btnGitPull.Location = new Point(3, 61);
            btnGitPull.Name = "btnGitPull";
            btnGitPull.Size = new Size(78, 23);
            btnGitPull.TabIndex = 4;
            btnGitPull.Text = "Git Pull";
            btnGitPull.UseVisualStyleBackColor = true;
            btnGitPull.Click += btnGitPull_clicked;
            // 
            // btnGitStatus
            // 
            btnGitStatus.Location = new Point(3, 32);
            btnGitStatus.Name = "btnGitStatus";
            btnGitStatus.Size = new Size(78, 23);
            btnGitStatus.TabIndex = 3;
            btnGitStatus.Text = "Git Status";
            btnGitStatus.UseVisualStyleBackColor = true;
            btnGitStatus.Click += btnGitStatus_clicked;
            // 
            // btnCommitProject
            // 
            btnCommitProject.Location = new Point(3, 3);
            btnCommitProject.Name = "btnCommitProject";
            btnCommitProject.Size = new Size(78, 23);
            btnCommitProject.TabIndex = 2;
            btnCommitProject.Text = "Git Commit";
            btnCommitProject.UseVisualStyleBackColor = true;
            btnCommitProject.Click += btnCommitProject_clicked;
            // 
            // btnAllTickets
            // 
            btnAllTickets.Location = new Point(58, 161);
            btnAllTickets.Name = "btnAllTickets";
            btnAllTickets.Size = new Size(33, 23);
            btnAllTickets.TabIndex = 15;
            btnAllTickets.Text = "All";
            btnAllTickets.UseVisualStyleBackColor = true;
            btnAllTickets.Click += btnAllTickets_clicked;
            // 
            // lblDetermination
            // 
            lblDeterminationQuote.AutoSize = true;
            lblDeterminationQuote.Location = new Point(12, 381);
            lblDeterminationQuote.Name = "lblDetermination";
            lblDeterminationQuote.Size = new Size(22, 15);
            lblDeterminationQuote.TabIndex = 16;
            lblDeterminationQuote.Text = "---";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(lblDeterminationQuote);
            Controls.Add(btnAllTickets);
            Controls.Add(panel1);
            Controls.Add(btnCompletedTickets);
            Controls.Add(lblCurrentProject);
            Controls.Add(btnActiveTickets);
            Controls.Add(btnEditTicket);
            Controls.Add(lblDateEnd);
            Controls.Add(lblDateStart);
            Controls.Add(lblTicketType);
            Controls.Add(lblTicketPriorty);
            Controls.Add(lblCurrentTicket);
            Controls.Add(txbxTicketDescription_display);
            Controls.Add(btnNewTicket);
            Controls.Add(lstbxProjectTickets);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Workplace Companion";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiAddProject;
        private ToolStripMenuItem tsmiSelectProject;
        private Label lblCurrentProject;
        private ListBox lstbxProjectTickets;
        private Button btnNewTicket;
        private TextBox txbxTicketDescription_display;
        private Label lblCurrentTicket;
        private Label lblTicketPriorty;
        private Label lblTicketType;
        private Label lblDateStart;
        private Label lblDateEnd;
        private Button btnEditTicket;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem editProjectToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem solutionToolStripMenuItem;
        private Button btnActiveTickets;
        private Button btnCompletedTickets;
        private ToolStripMenuItem gitBashToolStripMenuItem;
        private Panel panel1;
        private Button btnCommitProject;
        private Button btnAllTickets;
        private Button btnGitPush;
        private Button btnGitPull;
        private Button btnGitStatus;
        private Label lblDeterminationQuote;
    }
}
