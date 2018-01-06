using NUnit.Framework;
using System;
using ChipLibrary;
using PlayerLibrary;
using BoardLibrary;
namespace MoveLibrary.Tests
{
    [TestFixture]
    public class MoveTests
    {
        [Test]
        public void TestMoveConstructor()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);

            Move firstMove = new Move(johnChip, 2);
            Move secondMove = new Move(computerChip, 1);

            Assert.AreEqual(firstMove.GetChipFromPlayer(), johnChip);
            Assert.AreEqual(firstMove.GetChipFromPlayer().GetOwner(), "John");
            Assert.AreEqual(firstMove.GetColumn(), 2);
            Assert.AreEqual(secondMove.GetChipFromPlayer(), computerChip);
            Assert.AreEqual(secondMove.GetChipFromPlayer().GetOwner(), "MyMacComputer");
            Assert.AreEqual(secondMove.GetColumn(), 1);
        }

        [Test]
        public void TestIdentifyDropPosition1()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);

            Move thirdMove = new Move(johnChip, 2);

            Assert.AreEqual(theNewBoard.CheckForAvailability(thirdMove.GetColumn(), 0), true);
            Assert.AreEqual(thirdMove.IdentifyDropPosition(theNewBoard), true);
            Assert.AreEqual(theNewBoard.CheckForAvailability(thirdMove.GetColumn(), 0), false);
        }



        [Test]
        public void TestIdentifyDropPosition2()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);

            Move fourthMove = new Move(johnChip, 4);
            Move fifthMove = new Move(johnChip, 4);

            fourthMove.IdentifyDropPosition(theNewBoard);
            Assert.AreEqual(theNewBoard.CheckForAvailability(fourthMove.GetColumn(), 0), false);
            Assert.AreEqual(theNewBoard.CheckForAvailability(fourthMove.GetColumn(), 1), true);
            fifthMove.IdentifyDropPosition(theNewBoard);
            Assert.AreEqual(theNewBoard.CheckForAvailability(fourthMove.GetColumn(), 0), false);
            Assert.AreEqual(theNewBoard.CheckForAvailability(fourthMove.GetColumn(), 1), false);
        }

        [Test]
        public void TestIdentifyDropPosition3()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Board theNewBoard = new Board(7, 6);

            Move sixthMove = new Move(johnChip, 4);
            Move seventhMove = new Move(johnChip, 4);
            Move eighthMove = new Move(computerChip, 4);
            Move ninthMove = new Move(johnChip, 4);
            Move tenthMove = new Move(computerChip, 4);
            Move eleventhMove = new Move(johnChip, 4);
            Move twelfthMove = new Move(computerChip, 4);

            Assert.AreEqual(sixthMove.IdentifyDropPosition(theNewBoard), true);
            Assert.AreEqual(seventhMove.IdentifyDropPosition(theNewBoard), true);
            Assert.AreEqual(eighthMove.IdentifyDropPosition(theNewBoard), true);
            Assert.AreEqual(ninthMove.IdentifyDropPosition(theNewBoard), true);
            Assert.AreEqual(tenthMove.IdentifyDropPosition(theNewBoard), true);
            Assert.AreEqual(eleventhMove.IdentifyDropPosition(theNewBoard), true);
            Assert.AreEqual(twelfthMove.IdentifyDropPosition(theNewBoard), false);
        }
    }
}
