using NUnit.Framework;
using System;
namespace PlayerLibrary.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void TestPlayerConstructor()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);

            Assert.AreEqual(john.GetName(), "John");
            Assert.AreEqual(john.GetAge(), 12);
            Assert.AreEqual(john.GetSkillLevel(), 8.5);
            Assert.AreEqual(john.GetNumChipsRemain(), 21);
            Assert.AreEqual(computer.GetName(), "MyMacComputer");
            Assert.AreEqual(computer.GetAge(), 3);
            Assert.AreEqual(computer.GetSkillLevel(), 9.99);
            Assert.AreEqual(computer.GetNumChipsRemain(), 21);
        }

        [Test]
        public void TestDecreaseChips()
        {
            Player john = new Player("John", 12, 8.5, 21);
            Player computer = new Player("MyMacComputer", 3, 9.99, 21);
            john.DecreaseChips();
            Assert.AreEqual(john.GetNumChipsRemain(), 20);
            computer.DecreaseChips();
            Assert.AreEqual(computer.GetNumChipsRemain(), 20);

            for (int i = 1; i <= 3; i++)
            {
                john.DecreaseChips();
            }
            Assert.AreEqual(john.GetNumChipsRemain(), 17);
        }

    }
}

    

