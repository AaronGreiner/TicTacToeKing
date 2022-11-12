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
        Image image_square = (Image)Properties.Resources.ResourceManager.GetObject("square");
        Image image_cross = (Image)Properties.Resources.ResourceManager.GetObject("cross");
        Image image_circle = (Image)Properties.Resources.ResourceManager.GetObject("circle");

        Square[,] squares = new Square[3, 3];
        
        Point current_pos;
        Square current_square;

        bool is_cross_turn = true;

        public Board()
        {
            InitBoard();
            InitializeComponent();
        }

        private void InitBoard()
        {
            for (int x = 0; x < squares.GetLength(0); x++)
            {
                for (int y = 0; y < squares.GetLength(1); y++)
                {
                    squares[x, y] = new Square(new Point(x, y));
                }
            }
        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            Pen pen = new Pen(new SolidBrush(Color.Black));
            pen.Width = 3;

            foreach (Square square in squares)
            {
                g.DrawImage(image_square, square.pos.X * 100, square.pos.Y * 100, 100, 100);

                if (square.is_occupied)
                {
                    g.DrawImage(square.is_cross ? image_cross : image_circle, square.pos.X * 100, square.pos.Y * 100, 100, 100);
                }
            }
        }

        private void SetCurrentPos(int x, int y)
        {
            current_pos = new Point(x / 100, y / 100);
            current_square = GetSquareFromPos(current_pos);

            Console.WriteLine(current_pos);

            if (!current_square.is_occupied)
            {
                current_square.SetOccupied(true, is_cross_turn);
                is_cross_turn = !is_cross_turn;
                Invalidate();
            }
        }

        private Square GetSquareFromPos(Point pos)
        {
            foreach (Square square in squares)
            {
                if (square.pos.X == pos.X && square.pos.Y == pos.Y)
                {
                    return square;
                }
            }
            return null;
        }

        private void Board_MouseClick(object sender, MouseEventArgs e)
        {
            SetCurrentPos(e.X, e.Y);
        }
    }
}
