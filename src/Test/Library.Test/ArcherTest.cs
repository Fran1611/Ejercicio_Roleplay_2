using System;
using NUnit.Framework; 

namespace Library.Test
{
    public class ArcherTest
    {

        RoleplayGame.Archer daniel;

        [SetUp]
        public void Setup()
        {
            daniel = new RoleplayGame.Archer("Daniel");
        }

        [Test]
        public void Archer_Name_ShouldReturnName()
        {
            Assert.AreEqual(daniel.Name, "Daniel");
        }

        [Test]
        public void AttackValue_Element_ElementValue()
        {
            daniel.Bow = new RoleplayGame.Bow();
            RoleplayGame.Bow actual = daniel.Bow;
            Assert.AreEqual(actual.AttackValue, 15);
        }

        [Test]
        public void DefenseValue_Element_ElementValue()
        {
            daniel.Helmet = new RoleplayGame.Helmet();
            RoleplayGame.Helmet actual = daniel.Helmet;
            Assert.AreEqual(actual.DefenseValue, 18);
        }

        [Test]
        public void Health_IntOverCero_Health()
        {
            daniel.Health = 100;
            int actual = daniel.Health;
            Assert.AreEqual(actual, 100);
        }

        [Test]
        public void Health_IntLessThanCero_Cero()
        {
            daniel.Health = -11;
            int actual = daniel.Health;
            Assert.AreEqual(actual, 0);
        }

        [Test]
        public void ReceiveAttack_Damage_NewLife()
        {
            daniel.Health = 100;
            daniel.ReceiveAttack(70);
            Assert.AreEqual(daniel.Health, 30);
        }

        [Test]
        public void Cure_Life100()
        {
            daniel.Health = 0;
            daniel.Cure();
            Assert.AreEqual(daniel.Health, 100);
        }
    }
}