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

        [Test]
        public void TestCheckForAvailability()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);
            theNewBoard.theGrid[10].Occupy(johnChip);
            theNewBoard.theGrid[30].Occupy(computerChip);
            Assert.AreEqual(theNewBoard.CheckForAvailability(0, 0), true);
            Assert.AreEqual(theNewBoard.CheckForAvailability(2, 0), true);
            Assert.AreEqual(theNewBoard.CheckForAvailability(3, 5), true);
            Assert.AreEqual(theNewBoard.CheckForAvailability(2, 1), false);
            Assert.AreEqual(theNewBoard.CheckForAvailability(3, 4), false);
        }

        [Test]
        public void TestHasAChip()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);
            Assert.AreEqual(theNewBoard.HasAChip(0, 4, 'O'), false);
            theNewBoard.theGrid[10].Occupy(johnChip);
            Assert.AreEqual(theNewBoard.HasAChip(3, 4, 'X'), true);
            Assert.AreEqual(theNewBoard.HasAChip(3, 4, 'O'), false);
            theNewBoard.theGrid[30].Occupy(computerChip);
            Assert.AreEqual(theNewBoard.HasAChip(2, 1, 'O'), true);
            Assert.AreEqual(theNewBoard.HasAChip(2, 1, 'X'), false);
        }

        [Test]
        public void TestOccupyingThePosition()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);
            Assert.AreEqual(theNewBoard.CheckForAvailability(3, 2), true);
            theNewBoard.OccupyingThePosition(3, 2, johnChip);
            Assert.AreEqual(theNewBoard.CheckForAvailability(3, 2), false);
        }

        [Test]
        public void TestIsAHorizontalConnect4()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);
            theNewBoard.theGrid[30].Occupy(johnChip);
            theNewBoard.theGrid[31].Occupy(johnChip);
            theNewBoard.theGrid[32].Occupy(johnChip);
            Assert.AreEqual(theNewBoard.IsAHorizontalConnect4(1, 'X'), false);
            theNewBoard.theGrid[33].Occupy(johnChip);
            Assert.AreEqual(theNewBoard.IsAHorizontalConnect4(1, 'X'), true);
        }

        [Test]
        public void TestCheckBoardForHorizConnect4()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);
            theNewBoard.theGrid[30].Occupy(johnChip);
            theNewBoard.theGrid[31].Occupy(johnChip);
            theNewBoard.theGrid[32].Occupy(johnChip);
            Assert.AreEqual(theNewBoard.CheckBoardForHorizConnect4('X'), false);
            theNewBoard.theGrid[33].Occupy(johnChip);
            Assert.AreEqual(theNewBoard.IsAHorizontalConnect4(1, 'X'), true);
            Assert.AreEqual(theNewBoard.CheckBoardForHorizConnect4('X'), true);
        }

        [Test]
        public void TestIsAVerticalConnect4()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);
            theNewBoard.theGrid[37].Occupy(johnChip);
            theNewBoard.theGrid[30].Occupy(johnChip);
            theNewBoard.theGrid[23].Occupy(johnChip);
            Assert.AreEqual(theNewBoard.IsAVerticalConnect4(2, 'X'), false);
            theNewBoard.theGrid[16].Occupy(johnChip);
            Assert.AreEqual(theNewBoard.IsAVerticalConnect4(2, 'X'), true);
        }

        [Test]
        public void TestCheckBoardForVerticalConnect4()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);
            theNewBoard.theGrid[37].Occupy(johnChip);
            theNewBoard.theGrid[30].Occupy(johnChip);
            theNewBoard.theGrid[23].Occupy(johnChip);
            Assert.AreEqual(theNewBoard.CheckBoardForVerticalConnect4('X'), false);
            theNewBoard.theGrid[16].Occupy(johnChip);
            Assert.AreEqual(theNewBoard.IsAVerticalConnect4(2, 'X'), true);
            Assert.AreEqual(theNewBoard.CheckBoardForVerticalConnect4('X'), true);
        }
    }
}
