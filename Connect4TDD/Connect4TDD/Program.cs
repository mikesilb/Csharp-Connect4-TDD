using System;
using System.Collections.Generic;
using PlayerLibrary;
using ChipLibrary;
using PositionLibrary;
using MoveLibrary;
using BoardLibrary;

namespace Connect4TDD
{
    class Connect4
    {
        
        private Dictionary<string, Player> gameDataPlayer = new Dictionary<string, Player>();
        private Dictionary<string, Chip> gameDataChip = new Dictionary<string, Chip>();
        private Dictionary<string, int> gameDataInt = new Dictionary<string, int>();
        private Dictionary<string, Board> gameDataBoard = new Dictionary<string, Board>();
        public Player Player1;
        public Player Player2;
        public Chip Player1Chip;
        public Chip Player2Chip;
        public int Player1ChipTotal;
        public int Player2ChipTotal;

        public Connect4()
        {
            Board theGameBoard = new Board(7, 6);
            gameDataBoard.Add("The Game Board", theGameBoard);

        }

        public void nameInput(Player whichPlayer)
        {  
            string name = "";
            while (name == "")
            {
                Console.WriteLine($"\n{whichPlayer.GetName()}, what is your name?");
                name = Console.ReadLine();
            }
            while (whichPlayer.GetName() == "Player 2" && name == Player1.GetName())
            {
                Console.WriteLine("You can't have the same name as Player 1");
                Console.WriteLine($"\n{whichPlayer.GetName()}, what is your name?");
                name = Console.ReadLine();
            }
            if (whichPlayer.GetName() == "Player 1")
            {
                Player1 = new Player(name);
                gameDataPlayer.Add("Player 1", Player1);
                Player1Chip = new Chip("Player 1", 'X');
                gameDataChip.Add("Player 1 Chip", Player1Chip);
                Player1ChipTotal = Player1.GetNumChipsRemain();
                gameDataInt.Add("Player 1 Chip Total", Player1ChipTotal);
            }
            else if (whichPlayer.GetName() == "Player 2")
            {
                Player2 = new Player(name);
                gameDataPlayer.Add("Player 2", Player2);
                Player2Chip = new Chip("Player 2", 'O');
                gameDataChip.Add("Player 2 Chip", Player2Chip);
                Player2ChipTotal = Player2.GetNumChipsRemain();
                gameDataInt.Add("Player 2 Chip Total", Player2ChipTotal);
            }
        }

        public Dictionary<string, Player> GetGameDataPlayer()
        {
            return gameDataPlayer;
        }
        public Dictionary<string, Chip> GetGameDataChip()
        {
            return gameDataChip;
        }
        public Dictionary<string, int> GetGameDataInt()
        {
            return gameDataInt;
        }

        public Dictionary<string, Board> GetGameDataBoard()
        {
            return gameDataBoard;
        }


            public static void Main(string[] args)
        {
            //bool interestToPlay = true;
            Connect4 c4 = new Connect4();
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            c4.nameInput(player1);
            c4.nameInput(player2);
           // c4.areWeInterested(interestToPlay);
        }
    }
}
