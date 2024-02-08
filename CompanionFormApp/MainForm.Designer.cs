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
            lblCurrentProject = new Label();
            lstbxProjectTasks = new ListBox();
            btnNewTask = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiFile });
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
            tsmiAddProject.Size = new Size(145, 22);
            tsmiAddProject.Text = "Add Project";
            tsmiAddProject.Click += tsmiAddProject_clicked;
            // 
            // tsmiSelectProject
            // 
            tsmiSelectProject.Name = "tsmiSelectProject";
            tsmiSelectProject.Size = new Size(145, 22);
            tsmiSelectProject.Text = "Select Project";
            tsmiSelectProject.Click += tsmiSelectProject_clicked;
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
            // 
            // btnNewTask
            // 
            btnNewTask.Location = new Point(12, 135);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new Size(75, 23);
            btnNewTask.TabIndex = 3;
            btnNewTask.Text = "New Task";
            btnNewTask.UseVisualStyleBackColor = true;
            btnNewTask.Click += btnNewTask_clicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
