using CompanionDomain.Interfaces;
using CompanionDomain.Objects;

#pragma warning disable IDE1006 // Naming Styles

namespace CompanionFormApp.New;

//btn = button
//txbx = textbox

public partial class NewProjectForm : Form
{
    private readonly Project _newProject = new();

    private readonly AppDirectory _appDirectory = new();

    public string ProjectName = "";

    private readonly IProjectManager _projectManager;

    public NewProjectForm(IProjectManager projectManager)
    {
        InitializeComponent();

        _projectManager = projectManager;
    }

    private void btnBrowseFolders_Clicked(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new()
        {
            InitialDirectory = _appDirectory.PortfolioDir
        };

        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            string selectedPath = folderBrowserDialog.SelectedPath;

            txbxSelectedFolder.Text = selectedPath;

            _newProject.Folder = selectedPath;
        }
    }

    private void btnSelectSolution_Clicked(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new();

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _newProject.Solution = openFileDialog.FileName;

            txbxSelectedSolution.Text = openFileDialog.FileName;
        }
    }

    private void btnAcceptNewProject_Clicked(object sender, EventArgs e)
    {
        _newProject.Name = txbxProjectName.Text;

        if (File.Exists($@"C:\ProjectTracking\{_newProject.Name}.txt"))
        {
            var warningMsg = "This project name already exists. Please try again";

            MessageBox.Show(warningMsg);

            return;
        }
        else
        {
            ProjectName = _newProject.Name;

            _projectManager.Save(_newProject);

            Close();

            Dispose();

            this.DialogResult = DialogResult.Yes;
        }
    }
}
