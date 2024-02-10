using CompanionDomain;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace CompanionFormApp

{
    //tsmi = tool strip menu item
    //txbx = textbox
    //lbl = label
    //lstbx = listbox
    //btn = button
    public partial class MainForm : Form
    {
        const string rootDir = "C:\\ProjectTracking";

        Project currentProject = new();

        public MainForm()
        {
            InitializeComponent();

            if (!Directory.Exists(rootDir))
            {
                Directory.CreateDirectory(rootDir);
            }
        }
        private void PopulateTasks()
        {
            if (currentProject.Tasks.Count == 0) return;

            lstbxProjectTasks.Items.Clear();

            foreach (var task in currentProject.Tasks)
            {
                lstbxProjectTasks.Items.Add(task.Name);
            }
        }

        private void PopulateTaskDetails(CompanionDomain.Task task)
        {
            txbxTaskDescription_display.Text = task.Description;

            lblCurrentTask.Text = $"Task: {task.Name}";

            lblTaskPriorty.Text = $"Priority: {task.Priority}";

            lblTaskType.Text = $"Type: {task.Type}";

            lblDateStart.Text = $"Submission Date: {task.TaskStart.ToShortDateString()}";

            if (task.TaskEnd != DateTime.MinValue)
            {
                lblDateEnd.Text = $"Completion Date: {task.TaskEnd.ToShortDateString()}";
            }
            else
            {
                lblDateEnd.Text = "Completion Date:";
            }

            btnEditTask.Enabled = true;
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

                currentProject = JsonConvert.DeserializeObject<Project>(json);

                lblCurrentProject.Text = $"Project: {currentProject.Name}";

                PopulateTasks();
            }
        }

        private void btnNewTask_clicked(object sender, EventArgs e)
        {
            if (currentProject != null)
            {
                NewTaskForm newTaskForm = new NewTaskForm(currentProject);

                var result = newTaskForm.ShowDialog();

                if (result == DialogResult.Cancel) return;

                currentProject = newTaskForm.CurrentProject;

                PopulateTasks();
            }
            else
            {
                string wrnMessage = "Please select a project";

                MessageBox.Show(wrnMessage);
            }
        }

        private void lstbxProjectTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var taskIndex = lstbxProjectTasks.SelectedIndex;

            var task = currentProject.Tasks[taskIndex];

            PopulateTaskDetails(task);
        }

        private void btnEditTask_clicked(object sender, EventArgs e)
        {
            var taskIndex = lstbxProjectTasks.SelectedIndex;

            EditTaskForm editTaskForm = new EditTaskForm(currentProject, taskIndex);

            var result = editTaskForm.ShowDialog();

            if (result == DialogResult.Cancel) return;

            currentProject = editTaskForm.CurrentProject;

            PopulateTaskDetails(currentProject.Tasks[taskIndex]);
        }

        private void tsmiOpenSolution_clicked(object sender, EventArgs e)
        {
            if (currentProject == null) return;

            var visualStudioDir = "C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe";

            var solutionPath = $@"{currentProject.Solution}";

            Process.Start(visualStudioDir, solutionPath);
        }

        private void tsmiEditProject_clicked(object sender, EventArgs e)
        {
            EditProjectForm editProjectForm = new EditProjectForm(currentProject);

            editProjectForm.ShowDialog();
        }

        private void btnActiveTasks_clicked(object sender, EventArgs e)
        {
            if (currentProject.Tasks.Count == 0) return;

            lstbxProjectTasks.Items.Clear();

            foreach (var task in currentProject.Tasks)
            {
                if (task.Active == true)
                {
                    lstbxProjectTasks.Items.Add(task.Name); 
                }
            }
        }

        private void btnCompletedTasks_clicked(object sender, EventArgs e)
        {
            if (currentProject.Tasks.Count == 0) return;

            lstbxProjectTasks.Items.Clear();

            foreach (var task in currentProject.Tasks)
            {
                if (task.Active == false)
                {
                    lstbxProjectTasks.Items.Add(task.Name);
                }
            }
        }
    }
}
