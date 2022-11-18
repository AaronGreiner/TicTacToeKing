using System.Windows.Forms;

namespace TicTacToe.Components.Controls
{
    public partial class SingleplayerControl : UserControl
    {
        public SingleplayerControl(SingleplayerDifficulty difficulty)
        {
            InitializeComponent();
            gameBoard.SetLockedPlayer(Player.Circle);
        }
    }
}
