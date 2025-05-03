using CompanionDomain.Enums;
using CompanionDomain.Interfaces;
using CompanionDomain.Objects;

#pragma warning disable IDE1006

namespace CompanionFormApp.New
{
    public partial class NewTicketForm : Form
    {
        private readonly Project? _currentProject;

        private readonly IProjectManager _projectManager;

        private readonly PathBuilder _pathBuilder;

        public NewTicketForm(Project? project, IProjectManager projectManager, PathBuilder pathBuilder)
        {
            InitializeComponent();

            _currentProject = project;

            _projectManager = projectManager;

            _pathBuilder = pathBuilder;

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

                _projectManager.Save(_currentProject, _pathBuilder);

                Close();
            }
        }
    }
}
