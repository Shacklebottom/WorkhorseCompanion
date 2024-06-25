using CompanionDomain.Enums;
using CompanionDomain.Objects;

#pragma warning disable IDE1006

namespace CompanionFormApp.tsmiEdit
{
    public partial class EditTicketForm : Form
    {
        private readonly Project? _currentProject;

        private readonly Ticket? _currentTicket;

        public EditTicketForm(Project? project, Ticket? ticket)
        {
            InitializeComponent();

            _currentProject = project;

            _currentTicket = ticket;

            cmbbxTicketType.DataSource = Enum.GetValues(typeof(TicketType));

            cmbbxTicketPriority.DataSource = Enum.GetValues(typeof(TicketPriority));

            PopulateEditInformation();
        }

        private void PopulateEditInformation()
        {
            txbxTicketName.Text = _currentTicket?.Name;

            txbxTicketDescription.Text = _currentTicket?.Description;

            cmbbxTicketType.SelectedItem = _currentTicket?.Type;

            cmbbxTicketPriority.SelectedItem = _currentTicket?.Priority;

            if (_currentTicket?.Active == false)
            {
                chkbxTicketComplete.Checked = true;
            }
        }

        private void btnAcceptTicketEdit_Clicked(object sender, EventArgs e)
        {
            if (_currentTicket != null && _currentProject != null)
            {
                _currentTicket.Name = txbxTicketName.Text;

                _currentTicket.Description = txbxTicketDescription.Text;

                _currentTicket.Type = cmbbxTicketType.SelectedItem as TicketType?;

                _currentTicket.Priority = cmbbxTicketPriority.SelectedItem as TicketPriority?;

                _currentTicket.Active = !chkbxTicketComplete.Checked;

                if (chkbxTicketComplete.Checked)
                {
                    _currentTicket.TicketEnd = DateTime.Now;
                }

                Project.SaveProject(_currentProject);

                Close();
            }
            else
            {
                MessageBox.Show($"Something went wrong with the ticket: {_currentTicket?.Name}. Try again or start over :)");

                return;
            }
        }
    }
}
