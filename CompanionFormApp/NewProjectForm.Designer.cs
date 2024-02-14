namespace CompanionFormApp
{
    partial class NewProjectForm
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
            txbxProjectName = new TextBox();
            lblProjectName = new Label();
            txbxSelectedFolder = new TextBox();
            btnBrowseFolders = new Button();
            btnAcceptNewProject = new Button();
            txbxSelectedSolution = new TextBox();
            btnSelectSolution = new Button();
            SuspendLayout();
            // 
            // txbxProjectName
            // 
            txbxProjectName.Location = new Point(97, 6);
            txbxProjectName.Name = "txbxProjectName";
            txbxProjectName.Size = new Size(226, 23);
            txbxProjectName.TabIndex = 0;
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Location = new Point(12, 9);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(79, 15);
            lblProjectName.TabIndex = 1;
            lblProjectName.Text = "Project Name";
            // 
            // txbxSelectedFolder
            // 
            txbxSelectedFolder.Location = new Point(12, 35);
            txbxSelectedFolder.Name = "txbxSelectedFolder";
            txbxSelectedFolder.Size = new Size(278, 23);
            txbxSelectedFolder.TabIndex = 2;
            // 
            // btnBrowseFolders
            // 
            btnBrowseFolders.Location = new Point(296, 35);
            btnBrowseFolders.Name = "btnBrowseFolders";
            btnBrowseFolders.Size = new Size(96, 23);
            btnBrowseFolders.TabIndex = 3;
            btnBrowseFolders.Text = "Browse Folders";
            btnBrowseFolders.UseVisualStyleBackColor = true;
            btnBrowseFolders.Click += btnBrowseFolders_clicked;
            // 
            // btnAcceptNewProject
            // 
            btnAcceptNewProject.Location = new Point(317, 165);
            btnAcceptNewProject.Name = "btnAcceptNewProject";
            btnAcceptNewProject.Size = new Size(75, 23);
            btnAcceptNewProject.TabIndex = 4;
            btnAcceptNewProject.Text = "Accept";
            btnAcceptNewProject.UseVisualStyleBackColor = true;
            btnAcceptNewProject.Click += btnAcceptNewProject_clicked;
            // 
            // txbxSelectedSolution
            // 
            txbxSelectedSolution.Location = new Point(12, 64);
            txbxSelectedSolution.Name = "txbxSelectedSolution";
            txbxSelectedSolution.Size = new Size(278, 23);
            txbxSelectedSolution.TabIndex = 5;
            // 
            // btnSelectSolution
            // 
            btnSelectSolution.Location = new Point(296, 64);
            btnSelectSolution.Name = "btnSelectSolution";
            btnSelectSolution.Size = new Size(96, 23);
            btnSelectSolution.TabIndex = 6;
            btnSelectSolution.Text = "Select Solution";
            btnSelectSolution.UseVisualStyleBackColor = true;
            btnSelectSolution.Click += btnSelectSolution_clicked;
            // 
            // NewProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 200);
            Controls.Add(btnSelectSolution);
            Controls.Add(txbxSelectedSolution);
            Controls.Add(btnAcceptNewProject);
            Controls.Add(btnBrowseFolders);
            Controls.Add(txbxSelectedFolder);
            Controls.Add(lblProjectName);
            Controls.Add(txbxProjectName);
            Name = "NewProjectForm";
            Text = "New Project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbxProjectName;
        private Label lblProjectName;
        private TextBox txbxSelectedFolder;
        private Button btnBrowseFolders;
        private Button btnAcceptNewProject;
        private TextBox txbxSelectedSolution;
        private Button btnSelectSolution;
    }
}