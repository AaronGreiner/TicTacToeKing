using System.Drawing;

namespace TicTacToe.Classes
{
    internal class Square
    {
        private Image image_square = (Image)Properties.Resources.ResourceManager.GetObject("square");
        private Image image_cross = (Image)Properties.Resources.ResourceManager.GetObject("cross");
        private Image image_circle = (Image)Properties.Resources.ResourceManager.GetObject("circle");

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
            return image_square;
        }

        public Image GetImagePlayer()
        {
            return owner == Player.Cross ? image_cross : image_circle;
        }
    }
}
