using AutoClicker_Black0wl.SaveFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker_Black0wl.User_Controls
{
    public partial class LocationChooserForm : Form
    {
        private GlobalKeyboardHook _globalKeyboardHook;
        private int counter = 0;
        List<LocationForm> locations = new List<LocationForm>();
        List<Point> points = new List<Point>();

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", EntryPoint = "GetDCEx", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, int flags);

        public LocationChooserForm(MultiClickerUserControl _multiClickerUserControl)
        {
            InitializeComponent();
        }

        private void scan_positions_button_Click(object sender, EventArgs e)
        {
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;

            foreach (var location in locations) location.Close();

            locations.Clear();
            points.Clear();
            counter = 0;
            scan_positions_button.Text = "Scanning ...";
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                Keys loggedKey = e.KeyboardData.Key;

                if (loggedKey == (Keys)Enum.Parse(typeof(Keys), MultiClickerUserControl.GetInstance().scan_button))
                {
                    var form = new LocationForm(Cursor.Position);
                    form.Show();
                    form.TopMost = true;
                    locations.Add(form);
                    points.Add(form.Location);
                    counter++;
                }
                if (counter >= location_number_numeric.Value)
                {
                    _globalKeyboardHook.Dispose();
                    scan_positions_button.Text = "Scan Positions";
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (points.Count < 1)
            {
                MessageBox.Show("Please select atleast one point");
                return;
            }

            MultiClickerUserControl.GetInstance().points = points;
            List<Point> currentPoints = new List<Point>();
            foreach (var point in points)
            {
                currentPoints.Add(point);
            }

            Coords coord = new Coords();

            if (!string.IsNullOrWhiteSpace(locations_name_textbox.Text))
                coord.Name = locations_name_textbox.Text;
            else
                coord.Name = $"Locations №{ MultiClickerUserControl.GetInstance().saved_locations_combobox.Items.Count + 1}";

            coord.Points = currentPoints;

            List<Coords> coords = new List<Coords>();

            if (MultiClickerUserControl.GetInstance().coords != null)
                coords = MultiClickerUserControl.GetInstance().coords;

            coords.Add(coord);

            AutoClickerGlobalSettings.SaveToFile(MultiClickerUserControl.GetInstance().start_stop_btn, MultiClickerUserControl.GetInstance().buttonHold, coords);

            MultiClickerUserControl.GetInstance().saved_locations_combobox.Items.Add(coord);

            foreach (var location in locations)
            {
                location.Close();
            }

            locations.Clear();
            points.Clear();
            Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            foreach (var location in locations)
            {
                location.Close();
            }

            locations.Clear();
            points.Clear();
            Close();
        }
    }
}
