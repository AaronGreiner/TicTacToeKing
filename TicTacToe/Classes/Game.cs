using System.Collections.Generic;
using System.Drawing;

namespace TicTacToe.Classes
{
    internal class Game
    {
        public Square[] squares = new Square[9];
        public Player current_player;
        public Player locked_player;

        public GameState current_state;
        public Player winning_player;

        private readonly int[,] win_conditions =  { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
                                                    { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
                                                    { 0, 4, 8 }, { 2, 4, 6 } };

        public void Start()
        {
            InitSquares();
            current_player = Player.Cross;
            locked_player = Player.None;
            current_state = GameState.Running;
        }

        private void InitSquares()
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < squares.Length; i++)
            {
                if (x > 2)
                {
                    y++;
                    x = 0;
                }

                squares[i] = new Square(new Point(x, y));

                x++;
            }
        }

        public bool UpdateSquare(Point pos, bool ignore_locked)
        {
            if (ignore_locked || locked_player != current_player)
            {
                foreach (Square square in squares)
                {
                    if (!square.is_occupied && square.pos == pos)
                    {
                        square.SetOccupied(current_player);
                        return true;
                    }
                }
            }

            return false;
        }

        public void SwitchPlayer()
        {
            if (current_player == Player.Circle)
            {
                current_player = Player.Cross;

            }
            else
            {
                current_player = Player.Circle;
            }
        }

        public GameState CheckGameState()
        {
            if (CheckWinLose())
            {
                current_state = GameState.WinLose;

            }
            else if (CheckTie())
            {
                current_state = GameState.Tie;
            }

            return current_state;
        }

        private bool CheckTie()
        {
            foreach (Square square in squares)
            {
                if (!square.is_occupied)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckWinLose()
        {
            for (int i = 0; i < win_conditions.GetLength(0); i++)
            {
                if (squares[win_conditions[i, 0]].is_occupied && squares[win_conditions[i, 1]].is_occupied && squares[win_conditions[i, 2]].is_occupied)
                {
                    if (squares[win_conditions[i, 0]].owner == squares[win_conditions[i, 1]].owner &&
                        squares[win_conditions[i, 1]].owner == squares[win_conditions[i, 2]].owner)
                    {
                        winning_player = squares[win_conditions[i, 0]].owner;
                        return true;
                    }
                }
            }

            return false;
        }

        public List<Square> GetAvailableSquares()
        {
            List<Square> list = new List<Square>();

            foreach (Square square in squares)
            {
                if (!square.is_occupied)
                {
                    list.Add(square);
                }
            }

            return list;
        }

        public void Clone(Game game_to_clone)
        {
            InitSquares();

            for (int i = 0; i < squares.Length; i++)
            {
                squares[i].Clone(game_to_clone.squares[i]);
            }

            current_player = game_to_clone.current_player;
            locked_player = game_to_clone.locked_player;
            current_state = game_to_clone.current_state;
            winning_player = game_to_clone.winning_player;
        }
    }
}
