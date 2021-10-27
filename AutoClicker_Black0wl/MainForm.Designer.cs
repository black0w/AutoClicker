
namespace AutoClicker_Black0wl
{
    partial class MainForm
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
            this.title_panel = new System.Windows.Forms.Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.exit_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_controls_holder_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.title_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.Color.Transparent;
            this.title_panel.Controls.Add(this.guna2Button3);
            this.title_panel.Controls.Add(this.exit_btn);
            this.title_panel.Controls.Add(this.label1);
            this.title_panel.Controls.Add(this.guna2CirclePictureBox1);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(275, 31);
            this.title_panel.TabIndex = 0;
            this.title_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseDown);
            this.title_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseMove);
            this.title_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseUp);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackgroundImage = global::AutoClicker_Black0wl.Properties.Resources.minus_sign_of_a_line_in_horizontal_position;
            this.guna2Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(211, 7);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(26, 26);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "guna2Button3";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackgroundImage = global::AutoClicker_Black0wl.Properties.Resources.cancel;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_btn.CheckedState.Parent = this.exit_btn;
            this.exit_btn.CustomImages.Parent = this.exit_btn;
            this.exit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit_btn.DisabledState.Parent = this.exit_btn;
            this.exit_btn.FillColor = System.Drawing.Color.Transparent;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.HoverState.Parent = this.exit_btn;
            this.exit_btn.Location = new System.Drawing.Point(243, 3);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit_btn.ShadowDecoration.Parent = this.exit_btn;
            this.exit_btn.Size = new System.Drawing.Size(26, 26);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "guna2CircleButton1";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Auto Clicker";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackgroundImage = global::AutoClicker_Black0wl.Properties.Resources.clicker;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CirclePictureBox1.Enabled = false;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(25, 25);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 2);
            this.panel1.TabIndex = 1;
            // 
            // user_controls_holder_flp
            // 
            this.user_controls_holder_flp.BackColor = System.Drawing.Color.Transparent;
            this.user_controls_holder_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_controls_holder_flp.Location = new System.Drawing.Point(0, 33);
            this.user_controls_holder_flp.Name = "user_controls_holder_flp";
            this.user_controls_holder_flp.Size = new System.Drawing.Size(275, 313);
            this.user_controls_holder_flp.TabIndex = 2;
            this.user_controls_holder_flp.Paint += new System.Windows.Forms.PaintEventHandler(this.user_controls_holder_flp_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 37);
            this.panel2.TabIndex = 3;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::AutoClicker_Black0wl.Properties.Resources.ff2e3fb0109540959bbd8badbda51664;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(2, -119);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(272, 239);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BackgroundImage = global::AutoClicker_Black0wl.Properties.Resources.Background11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(275, 383);
            this.ControlBox = false;
            this.Controls.Add(this.user_controls_holder_flp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title_panel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton exit_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.FlowLayoutPanel user_controls_holder_flp;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

