namespace CompanionFormApp.New
{
    partial class NewSolutionForm
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
            txbxSolutionName = new TextBox();
            lblSolutionName = new Label();
            btnAccept = new Button();
            SuspendLayout();
            // 
            // txbxSolutionName
            // 
            txbxSolutionName.BackColor = Color.LemonChiffon;
            txbxSolutionName.Location = new Point(107, 6);
            txbxSolutionName.Name = "txbxSolutionName";
            txbxSolutionName.Size = new Size(200, 23);
            txbxSolutionName.TabIndex = 0;
            txbxSolutionName.KeyPress += txbxSolutionName_KeyPress;
            // 
            // lblSolutionName
            // 
            lblSolutionName.AutoSize = true;
            lblSolutionName.Location = new Point(12, 9);
            lblSolutionName.Name = "lblSolutionName";
            lblSolutionName.Size = new Size(89, 15);
            lblSolutionName.TabIndex = 1;
            lblSolutionName.Text = "Name Solution:";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.LemonChiffon;
            btnAccept.Location = new Point(365, 30);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Clicked;
            // 
            // NewSolutionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(452, 63);
            Controls.Add(btnAccept);
            Controls.Add(lblSolutionName);
            Controls.Add(txbxSolutionName);
            Name = "NewSolutionForm";
            ShowIcon = false;
            Text = "Create New Solution";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbxSolutionName;
        private Label lblSolutionName;
        private Button btnAccept;
    }
}