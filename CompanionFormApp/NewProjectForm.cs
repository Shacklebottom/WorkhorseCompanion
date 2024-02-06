using Newtonsoft.Json;
using CompanionDomain;

namespace CompanionFormApp
{
    //btn = button
    //txbx = textbox

    public partial class NewProjectForm : Form
    {
        Project _project = new();

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

                _project.Folder = selectedPath;
            }
        }

        private void btnSelectSolution_clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _project.Solution = openFileDialog.FileName;

                txbxSelectedSolution.Text = openFileDialog.FileName;
            }
        }

        private void btnAcceptNewProject_Click(object sender, EventArgs e)
        {
            _project.Name = txbxProjectName.Text;

            var projString = JsonConvert.SerializeObject(_project);

            if (File.Exists($@"C:\ProjectTracking\{_project.Name}.txt"))
            {
                var warningMsg = "This project name already exists. Please try again";

                MessageBox.Show(warningMsg);
            }
            else
            {
                File.WriteAllText($@"C:\ProjectTracking\{_project.Name}.txt", projString);

                Close();
            }
        }


    }
}
