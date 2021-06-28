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
        public void NewOysterCardHasBalance()
        {
            Oystercard oystercard = new Oystercard(10);
            Assert.AreEqual(10, oystercard.Balance);
        }
    }
}