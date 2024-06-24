
using CompanionDomain.Enums;
using CompanionDomain.Objects;
using System.Reflection.Metadata.Ecma335;

#pragma warning disable IDE1006

namespace CompanionFormApp.tsmiNew
{
    public partial class NewTicketForm : Form
    {
        public Project? CurrentProject;

        public NewTicketForm(Project? project)
        {
            InitializeComponent();

            CurrentProject = project;

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

            if (CurrentProject?.Tickets.Any(p => p.Name == newTicket.Name) ?? true)
            {
                MessageBox.Show($"The ticket name: {newTicket.Name} already exists for {CurrentProject?.Name}");

                return;
            }
            else
            {
                CurrentProject.Tickets.Add(newTicket);

                Project.SaveProject(CurrentProject);

                Close();
            }
        }
    }
}
