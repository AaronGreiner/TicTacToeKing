using TicTacToe.Classes.Computer;

namespace TicTacToe.Components.GameBoards
{
    public class GameBoardSingleplayer : GameBoard
    {
        Computer com;

        internal override void ProcessMove()
        {
            Refresh();
            com.DoMove(game);
            UpdateBoard(false);
        }

        internal override void SetDifficulty(SingleplayerDifficulty difficulty)
        {
            com = new Computer(difficulty);
        }
    }
}
