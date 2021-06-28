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
            Oystercard oystercard = new Oystercard(10.0);
            Assert.AreEqual(10.0, oystercard.Balance);
        }

        [Test]
        public void AddBalance()
        {
            Oystercard oystercard = new Oystercard(10.0);
            oystercard.TopUp(10.0);
            Assert.AreEqual(20.0, oystercard.Balance);
        }    }
}