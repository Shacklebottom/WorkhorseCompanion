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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tsmiEdit = new ToolStripMenuItem();
            tsmiEditCurrentTicket = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SaddleBrown;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiNew, tsmiEdit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
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
            tsmiNewTicket.Size = new Size(180, 22);
            tsmiNewTicket.Text = "Ticket";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.Location = new Point(210, 56);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(578, 350);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.Location = new Point(12, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 23);
            textBox2.TabIndex = 2;
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
            tsmiEditCurrentTicket.Name = "tsmiEditCurrentTicket";
            tsmiEditCurrentTicket.Size = new Size(180, 22);
            tsmiEditCurrentTicket.Text = "Current Ticket";
            // 
            // TicketSystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TicketSystemForm";
            ShowIcon = false;
            Text = "Workhorse Companion: Ticket System";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem tsmiEditCurrentTicket;
    }
}