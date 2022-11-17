using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe.Components.Buttons
{
    public class ButtonMedium : Button
    {
        public ButtonMedium()
        {
            this.Size = new Size(180, 30);
            this.TabStop = false;
            this.Cursor = Cursors.Hand;
        }
    }
}
