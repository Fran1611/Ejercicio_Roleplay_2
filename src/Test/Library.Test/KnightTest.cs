using System;
using RoleplayGame;
using NUnit.Framework;

namespace Library.Test
{
    public class KnightTest
    {
        Knight arthur;

        [SetUp]
        public void SetUp()
        {
            arthur = new Knight("Arthur");
        }

        [Test]
        public void DefenseValue_TwoElement_ElementValue()
        {
            arthur.Shield = new Shield();
            Shield actual1 = arthur.Shield;
            arthur.Armor = new Armor();
            Armor actual2 = arthur.Armor;
            Assert.AreEqual(arthur.DefenseValue, 39);
        }

        [Test]
        public void Health_IntOverCero_Health()
        {
            int actual = arthur.Health;
            Assert.AreEqual(actual, 100);
        }

        [Test]
        public void Health_IntLessThanCero_Cero()
        {
            arthur.ReceiveAttack(145);
            int actual = arthur.Health;
            Assert.AreEqual(actual, 0);
        }

        [Test]
        public void ReceiveAttack_Damage_NewLife()
        {
            arthur.ReceiveAttack(70);
            Assert.AreEqual(arthur.Health, 30);
        }

        [Test]
        public void Cure_Life100()
        {
            arthur.ReceiveAttack(100);
            arthur.Cure();
            Assert.AreEqual(arthur.Health, 100);
        }

    }
}
