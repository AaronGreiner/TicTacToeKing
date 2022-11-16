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
using TicTacToe.Classes;

namespace TicTacToe.Components.basic
{
    public partial class GameBoard : UserControl
    {
        public bool draw_debug_info = false;
        private Game game = new Game();

        public GameBoard()
        {
            InitializeComponent();
            game.Start();
        }

        private void GameBoard_Paint(object sender, PaintEventArgs e)
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

                if (draw_debug_info)
                {
                    g.DrawString(" > " + square.pos.ToString(), font, brush, square.pos.X * 100, square.pos.Y * 100);
                    g.DrawString(" > occupied: " + square.is_occupied, font, brush, square.pos.X * 100, square.pos.Y * 100 + 12);
                    g.DrawString(" > " + square.owner, font, brush, square.pos.X * 100, square.pos.Y * 100 + 24);
                }
            }
        }

        private void GameBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (game.UpdateSquare(new Point(e.X / 100, e.Y / 100)))
            {
                Invalidate();

                switch (game.CheckGameState())
                {
                    case GameState.Running:
                        game.SwitchPlayer();
                        break;
                    case GameState.WinLose:
                        MessageBox.Show("The Winner is " + game.winning_player);
                        game.Start();
                        break;
                    case GameState.Tie:
                        MessageBox.Show("Tie");
                        game.Start();
                        break;
                    default:
                        break;
                }

                Invalidate();
            }
        }
    }


}
