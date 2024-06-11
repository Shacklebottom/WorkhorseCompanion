using CompanionBusiness;
using CompanionDomain;
using System.Diagnostics;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.tsmiGit
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

            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = "add .",
                WorkingDirectory = _currentProject.Folder,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };

            _processManager.Run(startInfo);

            startInfo.Arguments = $"commit -m\"{commitMsg}\"";

            _processManager.Run(startInfo);

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
