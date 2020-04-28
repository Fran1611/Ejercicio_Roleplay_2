using System;
using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class WizardTest
    {

        Wizard mago;
        ISpells[] hechizos;
        SpellsBook libroDeHechizos = new SpellsBook();
        Staff staff = new Staff();

        [SetUp]
        public void Setup()
        {
            mago = new Wizard("Juan");

            ISpells[] hechizos = new ISpells[]{new Spell()};
            libroDeHechizos.Spells=hechizos;
            mago.SpellsBook=libroDeHechizos;
            mago.Staff=staff;
        }

        [Test]
        public void TestAttackValue_1Hechizo()
        {
            int esperado = 170;
            Assert.AreEqual(esperado, mago.AttackValue);
        }

        [Test]
        public void TestAttackValue_2Hechizos()
        {
            ISpells[] hechizos = new ISpells[]{new Spell(), new SpellTwo()};
            libroDeHechizos.Spells = hechizos;
            mago.SpellsBook=libroDeHechizos;

            int esperado = 270;
            Assert.AreEqual(esperado, mago.AttackValue);
        }

        [Test]
        public void TestDefenseValue_1Hechizo()
        {
            int esperado = 170;
            Assert.AreEqual(esperado, mago.DefenseValue);
        }

        [Test]
        public void TestDefenseValue_2Hechizos()
        {
            ISpells[] hechizos = new ISpells[]{new Spell(), new SpellTwo()};
            libroDeHechizos.Spells=hechizos;
            mago.SpellsBook=libroDeHechizos;

            int esperado = 220;
            Assert.AreEqual(esperado, mago.DefenseValue);
        }

        [Test]
        public void TestHealth_AntesDeAtacar()
        {
            int esperado = 100;
            Assert.AreEqual(esperado, mago.Health);
        }
        
        [Test]
        public void TestHealth_despuesDeAtaque25()
        {
            mago.ReceiveAttack(25);
            int esperado = 75;
            Assert.AreEqual(esperado, mago.Health);
        }

        [Test]
        public void TestHealth_despuesDeAtaque140()
        {
            mago.ReceiveAttack(140);
            int esperado = mago.Health;
            Assert.AreEqual(esperado, 0);
        }

        
        [Test]
        public void TestReceiveAttack_Danio0()
        {
            mago.ReceiveAttack(0);
            int esperado = 100;
            Assert.AreEqual(esperado,mago.Health);
        }

        [Test]
        public void TestReceiveAttack_Danio33()
        {
            mago.ReceiveAttack(33);
            int esperado = 67;
            Assert.AreEqual(esperado,mago.Health);
        }

        [Test]
        public void TestReceiveAttack_Danio225()
        {
            mago.ReceiveAttack(225);
            int esperado = 0;
            Assert.AreEqual(esperado,mago.Health);
        }

        [Test]
        public void TestCure()
        {
            int esperado = 0;
            mago.ReceiveAttack(100);
            Assert.AreEqual(esperado, mago.Health);
            mago.Cure();
            esperado = 100;
            Assert.AreEqual(esperado,mago.Health);
        }
    }
}