using NUnit.Framework;

namespace Library.Test
{
    public class AxeTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void AxeAttackValue_ExpectedValue()
        {   
            RoleplayGame.Axe axe = new RoleplayGame.Axe();
            int axeAttack = axe.AttackValue;
            int expected = 25;
            Assert.AreEqual(expected,axeAttack);
        }
    }
}