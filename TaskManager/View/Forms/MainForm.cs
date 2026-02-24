using Guna.UI2.WinForms;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(HomeButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("Home");
        }

        private void TasksButton_Click(object sender, EventArgs e)
        {
            OffButton();
            FillButton(TasksButton, Color.DarkGoldenrod);
            RenameTitleTextLabel("Tasks");
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

        private void label1_click(object sender, EventArgs e)
        {

        }

        private void label2_click(object sender, EventArgs e)
        {

        }
    }
}
