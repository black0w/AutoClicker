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
    public partial class LocationForm : Form
    {
        private Point point;
        public LocationForm(Point _point)
        {
            InitializeComponent();
            point = _point;
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(10, 10);
            Location = new Point(point.X - Size.Width/2, point.Y - Size.Height/2);
            Opacity = 0.6f;
        }
    }
}
