using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        {
            MainForm.GetInstance().SwitchControls(new AutoClickerUserControl());
        }
       
        private void multi_clicker_btn_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().SwitchControls(new MultiClickerUserControl());
        }

    }
}
