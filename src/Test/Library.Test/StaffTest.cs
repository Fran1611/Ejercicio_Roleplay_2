using NUnit.Framework;

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