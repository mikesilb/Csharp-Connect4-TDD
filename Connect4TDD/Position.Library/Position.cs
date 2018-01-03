using System;
using ChipLibrary;

namespace PositionLibrary
{
    public class Position
    {
        private int[] _location;
        private bool _availability;
        private Chip _chipAtPosition;

        public Position(int[] location, bool availability, Chip chipAtPosition)
        {
            _location = location;
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

        public string GetLocation()
        {
            return $"[{_location[0]}, {_location[1]}]";
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
