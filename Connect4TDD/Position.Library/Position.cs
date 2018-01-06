using System;
using ChipLibrary;

namespace PositionLibrary
{
    public class Position
    {
        public int[] location { get; set; }
        private bool _availability;
        private Chip _chipAtPosition;

        public Position(int[] thelocation, bool availability, Chip chipAtPosition)
        {
            location = thelocation;
            _availability = availability;
            _chipAtPosition = chipAtPosition;
        }

        public void Occupy(Chip chip)
        {
            if (_availability == true)
            {
                _availability = false;
                _chipAtPosition = chip; 
            }

        }


        public bool GetAvailability()
        {
            return _availability;
        }

        public Chip GetChipAtPosition()
        {
            return _chipAtPosition;
        }

        public void SetAvailability(bool availability)
        {
            _availability = availability ;
        }

        public void GetChipAtPosition(Chip chipAtPosition)
        {
            _chipAtPosition = chipAtPosition;
        }

    }
}
