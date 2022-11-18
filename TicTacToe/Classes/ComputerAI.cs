using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    internal class ComputerAI
    {
        private SingleplayerDifficulty difficulty;
        private Game game;

        public ComputerAI(SingleplayerDifficulty difficulty)
        {
            this.difficulty = difficulty;
        }

        public void DoMove(Game game)
        {
            this.game = game;

            switch (difficulty)
            {
                case SingleplayerDifficulty.Easy:
                    MoveRandomSquare();
                    break;
                case SingleplayerDifficulty.Medium:
                    MoveRandomSquare(); // TODO
                    break;
                case SingleplayerDifficulty.Hard:
                    MoveRandomSquare(); // TODO
                    break;
            }
        }

        private void MoveRandomSquare()
        {
            List<Square> list = new List<Square>();

            foreach (Square square in game.squares)
            {
                if (!square.is_occupied)
                {
                    list.Add(square);
                }
            }

            Square square_random = list[new Random().Next(list.Count)];

            game.UpdateSquare(square_random.pos, true);
        }
    }
}
