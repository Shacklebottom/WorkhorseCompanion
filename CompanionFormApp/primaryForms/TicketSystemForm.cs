using CompanionDomain.Objects;

namespace CompanionFormApp.primaryForms
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

            txbxCurrentProject.Text = $"Project: {CurrentProject?.Name}";
        }
        #region TICKET FORM CLOSING
        private void TicketSystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            Hide();

            _parentForm.Show();
        }
        #endregion

        #region POPULATE UI ELEMENTS
        private void PopulateDeterminationWhen_TicketSystemForm_Activated(object sender, EventArgs e)
        {
            lblDeterminationQuote.Text = Determination.GetQuote();
        }
        #endregion
    }
}
