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
        private void PopulateTasks()
        {
            if (currectProject.Tasks.Count == 0) return;

            lstbxProjectTasks.Items.Clear();

            foreach (var task in currectProject.Tasks)
            {
                lstbxProjectTasks.Items.Add(task.Name);
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



        private void btnNewTask_clicked(object sender, EventArgs e)
        {
            if (currectProject != null)
            {
                NewTaskForm newTaskForm = new NewTaskForm(currectProject);

                var result = newTaskForm.ShowDialog();

                if (result == DialogResult.Cancel) return;

                currectProject = newTaskForm.Project;

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

            var task = currectProject.Tasks[taskIndex];

            txbxTaskDescription_display.Text = task.Description;

            lblCurrentTask.Text = $@"Task: {task.Name}";

            lblTaskPriorty.Text = $@"Priority: {task.Priority}";

            lblTaskType.Text = $@"Type: {task.Type}";

            lblDateStart.Text = $@"Submission Date: {task.TaskStart.ToShortDateString()}";

            if (task.TaskEnd != DateTime.MinValue)
            {
                lblDateEnd.Text = $@"Completion Date: {task.TaskEnd.ToShortDateString()}";
            }

            btnEditTask.Enabled = true;
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            ComboBox taskPriority = new ComboBox();
            ComboBox taskType = new ComboBox();
            TextBox taskName = new TextBox();

            var taskIndex = lstbxProjectTasks.SelectedIndex;

            taskPriority.Location = lblTaskPriorty.Location;
            taskPriority.DataSource = Enum.GetValues(typeof(TaskPriority));

            taskType.Location = lblTaskType.Location;
            taskType.DataSource = Enum.GetValues(typeof(TaskType));

            taskName.Location = lblCurrentTask.Location;
            taskName.Text = lblCurrentTask.Text.Split(':')[1].Trim();

            this.Controls.Add(taskPriority);
            this.Controls.Add(taskType);
            this.Controls.Add(taskName);

            this.Controls.Remove(lblTaskPriorty);
            this.Controls.Remove(lblTaskType);
            this.Controls.Remove(lblCurrentTask);

            taskPriority.SelectedIndex = (int)currectProject.Tasks[taskIndex].Priority;
            taskType.SelectedIndex = (int)currectProject.Tasks[taskIndex].Type;

            txbxTaskDescription_display.ReadOnly = false;

            chckbxTaskComplete.Visible = true;

            btnSaveTaskEdit.Visible = true;
        }

        private void btnSaveTaskEdit_Click(object sender, EventArgs e)
        {
            var task = (CompanionDomain.Task)sender;

            var x = task.Name;
        }
    }
}
