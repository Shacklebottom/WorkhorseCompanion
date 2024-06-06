using CompanionDomain;

namespace RefactoredFormApp
{
    public partial class NewTicketForm : Form
    {
        public Project CurrentProject { get; set; }

        private readonly Ticket _ticket = new();

        public NewTicketForm(Project project)
        {
            InitializeComponent();

            cmbbxTicketPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            
            cmbbxTicketType.DataSource = Enum.GetValues(typeof(TicketType));

            CurrentProject = project;
        }

        private void btnSubmitNewTicket_clicked(object sender, EventArgs e)
        {
            _ticket.Name = txbxTicketName.Text;

            _ticket.Description = txbxTicketDescription_capture.Text;

            _ticket.Priority = (TicketPriority)cmbbxTicketPriority.SelectedItem;

            _ticket.Type = (TicketType)cmbbxTicketType.SelectedItem;

            _ticket.TicketStart = DateTime.Now;

            CurrentProject.Tickets.Add(_ticket);

            Project.SaveProject(CurrentProject);

            Close();
        }
    }
}
