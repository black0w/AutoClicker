using AutoClicker_Black0wl.User_Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoClicker_Black0wl
{
    public partial class MainForm : Form
    {

        private bool mouseDown; // Bool used to check if the user is holding the left button over the application header
        private Point lastLocation; // Last location of the cursor        

        private static MainForm Singleton; 
        public static MainForm GetInstance() => Singleton;
        
        public MainForm()
        {
            InitializeComponent();
            Singleton = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
            => user_controls_holder_flp.Controls.Add(new MainMenuUserControl());

        private void title_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void title_panel_MouseUp(object sender, MouseEventArgs e)
            => mouseDown = false;

        private void title_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void exit_btn_click(object sender, EventArgs e)
            => Application.Exit();

        private void guna2Button3_Click(object sender, EventArgs e)
            => WindowState = FormWindowState.Minimized;

        public void SwitchControls(UserControl userControl)
        {
            user_controls_holder_flp.SuspendLayout();
            user_controls_holder_flp.Controls.Clear();
            user_controls_holder_flp.Controls.Add(userControl);
            user_controls_holder_flp.ResumeLayout();
        }
    }
}
