using Newtonsoft.Json;
using CompanionDomain;

namespace CompanionFormApp
{
    //btn = button
    //txbx = textbox

    public partial class NewProjectForm : Form
    {
        private Project NewProject = new();

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

                NewProject.Folder = selectedPath;
            }
        }

        private void btnSelectSolution_clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                NewProject.Solution = openFileDialog.FileName;

                txbxSelectedSolution.Text = openFileDialog.FileName;
            }
        }

        private void btnAcceptNewProject_clicked(object sender, EventArgs e)
        {
            NewProject.Name = txbxProjectName.Text;

            if (File.Exists($@"C:\ProjectTracking\{NewProject.Name}.txt"))
            {
                var warningMsg = "This project name already exists. Please try again";

                MessageBox.Show(warningMsg);
            }
            else
            {
                Project.SaveProject(NewProject);

                Close();
            }
        }
    }
}
