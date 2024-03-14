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
            tsmiFileAddProject = new ToolStripMenuItem();
            tsmiFileAddResource = new ToolStripMenuItem();
            tsmiFileSelectProject = new ToolStripMenuItem();
            tsmiEdit = new ToolStripMenuItem();
            editProjectToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            solutionToolStripMenuItem = new ToolStripMenuItem();
            tsmiOpenResource = new ToolStripMenuItem();
            tsmiOpenResourceImage = new ToolStripMenuItem();
            tsmiOpenResourceDocument = new ToolStripMenuItem();
            tsmiOpenResourceWebsite = new ToolStripMenuItem();
            gitToolStripMenuItem = new ToolStripMenuItem();
            tsmiGitBash = new ToolStripMenuItem();
            tsmiGitCommit = new ToolStripMenuItem();
            tsmiGitStatus = new ToolStripMenuItem();
            fetchToolStripMenuItem = new ToolStripMenuItem();
            branchToolStripMenuItem = new ToolStripMenuItem();
            checkoutToolStripMenuItem = new ToolStripMenuItem();
            pullToolStripMenuItem = new ToolStripMenuItem();
            pushToolStripMenuItem = new ToolStripMenuItem();
            otherToolStripMenuItem = new ToolStripMenuItem();
            initToolStripMenuItem = new ToolStripMenuItem();
            addRemoteToolStripMenuItem = new ToolStripMenuItem();
            cloneToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
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
            btnAllTickets = new Button();
            lblDeterminationQuote = new Label();
            txbxBashOutput_display = new TextBox();
            panel1 = new Panel();
            txbxGitCommandLine_input = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFile, tsmiEdit, openToolStripMenuItem, gitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(690, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            tsmiFile.DropDownItems.AddRange(new ToolStripItem[] { tsmiFileAddProject, tsmiFileAddResource, tsmiFileSelectProject });
            tsmiFile.Name = "tsmiFile";
            tsmiFile.Size = new Size(37, 20);
            tsmiFile.Text = "File";
            // 
            // tsmiFileAddProject
            // 
            tsmiFileAddProject.Name = "tsmiFileAddProject";
            tsmiFileAddProject.Size = new Size(147, 22);
            tsmiFileAddProject.Text = "Add Project";
            tsmiFileAddProject.Click += tsmiFileAddProject_clicked;
            // 
            // tsmiFileAddResource
            // 
            tsmiFileAddResource.Name = "tsmiFileAddResource";
            tsmiFileAddResource.Size = new Size(147, 22);
            tsmiFileAddResource.Text = "Add Resource";
            tsmiFileAddResource.Click += tsmiFileAddResource_clicked;
            // 
            // tsmiFileSelectProject
            // 
            tsmiFileSelectProject.Name = "tsmiFileSelectProject";
            tsmiFileSelectProject.Size = new Size(147, 22);
            tsmiFileSelectProject.Text = "Select Project";
            tsmiFileSelectProject.DropDownItemClicked += tsmiFileSelectProject_DropDownItemClicked;
            tsmiFileSelectProject.Click += tsmiFileSelectProject_clicked;
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
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { solutionToolStripMenuItem, tsmiOpenResource });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(48, 20);
            openToolStripMenuItem.Text = "Open";
            // 
            // solutionToolStripMenuItem
            // 
            solutionToolStripMenuItem.Name = "solutionToolStripMenuItem";
            solutionToolStripMenuItem.Size = new Size(122, 22);
            solutionToolStripMenuItem.Text = "Solution";
            solutionToolStripMenuItem.Click += tsmiOpenSolution_clicked;
            // 
            // tsmiOpenResource
            // 
            tsmiOpenResource.DropDownItems.AddRange(new ToolStripItem[] { tsmiOpenResourceImage, tsmiOpenResourceDocument, tsmiOpenResourceWebsite });
            tsmiOpenResource.Name = "tsmiOpenResource";
            tsmiOpenResource.Size = new Size(122, 22);
            tsmiOpenResource.Text = "Resource";
            tsmiOpenResource.DropDownItemClicked += tsmiOpenResource_DropDownItemClicked;
            // 
            // tsmiOpenResourceImage
            // 
            tsmiOpenResourceImage.Name = "tsmiOpenResourceImage";
            tsmiOpenResourceImage.Size = new Size(130, 22);
            tsmiOpenResourceImage.Text = "Image";
            // 
            // tsmiOpenResourceDocument
            // 
            tsmiOpenResourceDocument.Name = "tsmiOpenResourceDocument";
            tsmiOpenResourceDocument.Size = new Size(130, 22);
            tsmiOpenResourceDocument.Text = "Document";
            // 
            // tsmiOpenResourceWebsite
            // 
            tsmiOpenResourceWebsite.Name = "tsmiOpenResourceWebsite";
            tsmiOpenResourceWebsite.Size = new Size(130, 22);
            tsmiOpenResourceWebsite.Text = "Website";
            // 
            // gitToolStripMenuItem
            // 
            gitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiGitBash, tsmiGitCommit, tsmiGitStatus, fetchToolStripMenuItem, branchToolStripMenuItem, pullToolStripMenuItem, pushToolStripMenuItem, otherToolStripMenuItem });
            gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            gitToolStripMenuItem.Size = new Size(34, 20);
            gitToolStripMenuItem.Text = "Git";
            // 
            // tsmiGitBash
            // 
            tsmiGitBash.Name = "tsmiGitBash";
            tsmiGitBash.Size = new Size(118, 22);
            tsmiGitBash.Text = "Bash";
            tsmiGitBash.Click += tsmiGitBash_Click;
            // 
            // tsmiGitCommit
            // 
            tsmiGitCommit.Name = "tsmiGitCommit";
            tsmiGitCommit.Size = new Size(118, 22);
            tsmiGitCommit.Text = "Commit";
            tsmiGitCommit.Click += tsmiGitCommit_Click;
            // 
            // tsmiGitStatus
            // 
            tsmiGitStatus.Name = "tsmiGitStatus";
            tsmiGitStatus.Size = new Size(118, 22);
            tsmiGitStatus.Text = "Status";
            tsmiGitStatus.Click += tsmiGitStatus_Click;
            // 
            // fetchToolStripMenuItem
            // 
            fetchToolStripMenuItem.Name = "fetchToolStripMenuItem";
            fetchToolStripMenuItem.Size = new Size(118, 22);
            fetchToolStripMenuItem.Text = "Fetch";
            // 
            // branchToolStripMenuItem
            // 
            branchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkoutToolStripMenuItem });
            branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            branchToolStripMenuItem.Size = new Size(118, 22);
            branchToolStripMenuItem.Text = "Branch";
            // 
            // checkoutToolStripMenuItem
            // 
            checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            checkoutToolStripMenuItem.Size = new Size(125, 22);
            checkoutToolStripMenuItem.Text = "Checkout";
            // 
            // pullToolStripMenuItem
            // 
            pullToolStripMenuItem.Name = "pullToolStripMenuItem";
            pullToolStripMenuItem.Size = new Size(118, 22);
            pullToolStripMenuItem.Text = "Pull";
            // 
            // pushToolStripMenuItem
            // 
            pushToolStripMenuItem.Name = "pushToolStripMenuItem";
            pushToolStripMenuItem.Size = new Size(118, 22);
            pushToolStripMenuItem.Text = "Push";
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { initToolStripMenuItem, addRemoteToolStripMenuItem, cloneToolStripMenuItem, resetToolStripMenuItem });
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(118, 22);
            otherToolStripMenuItem.Text = "Other";
            // 
            // initToolStripMenuItem
            // 
            initToolStripMenuItem.Name = "initToolStripMenuItem";
            initToolStripMenuItem.Size = new Size(140, 22);
            initToolStripMenuItem.Text = "Init";
            // 
            // addRemoteToolStripMenuItem
            // 
            addRemoteToolStripMenuItem.Name = "addRemoteToolStripMenuItem";
            addRemoteToolStripMenuItem.Size = new Size(140, 22);
            addRemoteToolStripMenuItem.Text = "Add Remote";
            // 
            // cloneToolStripMenuItem
            // 
            cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            cloneToolStripMenuItem.Size = new Size(140, 22);
            cloneToolStripMenuItem.Text = "Clone";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(140, 22);
            resetToolStripMenuItem.Text = "Reset";
            // 
            // lblCurrentProject
            // 
            lblCurrentProject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentProject.AutoSize = true;
            lblCurrentProject.Location = new Point(3, 2);
            lblCurrentProject.Name = "lblCurrentProject";
            lblCurrentProject.Size = new Size(47, 15);
            lblCurrentProject.TabIndex = 1;
            lblCurrentProject.Text = "Project:";
            // 
            // lstbxProjectTickets
            // 
            lstbxProjectTickets.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lstbxProjectTickets.BackColor = Color.GhostWhite;
            lstbxProjectTickets.FormattingEnabled = true;
            lstbxProjectTickets.ItemHeight = 15;
            lstbxProjectTickets.Location = new Point(12, 278);
            lstbxProjectTickets.Name = "lstbxProjectTickets";
            lstbxProjectTickets.Size = new Size(215, 184);
            lstbxProjectTickets.TabIndex = 2;
            lstbxProjectTickets.SelectedIndexChanged += lstbxProjectTickets_SelectedIndexChanged;
            // 
            // btnNewTicket
            // 
            btnNewTicket.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewTicket.Location = new Point(12, 251);
            btnNewTicket.Name = "btnNewTicket";
            btnNewTicket.Size = new Size(40, 23);
            btnNewTicket.TabIndex = 3;
            btnNewTicket.Text = "New Ticket";
            btnNewTicket.UseVisualStyleBackColor = true;
            btnNewTicket.Click += btnNewTicket_clicked;
            // 
            // txbxTicketDescription_display
            // 
            txbxTicketDescription_display.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbxTicketDescription_display.BackColor = Color.GhostWhite;
            txbxTicketDescription_display.Location = new Point(233, 278);
            txbxTicketDescription_display.Multiline = true;
            txbxTicketDescription_display.Name = "txbxTicketDescription_display";
            txbxTicketDescription_display.ReadOnly = true;
            txbxTicketDescription_display.Size = new Size(443, 155);
            txbxTicketDescription_display.TabIndex = 4;
            // 
            // lblCurrentTicket
            // 
            lblCurrentTicket.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCurrentTicket.AutoSize = true;
            lblCurrentTicket.Location = new Point(238, 255);
            lblCurrentTicket.Name = "lblCurrentTicket";
            lblCurrentTicket.Size = new Size(41, 15);
            lblCurrentTicket.TabIndex = 5;
            lblCurrentTicket.Text = "Ticket:";
            // 
            // lblTicketPriorty
            // 
            lblTicketPriorty.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTicketPriorty.AutoSize = true;
            lblTicketPriorty.Location = new Point(401, 255);
            lblTicketPriorty.Name = "lblTicketPriorty";
            lblTicketPriorty.Size = new Size(48, 15);
            lblTicketPriorty.TabIndex = 6;
            lblTicketPriorty.Text = "Priority:";
            // 
            // lblTicketType
            // 
            lblTicketType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTicketType.AutoSize = true;
            lblTicketType.Location = new Point(566, 255);
            lblTicketType.Name = "lblTicketType";
            lblTicketType.Size = new Size(34, 15);
            lblTicketType.TabIndex = 7;
            lblTicketType.Text = "Type:";
            // 
            // lblDateStart
            // 
            lblDateStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDateStart.AutoSize = true;
            lblDateStart.Location = new Point(290, 443);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(98, 15);
            lblDateStart.TabIndex = 9;
            lblDateStart.Text = "Submission Date:";
            // 
            // lblDateEnd
            // 
            lblDateEnd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDateEnd.AutoSize = true;
            lblDateEnd.Location = new Point(463, 443);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(100, 15);
            lblDateEnd.TabIndex = 10;
            lblDateEnd.Text = "Completion Date:";
            // 
            // btnEditTicket
            // 
            btnEditTicket.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditTicket.Enabled = false;
            btnEditTicket.Location = new Point(233, 439);
            btnEditTicket.Name = "btnEditTicket";
            btnEditTicket.Size = new Size(53, 23);
            btnEditTicket.TabIndex = 11;
            btnEditTicket.Text = "Edit";
            btnEditTicket.UseVisualStyleBackColor = true;
            btnEditTicket.Click += btnEditTicket_clicked;
            // 
            // btnActiveTickets
            // 
            btnActiveTickets.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnActiveTickets.Location = new Point(97, 251);
            btnActiveTickets.Name = "btnActiveTickets";
            btnActiveTickets.Size = new Size(49, 23);
            btnActiveTickets.TabIndex = 12;
            btnActiveTickets.Text = "Active";
            btnActiveTickets.UseVisualStyleBackColor = true;
            btnActiveTickets.Click += btnActiveTickets_clicked;
            // 
            // btnCompletedTickets
            // 
            btnCompletedTickets.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCompletedTickets.Location = new Point(152, 251);
            btnCompletedTickets.Name = "btnCompletedTickets";
            btnCompletedTickets.Size = new Size(75, 23);
            btnCompletedTickets.TabIndex = 13;
            btnCompletedTickets.Text = "Completed";
            btnCompletedTickets.UseVisualStyleBackColor = true;
            btnCompletedTickets.Click += btnCompletedTicket_clicked;
            // 
            // btnAllTickets
            // 
            btnAllTickets.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAllTickets.Location = new Point(58, 251);
            btnAllTickets.Name = "btnAllTickets";
            btnAllTickets.Size = new Size(33, 23);
            btnAllTickets.TabIndex = 15;
            btnAllTickets.Text = "All";
            btnAllTickets.UseVisualStyleBackColor = true;
            btnAllTickets.Click += btnAllTickets_clicked;
            // 
            // lblDeterminationQuote
            // 
            lblDeterminationQuote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDeterminationQuote.AutoSize = true;
            lblDeterminationQuote.Location = new Point(12, 471);
            lblDeterminationQuote.Name = "lblDeterminationQuote";
            lblDeterminationQuote.Size = new Size(22, 15);
            lblDeterminationQuote.TabIndex = 16;
            lblDeterminationQuote.Text = "---";
            // 
            // txbxBashOutput_display
            // 
            txbxBashOutput_display.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbxBashOutput_display.BackColor = Color.GhostWhite;
            txbxBashOutput_display.Location = new Point(12, 27);
            txbxBashOutput_display.Multiline = true;
            txbxBashOutput_display.Name = "txbxBashOutput_display";
            txbxBashOutput_display.ReadOnly = true;
            txbxBashOutput_display.ScrollBars = ScrollBars.Vertical;
            txbxBashOutput_display.Size = new Size(664, 160);
            txbxBashOutput_display.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.GhostWhite;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCurrentProject);
            panel1.Location = new Point(12, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 24);
            panel1.TabIndex = 20;
            // 
            // txbxGitCommandLine_input
            // 
            txbxGitCommandLine_input.AcceptsReturn = true;
            txbxGitCommandLine_input.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbxGitCommandLine_input.Location = new Point(12, 192);
            txbxGitCommandLine_input.Name = "txbxGitCommandLine_input";
            txbxGitCommandLine_input.Size = new Size(664, 23);
            txbxGitCommandLine_input.TabIndex = 21;
            txbxGitCommandLine_input.KeyPress += txbxGitCommandLine_input_KeyPress;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 495);
            Controls.Add(txbxGitCommandLine_input);
            Controls.Add(panel1);
            Controls.Add(txbxBashOutput_display);
            Controls.Add(lblDeterminationQuote);
            Controls.Add(btnAllTickets);
            Controls.Add(btnCompletedTickets);
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
            Text = "Workhorse Companion";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiFileAddProject;
        private ToolStripMenuItem tsmiFileSelectProject;
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
        private Button btnAllTickets;
        private Label lblDeterminationQuote;
        private ToolStripMenuItem tsmiOpenResource;
        private ToolStripMenuItem tsmiFileAddResource;
        private TextBox txbxBashOutput_display;
        private ToolStripMenuItem tsmiOpenResourceImage;
        private ToolStripMenuItem tsmiOpenResourceDocument;
        private ToolStripMenuItem tsmiOpenResourceWebsite;
        private Panel panel1;
        private ToolStripMenuItem gitToolStripMenuItem;
        private ToolStripMenuItem tsmiGitBash;
        private ToolStripMenuItem tsmiGitCommit;
        private ToolStripMenuItem tsmiGitStatus;
        private ToolStripMenuItem fetchToolStripMenuItem;
        private ToolStripMenuItem branchToolStripMenuItem;
        private ToolStripMenuItem checkoutToolStripMenuItem;
        private ToolStripMenuItem pullToolStripMenuItem;
        private ToolStripMenuItem pushToolStripMenuItem;
        private ToolStripMenuItem otherToolStripMenuItem;
        private ToolStripMenuItem initToolStripMenuItem;
        private ToolStripMenuItem addRemoteToolStripMenuItem;
        private ToolStripMenuItem cloneToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private TextBox txbxGitCommandLine_input;
    }
}
