using CompanionDomain;

namespace RefactoredFormApp
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
            lblTicketDescription = new Label();
            txbxTicketDescription_capture = new TextBox();
            cmbbxTicketPriority = new ComboBox();
            lblTicketPriority = new Label();
            lblTicketType = new Label();
            cmbbxTicketType = new ComboBox();
            btnSubmitNewTicket = new Button();
            SuspendLayout();
            // 
            // lblTicketName
            // 
            lblTicketName.AutoSize = true;
            lblTicketName.Location = new Point(12, 9);
            lblTicketName.Name = "lblTicketName";
            lblTicketName.Size = new Size(39, 15);
            lblTicketName.TabIndex = 0;
            lblTicketName.Text = "Name";
            // 
            // txbxTicketName
            // 
            txbxTicketName.Location = new Point(57, 6);
            txbxTicketName.Name = "txbxTicketName";
            txbxTicketName.Size = new Size(170, 23);
            txbxTicketName.TabIndex = 1;
            // 
            // lblTicketDescription
            // 
            lblTicketDescription.AutoSize = true;
            lblTicketDescription.Location = new Point(12, 42);
            lblTicketDescription.Name = "lblTicketDescription";
            lblTicketDescription.Size = new Size(67, 15);
            lblTicketDescription.TabIndex = 2;
            lblTicketDescription.Text = "Description";
            // 
            // txbxTicketDescription
            // 
            txbxTicketDescription_capture.Location = new Point(86, 39);
            txbxTicketDescription_capture.Name = "txbxTicketDescription";
            txbxTicketDescription_capture.Size = new Size(603, 23);
            txbxTicketDescription_capture.TabIndex = 3;
            // 
            // cmbbxTicketPriority
            // 
            cmbbxTicketPriority.FormattingEnabled = true;
            cmbbxTicketPriority.Location = new Point(63, 72);
            cmbbxTicketPriority.Name = "cmbbxTicketPriority";
            cmbbxTicketPriority.Size = new Size(144, 23);
            cmbbxTicketPriority.TabIndex = 4;
            // 
            // lblTicketPriority
            // 
            lblTicketPriority.AutoSize = true;
            lblTicketPriority.Location = new Point(12, 75);
            lblTicketPriority.Name = "lblTicketPriority";
            lblTicketPriority.Size = new Size(45, 15);
            lblTicketPriority.TabIndex = 5;
            lblTicketPriority.Text = "Priority";
            // 
            // lblTicketType
            // 
            lblTicketType.AutoSize = true;
            lblTicketType.Location = new Point(12, 112);
            lblTicketType.Name = "lblTicketType";
            lblTicketType.Size = new Size(31, 15);
            lblTicketType.TabIndex = 6;
            lblTicketType.Text = "Type";
            // 
            // cmbbxTicketType
            // 
            cmbbxTicketType.FormattingEnabled = true;
            cmbbxTicketType.Location = new Point(49, 109);
            cmbbxTicketType.Name = "cmbbxTicketType";
            cmbbxTicketType.Size = new Size(142, 23);
            cmbbxTicketType.TabIndex = 7;
            // 
            // btnSubmitNewTicket
            // 
            btnSubmitNewTicket.DialogResult = DialogResult.OK;
            btnSubmitNewTicket.Location = new Point(586, 132);
            btnSubmitNewTicket.Name = "btnSubmitNewTicket";
            btnSubmitNewTicket.Size = new Size(103, 23);
            btnSubmitNewTicket.TabIndex = 8;
            btnSubmitNewTicket.Text = "Accept";
            btnSubmitNewTicket.UseVisualStyleBackColor = true;
            btnSubmitNewTicket.Click += btnSubmitNewTicket_clicked;
            // 
            // NewTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 167);
            Controls.Add(btnSubmitNewTicket);
            Controls.Add(cmbbxTicketType);
            Controls.Add(lblTicketType);
            Controls.Add(lblTicketPriority);
            Controls.Add(cmbbxTicketPriority);
            Controls.Add(txbxTicketDescription_capture);
            Controls.Add(lblTicketDescription);
            Controls.Add(txbxTicketName);
            Controls.Add(lblTicketName);
            Name = "NewTicketForm";
            Text = "New Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicketName;
        private TextBox txbxTicketName;
        private Label lblTicketDescription;
        private TextBox txbxTicketDescription_capture;
        private ComboBox cmbbxTicketPriority;
        private Label lblTicketPriority;
        private Label lblTicketType;
        private ComboBox cmbbxTicketType;
        private Button btnSubmitNewTicket;
    }
}