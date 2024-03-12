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
            gitBashToolStripMenuItem = new ToolStripMenuItem();
            tsmiOpenResource = new ToolStripMenuItem();
            tsmiOpenResourceImage = new ToolStripMenuItem();
            tsmiOpenResourceDocument = new ToolStripMenuItem();
            tsmiOpenResourceWebsite = new ToolStripMenuItem();
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
            pnlCommonGitCommands = new Panel();
            btnGitCheckout = new Button();
            btnGitFetch = new Button();
            btnGitBranch = new Button();
            btnGitPush = new Button();
            btnGitPull = new Button();
            btnGitStatus = new Button();
            btnGitStash = new Button();
            btnGitCommit = new Button();
            btnAllTickets = new Button();
            lblDeterminationQuote = new Label();
            txbxBashOutput_display = new TextBox();
            pnlUncommonGitCommands = new Panel();
            btnGitAddRemote = new Button();
            btnGitReset = new Button();
            btnGitClone = new Button();
            btnGitInit = new Button();
            ckbxShowUncommonGitCommands = new CheckBox();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            pnlCommonGitCommands.SuspendLayout();
            pnlUncommonGitCommands.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFile, tsmiEdit, openToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(922, 24);
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
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { solutionToolStripMenuItem, gitBashToolStripMenuItem, tsmiOpenResource });
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
            // gitBashToolStripMenuItem
            // 
            gitBashToolStripMenuItem.Name = "gitBashToolStripMenuItem";
            gitBashToolStripMenuItem.Size = new Size(122, 22);
            gitBashToolStripMenuItem.Text = "Git Bash";
            gitBashToolStripMenuItem.Click += tsmiOpenGitBash_clicked;
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
            txbxTicketDescription_display.Size = new Size(675, 155);
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
            lblTicketPriorty.Location = new Point(438, 255);
            lblTicketPriorty.Name = "lblTicketPriorty";
            lblTicketPriorty.Size = new Size(48, 15);
            lblTicketPriorty.TabIndex = 6;
            lblTicketPriorty.Text = "Priority:";
            // 
            // lblTicketType
            // 
            lblTicketType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTicketType.AutoSize = true;
            lblTicketType.Location = new Point(625, 254);
            lblTicketType.Name = "lblTicketType";
            lblTicketType.Size = new Size(34, 15);
            lblTicketType.TabIndex = 7;
            lblTicketType.Text = "Type:";
            // 
            // lblDateStart
            // 
            lblDateStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDateStart.AutoSize = true;
            lblDateStart.Location = new Point(435, 443);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(98, 15);
            lblDateStart.TabIndex = 9;
            lblDateStart.Text = "Submission Date:";
            // 
            // lblDateEnd
            // 
            lblDateEnd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDateEnd.AutoSize = true;
            lblDateEnd.Location = new Point(608, 443);
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
            // pnlCommonGitCommands
            // 
            pnlCommonGitCommands.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCommonGitCommands.BackColor = Color.GhostWhite;
            pnlCommonGitCommands.BorderStyle = BorderStyle.FixedSingle;
            pnlCommonGitCommands.Controls.Add(btnGitCheckout);
            pnlCommonGitCommands.Controls.Add(btnGitFetch);
            pnlCommonGitCommands.Controls.Add(btnGitBranch);
            pnlCommonGitCommands.Controls.Add(btnGitPush);
            pnlCommonGitCommands.Controls.Add(btnGitPull);
            pnlCommonGitCommands.Controls.Add(btnGitStatus);
            pnlCommonGitCommands.Controls.Add(btnGitStash);
            pnlCommonGitCommands.Controls.Add(btnGitCommit);
            pnlCommonGitCommands.Location = new Point(650, 57);
            pnlCommonGitCommands.Name = "pnlCommonGitCommands";
            pnlCommonGitCommands.Size = new Size(165, 118);
            pnlCommonGitCommands.TabIndex = 14;
            // 
            // btnGitCheckout
            // 
            btnGitCheckout.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitCheckout.Location = new Point(85, 61);
            btnGitCheckout.Name = "btnGitCheckout";
            btnGitCheckout.Size = new Size(75, 23);
            btnGitCheckout.TabIndex = 8;
            btnGitCheckout.Text = "Checkout";
            btnGitCheckout.UseVisualStyleBackColor = true;
            btnGitCheckout.Click += btnGitCheckout_clicked;
            // 
            // btnGitFetch
            // 
            btnGitFetch.Location = new Point(3, 61);
            btnGitFetch.Name = "btnGitFetch";
            btnGitFetch.Size = new Size(75, 23);
            btnGitFetch.TabIndex = 7;
            btnGitFetch.Text = "Fetch";
            btnGitFetch.UseVisualStyleBackColor = true;
            btnGitFetch.Click += btnGitFetch_clicked;
            // 
            // btnGitBranch
            // 
            btnGitBranch.Location = new Point(85, 32);
            btnGitBranch.Name = "btnGitBranch";
            btnGitBranch.Size = new Size(75, 23);
            btnGitBranch.TabIndex = 6;
            btnGitBranch.Text = "Branch";
            btnGitBranch.UseVisualStyleBackColor = true;
            btnGitBranch.Click += btnGitBranch_clicked;
            // 
            // btnGitPush
            // 
            btnGitPush.Location = new Point(84, 90);
            btnGitPush.Name = "btnGitPush";
            btnGitPush.Size = new Size(75, 23);
            btnGitPush.TabIndex = 5;
            btnGitPush.Text = "Push";
            btnGitPush.UseVisualStyleBackColor = true;
            btnGitPush.Click += btnGitPush_clicked;
            // 
            // btnGitPull
            // 
            btnGitPull.Location = new Point(3, 90);
            btnGitPull.Name = "btnGitPull";
            btnGitPull.Size = new Size(75, 23);
            btnGitPull.TabIndex = 4;
            btnGitPull.Text = "Pull";
            btnGitPull.UseVisualStyleBackColor = true;
            btnGitPull.Click += btnGitPull_clicked;
            // 
            // btnGitStatus
            // 
            btnGitStatus.Location = new Point(3, 32);
            btnGitStatus.Name = "btnGitStatus";
            btnGitStatus.Size = new Size(75, 23);
            btnGitStatus.TabIndex = 3;
            btnGitStatus.Text = "Status";
            btnGitStatus.UseVisualStyleBackColor = true;
            btnGitStatus.Click += btnGitStatus_clicked;
            // 
            // btnGitStash
            // 
            btnGitStash.Location = new Point(85, 3);
            btnGitStash.Name = "btnGitStash";
            btnGitStash.Size = new Size(75, 23);
            btnGitStash.TabIndex = 2;
            btnGitStash.Text = "Stash";
            btnGitStash.UseVisualStyleBackColor = true;
            btnGitStash.Click += btnGitStash_clicked;
            // 
            // btnGitCommit
            // 
            btnGitCommit.Location = new Point(3, 3);
            btnGitCommit.Name = "btnGitCommit";
            btnGitCommit.Size = new Size(75, 23);
            btnGitCommit.TabIndex = 2;
            btnGitCommit.Text = "Commit";
            btnGitCommit.UseVisualStyleBackColor = true;
            btnGitCommit.Click += btnGitCommit_clicked;
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
            txbxBashOutput_display.Size = new Size(632, 218);
            txbxBashOutput_display.TabIndex = 17;
            // 
            // pnlUncommonGitCommands
            // 
            pnlUncommonGitCommands.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlUncommonGitCommands.BackColor = Color.GhostWhite;
            pnlUncommonGitCommands.BorderStyle = BorderStyle.FixedSingle;
            pnlUncommonGitCommands.Controls.Add(btnGitAddRemote);
            pnlUncommonGitCommands.Controls.Add(btnGitReset);
            pnlUncommonGitCommands.Controls.Add(btnGitClone);
            pnlUncommonGitCommands.Controls.Add(btnGitInit);
            pnlUncommonGitCommands.Location = new Point(821, 57);
            pnlUncommonGitCommands.Name = "pnlUncommonGitCommands";
            pnlUncommonGitCommands.Size = new Size(87, 118);
            pnlUncommonGitCommands.TabIndex = 18;
            // 
            // btnGitAddRemote
            // 
            btnGitAddRemote.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitAddRemote.Location = new Point(3, 32);
            btnGitAddRemote.Name = "btnGitAddRemote";
            btnGitAddRemote.Size = new Size(80, 23);
            btnGitAddRemote.TabIndex = 0;
            btnGitAddRemote.Text = "Add Remote";
            btnGitAddRemote.UseVisualStyleBackColor = true;
            btnGitAddRemote.Visible = false;
            btnGitAddRemote.Click += btnGitAddRemote_clicked;
            // 
            // btnGitReset
            // 
            btnGitReset.Location = new Point(3, 90);
            btnGitReset.Name = "btnGitReset";
            btnGitReset.Size = new Size(80, 23);
            btnGitReset.TabIndex = 0;
            btnGitReset.Text = "Reset";
            btnGitReset.UseVisualStyleBackColor = true;
            btnGitReset.Visible = false;
            btnGitReset.Click += btnGitReset_clicked;
            // 
            // btnGitClone
            // 
            btnGitClone.Location = new Point(2, 61);
            btnGitClone.Name = "btnGitClone";
            btnGitClone.Size = new Size(80, 23);
            btnGitClone.TabIndex = 0;
            btnGitClone.Text = "Clone";
            btnGitClone.UseVisualStyleBackColor = true;
            btnGitClone.Visible = false;
            btnGitClone.Click += btnGitClone_clicked;
            // 
            // btnGitInit
            // 
            btnGitInit.Location = new Point(3, 3);
            btnGitInit.Name = "btnGitInit";
            btnGitInit.Size = new Size(80, 23);
            btnGitInit.TabIndex = 0;
            btnGitInit.Text = "Init";
            btnGitInit.UseVisualStyleBackColor = true;
            btnGitInit.Visible = false;
            btnGitInit.Click += btnGitInit_clicked;
            // 
            // ckbxShowUncommonGitCommands
            // 
            ckbxShowUncommonGitCommands.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ckbxShowUncommonGitCommands.AutoSize = true;
            ckbxShowUncommonGitCommands.Location = new Point(821, 181);
            ckbxShowUncommonGitCommands.Name = "ckbxShowUncommonGitCommands";
            ckbxShowUncommonGitCommands.Size = new Size(67, 19);
            ckbxShowUncommonGitCommands.TabIndex = 19;
            ckbxShowUncommonGitCommands.Text = "Danger!";
            ckbxShowUncommonGitCommands.UseVisualStyleBackColor = true;
            ckbxShowUncommonGitCommands.CheckedChanged += ckbxShowUncommonGitCommands_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.GhostWhite;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCurrentProject);
            panel1.Location = new Point(650, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 24);
            panel1.TabIndex = 20;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 495);
            Controls.Add(panel1);
            Controls.Add(ckbxShowUncommonGitCommands);
            Controls.Add(pnlUncommonGitCommands);
            Controls.Add(txbxBashOutput_display);
            Controls.Add(lblDeterminationQuote);
            Controls.Add(btnAllTickets);
            Controls.Add(pnlCommonGitCommands);
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
            pnlCommonGitCommands.ResumeLayout(false);
            pnlUncommonGitCommands.ResumeLayout(false);
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
        private ToolStripMenuItem gitBashToolStripMenuItem;
        private Panel pnlCommonGitCommands;
        private Button btnGitCommit;
        private Button btnAllTickets;
        private Button btnGitPush;
        private Button btnGitPull;
        private Button btnGitStatus;
        private Label lblDeterminationQuote;
        private ToolStripMenuItem tsmiOpenResource;
        private ToolStripMenuItem tsmiFileAddResource;
        private TextBox txbxBashOutput_display;
        private Button btnGitBranch;
        private Button btnGitCheckout;
        private Button btnGitFetch;
        private ToolStripMenuItem tsmiOpenResourceImage;
        private ToolStripMenuItem tsmiOpenResourceDocument;
        private ToolStripMenuItem tsmiOpenResourceWebsite;
        private Button btnGitStash;
        private Panel pnlUncommonGitCommands;
        private Button btnGitInit;
        private Button btnGitAddRemote;
        private Button btnGitReset;
        private Button btnGitClone;
        private CheckBox ckbxShowUncommonGitCommands;
        private Panel panel1;
    }
}
