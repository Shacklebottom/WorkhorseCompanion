﻿using CompanionDomain.Objects;
using CompanionFormApp.tsmiNew;
using CompanionFormApp.tsmiEdit;

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

            //We're unassigning the event handler before populating the tickets, so that the handler doesn't fire when the form initially loads.
            lstbxTicketOverview.SelectedIndexChanged -= lstbxTicketOverview_SelectedIndexChanged;
            PopulateTickets();
            lstbxTicketOverview.SelectedIndexChanged += lstbxTicketOverview_SelectedIndexChanged;
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

        private void PopulateTicketInformation(Ticket? ticket)
        {
            txbxTicketDescription_display.Text = ticket?.Description;

            txbxTicketName.Text = ticket?.Name;

            txbxTicketPriority.Text = ticket?.Priority.ToString();

            txbxTicketType.Text = ticket?.Type.ToString();

            txbxDateStart.Text = ticket?.TicketStart.ToString();

            txbxDateEnd.Text = ticket?.TicketEnd.ToString();
        }
        #endregion

        #region TICKET OVERVIEW
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

        private void lstbxTicketOverview_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var selectedItem = lstbxTicketOverview.SelectedItem as string;

            var ticket = CurrentProject?.Tickets.Where(p => p.Name == selectedItem).First();

            PopulateTicketInformation(ticket);
        }
        #endregion



        #region TSMI NEW
        private void tsmiNewTicket_Clicked(object sender, EventArgs e)
        {
            NewTicketForm newTicketForm = new();

            newTicketForm.ShowDialog();
        }
        #endregion

        #region TSMI EDIT
        private void tsmiEditCurrentTicket_Clicked(object sender, EventArgs e)
        {   
            EditTicketForm editTicketForm = new();

            editTicketForm.ShowDialog();
        }
        #endregion
    }
}
