using CompanionDomain.Enums;
using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using System.Diagnostics;

namespace CompanionFormApp.PrimaryForms
{
    public partial class JournalSystemForm : Form
    {
        private readonly Project? _currentProject;

        private readonly IProcessManager _processManager;

        private readonly GitWrapperForm _parentForm;

        private static readonly char[] _separator = ['\n', '\r'];

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

        #region GET PROJECT VALUES
        private int GetCommitValue()
        {
            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = "rev-list --count HEAD",
                WorkingDirectory = _currentProject?.Folder,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };

            _processManager.Run(startInfo);

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
            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = "ls-files \"*.cs\"",
                WorkingDirectory = _currentProject?.Folder,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };

            _processManager.Run(startInfo);

            if (_processManager.Error != string.Empty)
            {
                MessageBox.Show($"{_processManager.Error}");

                return -1;
            }
            else
            {
                string[] fileList = _processManager.Output.Split(_separator, StringSplitOptions.RemoveEmptyEntries);

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
                        if (readLine.Length > 2)
                        {
                            lineCount++;
                        }
                    }

                    readLine = reader.ReadLine()?.Trim();
                }
            }

            return lineCount;
        }
        #endregion

    }
}
