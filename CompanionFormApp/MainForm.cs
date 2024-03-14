using CompanionBusiness;
using CompanionDomain;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Security.Policy;

namespace CompanionFormApp

{
    //tsmi = tool strip menu item
    //txbx = textbox
    //lbl = label
    //lstbx = listbox
    //btn = button
    public partial class MainForm : Form
    {
        private AppDirectory _appDirectory = new();

        private Project _currentProject = new();

        private List<Ticket> _projectTickets = new();

        //Constructor
        public MainForm()
        {
            InitializeComponent();

            PopulateQuoteLabel();

            PopulateRecentProjects();
        }

        #region Populate & Display UI Elements
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
            DirectoryInfo imageDir = new($"{_appDirectory.ImgDir}");
            DirectoryInfo documentDir = new($"{_appDirectory.DocDir}");
            DirectoryInfo websiteDir = new($"{_appDirectory.WebDir}");

            var imageFiles = imageDir.GetFiles().ToList();
            var documentFiles = documentDir.GetFiles().ToList();
            var websiteFiles = websiteDir.GetFiles().ToList();

            imageFiles.ForEach(r => tsmiOpenResourceImage.DropDownItems.Add(r.Name.Split('.')[0]));
            documentFiles.ForEach(r => tsmiOpenResourceDocument.DropDownItems.Add(r.Name.Split(".")[0]));
            websiteFiles.ForEach(r => tsmiOpenResourceWebsite.DropDownItems.Add(r.Name.Split(".")[0]));


            //_currentProject.Resources.ForEach(r => tsmiOpenResource.DropDownItems.Add(r.Name));
        }

        private void PopulateRecentProjects()
        {
            DirectoryInfo directoryInfo = new($"{_appDirectory.RootDir}");

            var projectFiles = directoryInfo.GetFiles();

            var sortedProjectsFiles = projectFiles.OrderByDescending(file => file.LastWriteTime).ToList();

            foreach (var project in sortedProjectsFiles)
            {
                tsmiOpenProject.DropDownItems.Add(project.Name.Split('.')[0]);
            }
        }

        private void PopulateGitBranches()
        {
            string gitBranch = "branch";

            ProcessManager manager = new GitProcessManager(_currentProject);

            manager.Run($"{gitBranch}");

            var branches = manager.Output.Split("\n");

            foreach (var branch in branches)
            {
                if (branch != string.Empty)
                {
                    tsmiGitBranch.DropDownItems.Add(branch);
                }
            }
        }

        private bool DisplayNoSelectedProject()
        {
            string warningMsg = "No Project Folder set. Please try again.";

            if (_currentProject.Folder == string.Empty)
            {
                MessageBox.Show($"{warningMsg}");

                return true;
            }
            else return false;
        }

        private void DisplayLines(string output, string error)
        {
            txbxBashOutput_display.Text = string.Empty;
            if (output != string.Empty)
            {
                txbxBashOutput_display.Lines = output.Split('\n');
            }

            if (error != string.Empty)
            {
                txbxBashOutput_display.Lines = error.Split('\n');
            }
        }
        #endregion

        #region Command Line
        private void txbxGitCommandLine_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (DisplayNoSelectedProject())
                {
                    txbxGitCommandLine_input.Text = string.Empty;

                    return;
                }

                e.Handled = true;

                ProcessManager manager = new GitProcessManager(_currentProject);

                manager.Run(txbxGitCommandLine_input.Text);

                DisplayLines(manager.Output, manager.Error);

