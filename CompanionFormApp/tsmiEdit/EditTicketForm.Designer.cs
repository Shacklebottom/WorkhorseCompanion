namespace CompanionFormApp.tsmiEdit
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
            lblTicketType = new Label();
            lblTicketPriority = new Label();
            txbxTicketName = new TextBox();
            cmbbxTicketType = new ComboBox();
            cmbbxTicketPriority = new ComboBox();
            lblTicketDescription = new Label();
            txbxTicketDescription = new TextBox();
            btnAcceptTicketEdit = new Button();
            chkbxTicketComplete = new CheckBox();
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
            // lblTicketType
            // 
            lblTicketType.AutoSize = true;
            lblTicketType.Location = new Point(12, 44);
            lblTicketType.Name = "lblTicketType";
            lblTicketType.Size = new Size(34, 15);
            lblTicketType.TabIndex = 1;
            lblTicketType.Text = "Type:";
            // 
            // lblTicketPriority
            // 
            lblTicketPriority.AutoSize = true;
            lblTicketPriority.Location = new Point(12, 73);
            lblTicketPriority.Name = "lblTicketPriority";
            lblTicketPriority.Size = new Size(48, 15);
            lblTicketPriority.TabIndex = 2;
            lblTicketPriority.Text = "Priority:";
            // 
            // txbxTicketName
            // 
            txbxTicketName.BackColor = Color.LemonChiffon;
            txbxTicketName.Location = new Point(66, 12);
            txbxTicketName.Name = "txbxTicketName";
            txbxTicketName.Size = new Size(166, 23);
            txbxTicketName.TabIndex = 3;
            // 
            // cmbbxTicketType
            // 
            cmbbxTicketType.BackColor = Color.LemonChiffon;
            cmbbxTicketType.FormattingEnabled = true;
            cmbbxTicketType.Location = new Point(66, 41);
            cmbbxTicketType.Name = "cmbbxTicketType";
            cmbbxTicketType.Size = new Size(121, 23);
            cmbbxTicketType.TabIndex = 4;
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
            // btnAcceptTicketEdit
            // 
            btnAcceptTicketEdit.BackColor = Color.LemonChiffon;
            btnAcceptTicketEdit.Location = new Point(341, 378);
            btnAcceptTicketEdit.Name = "btnAcceptTicketEdit";
            btnAcceptTicketEdit.Size = new Size(75, 23);
            btnAcceptTicketEdit.TabIndex = 8;
            btnAcceptTicketEdit.Text = "Accept";
            btnAcceptTicketEdit.UseVisualStyleBackColor = false;
            btnAcceptTicketEdit.Click += btnAcceptTicketEdit_Clicked;
            // 
            // chkbxTicketComplete
            // 
            chkbxTicketComplete.AutoSize = true;
            chkbxTicketComplete.Location = new Point(12, 382);
            chkbxTicketComplete.Name = "chkbxTicketComplete";
            chkbxTicketComplete.Size = new Size(115, 19);
            chkbxTicketComplete.TabIndex = 10;
            chkbxTicketComplete.Text = "Ticket Complete!";
            chkbxTicketComplete.UseVisualStyleBackColor = true;
            // 
            // EditTicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(428, 413);
            Controls.Add(chkbxTicketComplete);
            Controls.Add(btnAcceptTicketEdit);
            Controls.Add(txbxTicketDescription);
            Controls.Add(lblTicketDescription);
            Controls.Add(cmbbxTicketPriority);
            Controls.Add(cmbbxTicketType);
            Controls.Add(txbxTicketName);
            Controls.Add(lblTicketPriority);
            Controls.Add(lblTicketType);
            Controls.Add(lblTicketName);
            Name = "EditTicketForm";
            Text = "Edit Current Ticket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicketName;
        private Label lblTicketType;
        private Label lblTicketPriority;
        private TextBox txbxTicketName;
        private ComboBox cmbbxTicketType;
        private ComboBox cmbbxTicketPriority;
        private Label lblTicketDescription;
        private TextBox txbxTicketDescription;
        private Button btnAcceptTicketEdit;
        private CheckBox chkbxTicketComplete;
    }
}