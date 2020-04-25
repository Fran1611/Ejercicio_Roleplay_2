using NUnit.Framework;

namespace Library.Test
{
    public class Tests
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

        [Test]
        public void BowAttackValue_ExpectedValue()
        {   
            RoleplayGame.Bow bow = new RoleplayGame.Bow();
            int bowAttack = bow.AttackValue;
            int expected = 15;
            Assert.AreEqual(expected,bowAttack);
        }

         [Test]
        public void SwordAttackValue_ExpectedValue()
        {   
            RoleplayGame.Sword sword = new RoleplayGame.Sword();
            int swordAttack = sword.AttackValue;
            int expected = 25;
            Assert.AreEqual(expected,swordAttack);
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

         [Test]
         public void StaffAttackValue_ExpectedValue()
        {   
            RoleplayGame.Staff staff = new RoleplayGame.Staff();
            int staffAttack = staff.AttackValue;
            int expected = 100;
            Assert.AreEqual(expected,staffAttack);
        }

        [Test]
         public void StaffDefenseValue_ExpectedValue()
        {   
            RoleplayGame.Staff staff = new RoleplayGame.Staff();
            int staffDefense = staff.DefenseValue;
            int expected = 100;
            Assert.AreEqual(expected,staffDefense);
        }

    }
}