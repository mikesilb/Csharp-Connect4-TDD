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

        public void Rendering()
        {
            Console.WriteLine();
            int columnNum = 0;
            Console.Write(" ");
            while (columnNum < _column)
            {
                Console.Write($" {columnNum}");
                columnNum++;
            }
            Console.WriteLine(" ");
            foreach (var theLocation in theGrid)
            {
                if (theLocation.GetAvailability() == true && theLocation.location[0] % _column == _column - 1)
                {
                    Console.WriteLine(" .|");
                }
                else if (theLocation.GetAvailability() == false && theLocation.location[0] % _column == _column - 1)
                {
                    Console.WriteLine($" {theLocation.GetChipAtPosition().GetSymbol()}|");
                }
                else if (theLocation.GetAvailability() == true && theLocation.location[0] == 0)
                {
                    Console.Write($"{theLocation.location[1]}|.");
                }
                else if (theLocation.GetAvailability() == false && theLocation.location[0] == 0)
                {
                    Console.Write($"{theLocation.location[1]}|{theLocation.GetChipAtPosition().GetSymbol()}");
                }
                else if (theLocation.GetAvailability() == false)
                {
                    Console.Write($" {theLocation.GetChipAtPosition().GetSymbol()}");
                }
                else if (theLocation.GetAvailability() == true)
                {
                    Console.Write(" .");
                }
            }
        }

        public bool? CheckForAvailability(int column, int row)
        {

            bool? available = null;

            foreach (var theLocation in theGrid)
            {
                if (theLocation.location[0] == column && theLocation.location[1] == row)
                {
                    if (theLocation.GetAvailability() == true)
                    {
                        available = true;
                    }

                    else
                    {
                        available = false;
                    }
                }
            }
            return available;
        }

        public bool? HasAChip(int column, int row, char symbol)
        {
            bool? result = null;

            foreach (var theLocation in theGrid)
            {
                if (theLocation.location[0] == column && theLocation.location[1] == row)
                {
                    if (theLocation.GetAvailability() == false)
                    {
                        if (theLocation.GetChipAtPosition().GetSymbol() == symbol)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                    else
                    {
                        result = false;
                    }

                }

            }
            return result;
        }


        public void OccupyingThePosition(int column, int row, Chip chip)
        {
            foreach (var theLocation in theGrid)
            {
                if (theLocation.location[0] == column && theLocation.location[1] == row)
                {
                    theLocation.Occupy(chip);
                }
            }
        }
     

        public bool? IsAHorizontalConnect4(int row, char symbol)
        {
            bool? horizontalConnect4 = null;
            int column = 0;
            while (column < _column - 3)
            {
                if (HasAChip(column, row, symbol) == true)
                {
                    if (HasAChip(column + 1, row, symbol) == true)
                    {
                        if (HasAChip(column + 2, row, symbol) == true)
                        {
                            if (HasAChip(column + 3, row, symbol) == true)
                            {
                                horizontalConnect4 = true;
                            }
                        }
                    }
                }
                column++;
            }
            if (horizontalConnect4 == null)
            {
                horizontalConnect4 = false;
            }
            return horizontalConnect4;
        }

        public bool? CheckBoardForHorizConnect4(char symbol)
        {
            bool? output = null;
            int row = 0;
            while (row < _row)
            {
                if (IsAHorizontalConnect4(row, symbol) == true)
                {
                    output = true;
                    return output;
                }
                row++;
            }
            if (output == null)
            {
                output = false;
            }
            return output;
        }

        public bool? IsAVerticalConnect4(int column, char symbol)
        {
            bool? verticalConnect4 = null;
            int row = 0;
            while (row < _row - 3)
            {
                if (HasAChip(column, row, symbol) == true)
                {
                    if (HasAChip(column, row + 1, symbol) == true)
                    {
                        if (HasAChip(column, row + 2, symbol) == true)
                        {
                            if (HasAChip(column, row + 3, symbol) == true)
                            {
                                verticalConnect4 = true;
                            }
                        }
                    }
                }
                row++;
            }
            if (verticalConnect4 == null)
            {
                verticalConnect4 = false;
            }
            return verticalConnect4;
        }

        public bool? CheckBoardForVerticalConnect4(char symbol)
        {
            bool? output = null;
            int column = 0;
            while (column < _column)
            {
                if (IsAVerticalConnect4(column, symbol) == true)
                {
                    output = true;
                    return output;
                }
                column++;
            }
            if (output == null)
            {
                output = false;
            }
            return output;
        }
    }
}
