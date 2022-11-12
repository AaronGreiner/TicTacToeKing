using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Board : UserControl
    {
        public Board()
        {
            InitializeComponent();
        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            Pen pen = new Pen(new SolidBrush(Color.Black));
            pen.Width = 3;

            g.DrawLine(pen, 100, 0, 100, 300);
            g.DrawLine(pen, 200, 0, 200, 300);
            g.DrawLine(pen, 0, 100, 300, 100);
            g.DrawLine(pen, 0, 200, 300, 200);

        }
    }
}
