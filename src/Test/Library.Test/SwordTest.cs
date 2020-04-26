using NUnit.Framework;

namespace Library.Test
{
    public class SwordTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

         [Test]
        public void SwordAttackValue_ExpectedValue()
        {   
            RoleplayGame.Sword sword = new RoleplayGame.Sword();
            int swordAttack = sword.AttackValue;
            int expected = 25;
            Assert.AreEqual(expected,swordAttack);
        }

    }
}