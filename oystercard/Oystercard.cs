using System;

namespace oystercard
{
    public class Oystercard
    {
        private const double MAXIMUM_BALANCE = 90.0;
        private const double MINIMUM_FARE = 1.0;
        public double Balance { get; private set; }
        public bool IsInJourney { get; private set; }

        public Oystercard(double balance)
        {
            Balance = balance;
            IsInJourney = false;
        }

        public void TopUp(double amount)
        {
            if ((Balance + amount) > MAXIMUM_BALANCE) throw new ArgumentOutOfRangeException($"Maximum Limit of £{MAXIMUM_BALANCE} Reached.");
            Balance += amount;
        }

        private void Deduct(double amount)
        {
            Balance -= amount;
        }

        public void TouchIn()
        {
            if (Balance < MINIMUM_FARE) throw new ArgumentOutOfRangeException($"Balance less than minimum fare (£{MINIMUM_FARE})");
            IsInJourney = true;
        }

        public void TouchOut()
        {
            Deduct(MINIMUM_FARE);
            IsInJourney = false;
        }
    }
}