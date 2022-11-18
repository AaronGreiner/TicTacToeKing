using System.Windows.Forms;

namespace TicTacToe.Components.Controls
{
    public partial class MultiplayerSocketControl : UserControl
    {
        public MultiplayerSocketControl()
        {
            InitializeComponent();
            gameBoard.SetLockedPlayer(Player.None);
        }
    }
}
