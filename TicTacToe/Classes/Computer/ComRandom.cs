using System;
using System.Collections.Generic;
using System.Drawing;

namespace TicTacToe.Classes.Computer
{
    internal class ComRandom
    {
        public Point Move(Game game)
        {
            List<Square> list = game.GetAvailableSquares();

            Square square_random = list[new Random().Next(list.Count)];

            return square_random.pos;
        }
    }
}
