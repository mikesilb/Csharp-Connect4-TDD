using NUnit.Framework;
using System;
using PlayerLibrary;
using ChipLibrary;
namespace PositionLibrary.Tests
{
    [TestFixture]
    public class PositionTests
    {
        [Test]
        public void TestPositionConstructor()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');

            Position positionA = new Position(new int[] { 0, 0 }, false, johnChip);
            Position positionB = new Position(new int[] { 4, 3 }, true, null);
            Position positionC = new Position(new int[] { 5, 6 }, true, null);
            Position positionD = new Position(new int[] { 3, 4 }, false, computerChip);


            Assert.AreEqual(positionA.GetLocation(), "[0, 0]");
            Assert.AreEqual(positionA.GetAvailability(), false);
            Assert.AreEqual(positionB.GetLocation(), "[4, 3]");
            Assert.AreEqual(positionB.GetAvailability(), true);
            Assert.AreEqual(positionC.GetLocation(), "[5, 6]");
            Assert.AreEqual(positionC.GetAvailability(), true);

            Assert.AreEqual(positionA.GetChipAtPosition(), johnChip);
            Assert.AreEqual(positionD.GetChipAtPosition(), computerChip);
        }

        [Test]
        public void TestOccupy()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');
            Position positionB = new Position(new int[] { 4, 3 }, true, null);
            Position positionC = new Position(new int[] { 5, 6 }, true, null);

            positionB.Occupy(computerChip);
            Assert.AreEqual(positionB.GetAvailability(), false);
            Assert.AreEqual(positionB.GetChipAtPosition(), computerChip);

            positionC.Occupy(johnChip);
            Assert.AreEqual(positionC.GetAvailability(), false);
            Assert.AreEqual(positionC.GetChipAtPosition(), johnChip);

            positionB.Occupy(johnChip);
            Assert.AreEqual(positionB.GetChipAtPosition(), computerChip);
        }

    }
}
