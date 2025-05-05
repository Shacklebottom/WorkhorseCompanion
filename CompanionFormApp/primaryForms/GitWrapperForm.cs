using CompanionFormApp.New;
using CompanionFormApp.Edit;
using CompanionFormApp.Git;
using CompanionFormApp.FormSupport;
using CompanionDomain.Objects;
using CompanionDomain.Interfaces;
using System.Diagnostics;
using CompanionDomain.CommandObjs;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.PrimaryForms
{
    public partial class GitWrapperForm : Form
    {
        private readonly IProcessManager _processManager;
        private readonly IProjectManager _projectManager;
        private readonly PathConfig _pathConfig = new();
        private PathBuilder _pathBuilder;
        private readonly DirectoryHandler _directoryHandler = new();
        private DirectoryInitializer _directoryInitializer;
        private Project _currentProject = new();
        private TicketSystemForm? _ticketSystemForm;
        private JournalSystemForm? _journalSystemForm;

        //Constructor
        public GitWrapperForm(IProcessManager processManager, IProjectManager projectManager)
        {
            InitializeComponent();

            GitWrapperMenuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomToolStripColorTable());

            _processManager = processManager;
            _projectManager = projectManager;
            _pathBuilder = new PathBuilder(_pathConfig);
            _directoryInitializer = new DirectoryInitializer(_pathBuilder, _directoryHandler);

            this.Load += GitWrapperForm_Load;
        }



        #region POPULATE UI ELEMENTS
        private async void GitWrapperForm_Load(object? sender, EventArgs e)
        {
            await _directoryInitializer.InitializeAsync(_currentProject);
            PopulateRecentProjects();
            PopulateDocumentation();
        }

        private void PopulateRecentProjects()
        {
            tsmiOpenProject.DropDownItems.Clear();

            DirectoryInfo directoryInfo = new($"{_pathBuilder.AppDirectory.RootDir}");

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

            DirectoryInfo directoryInfo = new($"{_pathBuilder.AppDirectory.InternalDir}");
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

            var externalDocumentation = File.ReadAllLines(_pathBuilder.AppDirectory.CombinedExternalDir);

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
            tsmiResourceImages.DropDownItems.Clear();
            tsmiResourceWebsites.DropDownItems.Clear();
            tsmiResourceDocuments.DropDownItems.Clear();

            DirectoryInfo imageDirectoryInfo = new(_pathBuilder.ImgDir);
            var imageFiles = imageDirectoryInfo.GetFiles();

            foreach (var image in imageFiles)
            {
                ToolStripMenuItem tsmi = new(image.Name)
                {
                    BackColor = Color.LemonChiffon
                };

                tsmiResourceImages.DropDownItems.Add(tsmi);
            }

            var externalWebsites = File.ReadAllLines(_pathBuilder.CombinedWebDir);

            foreach (var website in externalWebsites)
            {
                ToolStripMenuItem tsmi = new(website)
                {
                    BackColor = Color.LemonChiffon
                };

                tsmiResourceWebsites.DropDownItems.Add(tsmi);
            }

            DirectoryInfo documentDirectoryInfo = new(_pathBuilder.DocDir);
            var documentFiles = documentDirectoryInfo.GetFiles();

            foreach (var document in documentFiles)
            {
                ToolStripMenuItem tsmi = new(document.Name)
                {
                    BackColor = Color.LemonChiffon
                };

                tsmiResourceDocuments.DropDownItems.Add(tsmi);
            }
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
            txbxOutput_display.Text = string.Empty;
            if (!string.IsNullOrWhiteSpace(output))
            {
                txbxOutput_display.Lines = output.Split('\n');
            }

            if (!string.IsNullOrWhiteSpace(error))
            {
                txbxOutput_display.Lines = error.Split('\n');
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
            NewSolutionForm newSolutionForm = new(_pathBuilder);
            if (newSolutionForm.ShowDialog() == DialogResult.Yes)
            {
                txbxOutput_display.Text = $"A new solution ({newSolutionForm.SanitizedName}) was created!";
            }
        }

        private void tsmiNewProject_Clicked(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new(_projectManager, _pathBuilder);
            if (newProjectForm.ShowDialog() == DialogResult.Yes)
            {
                txbxOutput_display.Text = $"A new project ({newProjectForm.ProjectName}) was created!";
            }
            PopulateRecentProjects();
        }

        private void tsmiNewDocumentation_Clicked(object sender, EventArgs e)
        {
            NewDocumentationForm newDocumentationForm = new(_pathBuilder);
            if (newDocumentationForm.ShowDialog() == DialogResult.Yes)
            {
                txbxOutput_display.Text = "New documentation was added to the catalog!";
            }

            PopulateDocumentation();
        }

        private void tsmiNewResource_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) { return; }

            NewResourceForm newResourceForm = new(_pathBuilder);
            if (newResourceForm.ShowDialog() == DialogResult.Yes)
            {
                txbxOutput_display.Text = $"A new project {newResourceForm.ResourceCategory} was added to the catalog";
            }

            PopulateProjectResources();
        }
        #endregion

        #region TSMI => OPEN
        private async void tsmiOpenProject_Clicked(object sender, EventArgs e)
        {
            //when Open => Project is clicked we:

            //instantiate a new OpenFileDialog obj and set the directory it opens to (InitialDirectory) to the Companion's root directory
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = _pathBuilder.AppDirectory.RootDir
            };

            //we then hide the Project DropDown menu, otherwise it will clip through the OpenFileDialog UI window that appears "on top" of it
            tsmiOpen.HideDropDown();

            //we show a new OpenFileDialog UI window.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //user selects a project file, and
                string selectedFile = openFileDialog.FileName;

                //we read the file and then deserialize it into a Project obj using JsonConvert
                _currentProject = _projectManager.Load(selectedFile);

                //then finally, we update the UI to show the current project name and set our AppDirectory and TicketSystemForm objs to the current project
                txbxCurrentProject.Text = $"Project: {_currentProject?.Name}";
                _pathBuilder = new PathBuilder(_pathConfig, _currentProject);
                _directoryInitializer = new DirectoryInitializer(_pathBuilder, _directoryHandler);
                if (_currentProject != null) await _directoryInitializer.InitializeAsync(_currentProject);
                _ticketSystemForm = new TicketSystemForm(this, _currentProject, _projectManager, _pathBuilder);
                _journalSystemForm = new JournalSystemForm(this, _processManager, _currentProject, _projectManager, _pathBuilder);
                PopulateProjectResources();

                txbxOutput_display.Text = $"The project {_currentProject?.Name} was loaded";
            }
        }

        private async void tsmiOpenProject_DropDownItem_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //user selects an item from the prepopulated dropdown list.
            var selectedProject = e.ClickedItem?.Text;

            //we instantiate a new DirectoryInfo obj and then get the files in that directory
            DirectoryInfo directoryInfo = new($"{_pathBuilder.AppDirectory.RootDir}");
            var projectFiles = directoryInfo.GetFiles();

            //of the files we got, we match the file with the item the user selected
            string projectFilePath = projectFiles.First(file => file.Name.Split('.')[0] == selectedProject).FullName;

            //we read the file and then deserialize it into a Project obj using JsonConvert
            _currentProject = _projectManager.Load(projectFilePath);

            //then finally, we update the UI to show the current project name and set our AppDirectory and TicketSystemForm objs to the current project
            txbxCurrentProject.Text = $"Project: {_currentProject?.Name}";


            _pathBuilder = new PathBuilder(_pathConfig, _currentProject);
            _directoryInitializer = new DirectoryInitializer(_pathBuilder, _directoryHandler);
            if (_currentProject != null) await _directoryInitializer.InitializeAsync(_currentProject);
            _ticketSystemForm = new TicketSystemForm(this, _currentProject, _projectManager, _pathBuilder);
            _journalSystemForm = new JournalSystemForm(this, _processManager, _currentProject, _projectManager, _pathBuilder);
            PopulateProjectResources();

            txbxOutput_display.Text = $"The project {_currentProject?.Name} was loaded.";
        }

        #region OPEN FOLDER
        private void tsmiOpenFolderThisProject_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) { return; }

            txbxOutput_display.Text = "Opening the project's folder.";

            StartInfo start = new("explorer.exe", $"{_currentProject.Folder}", null);
            _processManager.Run(start.Info);
        }

        private void tsmiOpenFolderProjectTracking_Clicked(object sender, EventArgs e)
        {
            txbxOutput_display.Text = "Opening the Project Tracking folder.";

            StartInfo start = new("explorer.exe", $"{_pathBuilder.AppDirectory.RootDir}", null);
            _processManager.Run(start.Info);
        }

        private void tsmiOpenFolderCodePortfolio_Clicked(object sender, EventArgs e)
        {
            txbxOutput_display.Text = "Opening the Code Portfolio folder.";

            StartInfo start = new("explorer.exe", $"{_pathBuilder.AppDirectory.PortfolioDir}", null);
            _processManager.Run(start.Info);
        }

        private void tsmiOpenFolderCodeLibrary_Clicked(object sender, EventArgs e)
        {
            txbxOutput_display.Text = "Opening the Code Library folder.";

            StartInfo start = new("explorer.exe", $"{_pathBuilder.AppDirectory.LibraryDir}", null);
            _processManager.Run(start.Info);
        }
        #endregion

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

            txbxOutput_display.Text = "Opening the project's Solution.";

            //The static method: Process.Start spawns a Process object that doesn't block the application.
            //If the object method is used instead, Visual Studio takes too long and the application becomes unresponsive.
            StartInfo start = new(visualStudioDir, solutionPath, null);
            Process.Start(start.Info);
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

            EditProjectForm editProjectForm = new(_currentProject, _projectManager, _pathBuilder);
            editProjectForm.ShowDialog();

            txbxOutput_display.Text = $"The project: {_currentProject.Name} was updated.";
            txbxCurrentProject.Text = $"Project: {_currentProject?.Name}";
        }
        #endregion

        #region TSMI => GIT
        private void tsmiGitBash_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            GitBashCommand gitBash = new(_currentProject, _processManager, DisplayLines);
            gitBash.Execute();
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

            GitStatusCommand gitStatus = new(_currentProject, _processManager, DisplayLines);
            gitStatus.Execute();
        }

        #region ===>GIT BRANCH<===
        private void tsmiGitBranch_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            GitBranchCommand gitBranch = new(_currentProject, _processManager, DisplayLines);
            gitBranch.Execute();
        }

        private void tsmiGitBranch_DropDownOpening(object sender, EventArgs e)
        {
            if (_currentProject.Folder == string.Empty) return;

            GitBranchCommand gitBranch = new(_currentProject, _processManager);
            gitBranch.Execute();

            tsmiGitBranch.DropDownItems.Clear();
            var branches = gitBranch.Branches;
            branches.ForEach(b =>
            {
                if (b != string.Empty)
                {
                    ToolStripMenuItem tsmi = new(b)
                    {
                        BackColor = Color.LemonChiffon
                    };

                    tsmiGitBranch.DropDownItems.Add(tsmi);
                }
            });
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

            GitCheckoutCommand gitCheckout = new(_currentProject, _processManager, DisplayLines, selectedBranch);
            gitCheckout.Execute();
        }
        #endregion

        private async void tsmiGitOtherInit_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;
            if (!await GenerateNewGitIgnoreFile()) return;

            GitInitCommand gitInit = new(_currentProject, _processManager, DisplayLines);
            gitInit.Execute();
        }

        private void tsmiGitOtherReset_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            string confirmMsg = "Are you sure you want to reset to your most recent commit?";
            string captionMsg = "Confirm Hard Reset?";
            var confirmReset = MessageBox.Show($"{confirmMsg}", $"{captionMsg}", MessageBoxButtons.YesNo);

            if (confirmReset == DialogResult.Yes)
            {
                GitResetCommand gitReset = new(_currentProject, _processManager, DisplayLines);
                gitReset.Execute();
            }
            else return;
        }
        #endregion

        #region TSMI => DOCUMENTATION
        private void tsmiDocumentationExternal_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var selectedItem = e.ClickedItem?.Text;

            if (selectedItem != null)
            {
                txbxOutput_display.Text = $"{selectedItem} is being opened [...]";

                StartInfo start = new($"{selectedItem}", "", null, false, false, useShellExecute: true);
                _processManager.Run(start.Info);
            }
        }

        private void tsmiDocumentationInternal_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var selectedItem = e.ClickedItem?.Text;

            if (selectedItem != null)
            {
                DirectoryInfo directoryInfo = new($"{_pathBuilder.AppDirectory.InternalDir}");
                var internalFiles = directoryInfo.GetFiles();

                string internalFilePath = internalFiles.First(file => file.Name.Split('.')[0] == selectedItem).FullName;

                txbxOutput_display.Text = $"{selectedItem} is being opened [...]";

                StartInfo start = new($"{internalFilePath}", "", null, false, false, useShellExecute: true);
                _processManager.Run(start.Info);
            }
        }
        #endregion

        #region TSMI => RESOURCE
        private void tsmiResourceImages_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var selectedItem = e.ClickedItem?.Text;

            if (selectedItem != null)
            {
                DirectoryInfo directoryInfo = new(_pathBuilder.ImgDir);
                var imageFiles = directoryInfo.GetFiles();

                string imageFilePath = imageFiles.First(file => file.Name == selectedItem).FullName;

                txbxOutput_display.Text = $"{selectedItem} is being opened [...]";

                StartInfo start = new($"{imageFilePath}", "", null, false, false, useShellExecute: true);
                _processManager.Run(start.Info);
            }
        }

        private void tsmiResourceWebsites_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var selectedItem = e.ClickedItem?.Text;

            if (selectedItem != null)
            {
                txbxOutput_display.Text = $"{selectedItem} is being opened [...]";

                StartInfo start = new($"{selectedItem}", "", null, false, false, useShellExecute: true);
                _processManager.Run(start.Info);
            }
        }

        private void tsmiResourceDocuments_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var selectedItem = e.ClickedItem?.Text;

            if (selectedItem != null)
            {
                DirectoryInfo directoryInfo = new(_pathBuilder.DocDir);
                var documentFiles = directoryInfo.GetFiles();

                string documentFilePath = documentFiles.First(file => file.Name == selectedItem).FullName;

                txbxOutput_display.Text = $"{selectedItem} is being opened [...]";

                StartInfo start = new($"{documentFilePath}", "", null, false, false, useShellExecute: true);
                _processManager.Run(start.Info);
            }
        }
        #endregion
    }
}
