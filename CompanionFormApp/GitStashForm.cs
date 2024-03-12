
using CompanionBusiness;
using CompanionDomain;

namespace CompanionFormApp
{
    public partial class GitStashForm : Form
    {
        private readonly Project _currentProject;

        public string ProcessOutput { get; private set; } = string.Empty;

        public string ProcessError { get; private set; } = string.Empty;

        public GitStashForm(Project currentProject)
        {
            InitializeComponent();

            _currentProject = currentProject;
        }

        private void btnGitStash_Click(object sender, EventArgs e)
        {
            string saveMsg = txbxStashMessage.Text;

            if (string.IsNullOrWhiteSpace(saveMsg)) return;

            ProcessManager manager = new GitProcessManager(_currentProject);

            string bashStash = $"git stash save \"{saveMsg}\"";

            manager.Run(bashStash, true);

            ProcessOutput = manager.Output;

            ProcessError = manager.Error;

            Close();
        }

        private void txbxStashMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                btnGitStash.PerformClick();
            }
        }
    }
}
