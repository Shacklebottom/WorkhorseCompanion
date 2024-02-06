using CompanionDomain;
using Newtonsoft.Json;

namespace CompanionFormApp

{
    //tsmi = tool strip menu item
    public partial class MainForm : Form
    {
        const string rootDir = "C:\\ProjectTracking";

        Project currectProject = new Project();

        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(rootDir))
            {
                Directory.CreateDirectory(rootDir);
            }
        }

        private void tsmiAddProject_clicked(object sender, EventArgs e)
        {
            NewProjectForm newProjectForm = new NewProjectForm();

            newProjectForm.ShowDialog();
        }

        private void tsmiSelectProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.InitialDirectory = rootDir;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                string json = File.ReadAllText(selectedFile);

                currectProject = JsonConvert.DeserializeObject<Project>(json);

                lblCurrentProject.Text = $@"Project: {currectProject.Name}";
            }
        }
    }
}
