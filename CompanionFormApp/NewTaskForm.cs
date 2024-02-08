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
    public partial class NewTaskForm : Form
    {
        public event Action<Project>? OnProjectUpdated;
        private Project _project;
        private CompanionDomain.Task _task = new();
        public NewTaskForm(Project project)
        {
            InitializeComponent();

            _project = project;
        }

        private void btnSubmitNewTask_clicked(object sender, EventArgs e)
        {
            _task.Name = txbxTaskName.Text;

            _task.Description = txbxTaskDescription.Text;

            _task.Priority = (TaskPriority)cmbbxTaskPriority.SelectedItem;

            _task.Type = (TaskType)cmbbxTaskType.SelectedItem;

            _task.TaskStart = DateTime.Now;

            _project.Tasks.Add(_task);

            OnProjectUpdated?.Invoke(_project);

            Close();
        }
    }
}
