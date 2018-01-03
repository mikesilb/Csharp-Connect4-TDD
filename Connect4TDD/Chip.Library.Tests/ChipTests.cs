using NUnit.Framework;
using System;
using PlayerLibrary;
namespace ChipLibrary.Tests
{
    [TestFixture]
    public class ChipTests
    {
        [Test]
        public void TestChipConstructor()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            Chip johnChip = new Chip(john.GetName(), 'X');
            Chip computerChip = new Chip(computer.GetName(), 'O');

            Assert.AreEqual(johnChip.GetOwner(), "John");
            Assert.AreEqual(johnChip.GetSymbol(), 'X');
            Assert.AreEqual(computerChip.GetOwner(), "MyMacComputer");
            Assert.AreEqual(computerChip.GetSymbol(), 'O');
        }
    }
}
