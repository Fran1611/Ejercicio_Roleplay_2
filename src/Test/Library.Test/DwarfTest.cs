using NUnit.Framework;
using RoleplayGame;
using System.Collections;
namespace Library.Test
{
    public class DwarfTest
    {

        [Test]
        // El test verifica que el ataque al Dwarf se efecúa correctamente, cuando ataque < vida
        public void ReceiveAttack_Test()
        {   
            Dwarf enano = new Dwarf("Enano");
            enano.Axe = new Axe();
            enano.Shield = new Shield();
            enano.Helmet = new Helmet();

            Archer arquero = new Archer("Arquero");
            arquero.Bow = new Bow();
            arquero.Helmet = new Helmet();

            enano.ReceiveAttack(arquero.AttackValue);

            int expected = 85;
            int actual = enano.Health;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        // El test verifica que el ataque al Dwarf se efecúa correctamente, cuando ataque > vida
        public void ReceiveAttack_Test2()
        {
            Dwarf enano = new Dwarf("Enano");
            enano.Axe = new Axe();
            enano.Shield = new Shield();
            enano.Helmet = new Helmet();

            Wizard mago = new Wizard("Mago Negro");
            mago.Staff = new Staff();
            SpellsBook book = new SpellsBook();
            Spell[] hechizos = new Spell[1];
            Spell hechizo = new Spell();
            hechizos[0] = hechizo;
            book.Spells = hechizos;
            mago.SpellsBook = book;
            
            enano.ReceiveAttack(mago.AttackValue);

            int expected = 0;
            int actual = enano.Health;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        // El test verifica que el ataque al Dwarf se efecúa correctamente, cuando ataque = vida
        public void ReceiveAttack_Test3()
        {
            Dwarf enano = new Dwarf("Enano");
            enano.Axe = new Axe();
            enano.Shield = new Shield();
            enano.Helmet = new Helmet();

            Wizard mago = new Wizard("Mago Negro");
            mago.Staff = new Staff();
            SpellsBook book = new SpellsBook();
            Spell[] hechizos = new Spell[0];

            book.Spells = hechizos;
            mago.SpellsBook = book;
            
            enano.ReceiveAttack(mago.AttackValue);
            int expected = 0;
            int actual = enano.Health;

            Assert.AreEqual(expected, actual);
        }
        // Verifica que la vida se cura completamente cuando el Dwarf tiene vida = 0.
        [Test]
        public void Cure_Test()
        {
            Dwarf enano = new Dwarf("Enano");
            enano.Axe = new Axe();
            enano.Shield = new Shield();
            enano.Helmet = new Helmet();

            Wizard mago = new Wizard("Mago Negro");
            mago.Staff = new Staff();
            SpellsBook book = new SpellsBook();
            Spell[] hechizos = new Spell[1];
            Spell hechizo = new Spell();
            hechizos[0] = hechizo;
            book.Spells = hechizos;
            mago.SpellsBook = book;
            
            enano.ReceiveAttack(mago.AttackValue);
            enano.Cure();

            int actual = enano.Health;
            int expected = 100;

            Assert.AreEqual(expected, actual);
        }

        // Verifica que la vida se cura completamente cuando 100 > vida > 0.
        [Test]
        public void Cure_Test2()
        {
            Dwarf enano = new Dwarf("Enano");
            enano.Axe = new Axe();
            enano.Shield = new Shield();
            enano.Helmet = new Helmet();

            Archer arquero = new Archer("Arquero");
            arquero.Bow = new Bow();
            arquero.Helmet = new Helmet();

            enano.ReceiveAttack(arquero.AttackValue);
            enano.Cure();

            int expected = 100;
            int actual = enano.Health;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        // Verifica que el Dwarf se crea de forma correcta, es decir que sus valores de ataque, defensa, vida y nombre son correctos.
        public void Create_a_Dwarf()
        {
            Dwarf enano = new Dwarf("Enano");
            enano.Axe = new Axe();
            enano.Shield = new Shield();
            enano.Helmet = new Helmet();
            ArrayList personaje = new ArrayList();
            personaje.Add(enano.Name);
            personaje.Add(enano.Health);
            personaje.Add(enano.DefenseValue);
            personaje.Add(enano.AttackValue);

            ArrayList expected = new ArrayList();
            expected.Add("Enano");
            expected.Add(100);
            expected.Add(32);
            expected.Add(25);

            Assert.AreEqual(personaje,expected);


        }
    }
}