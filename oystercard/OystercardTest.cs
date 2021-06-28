using NUnit.Framework;
using oystercard;
using System;

namespace oystercardTest
{
    public class Tests
    {
        private Oystercard oystercard;
        
        [SetUp]
        public void Setup()
        {
            oystercard = new Oystercard(50.0);
        }

        [Test]
        public void NewOysterCardHasBalance()
        {
            Assert.AreEqual(50.0, oystercard.Balance);
        }

        [Test]
        public void AddBalance()
        {
            oystercard.TopUp(10.0);
            Assert.AreEqual(60.0, oystercard.Balance);

            oystercard.TopUp(30.0);
            Assert.AreEqual(90.0, oystercard.Balance);
            Assert.Throws<ArgumentOutOfRangeException>(() => oystercard.TopUp(10.0));
        }

        // [Test]
        // public void RemoveBalance()
        // {
        //     oystercard.Deduct(10.0);
        //     Assert.AreEqual(40.0, oystercard.Balance);
        // }

       [Test]
       public void InJourney()
       {
           Assert.AreEqual(false, oystercard.IsInJourney);
       }

       [Test]
       public void TouchIn()
       {
           oystercard.TouchIn();
           Assert.AreEqual(true, oystercard.IsInJourney);

       }

       [Test]
       public void MinimumLimit()
       {
           oystercard = new Oystercard(0.0);
           Assert.Throws<ArgumentOutOfRangeException>(() => oystercard.TouchIn());
       }

       [Test]
       public void TouchOut()
       {
           oystercard.TouchIn();
           oystercard.TouchOut();
           Assert.AreEqual(false, oystercard.IsInJourney);
       }

       [Test]
       public void Journey()
       {
           oystercard.TouchIn();
           oystercard.TouchOut();
           Assert.AreEqual(49.0,oystercard.Balance);
       }
    }
}