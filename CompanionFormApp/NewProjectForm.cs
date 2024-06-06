using CompanionDomain;

namespace RefactoredFormApp
{
    //btn = button
    //txbx = textbox

    public partial class NewProjectForm : Form
    {
        private readonly Project _newProject = new();

        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void btnBrowseFolders_clicked(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;

                txbxSelectedFolder.Text = selectedPath;

                _newProject.Folder = selectedPath;
            }
        }

        private void btnSelectSolution_clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _newProject.Solution = openFileDialog.FileName;

                txbxSelectedSolution.Text = openFileDialog.FileName;
            }
        }

        private void btnAcceptNewProject_clicked(object sender, EventArgs e)
        {
            _newProject.Name = txbxProjectName.Text;

            if (File.Exists($@"C:\ProjectTracking\{_newProject.Name}.txt"))
            {
                var warningMsg = "This project name already exists. Please try again";

                MessageBox.Show(warningMsg);
            }
            else
            {
                Project.SaveProject(_newProject);

                Close();
            }
        }
    }
}
