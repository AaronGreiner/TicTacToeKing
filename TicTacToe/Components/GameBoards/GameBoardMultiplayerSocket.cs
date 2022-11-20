using System.Windows.Forms;

namespace TicTacToe.Components.GameBoards
{
    internal class GameBoardMultiplayerSocket : GameBoard
    {
        internal override void ProcessMove()
        {
            MessageBox.Show("Process Move Multiplayer Socket - TBC");
        }

        internal override void SetDifficulty(SingleplayerDifficulty difficulty)
        {

        }
    }
}
