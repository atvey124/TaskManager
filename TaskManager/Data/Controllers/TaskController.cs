using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManager.Data.Controllers
{
    public partial class TaskController : UserControl
    {
        public TaskController()
        {
            InitializeComponent();
        }

        private void TickCheckBox_Click(object sender, EventArgs e)
        {
            if (TickCheckBox.Checked)
            {
                StatusLabel.Text = "Completed";
                StatusLabel.ForeColor = Color.Lime;
            }
            else
            {
                StatusLabel.Text = "Pending..";
                StatusLabel.ForeColor = Color.Yellow;
            }
        }
    }
}
