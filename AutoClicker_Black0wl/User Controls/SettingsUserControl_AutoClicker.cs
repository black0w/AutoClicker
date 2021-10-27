using AutoClicker_Black0wl.SaveFiles;
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
    public partial class SettingsUserControl_AutoClicker : UserControl
    {
        private GlobalKeyboardHook _globalKeyboardHook;
        private GlobalKeyboardHook _globalKeyboardScanHook;
        private string currentKey = string.Empty;
        private string loggedScanKey;
        private string loggedKey;
        private bool scanButton = false;
        private UserControl control;
        public SettingsUserControl_AutoClicker(UserControl _control,string currentKey, bool buttonHold, string scanButton)
        {
            InitializeComponent();
            control = _control;
            scanned_key_textbox.Text = currentKey;
            enable_hold_button.Checked = buttonHold;
            scanned_scan_button_textbox.Text = scanButton;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainForm.GetInstance().SwitchControls(control);
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
                loggedKey = e.KeyboardData.Key.ToString();
                if (!scanButton)
                {
                    currentKey = string.Empty;
                    currentKey = loggedKey.ToString();
                    scanned_key_textbox.Text = currentKey;
                }
                else
                {
                    loggedScanKey = string.Empty;
                    loggedScanKey = loggedKey.ToString();
                    scanned_scan_button_textbox.Text = loggedScanKey;
                    
                }
            }
            if (!scanButton)
            {
                _globalKeyboardHook.Dispose();

                scan_key_button.Text = "Scan Key";
            }
            else
            {
                _globalKeyboardScanHook.Dispose();

                scan_button_button.Text = "Scan Key";
            }
            scanButton = false;
        }

        private void save_settings_button_Click(object sender, EventArgs e)
        {
            if (AutoClickerUserControl.GetInstance() != null)
            {
                AutoClickerUserControl.GetInstance().buttonHold = enable_hold_button.Checked;
                AutoClickerUserControl.GetInstance().start_stop_btn = scanned_key_textbox.Text;
            }
            if(MultiClickerUserControl.GetInstance() != null)
            {
                //MultiClickerUserControl.GetInstance(). = enable_hold_button.Checked;
                //MultiClickerUserControl.GetInstance().start_stop_btn = scanned_key_textbox.Text;
            }

            
                AutoClickerGlobalSettings.SaveToFile(scanned_key_textbox.Text, enable_hold_button.Checked, new List<Coords>(), scanned_scan_button_textbox.Text);
            

        }

        private void scan_button_button_Click(object sender, EventArgs e)
        {
            scanButton = true;
            _globalKeyboardScanHook = new GlobalKeyboardHook();
            _globalKeyboardScanHook.KeyboardPressed += OnKeyPressed;
            scan_button_button.Text = "Scanning...";
        }
    }
}
