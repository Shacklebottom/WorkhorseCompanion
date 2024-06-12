namespace CompanionFormApp.tsmiEdit
{
    partial class EditProjectForm
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
            lblProjectEditName = new Label();
            txbxProjectName = new TextBox();
            txbxBrowseFolders = new TextBox();
            txbxSelectSolution = new TextBox();
            btnBrowseFolders = new Button();
            btnSelectSolution = new Button();
            btnSubmitEdit = new Button();
            SuspendLayout();
            // 
            // lblProjectEditName
            // 
            lblProjectEditName.AutoSize = true;
            lblProjectEditName.Location = new Point(12, 9);
            lblProjectEditName.Name = "lblProjectEditName";
            lblProjectEditName.Size = new Size(82, 15);
            lblProjectEditName.TabIndex = 0;
            lblProjectEditName.Text = "Project Name:";
            // 
            // txbxProjectName
            // 
            txbxProjectName.BackColor = Color.LemonChiffon;
            txbxProjectName.Location = new Point(100, 6);
            txbxProjectName.Name = "txbxProjectName";
            txbxProjectName.Size = new Size(242, 23);
            txbxProjectName.TabIndex = 1;
            // 
            // txbxBrowseFolders
            // 
            txbxBrowseFolders.BackColor = Color.LemonChiffon;
            txbxBrowseFolders.Location = new Point(12, 35);
            txbxBrowseFolders.Name = "txbxBrowseFolders";
            txbxBrowseFolders.Size = new Size(292, 23);
            txbxBrowseFolders.TabIndex = 2;
            // 
            // txbxSelectSolution
            // 
            txbxSelectSolution.BackColor = Color.LemonChiffon;
            txbxSelectSolution.Location = new Point(12, 64);
            txbxSelectSolution.Name = "txbxSelectSolution";
            txbxSelectSolution.Size = new Size(292, 23);
            txbxSelectSolution.TabIndex = 3;
            // 
            // btnBrowseFolders
            // 
            btnBrowseFolders.BackColor = Color.LemonChiffon;
            btnBrowseFolders.Location = new Point(310, 35);
            btnBrowseFolders.Name = "btnBrowseFolders";
            btnBrowseFolders.Size = new Size(95, 23);
            btnBrowseFolders.TabIndex = 4;
            btnBrowseFolders.Text = "Browse Folders";
            btnBrowseFolders.UseVisualStyleBackColor = false;
            btnBrowseFolders.Click += btnBrowseFolders_clicked;
            // 
            // btnSelectSolution
            // 
            btnSelectSolution.BackColor = Color.LemonChiffon;
            btnSelectSolution.Location = new Point(310, 64);
            btnSelectSolution.Name = "btnSelectSolution";
            btnSelectSolution.Size = new Size(95, 23);
            btnSelectSolution.TabIndex = 5;
            btnSelectSolution.Text = "Select Solution";
            btnSelectSolution.UseVisualStyleBackColor = false;
            btnSelectSolution.Click += btnSelectSolution_clicked;
            // 
            // btnSubmitEdit
            // 
            btnSubmitEdit.BackColor = Color.LemonChiffon;
            btnSubmitEdit.Location = new Point(330, 102);
            btnSubmitEdit.Name = "btnSubmitEdit";
            btnSubmitEdit.Size = new Size(75, 23);
            btnSubmitEdit.TabIndex = 6;
            btnSubmitEdit.Text = "Accept";
            btnSubmitEdit.UseVisualStyleBackColor = false;
            btnSubmitEdit.Click += btnSubmitEdit_clicked;
            // 
            // EditProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(412, 141);
            Controls.Add(btnSubmitEdit);
            Controls.Add(btnSelectSolution);
            Controls.Add(btnBrowseFolders);
            Controls.Add(txbxSelectSolution);
            Controls.Add(txbxBrowseFolders);
            Controls.Add(txbxProjectName);
            Controls.Add(lblProjectEditName);
            Name = "EditProjectForm";
            ShowIcon = false;
            Text = "Edit Current Project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProjectEditName;
        private TextBox txbxProjectName;
        private TextBox txbxBrowseFolders;
        private TextBox txbxSelectSolution;
        private Button btnBrowseFolders;
        private Button btnSelectSolution;
        private Button btnSubmitEdit;
    }
}