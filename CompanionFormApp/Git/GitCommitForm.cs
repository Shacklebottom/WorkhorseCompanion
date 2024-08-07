﻿using CompanionDomain.Objects;
using CompanionDomain.Interfaces;
using System.Diagnostics;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.Git
{
    public partial class GitCommitForm : Form
    {
        private readonly Project _currentProject;

        private readonly IProcessManager _processManager;

        public string Output { get; private set; } = string.Empty;

        public string Error { get; private set; } = string.Empty;

        public GitCommitForm(Project project, IProcessManager manager)
        {
            InitializeComponent();

            _currentProject = project;

            _processManager = manager;
        }

        private void btnGitCommit_Clicked(object sender, EventArgs e)
        {
            string commitMsg = txbxCommitMessage.Text;

            if (string.IsNullOrWhiteSpace(commitMsg)) return;

            StartInfo start = new("git", "add .", _currentProject.Folder);

            _processManager.Run(start.Info);

            start.Info.Arguments = $"commit -m\"{commitMsg}\"";

            _processManager.Run(start.Info);

            Output = _processManager.Output;

            Error = _processManager.Error;

            Close();

            Dispose();
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
