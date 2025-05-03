using CompanionDomain.Interfaces;
using CompanionDomain.Objects;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.Edit
{
    public partial class EditProjectForm : Form
    {
        public Project CurrentProject { get; set;}

        private readonly PathBuilder _pathBuilder;

        private readonly IProjectManager _projectManager;

        public EditProjectForm(Project project, IProjectManager projectManager, PathBuilder pathBuilder)
        {
            InitializeComponent();

            _projectManager = projectManager;

            _pathBuilder = pathBuilder;

            CurrentProject = project;

            txbxProjectName.Text = CurrentProject.Name;

            txbxBrowseFolders.Text = CurrentProject.Folder;

            txbxSelectSolution.Text = CurrentProject.Solution;
        }

        private void btnBrowseFolders_clicked(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;

                txbxBrowseFolders.Text = selectedPath;

                CurrentProject.Folder = selectedPath;
            }
        }

        private void btnSelectSolution_clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txbxSelectSolution.Text = openFileDialog.FileName;

                CurrentProject.Solution = openFileDialog.FileName;
            }
        }

        private void btnSubmitEdit_clicked(object sender, EventArgs e)
        {
            _projectManager.Delete(CurrentProject, _pathBuilder);

            if (File.Exists($@"{_pathBuilder.AppDirectory.RootDir}\{txbxProjectName.Text}.txt"))
            {
                var warningMsg = "This project name already exists. Please try again";

                MessageBox.Show(warningMsg);
            }
            else
            {
                CurrentProject.Name = txbxProjectName.Text;

                CurrentProject.Folder = txbxBrowseFolders.Text;

                CurrentProject.Solution = txbxSelectSolution.Text;

                _projectManager.Save(CurrentProject, _pathBuilder);

                Close();

                Dispose();
            }
        }
    }
}
