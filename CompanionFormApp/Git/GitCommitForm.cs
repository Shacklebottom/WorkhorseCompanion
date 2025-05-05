using CompanionDomain.Objects;
using CompanionDomain.Interfaces;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.Git
{
    public partial class GitCommitForm : Form
    {
        public string CapturedInput = "";

        public GitCommitForm()
        {
            InitializeComponent();
        }

        private void btnGitCommit_Clicked(object sender, EventArgs e)
        {
            CapturedInput = txbxCommitMessage.Text;

            if (string.IsNullOrWhiteSpace(CapturedInput)) return;

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
