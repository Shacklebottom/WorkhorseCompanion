﻿using CompanionBusiness;
using CompanionDomain;

namespace CompanionFormApp
{
    public partial class GitCommitForm : Form
    {
        private readonly Project _currentProject;

        public string ProcessOutput { get; private set; } = string.Empty;

        public string ProcessError { get; private set; } = string.Empty;

        public GitCommitForm(Project project)
        {
            InitializeComponent();

            _currentProject = project;
        }

        private void btnGitCommit_clicked(object sender, EventArgs e)
        {
            string commitMsg = txbxCommitMessage.Text;

            if (string.IsNullOrWhiteSpace(commitMsg)) return;

            ProcessManager manager = new GitProcessManager(_currentProject);

            string bashAdd = "add .";
            string bashCommit = $"commit -m\"{commitMsg}\"";

            manager.Run(bashAdd, true);

            manager.Run(bashCommit, true);

            ProcessOutput = manager.Output;

            ProcessError = manager.Error;

            Close();
        }

        private void txbxCommitMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                btnGitCommit.PerformClick();
            }
        }
    }
}
