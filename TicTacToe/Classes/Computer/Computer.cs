namespace TicTacToe.Classes.Computer
{
    internal class Computer
    {
        private SingleplayerDifficulty difficulty;

        private ComRandom com_random = new ComRandom();
        private ComMinMax com_minmax = new ComMinMax();

        private Game current_game;

        public Computer(SingleplayerDifficulty difficulty)
        {
            this.difficulty = difficulty;
        }

        public void DoMove(Game game)
        {
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
