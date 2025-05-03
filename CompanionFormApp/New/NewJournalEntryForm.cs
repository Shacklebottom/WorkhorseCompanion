using CompanionDomain.Interfaces;
using CompanionDomain.Objects;

#pragma warning disable IDE1006

namespace CompanionFormApp.New
{
    public partial class NewJournalEntryForm : Form
    {
        private readonly Project? _currentProject;

        private readonly Dictionary<string, int> _projectStats;

        private readonly IProjectManager _projectManager;

        private readonly PathBuilder _pathBuilder;

        public NewJournalEntryForm(Project? project, Dictionary<string, int> projectStats, IProjectManager projectManager, PathBuilder pathBuilder)
        {
            InitializeComponent();

            _projectManager = projectManager;

            _pathBuilder = pathBuilder;

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

                _projectManager.Save(_currentProject, _pathBuilder);
            }
            else
            {
                MessageBox.Show("Something went terribly wrong. Restart and try again");
            }

            Close();
        }
    }
}
