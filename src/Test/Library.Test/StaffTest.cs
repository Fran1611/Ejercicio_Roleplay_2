using NUnit.Framework;
using RoleplayGame;
namespace Library.Test
{
    public class StaffTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

          [Test]
         public void StaffAttackValue_ExpectedValue()
        {   
            Staff staff = new Staff();
            int staffAttack = staff.AttackValue;
            int expected = 100;
            Assert.AreEqual(expected,staffAttack);
        }

        [Test]
         public void StaffDefenseValue_ExpectedValue()
        {   
            Staff staff = new Staff();
            int staffDefense = staff.DefenseValue;
            int expected = 100;
            Assert.AreEqual(expected,staffDefense);
        }


    }
}