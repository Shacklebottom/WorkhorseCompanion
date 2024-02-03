using Newtonsoft.Json;
using CompanionDomain;

namespace CompanionFormApp
{
    public partial class NewProjectForm : Form
    {
        Project _project = new();
        public NewProjectForm()
        {
            InitializeComponent();
        }

        private void btn_BrowseFolders_clicked(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                txbxSelectedFolder.Text = selectedPath;
                _project.Folder = selectedPath;
            }
        }

        private void btnAcceptNewProject_Click(object sender, EventArgs e)
        {
            _project.Name = txbxProjectName.Text;

            var projString = JsonConvert.SerializeObject(_project);

            if (File.Exists($@"C:\ProjectTracking\{_project.Name}"))
            {
                var warningMsg = "This project name already exists. Please try again";

                MessageBox.Show(warningMsg);

            } else
            {
                File.WriteAllText($@"C:\ProjectTracking\{_project.Name}", projString);

                Close();
            }
        }
    }
}
