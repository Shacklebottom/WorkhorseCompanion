namespace CompanionFormApp
{
    partial class EditTaskForm
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
            lblTaskName = new Label();
            lblTaskDescription = new Label();
            lblTaskPriority = new Label();
            lblTaskType = new Label();
            txbxTaskName = new TextBox();
            txbxTaskDescription = new TextBox();
            cmbobxTaskPriority = new ComboBox();
            cmbobxTaskType = new ComboBox();
            chkbxTaskCompleted = new CheckBox();
            btnSubmitTaskEdit = new Button();
            SuspendLayout();
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(12, 14);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(67, 15);
            lblTaskName.TabIndex = 0;
            lblTaskName.Text = "Task Name:";
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.Location = new Point(12, 44);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(95, 15);
            lblTaskDescription.TabIndex = 1;
            lblTaskDescription.Text = "Task Description:";
            // 
            // lblTaskPriority
            // 
            lblTaskPriority.AutoSize = true;
            lblTaskPriority.Location = new Point(12, 204);
            lblTaskPriority.Name = "lblTaskPriority";
            lblTaskPriority.Size = new Size(73, 15);
            lblTaskPriority.TabIndex = 2;
            lblTaskPriority.Text = "Task Priority:";
            // 
            // lblTaskType
            // 
            lblTaskType.AutoSize = true;
            lblTaskType.Location = new Point(208, 204);
            lblTaskType.Name = "lblTaskType";
            lblTaskType.Size = new Size(59, 15);
            lblTaskType.TabIndex = 3;
            lblTaskType.Text = "Task Type:";
            // 
            // txbxTaskName
            // 
            txbxTaskName.Location = new Point(85, 11);
            txbxTaskName.Name = "txbxTaskName";
            txbxTaskName.Size = new Size(166, 23);
            txbxTaskName.TabIndex = 4;
            // 
            // txbxTaskDescription
            // 
            txbxTaskDescription.Location = new Point(12, 62);
            txbxTaskDescription.Multiline = true;
            txbxTaskDescription.Name = "txbxTaskDescription";
            txbxTaskDescription.Size = new Size(362, 119);
            txbxTaskDescription.TabIndex = 5;
            // 
            // cmbobxTaskPriority
            // 
            cmbobxTaskPriority.FormattingEnabled = true;
            cmbobxTaskPriority.Location = new Point(91, 201);
            cmbobxTaskPriority.Name = "cmbobxTaskPriority";
            cmbobxTaskPriority.Size = new Size(111, 23);
            cmbobxTaskPriority.TabIndex = 6;
            // 
            // cmbobxTaskType
            // 
            cmbobxTaskType.FormattingEnabled = true;
            cmbobxTaskType.Location = new Point(273, 202);
            cmbobxTaskType.Name = "cmbobxTaskType";
            cmbobxTaskType.Size = new Size(101, 23);
            cmbobxTaskType.TabIndex = 7;
            // 
            // chkbxTaskCompleted
            // 
            chkbxTaskCompleted.AutoSize = true;
            chkbxTaskCompleted.Location = new Point(24, 241);
            chkbxTaskCompleted.Name = "chkbxTaskCompleted";
            chkbxTaskCompleted.Size = new Size(110, 19);
            chkbxTaskCompleted.TabIndex = 8;
            chkbxTaskCompleted.Text = "Task Completed";
            chkbxTaskCompleted.UseVisualStyleBackColor = true;
            // 
            // btnSubmitTaskEdit
            // 
            btnSubmitTaskEdit.DialogResult = DialogResult.OK;
            btnSubmitTaskEdit.Location = new Point(299, 241);
            btnSubmitTaskEdit.Name = "btnSubmitTaskEdit";
            btnSubmitTaskEdit.Size = new Size(75, 23);
            btnSubmitTaskEdit.TabIndex = 9;
            btnSubmitTaskEdit.Text = "Accept";
            btnSubmitTaskEdit.UseVisualStyleBackColor = true;
            btnSubmitTaskEdit.Click += btnSubmitTaskEdit_clicked;
            // 
            // EditTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 281);
            Controls.Add(btnSubmitTaskEdit);
            Controls.Add(chkbxTaskCompleted);
            Controls.Add(cmbobxTaskType);
            Controls.Add(cmbobxTaskPriority);
            Controls.Add(txbxTaskDescription);
            Controls.Add(txbxTaskName);
            Controls.Add(lblTaskType);
            Controls.Add(lblTaskPriority);
            Controls.Add(lblTaskDescription);
            Controls.Add(lblTaskName);
            Name = "EditTaskForm";
            Text = "EditTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskName;
        private Label lblTaskDescription;
        private Label lblTaskPriority;
        private Label lblTaskType;
        private TextBox txbxTaskName;
        private TextBox txbxTaskDescription;
        private ComboBox cmbobxTaskPriority;
        private ComboBox cmbobxTaskType;
        private CheckBox chkbxTaskCompleted;
        private Button btnSubmitTaskEdit;
    }
}