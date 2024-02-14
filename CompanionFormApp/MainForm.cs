using CompanionDomain;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CompanionFormApp

{
    //tsmi = tool strip menu item
    //txbx = textbox
    //lbl = label
    //lstbx = listbox
    //btn = button
    public partial class MainForm : Form
    {
        private const string rootDir = "C:\\ProjectTracking";

        private Project CurrentProject = new();

        private List<Ticket> ProjectTickets = new();

        //Constructor
        public MainForm()
        {
            InitializeComponent();

            if (!Directory.Exists(rootDir))
            {
                Directory.CreateDirectory(rootDir);
            }
        }

        #region PopulateUI Elements
        private void PopulateTickets()
        {
            if (ProjectTickets.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            foreach (var ticket in ProjectTickets)
            {
                lstbxProjectTickets.Items.Add(ticket.Name);
            }
        }

        private void PopulateTicketDetails(Ticket ticket)
        {
            txbxTicketDescription_display.Text = ticket.Description;

            lblCurrentTicket.Text = $"Ticket: {ticket.Name}";

            lblTicketPriorty.Text = $"Priority: {ticket.Priority}";

            lblTicketType.Text = $"Type: {ticket.Type}";

            lblDateStart.Text = $"Submission Date: {ticket.TicketStart.ToShortDateString()}";

            if (ticket.TicketEnd != DateTime.MinValue)
            {
                lblDateEnd.Text = $"Completion Date: {ticket.TicketEnd.ToShortDateString()}";
            }
            else
            {
                lblDateEnd.Text = "Completion Date:";
            }

            btnEditTicket.Enabled = true;
        }
        #endregion

        #region Tool Strip Menu Items
        private void tsmiAddProject_clicked(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new NewProjectForm();

            newProjectForm.ShowDialog();
        }

        private void tsmiSelectProject_clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = rootDir;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                string json = File.ReadAllText(selectedFile);

                CurrentProject = JsonConvert.DeserializeObject<Project>(json);

                lblCurrentProject.Text = $"Project: {CurrentProject.Name}";

                ProjectTickets = CurrentProject.Tickets;

                PopulateTickets();
            }
        }

        private void tsmiEditProject_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Folder == null)
            {
                MessageBox.Show("Please select a project.");

                return;
            }

            EditProjectForm editProjectForm = new EditProjectForm(CurrentProject);

            editProjectForm.ShowDialog();
        }

        private void tsmiOpenSolution_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Solution == null)
            {
                MessageBox.Show("No Project Solution set. Please try again.");

                return;
            }

            var visualStudioDir = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe";

            var solutionPath = $@"{CurrentProject.Solution}";

            Process.Start(visualStudioDir, solutionPath);
        }

        private void tsmiOpenGitBash_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Folder == null)
            {
                MessageBox.Show("No Project Folder set. Please try again.");

                return;
            }
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "C:\\Program Files\\Git\\git-bash.exe",
                WorkingDirectory = $"{CurrentProject.Folder}"
            };

            Process.Start(processStartInfo);
        }
        #endregion

        #region ListBox & Its Buttons
        private void lstbxProjectTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ticketIndex = lstbxProjectTickets.SelectedIndex;

            var ticket = ProjectTickets[ticketIndex];

            PopulateTicketDetails(ticket);
        }

        private void btnNewTicket_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Folder == null)
            {
                MessageBox.Show("Please select a project.");

                return;
            }
            NewTicketForm newTicketForm = new NewTicketForm(CurrentProject);

            var result = newTicketForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            CurrentProject = newTicketForm.CurrentProject;

            ProjectTickets = CurrentProject.Tickets;

            PopulateTickets();
        }

        private void btnAllTickets_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Tickets.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            ProjectTickets = CurrentProject.Tickets;

            foreach (var ticket in ProjectTickets)
            {
                lstbxProjectTickets.Items.Add(ticket.Name);
            }
        }

        private void btnActiveTickets_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Tickets.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            ProjectTickets = CurrentProject.Tickets.Where(ticket => ticket.Active == true).ToList();

            foreach (var ticket in ProjectTickets)
            {
                lstbxProjectTickets.Items.Add(ticket.Name);
            }
        }

        private void btnCompletedTicket_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Tickets.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            ProjectTickets = CurrentProject.Tickets.Where(ticket => ticket.Active == false).ToList();

            foreach (var ticket in ProjectTickets)
            {
                lstbxProjectTickets.Items.Add(ticket.Name);
            }
        }

        private void btnEditTicket_clicked(object sender, EventArgs e)
        {
            var ticketIndex = lstbxProjectTickets.SelectedIndex;

            var ticket = ProjectTickets[ticketIndex];

            EditTicketForm editTicketForm = new EditTicketForm(CurrentProject, ticket);

            if (editTicketForm.ShowDialog() == DialogResult.Cancel) return;

            CurrentProject = editTicketForm.CurrentProject;

            PopulateTicketDetails(ProjectTickets[ticketIndex]);
        }
        #endregion

        #region Git Bash Panel
        private void btnCommitProject_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Folder == null)
            {
                MessageBox.Show("No Project Folder set. Please try again.");

                return;
            }
            GitCommitForm gitCommitForm = new GitCommitForm(CurrentProject);

            gitCommitForm.ShowDialog();
        }
        #endregion
    }
}
