using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Position
    {
        //fields
        private int row;
        private int column;

        //Properties
        public int Row
        {
            get { return this.row; }
            set { this.row = value; }
        }

        public int Column
        {
            get { return this.column; }
            set { this.column = value; }
        }

        //Constructors

        public Position()
        { }

        public Position(int row, int column)
        {
            this.row = row;
            this.column = column;
        }




    }
}
