using AutoClicker_Black0wl.SaveFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker_Black0wl.User_Controls
{
    public partial class MultiClickerUserControl : UserControl
    {
        delegate object GetSelectedIndicesCountCallback(ComboBox item);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private GlobalKeyboardHook _globalStartHook;

        private bool isRunning = false;

        public List<Point> points = new List<Point>();
        public string start_stop_btn;
        public string currentKey;
        public bool buttonHold;
        public string scan_button;
        private static MultiClickerUserControl SINGLETON;
        public List<Coords> coords;
        public object SelectedItem;
        public static MultiClickerUserControl GetInstance() => SINGLETON;

        public MultiClickerUserControl()
        {
            InitializeComponent();

            _globalStartHook = new GlobalKeyboardHook();
            _globalStartHook.KeyboardPressed += OnKeyPressedStart;

            saved_locations_combobox.DisplayMember = "Name";
            saved_locations_combobox.ValueMember = "Points";
            SINGLETON = this;
            var result = AutoClickerGlobalSettings.ReadFromJson();
            start_stop_btn = result.start_stop_btn;
            currentKey = start_stop_btn;
            buttonHold = result.holdButton;
            coords = result.coords;
            scan_button = result.scan_button;
            if(coords != null)
            foreach (var cord in coords)
            saved_locations_combobox.Items.Add(cord);
        }

        private void scan_positions_button_Click(object sender, EventArgs e)
        {
            LocationChooserForm form = new LocationChooserForm(this);
            form.Show();
        }

        private void settings_button_Click(object sender, EventArgs e)
             => MainForm.GetInstance().SwitchControls(new SettingsUserControl_AutoClicker(this,currentKey, buttonHold,scan_button));

        List<LocationForm> locations;
        int counter = 0;
        private void show_locations_checkbox_Click(object sender, EventArgs e)
        {
            
            if (show_locations_checkbox.Checked)
            {
                locations = new List<LocationForm>();
                counter = 0;
                var selectedItem = saved_locations_combobox.SelectedItem;
                if(selectedItem != null)
                {
                    foreach(var item in ((Coords)selectedItem).Points)
                    {
                        var form = new LocationForm(new Point(item.X,item.Y));
                        // form.Location = Cursor.Position;
                        form.Show();
                        form.TopMost = true;
                        locations.Add(form);
                       // points.Add(form.Location);
                        counter++;
                    }
                }
            }
            else
            {
                foreach (var loc in locations)
                    loc.Close();
                locations.Clear();
               // points.Clear();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().SwitchControls(new MainMenuUserControl());
        }

        private void start_button_Click(object sender, EventArgs e)
        {
          //  saved_locations_combobox.SelectedIndex = 0;
            isRunning = !isRunning;
            start_button.Text = isRunning ? "Stop" : "Start";
            if (isRunning)
            {
               
                ButtonClick(saved_locations_combobox.SelectedItem);
            }
        }

        private void OnKeyPressedStart(object sender, GlobalKeyboardHookEventArgs e)
        {
            // EDT: No need to filter for VkSnapshot anymore. This now gets handled
            // through the constructor of GlobalKeyboardHook(...).
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                // Now you can access both, the key and virtual code
                Keys loggedKey = e.KeyboardData.Key;

                if (loggedKey == (Keys)Enum.Parse(typeof(Keys), start_stop_btn))
                {
                    isRunning = !isRunning;
                    start_button.Text = isRunning ? "Stop" : "Start";
                    if (isRunning)
                    {
                        ButtonClick(saved_locations_combobox.SelectedItem);
                    }
                }
            }
        }

        private void ButtonClick(object item)
        {
            Task.Factory.StartNew(() => ClickThreadAsync(item));
        }

        private void ClickThreadAsync(object item)
        {

            var sItem = item as Coords;
            //MessageBox.Show((saved_locations_combobox.SelectedItem as Coords).Points[0].ToString());
            for (int i = 0; i < number_of_loops_numeric.Value; i++)
            {
                foreach (var point in (sItem as Coords).Points)
                {
                    if (!isRunning)
                        return;

                    DoMouseClick(point);
                    Thread.Sleep((int)delay_seconds_numeric.Value * 1000);
                }
            }
            GetInstance().Invoke(new Action(() => { start_button.Text = isRunning ? "Stop" : "Start"; }));
            GetInstance().Invoke(new Action(() => { isRunning = false; ; }));
           
        }

        public void DoMouseClick(Point point)
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)point.X;
            uint Y = (uint)point.Y;
            Cursor.Position = point;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void saved_locations_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
