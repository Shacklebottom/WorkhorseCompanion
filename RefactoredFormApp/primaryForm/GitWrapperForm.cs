using CompanionBusiness;
using CompanionDomain;
using Newtonsoft.Json;
using System.Diagnostics;

namespace RefactoredFormApp
{
    public partial class GitWrapperForm : Form
    {
        private readonly IProcessManager _processManager;

        private AppDirectory _appDirectory = new AppDirectory();

        private Project _currentProject = new Project();

        //Constructor
        public GitWrapperForm(IProcessManager manager)
        {
            InitializeComponent();

            _processManager = manager;

            PopulateRecentProjects();
        }

        #region POPULATE UI ELEMENTS
        private void PopulateRecentProjects()
        {
            DirectoryInfo directoryInfo = new($"{_appDirectory.RootDir}");

            var projectFiles = directoryInfo.GetFiles();

            var sortedProjectsFiles = projectFiles.OrderByDescending(file => file.Name).ToList();

            foreach (var project in sortedProjectsFiles)
            {
                tsmiOpenProject.DropDownItems.Add(project.Name.Split('.')[0]);
            }
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
        #endregion

        #region COMMAND LINE
        private void txbxCommandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (DisplayNoSelectedProject())
                {
                    txbxCommandLine_input.Text = string.Empty;

                    Focus();

                    return;
                }

                e.Handled = true;

                string[] segments = txbxCommandLine_input.Text.Split(" ");

                var fileName = segments[0];

                var args = string.Join(" ", segments.Skip(1));

                ProcessStartInfo startInfo = new()
                {
                    FileName = fileName,
                    Arguments = args,
                    CreateNoWindow = true
                };

                _processManager.Run(startInfo);

                DisplayLines(_processManager.Output, _processManager.Error);

                txbxCommandLine_input.Text = string.Empty;

                Focus();
            }
        }
        #endregion

        #region TSMI => NEW
        private void tsmiNewProject_Clicked(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new();

            newProjectForm.ShowDialog();
        }
        #endregion

        #region TSMI => OPEN
        private void tsmiOpenProject_Clicked(object sender, EventArgs e)
        {
            //when Open => Project is clicked we:

            //instantiate a new OpenFileDialog obj and set the directory it opens to (InitialDirectory) to the Companion's root directory
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = _appDirectory.RootDir;

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

                //then finally, we update the UI to show the current project name and set our AppDirectory obj to the current project
                txbxCurrentProject.Text = $"Project: {_currentProject?.Name}";
                _appDirectory = new AppDirectory(_currentProject);
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

            //then finally, we update the UI to show the current project name and set our AppDirectory obj to the current project
            txbxCurrentProject.Text = $"Project: {_currentProject?.Name}";
            _appDirectory = new AppDirectory(_currentProject);
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

            ProcessStartInfo startInfo = new()
            {
                FileName = "C:\\Program Files\\Git\\git-bash.exe",
                WorkingDirectory = _currentProject.Folder
            };

            _processManager.Run(startInfo, true);
        }

        private void tsmiGitCommit_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            GitCommitForm gitCommitForm = new GitCommitForm(_currentProject, _processManager);

            gitCommitForm.ShowDialog();

            DisplayLines(gitCommitForm.Output, gitCommitForm.Error);
        }

        private void tsmiGitStatus_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = "status",
                WorkingDirectory = _currentProject.Folder,
                CreateNoWindow = true
            };

            _processManager.Run(startInfo);

            DisplayLines(_processManager.Output, _processManager.Error);
        }

        #region ===>GIT BRANCH<===
        private void tsmiGitBranch_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            //tsmiGitBranch.HideDropDown();

            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = "branch",
                CreateNoWindow = true
            };

            _processManager.Run(startInfo);

            DisplayLines(_processManager.Output, _processManager.Error);
        }

        private void tsmiGitBranch_DropDownOpening(object sender, EventArgs e)
        {
            if (_currentProject.Folder == null) return;

            tsmiGitBranch.DropDownItems.Clear();

            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = "branch",
                CreateNoWindow = true
            };

            _processManager.Run(startInfo);

            var branches = _processManager.Output.Split("\n");

            foreach (var branch in branches)
            {
                if (branch != string.Empty)
                {
                    tsmiGitBranch.DropDownItems.Add(branch);
                }
            }
        }

        private void tsmiGitBranch_DropDownItem_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string? selectedBranch = e.ClickedItem?.Text;

            string warningMsg = "Please select a branch you haven't already checked out";

            if (selectedBranch == null || selectedBranch.Contains('*'))
            {
                MessageBox.Show(warningMsg);

                return;
            }

            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = $"checkout {selectedBranch}",
            };

            _processManager.Run(startInfo);

            DisplayLines(_processManager.Output, _processManager.Error);
        }
        #endregion

        private async void tsmiGitOtherInit_Clicked(object sender, EventArgs e)
        {
            if (DisplayNoSelectedProject()) return;

            if (!await GenerateNewGitIgnoreFile()) return;

            ProcessStartInfo startInfo = new()
            {
                FileName = "git",
                Arguments = "init",
                CreateNoWindow = true
            };

            _processManager.Run(startInfo);

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
                ProcessStartInfo startInfo = new()
                {
                    FileName = "git",
                    Arguments = "reset --hard HEAD",
                    CreateNoWindow = true
                };

                _processManager.Run(startInfo);

                DisplayLines(_processManager.Output, _processManager.Error);
            }
            else return;
        }

        #endregion
    }
}
