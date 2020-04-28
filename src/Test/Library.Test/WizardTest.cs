using System;
using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class WizardTest
    {

        Wizard mago;
        ISpells[] hechizos = new ISpells[] {new Spell()};
        SpellsBook libroDeHechizos = new SpellsBook();

        Staff staff = new Staff();


        [SetUp]
        public void Setup()
        {
            mago = new Wizard("Juan");
            libroDeHechizos.Spells=hechizos;

            mago.SpellsBook=libroDeHechizos;
            mago.Staff = staff;
        }

        [Test]
        public void TestGetSpellsBook()
        {
            SpellsBook esperado = this.libroDeHechizos;
            Assert.AreEqual(esperado, mago.SpellsBook);
        }

        [Test]
        public void TestsetSpellsBook()
        {
            SpellsBook esperado = new SpellsBook();

            ISpells[] hechizos2 = new ISpells[] {new Spell()};

            Spell hechizo1 = new Spell();
            SpellTwo hechizo2 = new SpellTwo();
           

            hechizos2[0]=hechizo1;
            hechizos2[1]=hechizo2;

            esperado.Spells = hechizos2;

            mago.SpellsBook = esperado;

            Assert.AreEqual(esperado, mago.SpellsBook);
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
            Spell hechizo1 = new Spell();
            SpellTwo hechizo2 = new SpellTwo();
            hechizos = new Spell[1];
            hechizos[0]=hechizo1;
            hechizos[1]=hechizo2;
            libroDeHechizos.Spells=hechizos;
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
            Spell hechizo1 = new Spell();
            SpellTwo hechizo2 = new SpellTwo();
            hechizos = new Spell[1];
            hechizos[0]=hechizo1;
            hechizos[1]=hechizo2;
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
