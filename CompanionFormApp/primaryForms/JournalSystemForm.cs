using CompanionDomain.Enums;
using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using CompanionFormApp.New;

#pragma warning disable IDE1006

namespace CompanionFormApp.PrimaryForms
{
    public partial class JournalSystemForm : Form
    {
        private readonly GitWrapperForm _parentForm;
        private readonly Project? _currentProject;
        private readonly IProcessManager _processManager;
        private static readonly char[] _separator = ['\n', '\r'];
        private Dictionary<string, int> _projectStats = [];

        public JournalSystemForm(GitWrapperForm parentForm, IProcessManager manager, Project? project)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _processManager = manager;
            _currentProject = project;

            txbxCurrentProject.Text = _currentProject?.Name;

            PopulateJournalEntryComboBox();
        }

        #region JOURNAL FORM CLOSING
        private void JournalSystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            Hide();

            _parentForm.Show();
        }
        #endregion

        #region POPULATE UI ELEMENTS
        private void PopulateToDateInformationWhen_JournalSystemForm_Activated(object sender, EventArgs e)
        {
            _projectStats = [];

            var commits = GetCommitValue();
            txbxCommitsToDate.Text = $"Commits To Date: {commits}";
            _projectStats.Add("Commits", commits);

            var lines = GetSolutionLines();
            txbxLinesToDate.Text = $"Lines To Date: {lines}";
            _projectStats.Add("Lines", lines);
        }

        private void PopulateJournalEntryComboBox()
        {
            cmbbxJournalEntries.SelectedIndexChanged -= cmbbxJournalEntries_SelectedIndexChanged;

            cmbbxJournalEntries.DataSource = _currentProject?.Journal.Select(p => $"Entry: {p.Id}").ToList();

            cmbbxJournalEntries.SelectedIndexChanged += cmbbxJournalEntries_SelectedIndexChanged;
        }

        private void PopulateEntryDetails(Journal? entry)
        {
            txbxCommitsAtEntry.Text = $"Commits At Entry: {entry?.Commits}";
            txbxLinesAtEntry.Text = $"Lines At Entry: {entry?.Lines}";
            txbxJournalEntry_display.Text = entry?.Page;
        }

        #endregion

        #region GET PROJECT VALUES
        private int GetCommitValue()
        {
            StartInfo start = new("git", "rev-list --count HEAD", _currentProject?.Folder);
            _processManager.Run(start.Info);

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
            StartInfo start = new("git", "ls-files \"*.cs\"", _currentProject?.Folder);
            _processManager.Run(start.Info);

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
                        if (readLine.Length > 3)
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

        private void btnNewEntry_Clicked(object sender, EventArgs e)
        {
            NewJournalEntryForm newJournalEntryForm = new(_currentProject, _projectStats);
            newJournalEntryForm.ShowDialog();

            PopulateJournalEntryComboBox();
        }

        private void cmbbxJournalEntries_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var entry = _currentProject?.Journal[cmbbxJournalEntries.SelectedIndex];

            PopulateEntryDetails(entry);
        }
    }
}
