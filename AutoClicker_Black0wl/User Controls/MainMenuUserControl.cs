using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker_Black0wl.User_Controls
{
    public partial class MainMenuUserControl : UserControl
    {
        public MainMenuUserControl() => InitializeComponent();

        private void auto_clicker_btn_Click(object sender, EventArgs e)
              => MainForm.GetInstance().SwitchControls(new AutoClickerUserControl());

        private void multi_clicker_btn_Click(object sender, EventArgs e)
              => MainForm.GetInstance().SwitchControls(new MultiClickerUserControl());

        private void about_btn_Click(object sender, EventArgs e)
            => MessageBox.Show("AutoClicker Made By Black0wl \nGitHub: https://github.com/black0w/ " +
                "\nIcons Made By: https://www.freepik.com", "About", MessageBoxButtons.OK);

        private void MainMenuUserControl_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\settings.json"))
            {
                MessageBox.Show("No hotkeys specified. \nPlease set them in the options!", "Warning", MessageBoxButtons.OK);
                MainForm.GetInstance().SwitchControls(new SettingsUserControl_AutoClicker());
            }
        }
    }
}
