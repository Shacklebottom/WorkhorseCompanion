﻿using CompanionDomain;

namespace CompanionFormApp
{
    public partial class EditTicketForm : Form
    {
        public Project CurrentProject;

        private Ticket _ticket = new();

        public EditTicketForm(Project project, Ticket ticket)
        {
            InitializeComponent();

            cmbobxTicketPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            
            cmbobxTicketType.DataSource = Enum.GetValues(typeof(TicketType));

            CurrentProject = project;

            _ticket = ticket;

            txbxTicketName.Text = _ticket.Name;

            txbxTicketDescription.Text = _ticket.Description;

            cmbobxTicketPriority.SelectedIndex = (int)_ticket.Priority;

            cmbobxTicketType.SelectedIndex = (int)_ticket.Type;

            chkbxTicketCompleted.Checked = !_ticket.Active;
        }

        private void btnSubmitTicketEdit_clicked(object sender, EventArgs e)
        {
            _ticket.Name = txbxTicketName.Text;

            _ticket.Description = txbxTicketDescription.Text;
            
            _ticket.Priority = (TicketPriority)cmbobxTicketPriority.SelectedIndex;
            
            _ticket.Type = (TicketType)cmbobxTicketType.SelectedItem;

            _ticket.Active = !chkbxTicketCompleted.Checked;

            if (!_ticket.Active) 
            {
                _ticket.TicketEnd = DateTime.Now;
            }
            else
            {
                _ticket.TicketEnd = DateTime.MinValue;
            }

            var ticketIndex = CurrentProject.Tickets.FindIndex(x => x.Name == _ticket.Name);

            CurrentProject.Tickets[ticketIndex] = _ticket;

            Project.SaveProject(CurrentProject);

            Close();
        }
    }
}
