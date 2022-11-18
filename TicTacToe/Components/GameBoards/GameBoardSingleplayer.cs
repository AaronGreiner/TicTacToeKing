using System.Threading;
using TicTacToe.Classes;

namespace TicTacToe.Components.GameBoards
{
    public class GameBoardSingleplayer : GameBoard
    {
        ComputerAI com;

        internal override void ProcessMove()
        {
            Refresh();
            Thread.Sleep(100);
            com.DoMove(game);
            UpdateBoard(false);
        }

        internal override void SetDifficulty(SingleplayerDifficulty difficulty)
        {
            com = new ComputerAI(difficulty);
        }
    }
}
