using System;
using System.Collections.Generic;
using PositionLibrary;
using ChipLibrary;
namespace BoardLibrary
{
    public class Board
    {
        private int _column;
        private int _row;
        public List<Position> theGrid = new List<Position>();

        public Board(int column, int row)
        {
            _column = column;
            _row = row;
            int y = _row - 1;
            int x;

            while (y >= 0)
            {
                x = 0;
                while (x <= _column - 1)
                {
                    theGrid.Add(new Position(new int[] { x, y }, true, null));
                    x++;
                }
                y--;
            }
        }

        public int GetColumn()
        {
            return _column;
        }

        public int GetRow()
        {
            return _row;
        }

    }
}
