using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        private SquareState[,] squareState;
        public SquareState NextTurn { get; private set;}

        public Board()
        {
            squareState = new SquareState[3, 3];
            NextTurn = SquareState.X;
        }
    }
}
