using CompanionBusiness;
using CompanionDomain;

namespace RefactoredFormApp
{
    public partial class GitCommitForm : Form
    {
        private readonly Project _currentProject;

        public string Output { get; private set; } = string.Empty;

        public string Error { get; private set; } = string.Empty;

        public GitCommitForm(Project project)
        {
            InitializeComponent();

            _currentProject = project;
        }

        private void btnGitCommit_Click(object sender, EventArgs e)
        {
            string commitMsg = txbxCommitMessage.Text;

            if (string.IsNullOrWhiteSpace(commitMsg)) return;

            ProcessManager manager = new GitProcessManager(_currentProject);

            string bashAdd = "add .";
            string bashCommit = $"commit -m\"{commitMsg}\"";

            manager.Run(bashAdd);

            manager.Run(bashCommit);

            Output = manager.Output;

            Error = manager.Error;

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
