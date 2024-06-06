using CompanionBusiness;
using CompanionDomain;
using System.Diagnostics;

namespace RefactoredFormApp
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

        private void btnGitCommit_Click(object sender, EventArgs e)
        {
            string commitMsg = txbxCommitMessage.Text;

            if (string.IsNullOrWhiteSpace(commitMsg)) return;

            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = "add .",
                WorkingDirectory = _currentProject.Folder,
            };

            _processManager.Run(startInfo, false);

            startInfo.Arguments = $"commit -m\"{commitMsg}\"";

            _processManager.Run(startInfo, false);

            Output = _processManager.Output;

            Error = _processManager.Error;

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
