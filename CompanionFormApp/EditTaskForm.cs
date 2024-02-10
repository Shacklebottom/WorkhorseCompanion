using CompanionDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanionFormApp
{
    public partial class EditTaskForm : Form
    {
        public Project CurrentProject;

        private CompanionDomain.Task _task = new();

        private int _taskID;

        public EditTaskForm(Project project, int taskIndex)
        {
            InitializeComponent();

            cmbobxTaskPriority.DataSource = Enum.GetValues(typeof(TaskPriority));
            
            cmbobxTaskType.DataSource = Enum.GetValues(typeof(TaskType));

            CurrentProject = project;

            _taskID = taskIndex;

            _task = CurrentProject.Tasks[_taskID];

            txbxTaskName.Text = _task.Name;

            txbxTaskDescription.Text = _task.Description;

            cmbobxTaskPriority.SelectedIndex = (int)_task.Priority;

            cmbobxTaskType.SelectedIndex = (int)_task.Type;

            chkbxTaskCompleted.Checked = !_task.Active;
        }

        private void btnSubmitTaskEdit_clicked(object sender, EventArgs e)
        {
            _task.Name = txbxTaskName.Text;

            _task.Description = txbxTaskDescription.Text;
            
            _task.Priority = (TaskPriority)cmbobxTaskPriority.SelectedIndex;
            
            _task.Type = (TaskType)cmbobxTaskType.SelectedItem;

            _task.Active = !chkbxTaskCompleted.Checked;

            if (!_task.Active) 
            {
                _task.TaskEnd = DateTime.Now;
            }
            else
            {
                _task.TaskEnd = DateTime.MinValue;
            }

            CurrentProject.Tasks[_taskID] = _task;

            Project.SaveProject(CurrentProject);

            Close();
        }
    }
}
