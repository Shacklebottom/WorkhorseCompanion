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
            tsmiAddProject = new ToolStripMenuItem();
            tsmiSelectProject = new ToolStripMenuItem();
            tsmiEdit = new ToolStripMenuItem();
            editProjectToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            solutionToolStripMenuItem = new ToolStripMenuItem();
            lblCurrentProject = new Label();
            lstbxProjectTasks = new ListBox();
            btnNewTask = new Button();
            txbxTaskDescription_display = new TextBox();
            lblCurrentTask = new Label();
            lblTaskPriorty = new Label();
            lblTaskType = new Label();
            lblDateStart = new Label();
            lblDateEnd = new Label();
            btnEditTask = new Button();
            btnActiveTasks = new Button();
            btnCompletedTasks = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFile, tsmiEdit, openToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            tsmiFile.DropDownItems.AddRange(new ToolStripItem[] { tsmiAddProject, tsmiSelectProject });
            tsmiFile.Name = "tsmiFile";
            tsmiFile.Size = new Size(37, 20);
            tsmiFile.Text = "File";
            // 
            // tsmiAddProject
            // 
            tsmiAddProject.Name = "tsmiAddProject";
            tsmiAddProject.Size = new Size(180, 22);
            tsmiAddProject.Text = "Add Project";
            tsmiAddProject.Click += tsmiAddProject_clicked;
            // 
            // tsmiSelectProject
            // 
            tsmiSelectProject.Name = "tsmiSelectProject";
            tsmiSelectProject.Size = new Size(180, 22);
            tsmiSelectProject.Text = "Select Project";
            tsmiSelectProject.Click += tsmiSelectProject_clicked;
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
            editProjectToolStripMenuItem.Size = new Size(180, 22);
            editProjectToolStripMenuItem.Text = "Edit Project";
            editProjectToolStripMenuItem.Click += tsmiEditProject_clicked;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { solutionToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(48, 20);
            openToolStripMenuItem.Text = "Open";
            // 
            // solutionToolStripMenuItem
            // 
            solutionToolStripMenuItem.Name = "solutionToolStripMenuItem";
            solutionToolStripMenuItem.Size = new Size(180, 22);
            solutionToolStripMenuItem.Text = "Solution";
            solutionToolStripMenuItem.Click += tsmiOpenSolution_clicked;
            // 
            // lblCurrentProject
            // 
            lblCurrentProject.AutoSize = true;
            lblCurrentProject.Location = new Point(563, 37);
            lblCurrentProject.Name = "lblCurrentProject";
            lblCurrentProject.Size = new Size(47, 15);
            lblCurrentProject.TabIndex = 1;
            lblCurrentProject.Text = "Project:";
            // 
            // lstbxProjectTasks
            // 
            lstbxProjectTasks.FormattingEnabled = true;
            lstbxProjectTasks.ItemHeight = 15;
            lstbxProjectTasks.Location = new Point(12, 164);
            lstbxProjectTasks.Name = "lstbxProjectTasks";
            lstbxProjectTasks.Size = new Size(201, 274);
            lstbxProjectTasks.TabIndex = 2;
            lstbxProjectTasks.SelectedIndexChanged += lstbxProjectTasks_SelectedIndexChanged;
            // 
            // btnNewTask
            // 
            btnNewTask.Location = new Point(12, 135);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new Size(64, 23);
            btnNewTask.TabIndex = 3;
            btnNewTask.Text = "New Task";
            btnNewTask.UseVisualStyleBackColor = true;
            btnNewTask.Click += btnNewTask_clicked;
            // 
            // txbxTaskDescription_display
            // 
            txbxTaskDescription_display.Location = new Point(233, 186);
            txbxTaskDescription_display.Multiline = true;
            txbxTaskDescription_display.Name = "txbxTaskDescription_display";
            txbxTaskDescription_display.ReadOnly = true;
            txbxTaskDescription_display.Size = new Size(555, 156);
            txbxTaskDescription_display.TabIndex = 4;
            // 
            // lblCurrentTask
            // 
            lblCurrentTask.AutoSize = true;
            lblCurrentTask.Location = new Point(238, 165);
            lblCurrentTask.Name = "lblCurrentTask";
            lblCurrentTask.Size = new Size(32, 15);
            lblCurrentTask.TabIndex = 5;
            lblCurrentTask.Text = "Task:";
            // 
            // lblTaskPriorty
            // 
            lblTaskPriorty.AutoSize = true;
            lblTaskPriorty.Location = new Point(438, 165);
            lblTaskPriorty.Name = "lblTaskPriorty";
            lblTaskPriorty.Size = new Size(48, 15);
            lblTaskPriorty.TabIndex = 6;
            lblTaskPriorty.Text = "Priority:";
            // 
            // lblTaskType
            // 
            lblTaskType.AutoSize = true;
            lblTaskType.Location = new Point(625, 164);
            lblTaskType.Name = "lblTaskType";
            lblTaskType.Size = new Size(34, 15);
            lblTaskType.TabIndex = 7;
            lblTaskType.Text = "Type:";
            // 
            // lblDateStart
            // 
            lblDateStart.AutoSize = true;
            lblDateStart.Location = new Point(306, 353);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(98, 15);
            lblDateStart.TabIndex = 9;
            lblDateStart.Text = "Submission Date:";
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
            lblDateEnd.Location = new Point(479, 353);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(100, 15);
            lblDateEnd.TabIndex = 10;
            lblDateEnd.Text = "Completion Date:";
            // 
            // btnEditTask
            // 
            btnEditTask.Enabled = false;
            btnEditTask.Location = new Point(233, 349);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(53, 23);
            btnEditTask.TabIndex = 11;
            btnEditTask.Text = "Edit";
            btnEditTask.UseVisualStyleBackColor = true;
            btnEditTask.Click += btnEditTask_clicked;
            // 
            // btnActiveTasks
            // 
            btnActiveTasks.Location = new Point(82, 135);
            btnActiveTasks.Name = "btnActiveTasks";
            btnActiveTasks.Size = new Size(49, 23);
            btnActiveTasks.TabIndex = 12;
            btnActiveTasks.Text = "Active";
            btnActiveTasks.UseVisualStyleBackColor = true;
            btnActiveTasks.Click += btnActiveTasks_clicked;
            // 
            // btnCompletedTasks
            // 
            btnCompletedTasks.Location = new Point(137, 135);
            btnCompletedTasks.Name = "btnCompletedTasks";
            btnCompletedTasks.Size = new Size(75, 23);
            btnCompletedTasks.TabIndex = 13;
            btnCompletedTasks.Text = "Completed";
            btnCompletedTasks.UseVisualStyleBackColor = true;
            btnCompletedTasks.Click += btnCompletedTasks_clicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCompletedTasks);
            Controls.Add(btnActiveTasks);
            Controls.Add(btnEditTask);
            Controls.Add(lblDateEnd);
            Controls.Add(lblDateStart);
            Controls.Add(lblTaskType);
            Controls.Add(lblTaskPriorty);
            Controls.Add(lblCurrentTask);
            Controls.Add(txbxTaskDescription_display);
            Controls.Add(btnNewTask);
            Controls.Add(lstbxProjectTasks);
            Controls.Add(lblCurrentProject);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiFile;
        private ToolStripMenuItem tsmiAddProject;
        private ToolStripMenuItem tsmiSelectProject;
        private Label lblCurrentProject;
        private ListBox lstbxProjectTasks;
        private Button btnNewTask;
        private TextBox txbxTaskDescription_display;
        private Label lblCurrentTask;
        private Label lblTaskPriorty;
        private Label lblTaskType;
        private Label lblDateStart;
        private Label lblDateEnd;
        private Button btnEditTask;
        private ToolStripMenuItem tsmiEdit;
        private ToolStripMenuItem editProjectToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem solutionToolStripMenuItem;
        private Button btnActiveTasks;
        private Button btnCompletedTasks;
    }
}
