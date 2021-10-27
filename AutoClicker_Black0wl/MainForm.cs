using AutoClicker_Black0wl.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker_Black0wl
{
    public partial class MainForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        
        private static MainForm Singleton;


        public MainForm()
        {
            InitializeComponent();
            Singleton = this;
        }

        public static MainForm GetInstance() => Singleton;

        private void MainForm_Load(object sender, EventArgs e)
        { 
            user_controls_holder_flp.Controls.Add(new MainMenuUserControl());
        }

        private void title_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

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

        private void user_controls_holder_flp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
