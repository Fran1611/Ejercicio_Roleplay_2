using NUnit.Framework;

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
            RoleplayGame.Shield shield = new RoleplayGame.Shield();
            int expected = 14;
            Assert.AreEqual(expected,shield.DefenseValue);

        }
    }
}