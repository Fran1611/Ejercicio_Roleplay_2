using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class ArmorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArmorDefenseValue_ExpectedValue()
        {
            Armor armor = new Armor();
            int expected = 25;
            Assert.AreEqual(expected,armor.DefenseValue);

        }
    }
}