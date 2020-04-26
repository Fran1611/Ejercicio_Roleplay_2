using NUnit.Framework;
using RoleplayGame;
using System.Collections;
namespace Library.Test
{
    public class DwarfTest
    {
        Dwarf enano;
        
        [SetUp]
        public void SetUp()
        {
            enano = new Dwarf("Enano");
            enano.Axe = new Axe();
            enano.Helmet = new Helmet();
            enano.Shield = new Shield();
        }

        [Test]
        // El test verifica que el ataque al Dwarf se efecúa correctamente, cuando ataque < vida
        public void ReceiveAttack_Test()
        {   
            enano.ReceiveAttack(15);
            int expected = 85;
            int actual = enano.Health;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        // El test verifica que el ataque al Dwarf se efecúa correctamente, cuando ataque > vida
        public void ReceiveAttack_Test2()
        {                      
            enano.ReceiveAttack(110);
            int expected = 0;
            int actual = enano.Health;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        // El test verifica que el ataque al Dwarf se efecúa correctamente, cuando ataque = vida
        public void ReceiveAttack_Test3()
        {                        
            enano.ReceiveAttack(100);
            int expected = 0;
            int actual = enano.Health;

            Assert.AreEqual(expected, actual);
        }
        // Verifica que la vida se cura completamente cuando el Dwarf tiene vida = 0.
        [Test]
        public void Cure_Test()
        {                       
            enano.ReceiveAttack(100);
            enano.Cure();
            int actual = enano.Health;
            int expected = 100;
            Assert.AreEqual(expected, actual);
        }

        // Verifica que la vida se cura completamente cuando 100 > vida > 0.
        [Test]
        public void Cure_Test2()
        {
            enano.ReceiveAttack(55);
            enano.Cure();
            int expected = 100;
            int actual = enano.Health;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        // Verifica que el Dwarf se crea de forma correcta, es decir que sus valores de ataque, defensa, vida y nombre son correctos.
        public void Create_a_Dwarf()
        {
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

        // Verifica que el valor de ataque del Dwarf es igual a la suma de valores de ataque de Shield y Helmet.
        [Test]
        public void DefenseValue_test()
        {
            Shield enanoShield = new Shield();
            Helmet enanoHelmet= new Helmet();
            int expected = (enanoHelmet.DefenseValue + enanoShield.DefenseValue);
            int actual = enano.DefenseValue;
            Assert.AreEqual(actual, expected);
        }
    }
}