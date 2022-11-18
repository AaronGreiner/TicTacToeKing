using System.Windows.Forms;

namespace TicTacToe.Components.Controls
{
    public partial class MultiplayerLocalControl : UserControl
    {
        public MultiplayerLocalControl()
        {
            InitializeComponent();
            gameBoard.SetLockedPlayer(Player.None);
        }
    }
}
