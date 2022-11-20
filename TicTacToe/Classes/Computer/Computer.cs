using System;
using System.Threading;
using System.Windows.Forms;

namespace TicTacToe.Classes.Computer
{
    internal class Computer
    {
        private SingleplayerDifficulty difficulty;

        public int min_move_time = 250;
        private int total_move_time;
        private DateTime move_start;
        private DateTime move_end;

        private ComRandom com_random = new ComRandom();
        private ComMinMax com_minmax = new ComMinMax();

        private Game current_game;

        public Computer(SingleplayerDifficulty difficulty)
        {
            this.difficulty = difficulty;
        }

        public void DoMove(Game game)
        {
            Cursor.Current = Cursors.WaitCursor;
            move_start = DateTime.Now;

            current_game = game;

            switch (difficulty)
            {
                case SingleplayerDifficulty.Easy:
                    MoveRandomSquare();
                    break;
                case SingleplayerDifficulty.Medium:
                    MoveRandomSquare(); // TODO
                    break;
                case SingleplayerDifficulty.Hard:
                    MoveMinMaxSquare();
                    break;
            }

            move_end = DateTime.Now;

            total_move_time = (int)((TimeSpan)(move_end - move_start)).TotalMilliseconds;
            Console.WriteLine(total_move_time);

            if (min_move_time - total_move_time > 0)
            {
                Thread.Sleep(min_move_time - total_move_time);
            }

            Cursor.Current = Cursors.Default;
        }

        private void MoveRandomSquare()
        {
            current_game.UpdateSquare(com_random.Move(current_game), true);
        }

        private void MoveMinMaxSquare()
        {
            current_game.UpdateSquare(com_minmax.Move(current_game), true);
        }
    }
}
