using CompanionBusiness;
using CompanionDomain;
using System.Diagnostics;

namespace CompanionFormApp
{
    public partial class GitCommitForm : Form
    {
        private Project _currentProject;

        public string ProcessOutput { get; set; }

        public string ProcessError { get; set; }

        public GitCommitForm(Project project)
        {
            InitializeComponent();

            _currentProject = project;
        }

        private void btnGitCommit_clicked(object sender, EventArgs e)
        {
            string commitMsg = txbxCommitMessage.Text;

            if (string.IsNullOrWhiteSpace(commitMsg)) return;

            ProcessManager manager = new ProcessManager(_currentProject);

            string bashAdd = "add .";
            string bashCommit = $"commit -m\"{commitMsg}\"";

            manager.Run(bashAdd);

            manager.Run(bashCommit);

            ProcessOutput = manager.Output;

            ProcessError = manager.Error;

            Close();
        }

        //private void RunCommandProcess(string args)
        //{
        //    ProcessStartInfo processStartInfo = new ProcessStartInfo()
        //    {
        //        FileName = "git",
        //        Arguments = $"{args}",
        //        WorkingDirectory = $"{ProjectFolder}",
        //        RedirectStandardOutput = true,
        //        RedirectStandardError = true,
        //        CreateNoWindow = true,
        //    };

        //    var error = string.Empty;
        //    var output = string.Empty;

        //    using (Process process = new())
        //    {
        //        process.StartInfo = processStartInfo;

        //        process.Start();
        //        process.WaitForExit();

        //        error = process.StandardError.ReadToEnd();
        //        output = process.StandardOutput.ReadToEnd();
        //    }

        //    if (error != string.Empty)
        //    {
        //        MessageBox.Show($"{error}");
        //    }

        //    if (output != string.Empty)
        //    {
        //        MessageBox.Show($"{output}");
        //    }
        //}

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
