using CompanionDomain.Enums;
using CompanionDomain.Objects;

namespace CompanionFormApp.tsmiView
{
    public partial class ViewJournalForm : Form
    {
        private readonly Project? _currentProject;

        public ViewJournalForm(Project? project)
        {
            InitializeComponent();
        
            _currentProject = project;
        }
    }
}
