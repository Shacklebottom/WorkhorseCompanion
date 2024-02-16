namespace CompanionFormApp
{
    partial class NewResourceForm
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
            cmbbxResourceState = new ComboBox();
            btnLocalFile = new Button();
            txbxResourcePath = new TextBox();
            btnSubmitNewResource = new Button();
            lblResourceName = new Label();
            txbxResourceName = new TextBox();
            SuspendLayout();
            // 
            // cmbbxResourceState
            // 
            cmbbxResourceState.FormattingEnabled = true;
            cmbbxResourceState.Location = new Point(12, 41);
            cmbbxResourceState.Name = "cmbbxResourceState";
            cmbbxResourceState.Size = new Size(121, 23);
            cmbbxResourceState.TabIndex = 0;
            // 
            // btnLocalFile
            // 
            btnLocalFile.Location = new Point(139, 41);
            btnLocalFile.Name = "btnLocalFile";
            btnLocalFile.Size = new Size(75, 23);
            btnLocalFile.TabIndex = 1;
            btnLocalFile.Text = "Local File";
            btnLocalFile.UseVisualStyleBackColor = true;
            btnLocalFile.Click += btnLocalFile_clicked;
            // 
            // txbxResourcePath
            // 
            txbxResourcePath.Location = new Point(12, 12);
            txbxResourcePath.Name = "txbxResourcePath";
            txbxResourcePath.PlaceholderText = "any url can be placed here and the app will do the work :)";
            txbxResourcePath.Size = new Size(416, 23);
            txbxResourcePath.TabIndex = 2;
            // 
            // btnSubmitNewResource
            // 
            btnSubmitNewResource.DialogResult = DialogResult.OK;
            btnSubmitNewResource.Location = new Point(353, 67);
            btnSubmitNewResource.Name = "btnSubmitNewResource";
            btnSubmitNewResource.Size = new Size(75, 23);
            btnSubmitNewResource.TabIndex = 3;
            btnSubmitNewResource.Text = "Accept";
            btnSubmitNewResource.UseVisualStyleBackColor = true;
            btnSubmitNewResource.Click += btnSubmitNewResource_clicked;
            // 
            // lblResourceName
            // 
            lblResourceName.AutoSize = true;
            lblResourceName.Location = new Point(12, 70);
            lblResourceName.Name = "lblResourceName";
            lblResourceName.Size = new Size(93, 15);
            lblResourceName.TabIndex = 4;
            lblResourceName.Text = "Resource Name:";
            // 
            // txbxResourceName
            // 
            txbxResourceName.Location = new Point(111, 67);
            txbxResourceName.Name = "txbxResourceName";
            txbxResourceName.Size = new Size(149, 23);
            txbxResourceName.TabIndex = 5;
            // 
            // NewResourceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 94);
            Controls.Add(txbxResourceName);
            Controls.Add(lblResourceName);
            Controls.Add(btnSubmitNewResource);
            Controls.Add(txbxResourcePath);
            Controls.Add(btnLocalFile);
            Controls.Add(cmbbxResourceState);
            Name = "NewResourceForm";
            Text = "NewResourceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbbxResourceState;
        private Button btnLocalFile;
        private TextBox txbxResourcePath;
        private Button btnSubmitNewResource;
        private Label lblResourceName;
        private TextBox txbxResourceName;
    }
}