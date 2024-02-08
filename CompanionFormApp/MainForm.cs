using CompanionDomain;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace CompanionFormApp

{
    //tsmi = tool strip menu item
    public partial class MainForm : Form
    {
        const string rootDir = "C:\\ProjectTracking";

        Project? currectProject = null;

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

        private void tsmiSelectProject_clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = rootDir;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                string json = File.ReadAllText(selectedFile);

                currectProject = JsonConvert.DeserializeObject<Project>(json);

                lblCurrentProject.Text = $@"Project: {currectProject.Name}";
                PopulateTasks();
            }
        }

        private void PopulateTasks()
        {
            if (currectProject.Tasks.Count == 0) { return; }

            lstbxProjectTasks.Items.Clear();

            foreach (var task in currectProject.Tasks)
            {
                lstbxProjectTasks.Items.Add(task.Name);
            }
        }

        private void btnNewTask_clicked(object sender, EventArgs e)
        {
            if (currectProject != null)
            {
                NewTaskForm newTaskForm = new NewTaskForm(currectProject);

                newTaskForm.OnProjectUpdated += UpdateProject;

                newTaskForm.OnProjectUpdated += SaveProject;

                newTaskForm.ShowDialog();
            }
            else
            {
                string wrnMessage = "Please select a project";

                MessageBox.Show(wrnMessage);
            }
        }

        private void UpdateProject(Project project)
        {
            currectProject = project;

            PopulateTasks();
        }

        private void SaveProject(Project project)
        {
            string json = JsonConvert.SerializeObject(project);

            File.WriteAllText($@"C:\ProjectTracking\{project.Name}.txt", json);
        }
    }
}
