using AutoClicker_Black0wl.SaveFiles;
using InputManager;
using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
namespace AutoClicker_Black0wl.User_Controls
{
    public partial class AutoClickerUserControl : UserControl
    {

        private GlobalKeyboardHook _globalKeyboardHook;
        private GlobalKeyboardHook _globalStartHook;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private bool mouseClick = false;
        private bool isRunning = false;
        private string currentKey = string.Empty;
        private Keys ck;
        private bool delayed_start = false;
        private CancellationTokenSource tokenSource;

        private static AutoClickerUserControl SINGLETON;

        public bool buttonHold = false;
        public string start_stop_btn;
        public string scan_btn;

        public AutoClickerUserControl()
        {
            InitializeComponent();
            SINGLETON = this;
            _globalStartHook = new GlobalKeyboardHook();
            _globalStartHook.KeyboardPressed += OnKeyPressedStart;
            var result = AutoClickerGlobalSettings.ReadFromJson();
            start_stop_btn = result.start_stop_btn;
            currentKey = start_stop_btn;
            buttonHold = result.holdButton;
            scan_btn = result.scan_button;
        }

        public static AutoClickerUserControl GetInstance() => SINGLETON;

        private void left_mouse_checkbox_Click(object sender, EventArgs e)
        {
            if (right_mouse_checkbox.Checked)
                right_mouse_checkbox.Checked = false;

            mouseClick = left_mouse_checkbox.Checked;

            if (left_mouse_checkbox.Checked)
            {
                scan_key_button.Enabled = false;
                scanned_key_textbox.Enabled = false;
            }
            else
            {
                scan_key_button.Enabled = true;
                scanned_key_textbox.Enabled = true;
            }
        }

        private void right_mouse_checkbox_Click(object sender, EventArgs e)
        {
            if (left_mouse_checkbox.Checked)
                left_mouse_checkbox.Checked = false;

            mouseClick = right_mouse_checkbox.Checked;

            if (right_mouse_checkbox.Checked)
            {
                scan_key_button.Enabled = false;
                scanned_key_textbox.Enabled = false;
            }
            else
            {
                scan_key_button.Enabled = true;
                scanned_key_textbox.Enabled = true;
            }
        }

        private void scan_key_button_Click(object sender, EventArgs e)
        {
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;
            scan_key_button.Text = "Scanning...";
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                // Now you can access both, the key and virtual code
                Keys loggedKey = e.KeyboardData.Key;
                ck = loggedKey;
                currentKey = string.Empty;
                currentKey = loggedKey.ToString();
                scanned_key_textbox.Text = currentKey;
            }
            _globalKeyboardHook.Dispose();

            scan_key_button.Text = "Scan Key";
        }
        bool isHolding = false;
        private void OnKeyPressedStart(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                Keys loggedKey = e.KeyboardData.Key;
                if(start_stop_btn!= null)
                if (loggedKey == (Keys)Enum.Parse(typeof(Keys), start_stop_btn))
                {
                    //if (!buttonHold)
                    //{
                        isRunning = !isRunning;

                        if (tokenSource != null)
                            tokenSource.Cancel();

                        if (!mouseClick)
                            EmulateButton();
                        else
                        {
                            if (left_mouse_checkbox.Checked)
                                DoMouseClick(new Point(0, 0), true);
                            else
                                DoMouseClick(new Point(0, 0), false);
                        }
                }
            }
        }

        private void enable_delayed_start_Click(object sender, EventArgs e)
        {
            delayed_start = enable_delayed_start.Checked;
            if (enable_delayed_start.Checked)
                delayed_seconds_numeric.Enabled = true;
            else
                delayed_seconds_numeric.Enabled = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;

            if (tokenSource != null)
                tokenSource.Cancel();

            if (!mouseClick)
                EmulateButton();
            else
            {
                if (left_mouse_checkbox.Checked)
                    DoMouseClick(new Point(0, 0), true);
                else
                    DoMouseClick(new Point(0, 0), false);
            }
        }

        private void DoMouseClick(Point point, bool left)
        {

            if (isRunning)
            {
                tokenSource = new CancellationTokenSource();
                CancellationToken token = tokenSource.Token;
                Task.Factory.StartNew(() =>
                {
                    if (delayed_start)
                        Thread.Sleep((int)delayed_seconds_numeric.Value * 1000);
                    while (!token.IsCancellationRequested)
                    {
                        Thread.Sleep(10);
                        if (left)
                            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)point.X, (uint)point.Y, 0, 0);
                        else
                            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)point.X, (uint)point.Y, 0, 0);
                        Thread.Sleep((int)guna2NumericUpDown1.Value);
                    }
                });
            }
        }

        private void EmulateButton()
        {

            start_button.Text = isRunning ? "Stop" : "Start";
            if (isRunning)
            {

                tokenSource = new CancellationTokenSource();
                CancellationToken token = tokenSource.Token;

                Task.Factory.StartNew(() =>
                {
                    if (delayed_start)
                        Thread.Sleep((int)delayed_seconds_numeric.Value * 1000);
                    using (var soundPlayer = new SoundPlayer(Properties.Resources.switch_3))
                    {
                        soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                    }
                    while (!token.IsCancellationRequested)
                    {
                        try
                        {
                            Keyboard.KeyDown(ck);
                            Thread.Sleep(100);
                            Keyboard.KeyUp(ck);
                            // SendKeys.SendWait("{" + currentKey + "}");

                        }
                        catch (ArgumentException)
                        {
                            using (var soundPlayer = new SoundPlayer(Properties.Resources.sci_fi_beeperror_179_sound_effect_97326661))
                            {
                                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                            }
                            MessageBox.Show("Please try another button, this one is not supported by windows :/", "Alert");
                            if (InvokeRequired)
                            {
                                Invoke(new MethodInvoker(delegate { guna2Button1_Click(new object(), new EventArgs()); }));
                            }

                            return;
                        }
                        Thread.Sleep((int)guna2NumericUpDown1.Value);
                    }
                    //  Keyboard.KeyUp(ck);
                    using (var soundPlayer = new SoundPlayer(Properties.Resources.switch_7))
                    {
                        soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                    }
                });
            }
        }


        private void settings_button_Click(object sender, EventArgs e)
            => MainForm.GetInstance().SwitchControls(new SettingsUserControl_AutoClicker(this,currentKey, buttonHold, scan_btn));

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void scanned_key_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().SwitchControls(new MainMenuUserControl());
        }
    }
}
