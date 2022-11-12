using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Square
    {
        public Point pos;
        public bool is_occupied = false;
        public bool is_cross;

        public Square(Point pos)
        {
            this.pos = pos;
        }

        public void SetOccupied(bool is_occupied, bool is_cross)
        {
            this.is_occupied = is_occupied;
            this.is_cross = is_cross;
        }
    }
}
