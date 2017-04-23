using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Курсач
{ 
    public partial class okno : Form
    {
       private int[] clicks = new int[] { 0, 0};
        Point DownPoint;

        public okno()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void shashka1_Click(object sender, EventArgs e)
        {
           //clicks[0] = (clicks[0] + 1) % 2;
        }

        private void shashka1_MouseDown(object sender, MouseEventArgs e)
        {
            DownPoint = e.Location;
            clicks[0] = 1;
        }

        private void shashka1_MouseUp(object sender, MouseEventArgs e)
        {
            DownPoint = new Point();
            clicks[0] = 0;
        }

        private void shashka1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicks[0] == 1)
            {
                Point dp = new Point(e.Location.X - DownPoint.X, e.Location.Y - DownPoint.Y);
                shashka1.Location = new Point(shashka1.Location.X + dp.X, shashka1.Location.Y + dp.Y);
            }
        }

        private void shashka2_MouseDown(object sender, MouseEventArgs e)
        {
            DownPoint = e.Location;
            clicks[1] = 1;
        }

        private void shashka2_MouseUp(object sender, MouseEventArgs e)
        {
            DownPoint = new Point();
            clicks[1] = 0;
        }

        private void shashka2_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicks[1] == 1)
            {
                Point dp = new Point(e.Location.X - DownPoint.X, e.Location.Y - DownPoint.Y);
                shashka2.Location = new Point(shashka2.Location.X + dp.X, shashka2.Location.Y + dp.Y);
            }
        }
    }
}
