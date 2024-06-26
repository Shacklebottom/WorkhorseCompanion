using CompanionDomain.Objects;

#pragma warning disable IDE1006

namespace CompanionFormApp.New
{
    public partial class NewJournalEntryForm : Form
    {
        private readonly Project? _currentProject;

        private readonly Dictionary<string, int> _projectStats;
        public NewJournalEntryForm(Project? project, Dictionary<string, int> projectStats)
        {
            InitializeComponent();

            _currentProject = project;

            _projectStats = projectStats;
        }

        private void btnAcceptNewJournalEntry_Clicked(object sender, EventArgs e)
        {
            if (_currentProject != null)
            {
                Journal newEntry = new()
                {
                    Id = _currentProject.Journal.Count + 1,
                    Page = txbxJournalEntry.Text,
                    EntryDate = DateTime.Now,
                    Commits = _projectStats["Commits"],
                    Lines = _projectStats["Lines"]
                };

                _currentProject.Journal.Add(newEntry);

                Project.SaveProject(_currentProject);
            }
            else
            {
                MessageBox.Show("Something went terribly wrong. Restart and try again");
            }

            Close();
        }
    }
}
