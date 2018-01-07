using System;
namespace ChipLibrary
{
    public class Chip
    {
        private string _owner;
        private char _symbol;

        public Chip(string owner, char symbol)
        {
            _owner = owner;
            _symbol = symbol;
        }

        public string GetOwner()
        {
            return _owner;
        }

        public char GetSymbol()
        {
            return _symbol;
        }
    }
}
