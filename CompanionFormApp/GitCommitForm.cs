using CompanionDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (ProjectFolder == null)
            {
                MessageBox.Show("No Project Folder set. Please cancel and try again.");

                Close();
            }
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
                Arguments = $"-c \"{bashAdd} && {bashCommit}\"{commitMsg}\"\"",
                WorkingDirectory = $"{ProjectFolder}"
            };
            
            Process.Start(processStartInfo);

            Close();
        }
    }
}
