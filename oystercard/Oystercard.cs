namespace oystercard
{
    public class Oystercard
    {
        public double Balance { get; private set; }

        public Oystercard(double balance)
        {
            Balance = balance;
        }

        public void TopUp(double amount)
        {
            Balance += amount;
        }
    }
}