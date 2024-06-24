namespace CompanionFormApp.tsmiNew
{
    partial class NewTicketForm
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
            lblTicketName = new Label();
            txbxTicketName = new TextBox();
            lblTicketType = new Label();
            cmbbxTicketType = new ComboBox();
            lblTicketPriority = new Label();
            cmbbxTicketPriority = new ComboBox();
            lblTicketDescription = new Label();
            txbxTicketDescription = new TextBox();
            btnAcceptNewTicket = new Button();
            SuspendLayout();
            // 
            // lblTicketName
            // 
            lblTicketName.AutoSize = true;
            lblTicketName.Location = new Point(12, 15);
            lblTicketName.Name = "lblTicketName";
            lblTicketName.Size = new Size(42, 15);
            lblTicketName.TabIndex = 0;
            lblTicketName.Text = "Name:";
            // 
            // txbxTicketName
            // 
            txbxTicketName.BackColor = Color.LemonChiffon;
            txbxTicketName.Location = new Point(66, 12);
            txbxTicketName.Name = "txbxTicketName";
            txbxTicketName.Size = new Size(166, 23);
            txbxTicketName.TabIndex = 1;
            // 
            // lblTicketType
            // 
            lblTicketType.AutoSize = true;
            lblTicketType.Location = new Point(12, 44);
            lblTicketType.Name = "lblTicketType";
            lblTicketType.Size = new Size(34, 15);
            lblTicketType.TabIndex = 2;
            lblTicketType.Text = "Type:";
            // 
            // cmbbxTicketType
            // 
            cmbbxTicketType.BackColor = Color.LemonChiffon;
            cmbbxTicketType.FormattingEnabled = true;
            cmbbxTicketType.Location = new Point(66, 41);
            cmbbxTicketType.Name = "cmbbxTicketType";
            cmbbxTicketType.Size = new Size(121, 23);
            cmbbxTicketType.TabIndex = 3;
            // 
            // lblTicketPriority
            // 
            lblTicketPriority.AutoSize = true;
            lblTicketPriority.Location = new Point(12, 73);
            lblTicketPriority.Name = "lblTicketPriority";
            lblTicketPriority.Size = new Size(48, 15);
            lblTicketPriority.TabIndex = 4;
            lblTicketPriority.Text = "Priority:";
            // 
            // cmbbxTicketPriority
            // 
            cmbbxTicketPriority.BackColor = Color.LemonChiffon;
            cmbbxTicketPriority.FormattingEnabled = true;
            cmbbxTicketPriority.Location = new Point(66, 70);
            cmbbxTicketPriority.Name = "cmbbxTicketPriority";
            cmbbxTicketPriority.Size = new Size(121, 23);
            cmbbxTicketPriority.TabIndex = 5;
            // 
            // lblTicketDescription
            // 
            lblTicketDescription.AutoSize = true;
            lblTicketDescription.Location = new Point(12, 105);
            lblTicketDescription.Name = "lblTicketDescription";
            lblTicketDescription.Size = new Size(70, 15);
            lblTicketDescription.TabIndex = 6;
            lblTicketDescription.Text = "Description:";
            // 
            // txbxTicketDescription
            // 
            txbxTicketDescription.BackColor = Color.LemonChiffon;
            txbxTicketDescription.Location = new Point(12, 123);
            txbxTicketDescription.Multiline = true;
            txbxTicketDescription.Name = "txbxTicketDescription";
            txbxTicketDescription.Size = new Size(404, 249);
            txbxTicketDescription.TabIndex = 7;
            // 
            // btnAcceptNewTicket
            // 
            btnAcceptNewTicket.BackColor = Color.LemonChiffon;
            btnAcceptNewTicket.Location = new Point(341, 378);
            btnAcceptNewTicket.Name = "btnAcceptNewTicket";
            btnAcceptNewTicket.Size = new Size(75, 23);
            btnAcceptNewTicket.TabIndex = 8;
            btnAcceptNewTicket.Text = "Accept";
            btnAcceptNewTicket.UseVisualStyleBackColor = false;
            btnAcceptNewTicket.Click += btnAcceptNewTicket_Clicked;
            // 
            // NewTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(428, 413);
            Controls.Add(btnAcceptNewTicket);
            Controls.Add(txbxTicketDescription);
            Controls.Add(lblTicketDescription);
            Controls.Add(cmbbxTicketPriority);
            Controls.Add(lblTicketPriority);
            Controls.Add(cmbbxTicketType);
            Controls.Add(lblTicketType);
            Controls.Add(txbxTicketName);
            Controls.Add(lblTicketName);
            Name = "NewTicketForm";
            Text = "Create New Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicketName;
        private TextBox txbxTicketName;
        private Label lblTicketType;
        private ComboBox cmbbxTicketType;
        private Label lblTicketPriority;
        private ComboBox cmbbxTicketPriority;
        private Label lblTicketDescription;
        private TextBox txbxTicketDescription;
        private Button btnAcceptNewTicket;
    }
}