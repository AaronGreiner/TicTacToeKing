using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TicTacToe.Classes;

namespace TicTacToe
{
    public partial class BoardTest : UserControl
    {
        private Game game = new Game();

        public BoardTest()
        {
            game.Init();
            InitializeComponent();
        }

        private void ResetBoard()
        {
            game.Init();
            Invalidate();
        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            Brush brush = new SolidBrush(Color.Red);

            Font font = new Font("Arial", 8);

            foreach (Square square in game.squares)
            {
                g.DrawImage(square.GetImageSquare(), square.pos.X * 100, square.pos.Y * 100, 100, 100);

                if (square.is_occupied)
                {
                    g.DrawImage(square.GetImagePlayer(), square.pos.X * 100, square.pos.Y * 100, 100, 100);
                }

                g.DrawString(square.pos.ToString(), font, brush, square.pos.X * 100, square.pos.Y * 100);

            }
        }

        private bool Click(int x, int y)
        {
            if (game.UpdateSquare(new Point(x / 100, y / 100)))
            {
                game.SwitchPlayer();
                Invalidate();
                return true;

            } else
            {
                return false;
            }
        }

        private bool CheckWin()
        {
            //if (squares[0, 0].is_occupied && squares[1, 0].is_occupied && squares[2, 0].is_occupied)
            //{
            //    if ((squares[0, 0].is_cross && squares[1, 0].is_cross && squares[2, 0].is_cross) ||
            //    (!squares[0, 0].is_cross && !squares[1, 0].is_cross && !squares[2, 0].is_cross))
            //    {
            //        return true;
            //    }
            //}




            return false;
        }

        private bool CheckTie()
        {
            bool all_occupied = true;

            //foreach (Square square in squares)
            //{
            //    if (!square.is_occupied)
            //    {
            //        all_occupied = false;
            //        break;
            //    }
            //}

            return all_occupied;
        }

        private Square GetSquareFromPos(Point pos)
        {
            //foreach (Square square in squares)
            //{
            //    if (square.pos.X == pos.X && square.pos.Y == pos.Y)
            //    {
            //        return square;
            //    }
            //}
            return null;
        }

        private void Board_MouseClick(object sender, MouseEventArgs e)
        {
            Click(e.X, e.Y);
        }
    }
}
