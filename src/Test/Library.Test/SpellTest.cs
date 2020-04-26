using NUnit.Framework;
using RoleplayGame;
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
            Spell spell = new Spell();
            int spellAttack = spell.AttackValue;
            int expected = 70;
            Assert.AreEqual(expected,spellAttack);
        }

        [Test]
        public void SpellDefenseValue_ExpectedValue()
        {   
            Spell spell = new Spell();
            int spellDefense = spell.DefenseValue;
            int expected = 70;
            Assert.AreEqual(expected,spellDefense);
        }

    }
}