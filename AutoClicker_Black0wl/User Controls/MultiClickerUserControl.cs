using AutoClicker_Black0wl.SaveFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        private List<LocationForm> locations;
        private int counter = 0;
        public static MultiClickerUserControl GetInstance() => SINGLETON;

        public MultiClickerUserControl()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(start_stop_btn) && !string.IsNullOrEmpty(scan_button))
            {
                _globalStartHook = new GlobalKeyboardHook();
                _globalStartHook.KeyboardPressed += OnKeyPressedStart;
            }
            saved_locations_combobox.DisplayMember = "Name";
            saved_locations_combobox.ValueMember = "Points";
            SINGLETON = this;
            var result = AutoClickerGlobalSettings.ReadFromJson();
            if(result == null)
            {
                this.Dispose();
            }
            start_stop_btn = result.start_stop_btn;
            currentKey = start_stop_btn;
            buttonHold = result.holdButton;
            coords = result.coords;
            scan_button = result.scan_button;
            if (coords != null)
                foreach (var cord in coords)
                    saved_locations_combobox.Items.Add(cord);
        }

        private void scan_positions_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(scan_button))
            {
                new LocationChooserForm(this).Show();
            }
            else
            {
                MessageBox.Show("No hotkey specified for scanning positions. \nPlease set one in the options!", "Warning", MessageBoxButtons.OK);
                MainForm.GetInstance().SwitchControls(new SettingsUserControl_AutoClicker(this, currentKey, buttonHold, scan_button));
            }
        }


        private void settings_button_Click(object sender, EventArgs e)
             => MainForm.GetInstance().SwitchControls(new SettingsUserControl_AutoClicker(this, currentKey, buttonHold, scan_button));

        private void show_locations_checkbox_Click(object sender, EventArgs e)
        {

            if (show_locations_checkbox.Checked)
            {
                locations = new List<LocationForm>();
                counter = 0;
                var selectedItem = saved_locations_combobox.SelectedItem;
                if (selectedItem != null)
                {
                    foreach (var item in ((Coords)selectedItem).Points)
                    {
                        var form = new LocationForm(new Point(item.X, item.Y));
                        form.Show();
                        form.TopMost = true;
                        locations.Add(form);
                        counter++;
                    }
                }
            }
            else
            {
                foreach (var loc in locations) loc.Close();
                locations.Clear();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().SwitchControls(new MainMenuUserControl());
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            start_button.Text = isRunning ? "Stop" : "Start";
            if (isRunning)
            {
                ButtonClick(saved_locations_combobox.SelectedItem);
            }
        }

        private void OnKeyPressedStart(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                Keys loggedKey = e.KeyboardData.Key;
                if (!string.IsNullOrEmpty(start_stop_btn))
                {
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
        }

        private void ButtonClick(object item)
        {
            Task.Factory.StartNew(() => ClickThreadAsync(item));
        }

        private void ClickThreadAsync(object item)
        {
            using (var soundPlayer = new SoundPlayer(Properties.Resources.switch_3))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }

            var sItem = item as Coords;
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
            GetInstance().Invoke(new Action(() => { isRunning = false; ; }));
            GetInstance().Invoke(new Action(() => { start_button.Text = isRunning ? "Stop" : "Start"; }));
            using (var soundPlayer = new SoundPlayer(Properties.Resources.switch_7))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
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
            delete_saved_locations_btn.Show();
        }

        private void delete_saved_locations_btn_Click(object sender, EventArgs e)
        {

            if (saved_locations_combobox.SelectedItem != null)
            {
                foreach (var point in coords)
                {
                    if (point.Name == ((Coords)saved_locations_combobox.SelectedItem).Name)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this save?", "Just To Be Sure", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            coords.Remove(point);
                            saved_locations_combobox.Items.Remove(saved_locations_combobox.SelectedItem);
                            AutoClickerGlobalSettings.SaveAllToFile(start_stop_btn, buttonHold, coords, scan_button);
                            delete_saved_locations_btn.Hide();
                        }
                        break;
                    }
                }
            }

        }
    }
}
