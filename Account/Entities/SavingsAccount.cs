using System;
namespace Account.Entities
{
    public class SavingsAccount : Normal
    {

        public double InterestRate  { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;

        }




    }
}
