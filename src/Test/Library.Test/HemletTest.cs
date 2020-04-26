using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class HemletTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HemletDefenseValue_ExpectedValue()
        {
            Helmet helmet = new Helmet();
            int expected = 18;
            Assert.AreEqual(expected,helmet.DefenseValue);

        }
    }
}