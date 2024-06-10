namespace CompanionFormApp.tsmiNew
{
    partial class NewDocumentationForm
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
            btnAccept = new Button();
            cmbbxDocumentationSource = new ComboBox();
            txbxExternalSource = new TextBox();
            lblSourceType = new Label();
            txbxInternalSource = new TextBox();
            lblExternalSource = new Label();
            lblInternalSource = new Label();
            btnFindInternalPath = new Button();
            lblRenameInternalDocumentation = new Label();
            txbxRenameInternalDocumentation = new TextBox();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.LemonChiffon;
            btnAccept.Location = new Point(408, 80);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Clicked;
            // 
            // cmbbxDocumentationSource
            // 
            cmbbxDocumentationSource.BackColor = Color.LemonChiffon;
            cmbbxDocumentationSource.FormattingEnabled = true;
            cmbbxDocumentationSource.Location = new Point(181, 12);
            cmbbxDocumentationSource.Name = "cmbbxDocumentationSource";
            cmbbxDocumentationSource.Size = new Size(137, 23);
            cmbbxDocumentationSource.TabIndex = 1;
            cmbbxDocumentationSource.SelectedIndexChanged += cmbbxDocumentationSource_SelectedIndexChanged;
            // 
            // txbxExternalSource
            // 
            txbxExternalSource.BackColor = Color.LemonChiffon;
            txbxExternalSource.Location = new Point(92, 41);
            txbxExternalSource.Name = "txbxExternalSource";
            txbxExternalSource.Size = new Size(391, 23);
            txbxExternalSource.TabIndex = 2;
            txbxExternalSource.Visible = false;
            // 
            // lblSourceType
            // 
            lblSourceType.AutoSize = true;
            lblSourceType.Location = new Point(7, 15);
            lblSourceType.Name = "lblSourceType";
            lblSourceType.Size = new Size(166, 15);
            lblSourceType.TabIndex = 3;
            lblSourceType.Text = "Select Documentation Source:";
            // 
            // txbxInternalSource
            // 
            txbxInternalSource.BackColor = Color.LemonChiffon;
            txbxInternalSource.Location = new Point(92, 41);
            txbxInternalSource.Name = "txbxInternalSource";
            txbxInternalSource.Size = new Size(391, 23);
            txbxInternalSource.TabIndex = 4;
            txbxInternalSource.Visible = false;
            // 
            // lblExternalSource
            // 
            lblExternalSource.AutoSize = true;
            lblExternalSource.Location = new Point(7, 44);
            lblExternalSource.Name = "lblExternalSource";
            lblExternalSource.Size = new Size(79, 15);
            lblExternalSource.TabIndex = 5;
            lblExternalSource.Text = "External Path:";
            lblExternalSource.Visible = false;
            // 
            // lblInternalSource
            // 
            lblInternalSource.AutoSize = true;
            lblInternalSource.Location = new Point(7, 44);
            lblInternalSource.Name = "lblInternalSource";
            lblInternalSource.Size = new Size(77, 15);
            lblInternalSource.TabIndex = 6;
            lblInternalSource.Text = "Internal Path:";
            lblInternalSource.Visible = false;
            // 
            // btnFindInternalPath
            // 
            btnFindInternalPath.BackColor = Color.LemonChiffon;
            btnFindInternalPath.Location = new Point(92, 70);
            btnFindInternalPath.Name = "btnFindInternalPath";
            btnFindInternalPath.Size = new Size(75, 23);
            btnFindInternalPath.TabIndex = 7;
            btnFindInternalPath.Text = "Find Path";
            btnFindInternalPath.UseVisualStyleBackColor = false;
            btnFindInternalPath.Visible = false;
            btnFindInternalPath.Click += btnFindInternalPath_Clicked;
            // 
            // lblRenameInternalDocumentation
            // 
            lblRenameInternalDocumentation.AutoSize = true;
            lblRenameInternalDocumentation.Location = new Point(181, 74);
            lblRenameInternalDocumentation.Name = "lblRenameInternalDocumentation";
            lblRenameInternalDocumentation.Size = new Size(58, 15);
            lblRenameInternalDocumentation.TabIndex = 8;
            lblRenameInternalDocumentation.Text = "Rename?:";
            lblRenameInternalDocumentation.Visible = false;
            // 
            // txbxRenameInternalDocumentation
            // 
            txbxRenameInternalDocumentation.BackColor = Color.LemonChiffon;
            txbxRenameInternalDocumentation.Location = new Point(245, 70);
            txbxRenameInternalDocumentation.Name = "txbxRenameInternalDocumentation";
            txbxRenameInternalDocumentation.Size = new Size(144, 23);
            txbxRenameInternalDocumentation.TabIndex = 9;
            txbxRenameInternalDocumentation.Visible = false;
            // 
            // NewDocumentationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(495, 114);
            Controls.Add(txbxRenameInternalDocumentation);
            Controls.Add(lblRenameInternalDocumentation);
            Controls.Add(btnFindInternalPath);
            Controls.Add(lblInternalSource);
            Controls.Add(lblExternalSource);
            Controls.Add(txbxInternalSource);
            Controls.Add(lblSourceType);
            Controls.Add(txbxExternalSource);
            Controls.Add(cmbbxDocumentationSource);
            Controls.Add(btnAccept);
            Name = "NewDocumentationForm";
            Text = "Add New Documentation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccept;
        private ComboBox cmbbxDocumentationSource;
        private TextBox txbxExternalSource;
        private Label lblSourceType;
        private TextBox txbxInternalSource;
        private Label lblExternalSource;
        private Label lblInternalSource;
        private Button btnFindInternalPath;
        private Label lblRenameInternalDocumentation;
        private TextBox txbxRenameInternalDocumentation;
    }
}