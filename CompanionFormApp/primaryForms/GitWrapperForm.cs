using CompanionFormApp.New;
using CompanionFormApp.Edit;
using CompanionFormApp.Git;
using CompanionFormApp.FormSupport;
using CompanionDomain.Objects;
using CompanionDomain.Interfaces;
using Newtonsoft.Json;
using System.Diagnostics;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.PrimaryForms
{
    public partial class GitWrapperForm : Form
    {
        private readonly IProcessManager _processManager;

        private AppDirectory _appDirectory;

        private Project _currentProject = new();

        private TicketSystemForm? _ticketSystemForm;

        private JournalSystemForm? _journalSystemForm;

        //Constructor
        public GitWrapperForm(IProcessManager manager)
        {
            InitializeComponent();

            GitWrapperMenuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomToolStripColorTable());

            _processManager = manager;

            _appDirectory = new();

            PopulateRecentProjects();

            PopulateDocumentation();
        }

        #region POPULATE UI ELEMENTS
        private void PopulateRecentProjects()
        {
            tsmiOpenProject.DropDownItems.Clear();

            DirectoryInfo directoryInfo = new($"{_appDirectory.RootDir}");

            var projectFiles = directoryInfo.GetFiles();

            var sortedProjectsFiles = projectFiles.OrderByDescending(file => file.Name).ToList();

            foreach (var project in sortedProjectsFiles)
            {
                ToolStripMenuItem tsmi = new(project.Name.Split('.')[0])
                {
                    BackColor = Color.LemonChiffon
                };

                tsmiOpenProject.DropDownItems.Add(tsmi);
            }
        }

        private void PopulateDocumentation()
        {
            tsmiDocumentationExternal.DropDownItems.Clear();
            tsmiDocumentationInternal.DropDownItems.Clear();

            DirectoryInfo directoryInfo = new($"{_appDirectory.InternalDir}");
            var documentationFiles = directoryInfo.GetFiles();
            var sortedDocumentationFiles = documentationFiles.OrderBy(file => file.Name).ToList();

            foreach (var document in sortedDocumentationFiles)
            {
                ToolStripMenuItem tsmi = new(document.Name.Split('.')[0])
                {
                    BackColor = Color.LemonChiffon
                };

                tsmiDocumentationInternal.DropDownItems.Add(tsmi);
            }

            var externalDocumentation = File.ReadAllLines(_appDirectory.CombinedExternalPath);

            foreach (var document in externalDocumentation)
            {
                ToolStripMenuItem tsmi = new(document)
                {
                    BackColor = Color.LemonChiffon
                };

                tsmiDocumentationExternal.DropDownItems.Add(tsmi);
            }
        }

        private void PopulateProjectResources()
        {
            return;
        }

        private void PopulateDeterminationWhen_GitWrapperForm_Activated(object sender, EventArgs e)
        {
            lblDeterminationQuote.Text = Determination.GetQuote();
        }
        #endregion

        #region DISPLAY SUPPORT
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
            if (!string.IsNullOrWhiteSpace(output))
            {
                txbxBashOutput_display.Lines = output.Split('\n');
            }

            if (!string.IsNullOrWhiteSpace(error))
            {
                txbxBashOutput_display.Lines = error.Split('\n');
            }
        }
        #endregion

        #region GENERATE GIT IGNORE FILE
        private async Task<bool> GenerateNewGitIgnoreFile()
        {
            string gitRawURL = "https://raw.githubusercontent.com/github/gitignore/main/VisualStudio.gitignore";

            string fileName = ".gitignore";

            string savedToPathAs = Path.Combine(_currentProject.Folder, fileName);

            if (File.Exists(savedToPathAs))
            {
                MessageBox.Show("A .gitignore file already exists. You have either already initialized a git repo or you need to clean up your directory");

                return false;
            }

            try
            {
                using var httpClient = new HttpClient();

                var response = await httpClient.GetAsync(gitRawURL);

                if (response.IsSuccessStatusCode)
                {
                    using var fileStream = new FileStream(savedToPathAs, FileMode.Create);

                    await response.Content.CopyToAsync(fileStream);

                    return true;
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

                return false;
            }
        }
        #endregion

        #region TSMI => NEW
        private void tsmiNewSolution_Clicked(object sender, EventArgs e)
        {
            NewSolutionForm newSolutionForm = new();

            newSolutionForm.ShowDialog();
        }

        private void tsmiNewProject_Clicked(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new();

            newProjectForm.ShowDialog();

            PopulateRecentProjects();
        }

        private void tsmiNewDocumentation_Clicked(object sender, EventArgs e)
        {
            NewDocumentationForm newDocumentationForm = new();

            newDocumentationForm.ShowDialog();

            PopulateDocumentation();
        }

        private void tsmiNewResource_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) { return; }

            NewResourceForm newResourceForm = new(_currentProject);

            newResourceForm.ShowDialog();

            PopulateProjectResources();
        }
        #endregion

        #region TSMI => OPEN
        private void tsmiOpenProject_Clicked(object sender, EventArgs e)
        {
            //when Open => Project is clicked we:

            //instantiate a new OpenFileDialog obj and set the directory it opens to (InitialDirectory) to the Companion's root directory
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = _appDirectory.RootDir
            };

            //we then hide the Project DropDown menu, otherwise it will clip through the OpenFileDialog UI window that appears "on top" of it
            tsmiOpen.HideDropDown();

            //we show a new OpenFileDialog UI window.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //user selects a project file, and
                string selectedFile = openFileDialog.FileName;

                //we read the file and then deserialize it into a Project obj using JsonConvert
                string json = File.ReadAllText(selectedFile);
                _currentProject = JsonConvert.DeserializeObject<Project>(json) ?? throw new Exception("Project JSON was null");

                //then finally, we update the UI to show the current project name and set our AppDirectory and TicketSystemForm objs to the current project
                txbxCurrentProject.Text = $"Project: {_currentProject?.Name}";
                _appDirectory = new AppDirectory(_currentProject);
                _ticketSystemForm = new TicketSystemForm(this, _currentProject);
                _journalSystemForm = new JournalSystemForm(this, _processManager, _currentProject);
            }
        }

        private void tsmiOpenProject_DropDownItem_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //user selects an item from the prepopulated dropdown list.
            var selectedProject = e.ClickedItem?.Text;

            //we instantiate a new DirectoryInfo obj and then get the files in that directory
            DirectoryInfo directoryInfo = new($"{_appDirectory.RootDir}");
            var projectFiles = directoryInfo.GetFiles();

            //of the files we got, we match the file with the item the user selected
            string projectFilePath = "";
            foreach (var projectFile in projectFiles)
            {
                if (projectFile.Name.Split('.')[0] == selectedProject)
                {
                    projectFilePath = projectFile.FullName;
                }
            }

            //we read the file and then deserialize it into a Project obj using JsonConvert
            string json = File.ReadAllText(projectFilePath);
            _currentProject = JsonConvert.DeserializeObject<Project>(json) ?? throw new Exception("Project JSON was null");

            //then finally, we update the UI to show the current project name and set our AppDirectory and TicketSystemForm objs to the current project
            txbxCurrentProject.Text = $"Project: {_currentProject?.Name}";
            _appDirectory = new AppDirectory(_currentProject);
            _ticketSystemForm = new TicketSystemForm(this, _currentProject);
            _journalSystemForm = new JournalSystemForm(this, _processManager, _currentProject);
        }

        private void tsmiOpenSolution_Clicked(object sender, EventArgs e)
        {
            if (_currentProject.Solution == string.Empty)
            {
                MessageBox.Show("No Project Solution set. Please try again.");

                return;
            }

            //this should be the default install path of Visual Studio. I should really separate this out and make it so that the user can edit this.
            var visualStudioDir = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe";

            var solutionPath = $"{_currentProject.Solution}";

            //we're using the Process.Start() static method here because we're not screwin' with any of the class properties.
            Process.Start(visualStudioDir, solutionPath);
        }

        private void tsmiOpenTicketSystem_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) { return; }

            Hide();

            _ticketSystemForm?.Show();
        }

        private void tsmiOpenJournalSystem_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) { return; }

            Hide();

            _journalSystemForm?.Show();
        }
        #endregion

        #region TSMI => EDIT
        private void tsmiEditProject_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            EditProjectForm editProjectForm = new(_currentProject);

            editProjectForm.ShowDialog();

            _currentProject = editProjectForm.CurrentProject;

            txbxCurrentProject.Text = $"Project: {_currentProject?.Name}";

            _appDirectory = new AppDirectory(_currentProject);
        }
        #endregion

        #region TSMI => GIT
        private void tsmiGitBash_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            StartInfo start = new("C:\\Program Files\\Git\\git-bash.exe", args: "", _currentProject.Folder, false, false);

            _processManager.Run(start.Info);
        }

        private void tsmiGitCommit_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            GitCommitForm gitCommitForm = new(_currentProject, _processManager);

            gitCommitForm.ShowDialog();

            DisplayLines(gitCommitForm.Output, gitCommitForm.Error);
        }

        private void tsmiGitStatus_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            StartInfo start = new("git", "status", _currentProject.Folder);

            _processManager.Run(start.Info);

            DisplayLines(_processManager.Output, _processManager.Error);
        }

        #region ===>GIT BRANCH<===
        private void tsmiGitBranch_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            //tsmiGitBranch.HideDropDown();

            StartInfo start = new("git", "branch", _currentProject.Folder);

            _processManager.Run(start.Info);

            DisplayLines(_processManager.Output, _processManager.Error);
        }

        private void tsmiGitBranch_DropDownOpening(object sender, EventArgs e)
        {
            if (_currentProject.Folder == string.Empty) return;

            tsmiGitBranch.DropDownItems.Clear();

            StartInfo start = new("git", "branch", _currentProject.Folder);

            _processManager.Run(start.Info);

            var branches = _processManager.Output.Split("\n");

            foreach (var branch in branches)
            {
                if (branch != string.Empty)
                {
                    ToolStripMenuItem tsmi = new(branch)
                    {
                        BackColor = Color.LemonChiffon
                    };

                    tsmiGitBranch.DropDownItems.Add(tsmi);
                }
            }
        }

        private void tsmiGitBranch_DropDownItem_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string? selectedBranch = e.ClickedItem?.Text?.Trim();

            string warningMsg = "Please select a branch you haven't already checked out";

            if (selectedBranch == null || selectedBranch.Contains('*'))
            {
                MessageBox.Show(warningMsg);

                return;
            }

            StartInfo start = new("git", $"checkout {selectedBranch}", _currentProject.Folder);

            _processManager.Run(start.Info);

            DisplayLines(_processManager.Output, _processManager.Error);
        }
        #endregion

        private async void tsmiGitOtherInit_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            if (!await GenerateNewGitIgnoreFile()) return;

            StartInfo start = new("git", "init", _currentProject.Folder);

            _processManager.Run(start.Info);

            DisplayLines(_processManager.Output, _processManager.Error);
        }

        private void tsmiGitOtherReset_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            string confirmMsg = "Are you sure you want to reset to your most recent commit?";

            string captionMsg = "Confirm Hard Reset?";

            var confirmReset = MessageBox.Show($"{confirmMsg}", $"{captionMsg}", MessageBoxButtons.YesNo);

            if (confirmReset == DialogResult.Yes)
            {
                StartInfo start = new("git", "reset --hard HEAD", _currentProject.Folder);

                _processManager.Run(start.Info);

                DisplayLines(_processManager.Output, _processManager.Error);
            }
            else return;
        }
        #endregion

        #region TSMI => DOCUMENTATION
        private void tsmiDocumentationExternal_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var itemSelected = e.ClickedItem?.Text;

            if (itemSelected != null)
            {
                StartInfo start = new($"{itemSelected}", "", null, false, false, useShellExecute: true);

                _processManager.Run(start.Info);
            }
        }

        private void tsmiDocumentationInternal_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var itemSelected = e.ClickedItem?.Text;

            if (itemSelected != null)
            {
                DirectoryInfo directoryInfo = new($"{_appDirectory.InternalDir}");
                var internalFiles = directoryInfo.GetFiles();

                string internalFilePath = "";
                foreach (var internalFile in internalFiles)
                {
                    if (internalFile.Name.Split('.')[0] == itemSelected)
                    {
                        internalFilePath = internalFile.FullName;
                    }
                }

                StartInfo start = new($"{internalFilePath}", "", null, false, false, useShellExecute: true);

                _processManager.Run(start.Info);
            }
        }
        #endregion
    }
}
