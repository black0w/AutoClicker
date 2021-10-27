
namespace AutoClicker_Black0wl.User_Controls
{
    partial class LocationChooserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.location_number_numeric = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.scan_positions_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.locations_name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.location_number_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "№ Locations";
            // 
            // location_number_numeric
            // 
            this.location_number_numeric.AutoRoundedCorners = true;
            this.location_number_numeric.BackColor = System.Drawing.Color.Transparent;
            this.location_number_numeric.BorderColor = System.Drawing.Color.Black;
            this.location_number_numeric.BorderRadius = 12;
            this.location_number_numeric.BorderThickness = 0;
            this.location_number_numeric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.location_number_numeric.DisabledState.Parent = this.location_number_numeric;
            this.location_number_numeric.FillColor = System.Drawing.Color.DimGray;
            this.location_number_numeric.FocusedState.Parent = this.location_number_numeric;
            this.location_number_numeric.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_number_numeric.ForeColor = System.Drawing.Color.Black;
            this.location_number_numeric.Location = new System.Drawing.Point(52, 32);
            this.location_number_numeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.location_number_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.location_number_numeric.Name = "location_number_numeric";
            this.location_number_numeric.ShadowDecoration.Parent = this.location_number_numeric;
            this.location_number_numeric.Size = new System.Drawing.Size(100, 26);
            this.location_number_numeric.TabIndex = 24;
            this.location_number_numeric.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.location_number_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.scan_positions_button.Location = new System.Drawing.Point(45, 65);
            this.scan_positions_button.Name = "scan_positions_button";
            this.scan_positions_button.ShadowDecoration.Parent = this.scan_positions_button;
            this.scan_positions_button.Size = new System.Drawing.Size(107, 30);
            this.scan_positions_button.TabIndex = 23;
            this.scan_positions_button.Text = "Scan Positions";
            this.scan_positions_button.Click += new System.EventHandler(this.scan_positions_button_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(124, 137);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(75, 30);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Cancel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 14;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.DimGray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(12, 137);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(75, 30);
            this.guna2Button2.TabIndex = 27;
            this.guna2Button2.Text = "Finish";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // locations_name_textbox
            // 
            this.locations_name_textbox.AutoRoundedCorners = true;
            this.locations_name_textbox.BorderColor = System.Drawing.Color.Black;
            this.locations_name_textbox.BorderRadius = 12;
            this.locations_name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locations_name_textbox.DefaultText = "";
            this.locations_name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.locations_name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.locations_name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locations_name_textbox.DisabledState.Parent = this.locations_name_textbox;
            this.locations_name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locations_name_textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.locations_name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locations_name_textbox.FocusedState.Parent = this.locations_name_textbox;
            this.locations_name_textbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.locations_name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locations_name_textbox.HoverState.Parent = this.locations_name_textbox;
            this.locations_name_textbox.Location = new System.Drawing.Point(32, 101);
            this.locations_name_textbox.Name = "locations_name_textbox";
            this.locations_name_textbox.PasswordChar = '\0';
            this.locations_name_textbox.PlaceholderText = "Save Name";
            this.locations_name_textbox.SelectedText = "";
            this.locations_name_textbox.ShadowDecoration.Parent = this.locations_name_textbox;
            this.locations_name_textbox.Size = new System.Drawing.Size(132, 26);
            this.locations_name_textbox.TabIndex = 28;
            this.locations_name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocationChooserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(211, 179);
            this.ControlBox = false;
            this.Controls.Add(this.locations_name_textbox);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.location_number_numeric);
            this.Controls.Add(this.scan_positions_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LocationChooserForm";
            this.Text = "LocationChooserForm";
            ((System.ComponentModel.ISupportInitialize)(this.location_number_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown location_number_numeric;
        private Guna.UI2.WinForms.Guna2Button scan_positions_button;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TextBox locations_name_textbox;
    }
}