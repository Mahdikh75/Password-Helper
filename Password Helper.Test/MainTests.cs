using NUnit.Framework;

namespace Password_Helper.Test
{
    public class MainTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNumber()
        {
            var net = new Password(4, 8).Get();
            Assert.AreEqual(net, 150);
        }

        [Test]
        public void TestString()
        {

        }

        [Test]
        public void TestAll()
        {

        }

        [Test]
        public void TestPattern()
        {

        }

    }
}