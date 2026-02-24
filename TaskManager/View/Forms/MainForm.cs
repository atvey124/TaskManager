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
            IsButtonOff();
            FillButton(HomeButton, Color.DarkGoldenrod);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            IsButtonOff();
            FillButton(SettingsButton, Color.DarkGoldenrod);
        }

        private void UpdatesButton_Click(object sender, EventArgs e)
        {
            IsButtonOff();
            FillButton(UpdatesButton, Color.DarkGoldenrod);
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            IsButtonOff();
            FillButton(StatisticsButton, Color.DarkGoldenrod);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            IsButtonOff();
            FillButton(helpButton, Color.DarkGoldenrod);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            IsButtonOff();
            FillButton(AboutButton, Color.DarkGoldenrod);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            IsButtonOff();
            FillButton(LogOutButton, Color.DarkGoldenrod);
        }

        private void IsButtonOff()
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
    }
}
