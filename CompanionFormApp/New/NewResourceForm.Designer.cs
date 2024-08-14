namespace CompanionFormApp.New
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
            lblResourceState = new Label();
            cmbbxResourceState = new ComboBox();
            txbxResourcePath = new TextBox();
            lblResourcePath = new Label();
            btnFindPath = new Button();
            lblNameResource = new Label();
            txbxNameResource = new TextBox();
            btnAcceptNewResource = new Button();
            lblFileExtension = new Label();
            txbxFileExtension = new TextBox();
            SuspendLayout();
            // 
            // lblResourceState
            // 
            lblResourceState.AutoSize = true;
            lblResourceState.Location = new Point(12, 12);
            lblResourceState.Name = "lblResourceState";
            lblResourceState.Size = new Size(119, 15);
            lblResourceState.TabIndex = 0;
            lblResourceState.Text = "Select Resource Type:";
            // 
            // cmbbxResourceState
            // 
            cmbbxResourceState.BackColor = Color.LemonChiffon;
            cmbbxResourceState.FormattingEnabled = true;
            cmbbxResourceState.Location = new Point(137, 9);
            cmbbxResourceState.Name = "cmbbxResourceState";
            cmbbxResourceState.Size = new Size(125, 23);
            cmbbxResourceState.TabIndex = 1;
            cmbbxResourceState.SelectedIndexChanged += cmbbxResourceState_SelectedIndexChanged;
            // 
            // txbxResourcePath
            // 
            txbxResourcePath.BackColor = Color.LemonChiffon;
            txbxResourcePath.Location = new Point(103, 38);
            txbxResourcePath.Name = "txbxResourcePath";
            txbxResourcePath.Size = new Size(389, 23);
            txbxResourcePath.TabIndex = 2;
            // 
            // lblResourcePath
            // 
            lblResourcePath.AutoSize = true;
            lblResourcePath.Location = new Point(12, 41);
            lblResourcePath.Name = "lblResourcePath";
            lblResourcePath.Size = new Size(85, 15);
            lblResourcePath.TabIndex = 3;
            lblResourcePath.Text = "Resource Path:";
            // 
            // btnFindPath
            // 
            btnFindPath.BackColor = Color.LemonChiffon;
            btnFindPath.Location = new Point(103, 67);
            btnFindPath.Name = "btnFindPath";
            btnFindPath.Size = new Size(75, 23);
            btnFindPath.TabIndex = 4;
            btnFindPath.Text = "Find Path";
            btnFindPath.UseVisualStyleBackColor = false;
            btnFindPath.Click += btnFindPath_Clicked;
            // 
            // lblNameResource
            // 
            lblNameResource.AutoSize = true;
            lblNameResource.Location = new Point(195, 71);
            lblNameResource.Name = "lblNameResource";
            lblNameResource.Size = new Size(93, 15);
            lblNameResource.TabIndex = 5;
            lblNameResource.Text = "Name Resource:";
            // 
            // txbxNameResource
            // 
            txbxNameResource.BackColor = Color.LemonChiffon;
            txbxNameResource.Location = new Point(294, 68);
            txbxNameResource.Name = "txbxNameResource";
            txbxNameResource.Size = new Size(113, 23);
            txbxNameResource.TabIndex = 6;
            // 
            // btnAcceptNewResource
            // 
            btnAcceptNewResource.BackColor = Color.LemonChiffon;
            btnAcceptNewResource.Location = new Point(432, 115);
            btnAcceptNewResource.Name = "btnAcceptNewResource";
            btnAcceptNewResource.Size = new Size(75, 23);
            btnAcceptNewResource.TabIndex = 9;
            btnAcceptNewResource.Text = "Accept";
            btnAcceptNewResource.UseVisualStyleBackColor = false;
            btnAcceptNewResource.Click += btnAccept_Clicked;
            // 
            // lblFileExtension
            // 
            lblFileExtension.AutoSize = true;
            lblFileExtension.Location = new Point(206, 106);
            lblFileExtension.Name = "lblFileExtension";
            lblFileExtension.Size = new Size(82, 15);
            lblFileExtension.TabIndex = 7;
            lblFileExtension.Text = "File Extension:";
            // 
            // txbxFileExtension
            // 
            txbxFileExtension.BackColor = Color.LemonChiffon;
            txbxFileExtension.Location = new Point(294, 103);
            txbxFileExtension.Name = "txbxFileExtension";
            txbxFileExtension.Size = new Size(51, 23);
            txbxFileExtension.TabIndex = 8;
            txbxFileExtension.Text = ".turtle";
            // 
            // NewResourceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(519, 151);
            Controls.Add(txbxFileExtension);
            Controls.Add(lblFileExtension);
            Controls.Add(btnAcceptNewResource);
            Controls.Add(txbxNameResource);
            Controls.Add(lblNameResource);
            Controls.Add(btnFindPath);
            Controls.Add(lblResourcePath);
            Controls.Add(txbxResourcePath);
            Controls.Add(cmbbxResourceState);
            Controls.Add(lblResourceState);
            Name = "NewResourceForm";
            ShowIcon = false;
            Text = "Add New Resource";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResourceState;
        private ComboBox cmbbxResourceState;
        private TextBox txbxResourcePath;
        private Label lblResourcePath;
        private Button btnFindPath;
        private Label lblNameResource;
        private TextBox txbxNameResource;
        private Button btnAcceptNewResource;
        private Label lblFileExtension;
        private TextBox txbxFileExtension;
    }
}