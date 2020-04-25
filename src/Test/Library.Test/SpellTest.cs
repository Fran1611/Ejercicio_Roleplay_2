using NUnit.Framework;

namespace Library.Test
{
    public class SpellTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void SpellAttackValue_ExpectedValue()
        {   
            RoleplayGame.Spell spell = new RoleplayGame.Spell();
            int spellAttack = spell.AttackValue;
            int expected = 70;
            Assert.AreEqual(expected,spellAttack);
        }

        [Test]
        public void SpellDefenseValue_ExpectedValue()
        {   
            RoleplayGame.Spell spell = new RoleplayGame.Spell();
            int spellDefense = spell.DefenseValue;
            int expected = 70;
            Assert.AreEqual(expected,spellDefense);
        }

    }
}