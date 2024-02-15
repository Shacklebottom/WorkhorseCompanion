using CompanionDomain;

namespace CompanionFormApp
{
    public partial class EditTicketForm : Form
    {
        public Project CurrentProject;

        private Ticket Ticket = new();

        public EditTicketForm(Project project, Ticket ticket)
        {
            InitializeComponent();

            cmbobxTicketPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            
            cmbobxTicketType.DataSource = Enum.GetValues(typeof(TicketType));

            CurrentProject = project;

            Ticket = ticket;

            txbxTicketName.Text = Ticket.Name;

            txbxTicketDescription.Text = Ticket.Description;

            cmbobxTicketPriority.SelectedIndex = (int)Ticket.Priority;

            cmbobxTicketType.SelectedIndex = (int)Ticket.Type;

            chkbxTicketCompleted.Checked = !Ticket.Active;
        }

        private void btnSubmitTicketEdit_clicked(object sender, EventArgs e)
        {
            Ticket.Name = txbxTicketName.Text;

            Ticket.Description = txbxTicketDescription.Text;
            
            Ticket.Priority = (TicketPriority)cmbobxTicketPriority.SelectedIndex;
            
            Ticket.Type = (TicketType)cmbobxTicketType.SelectedItem;

            Ticket.Active = !chkbxTicketCompleted.Checked;

            if (!Ticket.Active) 
            {
                Ticket.TicketEnd = DateTime.Now;
            }
            else
            {
                Ticket.TicketEnd = DateTime.MinValue;
            }

            var ticketIndex = CurrentProject.Tickets.FindIndex(x => x.Name == Ticket.Name);

            CurrentProject.Tickets[ticketIndex] = Ticket;

            Project.SaveProject(CurrentProject);

            Close();
        }
    }
}
