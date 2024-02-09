﻿using CompanionDomain;
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
        public Project CurrentProject;

        private CompanionDomain.Task _task = new();

        public NewTaskForm(Project project)
        {
            InitializeComponent();

            cmbbxTaskPriority.DataSource = Enum.GetValues(typeof(TaskPriority));
            
            cmbbxTaskType.DataSource = Enum.GetValues(typeof(TaskType));

            CurrentProject = project;
        }

        private void btnSubmitNewTask_clicked(object sender, EventArgs e)
        {
            _task.Name = txbxTaskName.Text;

            _task.Description = txbxTaskDescription_capture.Text;

            _task.Priority = (TaskPriority)cmbbxTaskPriority.SelectedItem;

            _task.Type = (TaskType)cmbbxTaskType.SelectedItem;

            _task.TaskStart = DateTime.Now;

            CurrentProject.Tasks.Add(_task);

            Project.SaveProject(CurrentProject);

            Close();
        }
    }
}
