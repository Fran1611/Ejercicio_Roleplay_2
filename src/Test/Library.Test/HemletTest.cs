using NUnit.Framework;

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
            RoleplayGame.Helmet helmet = new RoleplayGame.Helmet();
            int expected = 18;
            Assert.AreEqual(expected,helmet.DefenseValue);

        }
    }
}