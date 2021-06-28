using System;

namespace oystercard
{
    public class Oystercard
    {
        private const double MAXIMUM_BALANCE = 90.0;
        public double Balance { get; private set; }
        public bool IsInJourney { get; private set; }

        public Oystercard(double balance)
        {
            Balance = balance;
            IsInJourney = false;
        }

        public void TopUp(double amount)
        {
            if ((Balance + amount) > MAXIMUM_BALANCE)
            {
                throw new ArgumentOutOfRangeException($"Maximum Limit of £{MAXIMUM_BALANCE} Reached.");
            }
            else
            {
                Balance += amount;
            }
        }

        public void Deduct(double amount)
        {
            Balance -= amount;
        }

        public void TouchIn()
        {
            IsInJourney = true;
        }

        public void TouchOut()
        {
            IsInJourney = false;
        }
    }
}