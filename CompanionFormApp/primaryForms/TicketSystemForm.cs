using CompanionDomain.Objects;

#pragma warning disable IDE1006

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

            lstbxTicketOverview.DataSource = CurrentProject?.Tickets.Select(p => p.Name).ToList();
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

        private void PopulateTickets(bool? active = null)
        {
            if (active == null)
            {
                lstbxTicketOverview.DataSource = CurrentProject?.Tickets.Select(p => p.Name).ToList();
            }
            else
            {
                lstbxTicketOverview.DataSource = CurrentProject?.Tickets.Where(b => b.Active == active).Select(p => p.Name).ToList();
            }
        }
        #endregion

        #region TICKET OVERVIEW BUTTONS
        private void btnAllTickets_Clicked(object sender, EventArgs e)
        {
            PopulateTickets();
        }

        private void btnActiveTickets_Clicked(object sender, EventArgs e)
        {
            var active = true;

            PopulateTickets(active);
        }

        private void btnCompleteTickets_Clicked(object sender, EventArgs e)
        {
            var active = false;

            PopulateTickets(active);
        }
        #endregion

        private void lstbxTicketOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
