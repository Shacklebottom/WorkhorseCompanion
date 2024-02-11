using CompanionDomain;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

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

        public MainForm()
        {
            InitializeComponent();
            
            if (!Directory.Exists(rootDir))
            {
                Directory.CreateDirectory(rootDir);
            }
        }
        private void PopulateTickets()
        {
            if (CurrentProject.Ticket.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            foreach (var ticket in CurrentProject.Ticket)
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

                PopulateTickets();
            }
        }

        private void btnNewTicket_clicked(object sender, EventArgs e)
        {
            if (CurrentProject != null)
            {
                NewTicketForm newTicketForm = new NewTicketForm(CurrentProject);

                var result = newTicketForm.ShowDialog();

                if (result == DialogResult.Cancel) return;

                CurrentProject = newTicketForm.CurrentProject;

                PopulateTickets();
            }
            else
            {
                string wrnMessage = "Please select a project";

                MessageBox.Show(wrnMessage);
            }
        }

        private void lstbxProjectTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            //because of how this is set up, it doesn't allow for proper filtering and selection.
            var ticketIndex = lstbxProjectTickets.SelectedIndex;

            var ticket = CurrentProject.Ticket[ticketIndex];

            PopulateTicketDetails(ticket);
        }

        private void btnEditTicket_clicked(object sender, EventArgs e)
        {
            var ticketIndex = lstbxProjectTickets.SelectedIndex;

            EditTicketForm editTicketForm = new EditTicketForm(CurrentProject, ticketIndex);

            var result = editTicketForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            CurrentProject = editTicketForm.CurrentProject;

            PopulateTicketDetails(CurrentProject.Ticket[ticketIndex]);
        }

        private void tsmiOpenSolution_clicked(object sender, EventArgs e)
        {
            if (CurrentProject == null) return;

            var visualStudioDir = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe";

            var solutionPath = $@"{CurrentProject.Solution}";

            Process.Start(visualStudioDir, solutionPath);
        }

        private void tsmiEditProject_clicked(object sender, EventArgs e)
        {
            EditProjectForm editProjectForm = new EditProjectForm(CurrentProject);

            editProjectForm.ShowDialog();
        }

        private void btnActiveTickets_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Ticket.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            foreach (var ticket in CurrentProject.Ticket)
            {
                if (ticket.Active == true)
                {
                    lstbxProjectTickets.Items.Add(ticket.Name);
                }
            }
        }

        private void btnCompletedTicket_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Ticket.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            foreach (var ticket in CurrentProject.Ticket)
            {
                if (ticket.Active == false)
                {
                    lstbxProjectTickets.Items.Add(ticket.Name);
                }
            }
        }

        private void tsmiOpenGitBash_clicked(object sender, EventArgs e)
        {
            if (CurrentProject.Folder == null) return;

            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "C:\\Program Files\\Git\\git-bash.exe",
                WorkingDirectory = $"{CurrentProject.Folder}"
            };

            Process.Start(processStartInfo);
        }

        private void btnCommitProject_clicked(object sender, EventArgs e)
        {
            GitCommitForm gitCommitForm = new GitCommitForm(CurrentProject);

            gitCommitForm.ShowDialog();
        }
    }
}
