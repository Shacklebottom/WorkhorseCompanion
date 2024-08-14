using CompanionDomain.Enums;
using CompanionDomain.Objects;

#pragma warning disable IDE1006

namespace CompanionFormApp.New
{
    public partial class NewTicketForm : Form
    {
        private readonly Project? _currentProject;

        public NewTicketForm(Project? project)
        {
            InitializeComponent();

            _currentProject = project;

            cmbbxTicketType.DataSource = Enum.GetValues(typeof(TicketType));

            cmbbxTicketPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
        }

        private void btnAcceptNewTicket_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbxTicketName.Text) || string.IsNullOrWhiteSpace(txbxTicketDescription.Text)) { return; }

            Ticket newTicket = new()
            {
                Name = txbxTicketName.Text,

                Description = txbxTicketDescription.Text,

                Type = cmbbxTicketType.SelectedItem as TicketType?,

                Priority = cmbbxTicketPriority.SelectedItem as TicketPriority?,

                TicketStart = DateTime.Now,
            };

            if (_currentProject?.Tickets.Any(p => p.Name == newTicket.Name) ?? true)
            {
                MessageBox.Show($"The ticket name: {newTicket.Name} already exists for {_currentProject?.Name}");

                return;
            }
            else
            {
                _currentProject.Tickets.Add(newTicket);

                Project.SaveProject(_currentProject);

                Close();
            }
        }
    }
}
