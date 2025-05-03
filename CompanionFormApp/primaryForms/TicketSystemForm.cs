using CompanionDomain.Interfaces;
using CompanionDomain.Objects;
using CompanionFormApp.New;
using CompanionFormApp.tsmiEdit;

#pragma warning disable IDE1006

namespace CompanionFormApp.PrimaryForms
{
    public partial class TicketSystemForm : Form
    {
        private readonly Form _parentForm;
        private Ticket? _currentTicket = new();
        private readonly Project? _currentProject;
        private readonly IProjectManager _projectManager;

        public TicketSystemForm(GitWrapperForm parentForm, Project? currentProject, IProjectManager projectManager)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _currentProject = currentProject;
            _projectManager = projectManager;

            txbxCurrentProject.Text = $"Project: {_currentProject?.Name}";

            PopulateTickets();
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
            lstbxTicketOverview.SelectedIndexChanged -= lstbxTicketOverview_SelectedIndexChanged;

            if (active == null)
            {
                lstbxTicketOverview.DataSource = _currentProject?.Tickets.Select(p => p.Name).ToList();

                lstbxTicketOverview.SelectedIndexChanged += lstbxTicketOverview_SelectedIndexChanged;
            }
            else
            {
                lstbxTicketOverview.DataSource = _currentProject?.Tickets.Where(b => b.Active == active).Select(p => p.Name).ToList();

                lstbxTicketOverview.SelectedIndexChanged += lstbxTicketOverview_SelectedIndexChanged;
            }
        }

        private void PopulateTicketInformation(Ticket? ticket)
        {
            txbxTicketDescription_display.Text = "";
            txbxTicketDescription_display.Text = ticket?.Description;

            txbxTicketName.Text = "";
            txbxTicketName.Text = ticket?.Name;

            txbxTicketPriority.Text = "";
            txbxTicketPriority.Text = ticket?.Priority.ToString();

            txbxTicketType.Text = "";
            txbxTicketType.Text = ticket?.Type.ToString();

            txbxDateStart.Text = "";
            txbxDateStart.Text = ticket?.TicketStart.ToString();

            txbxDateEnd.Text = "";
            if (ticket?.TicketEnd != new DateTime())
            {
                txbxDateEnd.Text = ticket?.TicketEnd.ToString();
            }
        }
        #endregion

        #region TICKET OVERVIEW
        private void btnAllTickets_Clicked(object sender, EventArgs e)
        {
            PopulateTickets();
        }

        private void btnActiveTickets_Clicked(object sender, EventArgs e)
        {
            PopulateTickets(active: true);
        }

        private void btnCompleteTickets_Clicked(object sender, EventArgs e)
        {
            PopulateTickets(active: false);
        }

        private void lstbxTicketOverview_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var selectedItem = lstbxTicketOverview.SelectedItem as string;

            var ticket = _currentProject?.Tickets.First(p => p.Name == selectedItem);
            _currentTicket = ticket;

            PopulateTicketInformation(ticket);
        }
        #endregion

        #region TSMI NEW
        private void tsmiNewTicket_Clicked(object sender, EventArgs e)
        {
            NewTicketForm newTicketForm = new(_currentProject, _projectManager);
            newTicketForm.ShowDialog();

            PopulateTickets(active: true);
        }
        #endregion

        #region TSMI EDIT
        private void tsmiEditCurrentTicket_Clicked(object sender, EventArgs e)
        {   
            EditTicketForm editTicketForm = new(_currentProject, _currentTicket, _projectManager);
            editTicketForm.ShowDialog();

            PopulateTickets(active: true);
            PopulateTicketInformation(_currentTicket);
        }
        #endregion
    }
}
