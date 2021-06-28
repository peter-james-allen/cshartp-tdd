using NUnit.Framework;
using oystercard;

namespace oystercardTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateOysterCard()
        {
            Oystercard oystercard = new Oystercard("Pete");
            Assert.AreEqual("Pete", oystercard.Name);
        }
    }
}