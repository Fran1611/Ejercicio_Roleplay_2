using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class BowTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void BowAttackValue_ExpectedValue()
        {   
            Bow bow = new Bow();
            int bowAttack = bow.AttackValue;
            int expected = 15;
            Assert.AreEqual(expected,bowAttack);
        }

    }
}