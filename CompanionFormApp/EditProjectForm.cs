using CompanionDomain;

namespace CompanionFormApp
{
    public partial class EditProjectForm : Form
    {
        public Project CurrentProject { get; set;}

        private readonly AppDirectory _appDirectory = new();

        public EditProjectForm(Project project)
        {
            InitializeComponent();

            CurrentProject = project;

            txbxProjectName.Text = CurrentProject.Name;

            txbxBrowseFolders.Text = CurrentProject.Folder;

            txbxSelectSolution.Text = CurrentProject.Solution;
        }

        private void btnBrowseFolders_clicked(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;

                txbxBrowseFolders.Text = selectedPath;

                CurrentProject.Folder = selectedPath;
            }
        }

        private void btnSelectSolution_clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txbxSelectSolution.Text = openFileDialog.FileName;

                CurrentProject.Solution = openFileDialog.FileName;
            }
        }

        private void btnSubmitEdit_clicked(object sender, EventArgs e)
        {
            Project.DeleteProject(CurrentProject);

            if (File.Exists($@"{_appDirectory.RootDir}\{txbxProjectName.Text}.txt"))
            {
                var warningMsg = "This project name already exists. Please try again";

                MessageBox.Show(warningMsg);
            }
            else
            {
                CurrentProject.Name = txbxProjectName.Text;

                CurrentProject.Folder = txbxBrowseFolders.Text;

                CurrentProject.Solution = txbxSelectSolution.Text;

                Project.SaveProject(CurrentProject);

                Close();
            }
        }
    }
}
