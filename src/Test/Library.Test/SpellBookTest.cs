using NUnit.Framework;
using RoleplayGame;

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
            SpellsBook spellBook = new SpellsBook();
            spellBook.Spells = new Spell[]{ new Spell() };
            int spellBookAttack = spellBook.AttackValue;
            int expected = 70;
            Assert.AreEqual(expected,spellBookAttack);
        }

        [Test]
         public void SpellBookDefenseValue_ExpectedValue()
        {   
            SpellsBook spellBook = new SpellsBook();
            spellBook.Spells = new Spell[]{ new Spell() };
            int spellBookDefense = spellBook.DefenseValue;
            int expected = 70;
            Assert.AreEqual(expected,spellBookDefense);
        }

    }
}