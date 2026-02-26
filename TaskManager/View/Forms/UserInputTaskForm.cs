using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskManager.View.Forms
{
    public partial class UserInputTaskForm : Form
    {
        public UserInputTaskForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
