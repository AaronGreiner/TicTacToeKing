using System.Windows.Forms;

namespace TicTacToe.Components.Controls
{
    public partial class SingleplayerControl : UserControl
    {
        public SingleplayerControl(SingleplayerDifficulty difficulty)
        {
            InitializeComponent();
            gameBoard.SetLockedPlayer(Player.Circle);
            gameBoard.SetDifficulty(difficulty);
        }

        public void SetPlayer(Player start_player)
        {
            gameBoard.SetPlayer(start_player);
        }
    }
}
