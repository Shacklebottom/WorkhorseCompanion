using CompanionDomain;

namespace CompanionFormApp
{
    public partial class NewTicketForm : Form
    {
        public Project CurrentProject;

        private CompanionDomain.Ticket _Ticket = new();

        public NewTicketForm(Project project)
        {
            InitializeComponent();

            cmbbxTicketPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            
            cmbbxTicketType.DataSource = Enum.GetValues(typeof(TicketType));

            CurrentProject = project;
        }

        private void btnSubmitNewTicket_clicked(object sender, EventArgs e)
        {
            _Ticket.Name = txbxTicketName.Text;

            _Ticket.Description = txbxTicketDescription_capture.Text;

            _Ticket.Priority = (TicketPriority)cmbbxTicketPriority.SelectedItem;

            _Ticket.Type = (TicketType)cmbbxTicketType.SelectedItem;

            _Ticket.TicketStart = DateTime.Now;

            CurrentProject.Ticket.Add(_Ticket);

            Project.SaveProject(CurrentProject);

            Close();
        }
    }
}
