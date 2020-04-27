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

        // Test que verifica el valor de ataque del libro de hechizos con 1 hechizo.
         [Test]
         public void SpellBookAttackValue_ExpectedValue()
        {   
            SpellsBook spellBook = new SpellsBook();
            ISpells[] hechizos = new ISpells[]{new Spell()};
            spellBook.Spells = hechizos;
            int spellBookAttack = spellBook.AttackValue;
            int expected = 70;
            Assert.AreEqual(expected,spellBookAttack);
        }

        // Test que verifica el valor de defensa del libro de hechizos con 1 hechizo.
        [Test]
         public void SpellBookDefenseValue_ExpectedValue()
        {   
            SpellsBook spellBook = new SpellsBook();
            ISpells[] hechizos = new ISpells[]{new Spell()};
            spellBook.Spells = hechizos;
            int spellBookDefense = spellBook.DefenseValue;
            int expected = 70;
            Assert.AreEqual(expected,spellBookDefense);
        }

        // Test que verifica el valor de ataque del libro de hechizos con 2 hechizos.
        [Test]
        public void SpellBookAttackValue_With_Two_Spells()
        {
            SpellsBook spellsBook = new SpellsBook();
            ISpells[] hechizos = new ISpells[]{new Spell(), new SpellTwo()};
            spellsBook.Spells = hechizos;
            int spellBookAttack = spellsBook.AttackValue;
            int expected = 170;
            Assert.AreEqual(expected, spellBookAttack); 
        }

        // Test que verifica el valor de defensa del libro de hechizos con 2 hechizo.
        [Test]
        public void SpellBookDefenseValue_Whit_Two_Spells()
        {   
            SpellsBook spellsBook = new SpellsBook();
            ISpells[] hechizos = new ISpells[]{new Spell(), new SpellTwo()};
            spellsBook.Spells = hechizos;
            int spellsBookDefense = spellsBook.DefenseValue;
            int expected = 120;
            Assert.AreEqual(expected,spellsBookDefense);
        }

        // Test que verifica el valor de defensa del libro de hechizos con 0 hechizos.
        [Test]
        public void SpellBookDefenseValue_No_Spells()
        {   
            SpellsBook spellsBook = new SpellsBook();
            ISpells[] hechizos = new ISpells[]{};
            spellsBook.Spells = hechizos;
            int spellBookDefense = spellsBook.DefenseValue;
            int expected = 0;
            Assert.AreEqual(expected,spellBookDefense);
        }

        // Test que verifica el valor de ataque del libro de hechizos con 0 hechizos.
        [Test]
        public void SpellBookAttackValue_No_Spells()
        {   
            SpellsBook spellsBook = new SpellsBook();
            ISpells[] hechizos = new ISpells[]{};
            spellsBook.Spells = hechizos;
            int spellBookAttack = spellsBook.AttackValue;
            int expected = 0;
            Assert.AreEqual(expected,spellBookAttack);
        }
    }
}