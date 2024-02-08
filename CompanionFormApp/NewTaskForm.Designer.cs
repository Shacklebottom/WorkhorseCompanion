namespace CompanionFormApp
{
    partial class NewTaskForm
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
            txbxTaskName = new TextBox();
            lblTaskDescription = new Label();
            txbxTaskDescription = new TextBox();
            cmbbxTaskPriority = new ComboBox();
            lblTaskPriority = new Label();
            lblTaskType = new Label();
            cmbbxTaskType = new ComboBox();
            btnSubmitNewTask = new Button();
            SuspendLayout();
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(12, 9);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(39, 15);
            lblTaskName.TabIndex = 0;
            lblTaskName.Text = "Name";
            // 
            // txbxTaskName
            // 
            txbxTaskName.Location = new Point(57, 6);
            txbxTaskName.Name = "txbxTaskName";
            txbxTaskName.Size = new Size(170, 23);
            txbxTaskName.TabIndex = 1;
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.Location = new Point(12, 42);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(67, 15);
            lblTaskDescription.TabIndex = 2;
            lblTaskDescription.Text = "Description";
            // 
            // txbxTaskDescription
            // 
            txbxTaskDescription.Location = new Point(86, 39);
            txbxTaskDescription.Name = "txbxTaskDescription";
            txbxTaskDescription.Size = new Size(603, 23);
            txbxTaskDescription.TabIndex = 3;
            // 
            // cmbbxTaskPriority
            // 
            cmbbxTaskPriority.FormattingEnabled = true;
            cmbbxTaskPriority.Location = new Point(63, 72);
            cmbbxTaskPriority.Name = "cmbbxTaskPriority";
            cmbbxTaskPriority.Size = new Size(144, 23);
            cmbbxTaskPriority.TabIndex = 4;
            // 
            // lblTaskPriority
            // 
            lblTaskPriority.AutoSize = true;
            lblTaskPriority.Location = new Point(12, 75);
            lblTaskPriority.Name = "lblTaskPriority";
            lblTaskPriority.Size = new Size(45, 15);
            lblTaskPriority.TabIndex = 5;
            lblTaskPriority.Text = "Priority";
            // 
            // lblTaskType
            // 
            lblTaskType.AutoSize = true;
            lblTaskType.Location = new Point(12, 112);
            lblTaskType.Name = "lblTaskType";
            lblTaskType.Size = new Size(31, 15);
            lblTaskType.TabIndex = 6;
            lblTaskType.Text = "Type";
            // 
            // cmbbxTaskType
            // 
            cmbbxTaskType.FormattingEnabled = true;
            cmbbxTaskType.Location = new Point(49, 109);
            cmbbxTaskType.Name = "cmbbxTaskType";
            cmbbxTaskType.Size = new Size(142, 23);
            cmbbxTaskType.TabIndex = 7;
            // 
            // btnSubmitNewTask
            // 
            btnSubmitNewTask.Location = new Point(586, 132);
            btnSubmitNewTask.Name = "btnSubmitNewTask";
            btnSubmitNewTask.Size = new Size(103, 23);
            btnSubmitNewTask.TabIndex = 8;
            btnSubmitNewTask.Text = "Accept";
            btnSubmitNewTask.UseVisualStyleBackColor = true;
            // 
            // NewTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 167);
            Controls.Add(btnSubmitNewTask);
            Controls.Add(cmbbxTaskType);
            Controls.Add(lblTaskType);
            Controls.Add(lblTaskPriority);
            Controls.Add(cmbbxTaskPriority);
            Controls.Add(txbxTaskDescription);
            Controls.Add(lblTaskDescription);
            Controls.Add(txbxTaskName);
            Controls.Add(lblTaskName);
            Name = "NewTaskForm";
            Text = "NewTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskName;
        private TextBox txbxTaskName;
        private Label lblTaskDescription;
        private TextBox txbxTaskDescription;
        private ComboBox cmbbxTaskPriority;
        private Label lblTaskPriority;
        private Label lblTaskType;
        private ComboBox cmbbxTaskType;
        private Button btnSubmitNewTask;
    }
}