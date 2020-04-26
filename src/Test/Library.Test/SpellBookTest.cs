using NUnit.Framework;

namespace Library.Test
{
    public class SpellBookTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

         [Test]
         public void SpellBookAttackValue_ExpectedValue()
        {   
            RoleplayGame.SpellsBook spellBook = new RoleplayGame.SpellsBook();
            spellBook.Spells = new RoleplayGame.Spell[]{ new RoleplayGame.Spell() };
            int spellBookAttack = spellBook.AttackValue;
            int expected = 70;
            Assert.AreEqual(expected,spellBookAttack);
        }

        [Test]
         public void SpellBookDefenseValue_ExpectedValue()
        {   
            RoleplayGame.SpellsBook spellBook = new RoleplayGame.SpellsBook();
            spellBook.Spells = new RoleplayGame.Spell[]{ new RoleplayGame.Spell() };
            int spellBookDefense = spellBook.DefenseValue;
            int expected = 70;
            Assert.AreEqual(expected,spellBookDefense);
        }

    }
}