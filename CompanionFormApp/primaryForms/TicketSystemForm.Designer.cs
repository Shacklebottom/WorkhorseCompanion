namespace CompanionFormApp.primaryForms
{
    partial class TicketSystemForm
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
            menuStrip1 = new MenuStrip();
            tsmiNew = new ToolStripMenuItem();
            tsmiNewTicket = new ToolStripMenuItem();
            tsmiEdit = new ToolStripMenuItem();
            tsmiEditCurrentTicket = new ToolStripMenuItem();
            txbxTicketDescription_display = new TextBox();
            txbxCurrentProject = new TextBox();
            lstbxTicketOverview = new ListBox();
            btnAllTickets = new Button();
            btnActiveTickets = new Button();
            btnCompleteTickets = new Button();
            txbxTicketName = new TextBox();
            txbxTicketType = new TextBox();
            txbxTicketPriority = new TextBox();
            txbxDateStart = new TextBox();
            txbxDateEnd = new TextBox();
            lblDeterminationQuote = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SaddleBrown;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiNew, tsmiEdit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiNew
            // 
            tsmiNew.DropDownItems.AddRange(new ToolStripItem[] { tsmiNewTicket });
            tsmiNew.Name = "tsmiNew";
            tsmiNew.Size = new Size(43, 20);
            tsmiNew.Text = "New";
            // 
            // tsmiNewTicket
            // 
            tsmiNewTicket.BackColor = Color.LemonChiffon;
            tsmiNewTicket.Name = "tsmiNewTicket";
            tsmiNewTicket.Size = new Size(105, 22);
            tsmiNewTicket.Text = "Ticket";
            tsmiNewTicket.Click += tsmiNewTicket_Clicked;
            // 
            // tsmiEdit
            // 
            tsmiEdit.DropDownItems.AddRange(new ToolStripItem[] { tsmiEditCurrentTicket });
            tsmiEdit.Name = "tsmiEdit";
            tsmiEdit.Size = new Size(39, 20);
            tsmiEdit.Text = "Edit";
            // 
            // tsmiEditCurrentTicket
            // 
            tsmiEditCurrentTicket.BackColor = Color.LemonChiffon;
            tsmiEditCurrentTicket.Name = "tsmiEditCurrentTicket";
            tsmiEditCurrentTicket.Size = new Size(148, 22);
            tsmiEditCurrentTicket.Text = "Current Ticket";
            tsmiEditCurrentTicket.Click += tsmiEditCurrentTicket_Clicked;
            // 
            // txbxTicketDescription_display
            // 
            txbxTicketDescription_display.BackColor = Color.LemonChiffon;
            txbxTicketDescription_display.Location = new Point(210, 56);
            txbxTicketDescription_display.Multiline = true;
            txbxTicketDescription_display.Name = "txbxTicketDescription_display";
            txbxTicketDescription_display.ReadOnly = true;
            txbxTicketDescription_display.Size = new Size(586, 349);
            txbxTicketDescription_display.TabIndex = 1;
            // 
            // txbxCurrentProject
            // 
            txbxCurrentProject.BackColor = Color.LemonChiffon;
            txbxCurrentProject.Location = new Point(12, 27);
            txbxCurrentProject.Name = "txbxCurrentProject";
            txbxCurrentProject.ReadOnly = true;
            txbxCurrentProject.Size = new Size(193, 23);
            txbxCurrentProject.TabIndex = 2;
            txbxCurrentProject.Text = "Project:";
            // 
            // lstbxTicketOverview
            // 
            lstbxTicketOverview.BackColor = Color.LemonChiffon;
            lstbxTicketOverview.FormattingEnabled = true;
            lstbxTicketOverview.ItemHeight = 15;
            lstbxTicketOverview.Location = new Point(12, 86);
            lstbxTicketOverview.Name = "lstbxTicketOverview";
            lstbxTicketOverview.Size = new Size(192, 319);
            lstbxTicketOverview.TabIndex = 3;
            lstbxTicketOverview.SelectedIndexChanged += lstbxTicketOverview_SelectedIndexChanged;
            // 
            // btnAllTickets
            // 
            btnAllTickets.BackColor = Color.LemonChiffon;
            btnAllTickets.Location = new Point(12, 55);
            btnAllTickets.Name = "btnAllTickets";
            btnAllTickets.Size = new Size(47, 23);
            btnAllTickets.TabIndex = 4;
            btnAllTickets.Text = "All";
            btnAllTickets.UseVisualStyleBackColor = false;
            btnAllTickets.Click += btnAllTickets_Clicked;
            // 
            // btnActiveTickets
            // 
            btnActiveTickets.BackColor = Color.LemonChiffon;
            btnActiveTickets.Location = new Point(65, 55);
            btnActiveTickets.Name = "btnActiveTickets";
            btnActiveTickets.Size = new Size(64, 23);
            btnActiveTickets.TabIndex = 5;
            btnActiveTickets.Text = "Active";
            btnActiveTickets.UseVisualStyleBackColor = false;
            btnActiveTickets.Click += btnActiveTickets_Clicked;
            // 
            // btnCompleteTickets
            // 
            btnCompleteTickets.BackColor = Color.LemonChiffon;
            btnCompleteTickets.Location = new Point(135, 55);
            btnCompleteTickets.Name = "btnCompleteTickets";
            btnCompleteTickets.Size = new Size(70, 23);
            btnCompleteTickets.TabIndex = 6;
            btnCompleteTickets.Text = "Complete";
            btnCompleteTickets.UseVisualStyleBackColor = false;
            btnCompleteTickets.Click += btnCompleteTickets_Clicked;
            // 
            // txbxTicketName
            // 
            txbxTicketName.BackColor = Color.LemonChiffon;
            txbxTicketName.Location = new Point(210, 27);
            txbxTicketName.Name = "txbxTicketName";
            txbxTicketName.ReadOnly = true;
            txbxTicketName.Size = new Size(152, 23);
            txbxTicketName.TabIndex = 7;
            txbxTicketName.Text = "Ticket:";
            // 
            // txbxTicketType
            // 
            txbxTicketType.BackColor = Color.LemonChiffon;
            txbxTicketType.Location = new Point(368, 27);
            txbxTicketType.Name = "txbxTicketType";
            txbxTicketType.ReadOnly = true;
            txbxTicketType.Size = new Size(85, 23);
            txbxTicketType.TabIndex = 8;
            txbxTicketType.Text = "Type:";
            // 
            // txbxTicketPriority
            // 
            txbxTicketPriority.BackColor = Color.LemonChiffon;
            txbxTicketPriority.Location = new Point(459, 27);
            txbxTicketPriority.Name = "txbxTicketPriority";
            txbxTicketPriority.ReadOnly = true;
            txbxTicketPriority.Size = new Size(79, 23);
            txbxTicketPriority.TabIndex = 9;
            txbxTicketPriority.Text = "Priority:";
            // 
            // txbxDateStart
            // 
            txbxDateStart.BackColor = Color.LemonChiffon;
            txbxDateStart.Location = new Point(544, 27);
            txbxDateStart.Name = "txbxDateStart";
            txbxDateStart.ReadOnly = true;
            txbxDateStart.Size = new Size(123, 23);
            txbxDateStart.TabIndex = 10;
            txbxDateStart.Text = "Start:";
            // 
            // txbxDateEnd
            // 
            txbxDateEnd.BackColor = Color.LemonChiffon;
            txbxDateEnd.Location = new Point(673, 27);
            txbxDateEnd.Name = "txbxDateEnd";
            txbxDateEnd.ReadOnly = true;
            txbxDateEnd.Size = new Size(123, 23);
            txbxDateEnd.TabIndex = 11;
            txbxDateEnd.Text = "End:";
            // 
            // lblDeterminationQuote
            // 
            lblDeterminationQuote.AutoSize = true;
            lblDeterminationQuote.Location = new Point(12, 414);
            lblDeterminationQuote.Name = "lblDeterminationQuote";
            lblDeterminationQuote.Size = new Size(22, 15);
            lblDeterminationQuote.TabIndex = 12;
            lblDeterminationQuote.Text = "---";
            // 
            // TicketSystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(808, 438);
            Controls.Add(lblDeterminationQuote);
            Controls.Add(txbxDateEnd);
            Controls.Add(txbxDateStart);
            Controls.Add(txbxTicketPriority);
            Controls.Add(txbxTicketType);
            Controls.Add(txbxTicketName);
            Controls.Add(btnCompleteTickets);
            Controls.Add(btnActiveTickets);
            Controls.Add(btnAllTickets);
            Controls.Add(lstbxTicketOverview);
            Controls.Add(txbxCurrentProject);
            Controls.Add(txbxTicketDescription_display);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TicketSystemForm";
            ShowIcon = false;
            Text = "Workhorse Companion: Ticket System";
            Activated += PopulateDeterminationWhen_TicketSystemForm_Activated;
            FormClosing += TicketSystemForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiNew;
        private ToolStripMenuItem tsmiNewTicket;
        private TextBox txbxTicketDescription_display;
        private TextBox txbxCurrentProject;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiEditCurrentTicket;
        private ListBox lstbxTicketOverview;
        private Button btnAllTickets;
        private Button btnActiveTickets;
        private Button btnCompleteTickets;
        private TextBox txbxTicketName;
        private TextBox txbxTicketType;
        private TextBox txbxTicketPriority;
        private TextBox txbxDateStart;
        private TextBox txbxDateEnd;
        private Label lblDeterminationQuote;
    }
}