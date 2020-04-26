using NUnit.Framework;
using RoleplayGame;

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
    }
}