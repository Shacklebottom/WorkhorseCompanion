using CompanionDomain;

namespace CompanionFormApp
{
    public partial class NewTicketForm : Form
    {
        public Project CurrentProject;

        private Ticket Ticket = new();

        public NewTicketForm(Project project)
        {
            InitializeComponent();

            cmbbxTicketPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            
            cmbbxTicketType.DataSource = Enum.GetValues(typeof(TicketType));

            CurrentProject = project;
        }

        private void btnSubmitNewTicket_clicked(object sender, EventArgs e)
        {
            Ticket.Name = txbxTicketName.Text;

            Ticket.Description = txbxTicketDescription_capture.Text;

            Ticket.Priority = (TicketPriority)cmbbxTicketPriority.SelectedItem;

            Ticket.Type = (TicketType)cmbbxTicketType.SelectedItem;

            Ticket.TicketStart = DateTime.Now;

            CurrentProject.Tickets.Add(Ticket);

            Project.SaveProject(CurrentProject);

            Close();
        }
    }
}
