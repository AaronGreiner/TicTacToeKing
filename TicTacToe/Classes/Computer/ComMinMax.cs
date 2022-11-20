using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TicTacToe.Classes.Computer
{
    internal class ComMinMax
    {
        private Player player;
        private Point best_pos;

        public Point Move(Game game)
        {
            player = game.current_player;

            MinMax(game, 0);

            return best_pos;
        }

        private int GetGameScore(Game game, int depth)
        {
            game.CheckGameState();

            if (game.current_state == GameState.WinLose)
            {
                return (game.winning_player == player ? 10 : -10) - depth;
            }
            else
            {
                return 0;
            }
        }

        private int MinMax(Game game, int depth)
        {
            Game virtual_game = new Game();
            virtual_game.Clone(game);

            if (virtual_game.current_state != GameState.Running)
            {
                return GetGameScore(virtual_game, depth);
            }

            List<int> scores = new List<int>();
            List<Point> moves = new List<Point>();

            foreach (Square square in virtual_game.GetAvailableSquares())
            {
                virtual_game.UpdateSquare(square.pos, true);

                scores.Add(MinMax(virtual_game, depth + 1));
                moves.Add(square.pos);
            }

            if (scores.Count > 0)
            {
                if (virtual_game.current_player == player)
                {
                    int max = scores.IndexOf(scores.Max());
                    best_pos = moves[max];
                    return scores[max];
                }
                else
                {
                    int min = scores.IndexOf(scores.Min());
                    best_pos = moves[min];
                    return scores[min];
                }
            }
            return 0;
        }
    }
}
