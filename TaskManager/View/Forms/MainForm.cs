using Guna.UI2.WinForms;
using TaskManager.View.Forms;


namespace TaskManager
{
    public partial class MainForm : Form
    {
        DashboardForm dashboardForm = new DashboardForm();
        TasksForm tasksForm = new TasksForm();

        public MainForm()
        {
            InitializeComponent();
            LoadForm(dashboardForm);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(HomeButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("Home");
            LoadForm(dashboardForm);
        }

        private void TasksButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(TasksButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("Tasks");
            LoadForm(tasksForm);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(SettingsButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("Settings");
        }

        private void UpdatesButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(UpdatesButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("Updates");
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(StatisticsButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("Statistics");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(helpButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("Help");
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(AboutButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("About");
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(LogOutButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("LogOut");
        }

        private void OffButton()
        {
            foreach(var control in SideMenuPanel.Controls)
            {
                if(control is Guna2Button button)
                {
                    button.FillColor = Color.Transparent;
                }
            }
        }
        private void FillButton(Guna2Button button,Color color)
        {
            button.FillColor = color;
        }

        private void RenameTitleTextLabel(string message)
        {
            TitleTextLabel.Text = message;
        }

        private void LoadForm(Form form)
        {
            PageContainerPanel.Controls.Clear();
            form.TopLevel = false;
            form.TopMost = true;
            form.Dock = DockStyle.Fill;
            PageContainerPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

    }
}
