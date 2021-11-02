
namespace AutoClicker_Black0wl.User_Controls
{
    partial class MultiClickerUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saved_locations_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.show_locations_checkbox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scan_positions_button = new Guna.UI2.WinForms.Guna2Button();
            this.number_of_loops_numeric = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delay_seconds_numeric = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.start_button = new Guna.UI2.WinForms.Guna2Button();
            this.delete_saved_locations_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.back_button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.settings_button = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_loops_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_seconds_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // saved_locations_combobox
            // 
            this.saved_locations_combobox.AutoRoundedCorners = true;
            this.saved_locations_combobox.BackColor = System.Drawing.Color.Transparent;
            this.saved_locations_combobox.BorderColor = System.Drawing.Color.Black;
            this.saved_locations_combobox.BorderRadius = 17;
            this.saved_locations_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.saved_locations_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saved_locations_combobox.FillColor = System.Drawing.Color.DimGray;
            this.saved_locations_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saved_locations_combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saved_locations_combobox.FocusedState.Parent = this.saved_locations_combobox;
            this.saved_locations_combobox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saved_locations_combobox.ForeColor = System.Drawing.Color.White;
            this.saved_locations_combobox.HoverState.Parent = this.saved_locations_combobox;
            this.saved_locations_combobox.ItemHeight = 30;
            this.saved_locations_combobox.ItemsAppearance.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saved_locations_combobox.ItemsAppearance.Parent = this.saved_locations_combobox;
            this.saved_locations_combobox.Location = new System.Drawing.Point(52, 70);
            this.saved_locations_combobox.Name = "saved_locations_combobox";
            this.saved_locations_combobox.ShadowDecoration.Parent = this.saved_locations_combobox;
            this.saved_locations_combobox.Size = new System.Drawing.Size(163, 36);
            this.saved_locations_combobox.TabIndex = 0;
            this.saved_locations_combobox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saved_locations_combobox.SelectedIndexChanged += new System.EventHandler(this.saved_locations_combobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(67, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Locations List";
            // 
            // show_locations_checkbox
            // 
            this.show_locations_checkbox.Animated = true;
            this.show_locations_checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.show_locations_checkbox.CheckedState.BorderRadius = 2;
            this.show_locations_checkbox.CheckedState.BorderThickness = 0;
            this.show_locations_checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.show_locations_checkbox.CheckedState.Parent = this.show_locations_checkbox;
            this.show_locations_checkbox.Location = new System.Drawing.Point(63, 111);
            this.show_locations_checkbox.Name = "show_locations_checkbox";
            this.show_locations_checkbox.ShadowDecoration.Parent = this.show_locations_checkbox;
            this.show_locations_checkbox.Size = new System.Drawing.Size(20, 20);
            this.show_locations_checkbox.TabIndex = 17;
            this.show_locations_checkbox.Text = "guna2CustomCheckBox1";
            this.show_locations_checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.show_locations_checkbox.UncheckedState.BorderRadius = 2;
            this.show_locations_checkbox.UncheckedState.BorderThickness = 0;
            this.show_locations_checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.show_locations_checkbox.UncheckedState.Parent = this.show_locations_checkbox;
            this.show_locations_checkbox.Click += new System.EventHandler(this.show_locations_checkbox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(82, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Show Positions";
            // 
            // scan_positions_button
            // 
            this.scan_positions_button.AutoRoundedCorners = true;
            this.scan_positions_button.BorderRadius = 14;
            this.scan_positions_button.BorderThickness = 2;
            this.scan_positions_button.CheckedState.Parent = this.scan_positions_button;
            this.scan_positions_button.CustomImages.Parent = this.scan_positions_button;
            this.scan_positions_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.scan_positions_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.scan_positions_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.scan_positions_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.scan_positions_button.DisabledState.Parent = this.scan_positions_button;
            this.scan_positions_button.FillColor = System.Drawing.Color.DimGray;
            this.scan_positions_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scan_positions_button.ForeColor = System.Drawing.Color.White;
            this.scan_positions_button.HoverState.Parent = this.scan_positions_button;
            this.scan_positions_button.Location = new System.Drawing.Point(79, 137);
            this.scan_positions_button.Name = "scan_positions_button";
            this.scan_positions_button.ShadowDecoration.Parent = this.scan_positions_button;
            this.scan_positions_button.Size = new System.Drawing.Size(107, 30);
            this.scan_positions_button.TabIndex = 19;
            this.scan_positions_button.Text = "Scan Positions";
            this.scan_positions_button.Click += new System.EventHandler(this.scan_positions_button_Click);
            // 
            // number_of_loops_numeric
            // 
            this.number_of_loops_numeric.AutoRoundedCorners = true;
            this.number_of_loops_numeric.BackColor = System.Drawing.Color.Transparent;
            this.number_of_loops_numeric.BorderColor = System.Drawing.Color.Black;
            this.number_of_loops_numeric.BorderRadius = 9;
            this.number_of_loops_numeric.BorderThickness = 0;
            this.number_of_loops_numeric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.number_of_loops_numeric.DisabledState.Parent = this.number_of_loops_numeric;
            this.number_of_loops_numeric.FillColor = System.Drawing.Color.DimGray;
            this.number_of_loops_numeric.FocusedState.Parent = this.number_of_loops_numeric;
            this.number_of_loops_numeric.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_loops_numeric.ForeColor = System.Drawing.Color.Black;
            this.number_of_loops_numeric.Location = new System.Drawing.Point(155, 184);
            this.number_of_loops_numeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_of_loops_numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.number_of_loops_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number_of_loops_numeric.Name = "number_of_loops_numeric";
            this.number_of_loops_numeric.ShadowDecoration.Parent = this.number_of_loops_numeric;
            this.number_of_loops_numeric.Size = new System.Drawing.Size(53, 20);
            this.number_of_loops_numeric.TabIndex = 21;
            this.number_of_loops_numeric.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.number_of_loops_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Number of Repeats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(206, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Seconds";
            // 
            // delay_seconds_numeric
            // 
            this.delay_seconds_numeric.AutoRoundedCorners = true;
            this.delay_seconds_numeric.BackColor = System.Drawing.Color.Transparent;
            this.delay_seconds_numeric.BorderColor = System.Drawing.Color.Black;
            this.delay_seconds_numeric.BorderRadius = 9;
            this.delay_seconds_numeric.BorderThickness = 0;
            this.delay_seconds_numeric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.delay_seconds_numeric.DisabledState.Parent = this.delay_seconds_numeric;
            this.delay_seconds_numeric.FillColor = System.Drawing.Color.DimGray;
            this.delay_seconds_numeric.FocusedState.Parent = this.delay_seconds_numeric;
            this.delay_seconds_numeric.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delay_seconds_numeric.ForeColor = System.Drawing.Color.Black;
            this.delay_seconds_numeric.Location = new System.Drawing.Point(155, 224);
            this.delay_seconds_numeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delay_seconds_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delay_seconds_numeric.Name = "delay_seconds_numeric";
            this.delay_seconds_numeric.ShadowDecoration.Parent = this.delay_seconds_numeric;
            this.delay_seconds_numeric.Size = new System.Drawing.Size(53, 20);
            this.delay_seconds_numeric.TabIndex = 25;
            this.delay_seconds_numeric.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delay_seconds_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Delay Between Clicks";
            // 
            // start_button
            // 
            this.start_button.AutoRoundedCorners = true;
            this.start_button.BorderRadius = 14;
            this.start_button.BorderThickness = 2;
            this.start_button.CheckedState.Parent = this.start_button;
            this.start_button.CustomImages.Parent = this.start_button;
            this.start_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.start_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.start_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.start_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.start_button.DisabledState.Parent = this.start_button;
            this.start_button.FillColor = System.Drawing.Color.DimGray;
            this.start_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.start_button.ForeColor = System.Drawing.Color.White;
            this.start_button.HoverState.Parent = this.start_button;
            this.start_button.Location = new System.Drawing.Point(79, 257);
            this.start_button.Name = "start_button";
            this.start_button.ShadowDecoration.Parent = this.start_button;
            this.start_button.Size = new System.Drawing.Size(107, 30);
            this.start_button.TabIndex = 27;
            this.start_button.Text = "Start";
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // delete_saved_locations_btn
            // 
            this.delete_saved_locations_btn.BackgroundImage = global::AutoClicker_Black0wl.Properties.Resources.delete;
            this.delete_saved_locations_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_saved_locations_btn.CheckedState.Parent = this.delete_saved_locations_btn;
            this.delete_saved_locations_btn.CustomImages.Parent = this.delete_saved_locations_btn;
            this.delete_saved_locations_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_saved_locations_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_saved_locations_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_saved_locations_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_saved_locations_btn.DisabledState.Parent = this.delete_saved_locations_btn;
            this.delete_saved_locations_btn.FillColor = System.Drawing.Color.Transparent;
            this.delete_saved_locations_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete_saved_locations_btn.ForeColor = System.Drawing.Color.White;
            this.delete_saved_locations_btn.HoverState.Parent = this.delete_saved_locations_btn;
            this.delete_saved_locations_btn.Location = new System.Drawing.Point(237, 73);
            this.delete_saved_locations_btn.Name = "delete_saved_locations_btn";
            this.delete_saved_locations_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.delete_saved_locations_btn.ShadowDecoration.Parent = this.delete_saved_locations_btn;
            this.delete_saved_locations_btn.Size = new System.Drawing.Size(30, 30);
            this.delete_saved_locations_btn.TabIndex = 28;
            this.delete_saved_locations_btn.Visible = false;
            this.delete_saved_locations_btn.Click += new System.EventHandler(this.delete_saved_locations_btn_Click);
            // 
            // back_button
            // 
            this.back_button.BackgroundImage = global::AutoClicker_Black0wl.Properties.Resources.back_button;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.CheckedState.Parent = this.back_button;
            this.back_button.CustomImages.Parent = this.back_button;
            this.back_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back_button.DisabledState.Parent = this.back_button;
            this.back_button.FillColor = System.Drawing.Color.Transparent;
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.HoverState.Parent = this.back_button;
            this.back_button.Location = new System.Drawing.Point(3, 3);
            this.back_button.Name = "back_button";
            this.back_button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.back_button.ShadowDecoration.Parent = this.back_button;
            this.back_button.Size = new System.Drawing.Size(30, 30);
            this.back_button.TabIndex = 20;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.BackgroundImage = global::AutoClicker_Black0wl.Properties.Resources.gear;
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_button.CheckedState.Parent = this.settings_button;
            this.settings_button.CustomImages.Parent = this.settings_button;
            this.settings_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settings_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settings_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settings_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settings_button.DisabledState.Parent = this.settings_button;
            this.settings_button.FillColor = System.Drawing.Color.Transparent;
            this.settings_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settings_button.ForeColor = System.Drawing.Color.White;
            this.settings_button.HoverState.Parent = this.settings_button;
            this.settings_button.Location = new System.Drawing.Point(237, 4);
            this.settings_button.Name = "settings_button";
            this.settings_button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.settings_button.ShadowDecoration.Parent = this.settings_button;
            this.settings_button.Size = new System.Drawing.Size(30, 30);
            this.settings_button.TabIndex = 15;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // MultiClickerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.delete_saved_locations_btn);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delay_seconds_numeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.number_of_loops_numeric);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.scan_positions_button);
            this.Controls.Add(this.show_locations_checkbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.saved_locations_combobox);
            this.Name = "MultiClickerUserControl";
            this.Size = new System.Drawing.Size(275, 301);
            ((System.ComponentModel.ISupportInitialize)(this.number_of_loops_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_seconds_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton settings_button;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomCheckBox show_locations_checkbox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button scan_positions_button;
        public Guna.UI2.WinForms.Guna2ComboBox saved_locations_combobox;
        private Guna.UI2.WinForms.Guna2CircleButton back_button;
        private Guna.UI2.WinForms.Guna2NumericUpDown number_of_loops_numeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown delay_seconds_numeric;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button start_button;
        private Guna.UI2.WinForms.Guna2CircleButton delete_saved_locations_btn;
    }
}
