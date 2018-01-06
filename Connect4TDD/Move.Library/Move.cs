using System;
using ChipLibrary;
using BoardLibrary;
namespace MoveLibrary
{
    public class Move
    {
        private Chip _chipFromPlayer;
        private int _column;

        public Move(Chip chipFromPlayer, int column) 
        {
            _chipFromPlayer = chipFromPlayer;
            _column = column;
        }    

        public Chip GetChipFromPlayer()
        {
            return _chipFromPlayer;
        }

        public int GetColumn()
        {
            return _column;
        }

        public bool? IdentifyDropPosition(Board board)
        {
            bool? output = null;
            if (board.CheckForAvailability(_column, board.GetRow() - 1) == false)
            {
                Console.WriteLine("\n\n\nThis column is completely filled.  Make another move.");
                output = false;
            }
            else
            {
                int row = 0;
                while (row <= board.GetRow())
                {
                    if (board.CheckForAvailability(_column, row) == true)
                    {
                        board.OccupyingThePosition(_column, row, _chipFromPlayer);
                        output = true;
                        return output;
                    }
                    else
                    {
                        row++;
                    }
                }
            }
            return output;
        }
    }
}
