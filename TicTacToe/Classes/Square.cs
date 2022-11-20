using System.Drawing;

namespace TicTacToe.Classes
{
    internal class Square
    {
        private Image image_square;
        private Image image_cross;
        private Image image_circle;

        public Point pos;

        public bool is_occupied;
        public Player owner;

        public Square(Point pos)
        {
            this.pos = pos;
            is_occupied = false;
            owner = Player.None;
        }

        public void SetOccupied(Player player)
        {
            owner = player;
            is_occupied = true;
        }

        public Image GetImageSquare()
        {
            if (image_square == null)
            {
                image_square = (Image)Properties.Resources.ResourceManager.GetObject("square");
            }

            return image_square;
        }

        public Image GetImagePlayer()
        {
            if (image_cross == null)
            {
                image_cross = (Image)Properties.Resources.ResourceManager.GetObject("cross");
            }

            if (image_circle == null)
            {
                image_circle = (Image)Properties.Resources.ResourceManager.GetObject("circle");
            }

            return owner == Player.Cross ? image_cross : image_circle;
        }

        public void Clone(Square square_to_clone)
        {
            pos = square_to_clone.pos;
            is_occupied = square_to_clone.is_occupied;
            owner = square_to_clone.owner;
        }
    }
}
