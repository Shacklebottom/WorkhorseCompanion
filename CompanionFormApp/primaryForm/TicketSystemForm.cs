using CompanionDomain.Objects;

namespace CompanionFormApp.primaryForm
{
    public partial class TicketSystemForm : Form
    {
        private readonly Form _parentForm;

        public Project? CurrentProject;

        public TicketSystemForm(GitWrapperForm parentForm, Project? currentProject)
        {
            InitializeComponent();

            _parentForm = parentForm;

            CurrentProject = currentProject;
        }

        private void TicketSystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            Hide();

            _parentForm.Show();
        }
    }
}
