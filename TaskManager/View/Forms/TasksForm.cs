using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskManager.Data.Controllers;

namespace TaskManager.View.Forms
{
    public partial class TasksForm : Form
    {

        public TasksForm()
        {
            InitializeComponent();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            TaskController taskController = new TaskController();
            TaskFlowPanel.Controls.Add(taskController);
        }
    }
}
