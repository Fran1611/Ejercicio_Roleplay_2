using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class ShieldTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShieldDefenseValue_ExpectedValue()
        {
            Shield shield = new Shield();
            int expected = 14;
            Assert.AreEqual(expected,shield.DefenseValue);

        }
    }
}