namespace CompanionFormApp.primaryForms
{
    partial class JournalSystemForm
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
            txbxCurrentProject = new TextBox();
            SuspendLayout();
            // 
            // txbxCurrentProject
            // 
            txbxCurrentProject.BackColor = Color.LemonChiffon;
            txbxCurrentProject.Location = new Point(12, 12);
            txbxCurrentProject.Name = "txbxCurrentProject";
            txbxCurrentProject.ReadOnly = true;
            txbxCurrentProject.Size = new Size(183, 23);
            txbxCurrentProject.TabIndex = 0;
            // 
            // JournalSystemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(582, 492);
            Controls.Add(txbxCurrentProject);
            Name = "JournalSystemForm";
            Text = "ViewJournalForm";
            FormClosing += JournalSystemForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbxCurrentProject;
    }
}