using CompanionDomain;
using Newtonsoft.Json;
using System.Diagnostics;

namespace RefactoredFormApp
{
    public partial class GitWrapperForm : Form
    {
        AppDirectory _appDirectory = new AppDirectory();

        Project _currentProject = new Project();

        public GitWrapperForm()
        {
            InitializeComponent();

            PopulateRecentProjects();
        }

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
        
        #region TSMI => NEW
        private void tsmiNewProject_clicked(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new NewProjectForm();

            newProjectForm.ShowDialog();
        }
        #endregion


        #region TSMI => OPEN
        private void tsmiOpenProject_clicked(object sender, EventArgs e)
        {

            //tsmiOpen.HideDropDown();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = _appDirectory.RootDir;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                string json = File.ReadAllText(selectedFile);

                _currentProject = JsonConvert.DeserializeObject<Project>(json) ?? throw new Exception("Project JSON was null");

                lblCurrentProject.Text = $"Project: {_currentProject?.Name}";

                _appDirectory = new AppDirectory(_currentProject);
            }
        }

        private void tsmiOpenProject_DropDownItem_clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DirectoryInfo directoryInfo = new($"{_appDirectory.RootDir}");

            var projectFiles = directoryInfo.GetFiles();

            var selectedProject = e.ClickedItem?.Text;

            string projectFilePath = string.Empty;

            foreach (var projectFile in projectFiles)
            {
                if (projectFile.Name.Split('.')[0] == selectedProject)
                {
                    projectFilePath = projectFile.FullName;
                }
            }

            string json = File.ReadAllText(projectFilePath);

            _currentProject = JsonConvert.DeserializeObject<Project>(json) ?? throw new Exception("Project JSON was null");

            lblCurrentProject.Text = $"Project: {_currentProject?.Name}";

            _appDirectory = new AppDirectory(_currentProject);
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
        #endregion


    }
}
