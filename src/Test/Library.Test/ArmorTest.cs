using NUnit.Framework;

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
            RoleplayGame.Armor armor = new RoleplayGame.Armor();
            int expected = 25;
            Assert.AreEqual(expected,armor.DefenseValue);

        }
    }
}