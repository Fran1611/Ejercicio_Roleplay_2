using NUnit.Framework;
using RoleplayGame;
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
            Sword sword = new Sword();
            int swordAttack = sword.AttackValue;
            int expected = 25;
            Assert.AreEqual(expected,swordAttack);
        }

    }
}