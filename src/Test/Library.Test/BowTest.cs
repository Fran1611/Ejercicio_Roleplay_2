using NUnit.Framework;

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
            RoleplayGame.Bow bow = new RoleplayGame.Bow();
            int bowAttack = bow.AttackValue;
            int expected = 15;
            Assert.AreEqual(expected,bowAttack);
        }

    }
}