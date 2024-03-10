using CompanionBusiness;
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
        private AppDirectory _appDirectory { get; set; } = new();

        private Project _currentProject = new();

        private List<Ticket> _projectTickets = new();

        //Constructor
        public MainForm()
        {
            InitializeComponent();

            PopulateQuoteLabel();

            PopulateRecentProjects();
        }

        #region PopulateUI Elements
        private void PopulateTickets()
        {
            if (_projectTickets.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            foreach (var ticket in _projectTickets)
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

        private void PopulateQuoteLabel()
        {
            var convictionIndex = new Random().Next(0, 10);

            lblDeterminationQuote.Text = Determination.Convinction[convictionIndex];
        }

        private void PopulateResources()
        {
            _currentProject.Resources.ForEach(r => tsmiOpenResource.DropDownItems.Add(r.Name));
        }

        private void PopulateRecentProjects()
        {
            DirectoryInfo directoryInfo = new($"{_appDirectory.RootDir}");

            var projectFiles = directoryInfo.GetFiles();

            var sortedProjectsFiles = projectFiles.OrderByDescending(file => file.LastAccessTime).ToList();

            foreach (var project in sortedProjectsFiles)
            {
                tsmiFileSelectProject.DropDownItems.Add(project.Name.Split('.')[0]);
            }
        }
        #endregion

        #region Tool Strip Menu Items
        private void tsmiFileAddProject_clicked(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new NewProjectForm();

            newProjectForm.ShowDialog();
        }

        private void tsmiFileAddResource_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Folder == string.Empty)
            {
                MessageBox.Show("No Project Folder set. Please try again.");

                return;
            }

            NewResourceForm newResourceForm = new NewResourceForm(_currentProject);

            if (newResourceForm.ShowDialog() == DialogResult.OK)
            {
                _currentProject = newResourceForm.CurrentProject;

                PopulateResources();
            }
        }

        private void tsmiFileSelectProject_clicked(object sender, EventArgs e)
        {
            tsmiFile.HideDropDown();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = _appDirectory.RootDir;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                string json = File.ReadAllText(selectedFile);

                _currentProject = JsonConvert.DeserializeObject<Project>(json);

                lblCurrentProject.Text = $"Project: {_currentProject?.Name}";

                _projectTickets = _currentProject.Tickets;

                _appDirectory = new AppDirectory(_currentProject);

                PopulateTickets();

                PopulateResources();
            }
        }

        private void tsmiFileSelectProject_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DirectoryInfo directoryInfo = new($"{_appDirectory.RootDir}");

            var projectFiles = directoryInfo.GetFiles();

            var selectedProject = e.ClickedItem.Text;

            string projectFilePath = string.Empty;

            foreach (var project in projectFiles)
            {
                if (project.Name.Split('.')[0] == selectedProject)
                {
                    projectFilePath = project.FullName;
                }
            }
            
            string json = File.ReadAllText(projectFilePath);

            _currentProject = JsonConvert.DeserializeObject<Project>(json);

            lblCurrentProject.Text = $"Project: {_currentProject?.Name}";

            _projectTickets = _currentProject.Tickets;

            _appDirectory = new AppDirectory(_currentProject);

            PopulateTickets();

            PopulateResources();
        }

        private void tsmiEditProject_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Folder == string.Empty)
            {
                MessageBox.Show("Please select a project.");

                return;
            }

            EditProjectForm editProjectForm = new EditProjectForm(_currentProject);

            editProjectForm.ShowDialog();
        }

        private void tsmiOpenSolution_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Solution == string.Empty)
            {
                MessageBox.Show("No Project Solution set. Please try again.");

                return;
            }

            var visualStudioDir = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe";

            var solutionPath = $"{_currentProject.Solution}";

            Process.Start(visualStudioDir, solutionPath);
        }

        private void tsmiOpenGitBash_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Folder == string.Empty)
            {
                MessageBox.Show("No Project Folder set. Please try again.");

                return;
            }

            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = "C:\\Program Files\\Git\\git-bash.exe",
                WorkingDirectory = $"{_currentProject.Folder}"
            };

            Process.Start(processStartInfo);
        }

        private void tsmiOpenResource_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var targetResource = _currentProject.Resources.Where(r => r.Name == e?.ClickedItem?.ToString()).First();

            //file open on targetResource.Path;
        }
        #endregion

        #region ListBox & Its Buttons
        private void lstbxProjectTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ticketIndex = lstbxProjectTickets.SelectedIndex;

            var ticket = _projectTickets[ticketIndex];

            PopulateTicketDetails(ticket);
        }

        private void btnNewTicket_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Folder == null)
            {
                MessageBox.Show("Please select a project.");

                return;
            }
            NewTicketForm newTicketForm = new NewTicketForm(_currentProject);

            var result = newTicketForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            _currentProject = newTicketForm.CurrentProject;

            _projectTickets = _currentProject.Tickets;

            PopulateTickets();
        }

        private void btnAllTickets_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Tickets.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            _projectTickets = _currentProject.Tickets;

            foreach (var ticket in _projectTickets)
            {
                lstbxProjectTickets.Items.Add(ticket.Name);
            }
        }

        private void btnActiveTickets_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Tickets.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            _projectTickets = _currentProject.Tickets.Where(ticket => ticket.Active == true).ToList();

            foreach (var ticket in _projectTickets)
            {
                lstbxProjectTickets.Items.Add(ticket.Name);
            }
        }

        private void btnCompletedTicket_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Tickets.Count == 0) return;

            lstbxProjectTickets.Items.Clear();

            _projectTickets = _currentProject.Tickets.Where(ticket => ticket.Active == false).ToList();

            foreach (var ticket in _projectTickets)
            {
                lstbxProjectTickets.Items.Add(ticket.Name);
            }
        }

        private void btnEditTicket_clicked(object sender, EventArgs e)
        {
            var ticketIndex = lstbxProjectTickets.SelectedIndex;

            var ticket = _projectTickets[ticketIndex];

            EditTicketForm editTicketForm = new EditTicketForm(_currentProject, ticket);

            if (editTicketForm.ShowDialog() == DialogResult.Cancel) return;

            _currentProject = editTicketForm.CurrentProject;

            PopulateTicketDetails(_projectTickets[ticketIndex]);
        }
        #endregion

        #region Git Bash Panel
        private void btnCommitProject_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Folder == null)
            {
                MessageBox.Show("No Project Folder set. Please try again.");

                return;
            }
            GitCommitForm gitCommitForm = new GitCommitForm(_currentProject);

            gitCommitForm.ShowDialog();

            if (gitCommitForm.ProcessError != string.Empty)
            {
                txbxBashOutput_display.Lines = gitCommitForm.ProcessError.Split('\n');
            }

            if (gitCommitForm.ProcessOutput != string.Empty)
            {
                txbxBashOutput_display.Lines = gitCommitForm.ProcessOutput.Split('\n');
            }
        }

        private void btnGitStatus_clicked(object sender, EventArgs e)
        {
            if (_currentProject.Folder == null)
            {
                MessageBox.Show("No Project Folder set. Please try again.");

                return;
            }

            string gitStatus = "status";

            ProcessManager manager = new ProcessManager(_currentProject);

            manager.Run($"{gitStatus}");

            if (manager.Output != string.Empty)
            {
                txbxBashOutput_display.Lines = manager.Output.Split('\n');
            }

            if (manager.Error != string.Empty)
            {
                txbxBashOutput_display.Lines = manager.Error.Split('\n');
            }
        }

        private void btnGitPull_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented.");

            return;
        }

        private void btnGitPush_clicked(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented.");

            return;
        }

        #endregion




    }
}
