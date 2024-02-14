using CompanionDomain;
using System.Diagnostics;

namespace CompanionFormApp
{
    public partial class GitCommitForm : Form
    {
        public Project CurrentProject;

        public string? ProjectFolder;

        public GitCommitForm(Project project)
        {
            InitializeComponent();

            CurrentProject = project;

            ProjectFolder = CurrentProject.Folder;

        }

        private void btnGitCommit_clicked(object sender, EventArgs e)
        {
            string bashPath = "C:\\Program Files\\Git\\git-bash.exe";
            string bashAdd = "git add .";
            string bashCommit = "git commit -m";

            string commitMsg = txbxCommitMessage.Text;

            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = $"{bashPath}",
                Arguments = $"-c \"{bashAdd} && {bashCommit}'{commitMsg}'\"",
                WorkingDirectory = $"{ProjectFolder}",
                CreateNoWindow = true,
                UseShellExecute = false,
                //Hmm, research suggests that Git Bash may have internal settings that force it to open an instance of itself when running commands
                // to it. Perhaps I could run these commands through the normal command prompt since git is a command line tool and integrated as such.
            };

            Process.Start(processStartInfo);

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
