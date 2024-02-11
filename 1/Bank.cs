
using System;

namespace Bank
{
    public class Account
    {
        public string CustomerName { get; private set; }
        public double Balance { get; private set; }

        public Account(string customerName, double balance)
        {
            CustomerName = customerName;
            Balance = balance;
        }

        public void Debit(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Debit amount exceeds balance");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Debit amount is less than zero");
            }

            Balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Credit amount is less than zero");
            }

            Balance += amount;
        }
    }
}
