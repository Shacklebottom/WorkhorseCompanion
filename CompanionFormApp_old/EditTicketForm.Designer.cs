namespace RefactoredFormApp
{
    partial class EditTicketForm
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
            lblTicketDescription = new Label();
            lblTicketPriority = new Label();
            lblTicketType = new Label();
            txbxTicketName = new TextBox();
            txbxTicketDescription = new TextBox();
            cmbobxTicketPriority = new ComboBox();
            cmbobxTicketType = new ComboBox();
            chkbxTicketCompleted = new CheckBox();
            btnSubmitTicketEdit = new Button();
            SuspendLayout();
            // 
            // lblTicketName
            // 
            lblTicketName.AutoSize = true;
            lblTicketName.Location = new Point(12, 14);
            lblTicketName.Name = "lblTicketName";
            lblTicketName.Size = new Size(76, 15);
            lblTicketName.TabIndex = 0;
            lblTicketName.Text = "Ticket Name:";
            // 
            // lblTicketDescription
            // 
            lblTicketDescription.AutoSize = true;
            lblTicketDescription.Location = new Point(12, 44);
            lblTicketDescription.Name = "lblTicketDescription";
            lblTicketDescription.Size = new Size(104, 15);
            lblTicketDescription.TabIndex = 1;
            lblTicketDescription.Text = "Ticket Description:";
            // 
            // lblTicketPriority
            // 
            lblTicketPriority.AutoSize = true;
            lblTicketPriority.Location = new Point(12, 204);
            lblTicketPriority.Name = "lblTicketPriority";
            lblTicketPriority.Size = new Size(82, 15);
            lblTicketPriority.TabIndex = 2;
            lblTicketPriority.Text = "Ticket Priority:";
            // 
            // lblTicketType
            // 
            lblTicketType.AutoSize = true;
            lblTicketType.Location = new Point(208, 204);
            lblTicketType.Name = "lblTicketType";
            lblTicketType.Size = new Size(68, 15);
            lblTicketType.TabIndex = 3;
            lblTicketType.Text = "Ticket Type:";
            // 
            // txbxTicketName
            // 
            txbxTicketName.Location = new Point(85, 11);
            txbxTicketName.Name = "txbxTicketName";
            txbxTicketName.Size = new Size(166, 23);
            txbxTicketName.TabIndex = 4;
            // 
            // txbxTicketDescription
            // 
            txbxTicketDescription.Location = new Point(12, 62);
            txbxTicketDescription.Multiline = true;
            txbxTicketDescription.Name = "txbxTicketDescription";
            txbxTicketDescription.Size = new Size(362, 119);
            txbxTicketDescription.TabIndex = 5;
            // 
            // cmbobxTicketPriority
            // 
            cmbobxTicketPriority.FormattingEnabled = true;
            cmbobxTicketPriority.Location = new Point(91, 201);
            cmbobxTicketPriority.Name = "cmbobxTicketPriority";
            cmbobxTicketPriority.Size = new Size(111, 23);
            cmbobxTicketPriority.TabIndex = 6;
            // 
            // cmbobxTicketType
            // 
            cmbobxTicketType.FormattingEnabled = true;
            cmbobxTicketType.Location = new Point(273, 202);
            cmbobxTicketType.Name = "cmbobxTicketType";
            cmbobxTicketType.Size = new Size(101, 23);
            cmbobxTicketType.TabIndex = 7;
            // 
            // chkbxTicketCompleted
            // 
            chkbxTicketCompleted.AutoSize = true;
            chkbxTicketCompleted.Location = new Point(24, 241);
            chkbxTicketCompleted.Name = "chkbxTicketCompleted";
            chkbxTicketCompleted.Size = new Size(119, 19);
            chkbxTicketCompleted.TabIndex = 8;
            chkbxTicketCompleted.Text = "Ticket Completed";
            chkbxTicketCompleted.UseVisualStyleBackColor = true;
            // 
            // btnSubmitTicketEdit
            // 
            btnSubmitTicketEdit.DialogResult = DialogResult.OK;
            btnSubmitTicketEdit.Location = new Point(299, 241);
            btnSubmitTicketEdit.Name = "btnSubmitTicketEdit";
            btnSubmitTicketEdit.Size = new Size(75, 23);
            btnSubmitTicketEdit.TabIndex = 9;
            btnSubmitTicketEdit.Text = "Accept";
            btnSubmitTicketEdit.UseVisualStyleBackColor = true;
            btnSubmitTicketEdit.Click += btnSubmitTicketEdit_clicked;
            // 
            // EditTicketForm
            // 
            AcceptButton = btnSubmitTicketEdit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 281);
            Controls.Add(btnSubmitTicketEdit);
            Controls.Add(chkbxTicketCompleted);
            Controls.Add(cmbobxTicketType);
            Controls.Add(cmbobxTicketPriority);
            Controls.Add(txbxTicketDescription);
            Controls.Add(txbxTicketName);
            Controls.Add(lblTicketType);
            Controls.Add(lblTicketPriority);
            Controls.Add(lblTicketDescription);
            Controls.Add(lblTicketName);
            Name = "EditTicketForm";
            Text = "Edit Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicketName;
        private Label lblTicketDescription;
        private Label lblTicketPriority;
        private Label lblTicketType;
        private TextBox txbxTicketName;
        private TextBox txbxTicketDescription;
        private ComboBox cmbobxTicketPriority;
        private ComboBox cmbobxTicketType;
        private CheckBox chkbxTicketCompleted;
        private Button btnSubmitTicketEdit;
    }
}