using CompanionDomain.Enums;
using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using System.Diagnostics;

namespace CompanionFormApp.PrimaryForms
{
    public partial class JournalSystemForm : Form
    {
        private Project? _currentProject;

        private IProcessManager _processManager;

        private GitWrapperForm _parentForm;

        public JournalSystemForm(GitWrapperForm parentForm, IProcessManager manager, Project? project)
        {
            InitializeComponent();

            _parentForm = parentForm;

            _processManager = manager;

            _currentProject = project;

            txbxCurrentProject.Text = _currentProject?.Name;

            txbxCommitsToDate.Text = $"Commits To Date: {GetCommitValue()}";

            txbxLinesToDate.Text = $"Lines To Date: {GetSolutionLines()}";
        }

        #region JOURNAL FORM CLOSING
        private void JournalSystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            Hide();

            _parentForm.Show();
        }
        #endregion


        private int GetCommitValue()
        {
            ProcessStartInfo processStartInfo = new()
            {
                FileName = "git",
                Arguments = "rev-list --count HEAD",
                WorkingDirectory = _currentProject?.Folder,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };

            _processManager.Run(processStartInfo);

            if (_processManager.Error != string.Empty)
            {
                MessageBox.Show($"{_processManager.Error}");

                return -1;
            }
            else
            {
                return int.Parse(_processManager.Output.Trim());
            }
        }

        private int GetSolutionLines()
        {
            ProcessStartInfo processStartInfo = new()
            {
                FileName = "git",
                Arguments = "ls-files \"*.cs\"",
                WorkingDirectory = _currentProject?.Folder,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };

            _processManager.Run(processStartInfo);

            if (_processManager.Error != string.Empty)
            {
                MessageBox.Show($"{_processManager.Error}");

                return -1;
            }
            else
            {
                string[] fileList = _processManager.Output.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                int totalLines = 0;

                foreach (var file in fileList)
                {
                    int lineCount = CountLinesInFile($"{_currentProject?.Folder}\\{file}");

                    totalLines += lineCount;
                }

                return totalLines;
            }
        }

        private static int CountLinesInFile(string filePath)
        {
            int lineCount = 0;

            var readLine = "";

            using (var reader = new StreamReader(filePath))
            {
                while (readLine != null)
                {
                    if (!string.IsNullOrEmpty(readLine) || !string.IsNullOrWhiteSpace(readLine))
                    {
                        if (readLine.Length != 1)
                        {
                            lineCount++;
                        }
                    }

                    readLine = reader.ReadLine()?.Trim();
                }
            }

            return lineCount;
        }
    }
}
