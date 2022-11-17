using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe.Components.Buttons
{
    public class ButtonSmall : Button
    {
        public ButtonSmall()
        {
            this.Size = new Size(30, 30);
            this.TabStop = false;
            this.Cursor = Cursors.Hand;
        }
    }
}
