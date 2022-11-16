using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    internal class Game
    {
        public Square[] squares = new Square[9];
        public Player current_player;

        public void Init()
        {
            InitSquares();
            current_player = Player.Cross;
        }

        public void Reset()
        {
            InitSquares();
            current_player = Player.Cross;
        }

        public bool UpdateSquare(Point pos)
        {
            foreach (Square square in squares)
            {
                if (square.pos == pos)
                {
                    square.SetOccupied(current_player);
                    return true;
                }
            }

            return false;
        }

        public void SwitchPlayer()
        {
            if (current_player == Player.Circle)
            {
                current_player = Player.Cross;

            } else
            {
                current_player = Player.Circle;
            }
        }

        private void InitSquares()
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < squares.Length; i++)
            {
                if (x > 2)
                {
                    y++;
                    x = 0;
                }

                squares[i] = new Square(new Point(x, y));

                x++;
            }
        }

    }
}
