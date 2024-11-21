using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazaAIDashboard.Source
{
    public partial class CustomWindow : Form
    {
        public CustomWindow()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool IsClicking = false;
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            IsClicking = true;
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicking = false;
        }
        Point startPoint;
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicking)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }
    }
}