                txbxGitCommandLine_input.Text = string.Empty;
            }
        }
        #endregion

        #region TSMI => New
        private void tsmiNewProject_Click(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new NewProjectForm();

            newProjectForm.ShowDialog();
        }
        private void tsmiNewResource_Click(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            NewResourceForm newResourceForm = new NewResourceForm(_currentProject);

            if (newResourceForm.ShowDialog() == DialogResult.OK)
            {
                PopulateResources();
            }
        }
        #endregion

        #region TSMI => Open
        private void tsmiOpenProject_Click(object sender, EventArgs e)
        {
            tsmiOpen.HideDropDown();

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

                PopulateGitBranches();
            }
        }

        private void tsmiOpenProject_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

            PopulateGitBranches();
        }

        private void tsmiOpenSolution_Click(object sender, EventArgs e)
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

        private void tsmiOpenResource_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        #endregion

        #region TSMI => Edit
        private void tsmiEditProject_clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            EditProjectForm editProjectForm = new EditProjectForm(_currentProject);

            editProjectForm.ShowDialog();

            _currentProject = editProjectForm.CurrentProject;

            lblCurrentProject.Text = $"Project: {_currentProject?.Name}";

            _projectTickets = _currentProject.Tickets;

            _appDirectory = new AppDirectory(_currentProject);

            PopulateTickets();

            PopulateResources();
        }
        #endregion

        #region TSMI => Git
        private void tsmiGitBash_Click(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            ProcessManager manager = new BashProcessManager(_currentProject);

            manager.Run("", false);
        }

        private void tsmiGitCommit_Click(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            GitCommitForm gitCommitForm = new GitCommitForm(_currentProject);

            gitCommitForm.ShowDialog();

            DisplayLines(gitCommitForm.Output, gitCommitForm.Error);
        }

        private void tsmiGitStatus_Click(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            string gitStatus = "status";

            ProcessManager manager = new GitProcessManager(_currentProject);

            manager.Run($"{gitStatus}");

            DisplayLines(manager.Output, manager.Error);
        }

        private void tsmiGitFetch_Click(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            string gitFetch = "fetch";

            ProcessManager manager = new GitProcessManager(_currentProject);

            manager.Run($"{gitFetch}");

            DisplayLines(manager.Output, manager.Error);
        }

        private void tsmiGitBranch_Click(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            string gitBranch = "branch";

            ProcessManager manager = new GitProcessManager(_currentProject);

            manager.Run($"{gitBranch}");

            DisplayLines(manager.Output, manager.Error);
        }

        private void tsmiGitBranch_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string? selectedBranch = e.ClickedItem?.Text;

            if (selectedBranch == null || selectedBranch.Contains('*'))
            {
                MessageBox.Show("Please select a branch you haven't already checked out");

                return;
            }
            string gitCheckout = $"checkout {selectedBranch}";

            ProcessManager manager = new GitProcessManager(_currentProject);

            manager.Run(gitCheckout);

            DisplayLines(manager.Output, manager.Error);
        }

        private void tsmiGitPull_Click(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            string gitPull = "pull";

            ProcessManager manager = new GitProcessManager(_currentProject);

            manager.Run($"{gitPull}");

            DisplayLines(manager.Output, manager.Error);
        }

        private void tsmiGitPush_Click(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            string gitPush = "push";

            ProcessManager manager = new GitProcessManager(_currentProject);

            manager.Run($"{gitPush}");

            DisplayLines(manager.Output, manager.Error);
        }

        private async void tsmiGitOtherInit_Click(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            if (!await GenerateNewGitIgnoreFile()) return;

            string gitInit = "init";

            ProcessManager manager = new GitProcessManager(_currentProject);

            manager.Run(gitInit);

            DisplayLines(manager.Output, manager.Error);
        }



        private void tsmiGitOtherAddRemote_Click(object sender, EventArgs e)
        {

        }

        private void tsmiGitOtherClone_Click(object sender, EventArgs e)
        {

        }

        private void tsmiGitOtherReset_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Tickets ListBox & Its Buttons
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

        private async Task<bool> GenerateNewGitIgnoreFile()
        {
            string gitRawURL = "https://raw.githubusercontent.com/github/gitignore/main/VisualStudio.gitignore";

            string fileName = ".gitignore";

            string savedToPathAs = Path.Combine(_currentProject.Folder, fileName);

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(gitRawURL);

                    if (response.IsSuccessStatusCode)
                    {
                        using (var fileStream = new FileStream(savedToPathAs, FileMode.Create))
                        {
                            await response.Content.CopyToAsync(fileStream);

                            return true;
                        }
                    }
                    else
                    {
                        throw new Exception(response.StatusCode.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

                return false;
            }
        }
    }
}
