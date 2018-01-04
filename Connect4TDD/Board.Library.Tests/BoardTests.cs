using NUnit.Framework;
using System;
using PlayerLibrary;
using ChipLibrary;
using PositionLibrary;

namespace BoardLibrary.Tests
{
    [TestFixture]
    public class BoardTests
    {
        [Test]
        public void TestBoardConstructor()
        {

            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);

            Assert.AreEqual(theNewBoard.GetColumn(), 7);
            Assert.AreEqual(theNewBoard.GetRow(), 6);
            Assert.AreEqual(theNewBoard.theGrid.Count, 42);
            Assert.AreEqual(theNewBoard.theGrid[6].location[0], 6);
            Assert.AreEqual(theNewBoard.theGrid[6].location[1], 5);
            Assert.AreEqual(theNewBoard.theGrid[theNewBoard.theGrid.Count - 1].location[0], 6);
            Assert.AreEqual(theNewBoard.theGrid[theNewBoard.theGrid.Count - 1].location[1], 0);
    
        }
    }
}
