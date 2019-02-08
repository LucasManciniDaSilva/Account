using System;
namespace Account.Entities
{

    //Created the Normal Account Class
    public class Normal
    {
        //Defined the variables
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        //Created the constructor without arguments
        public Normal()
        {
        }
        //Created the constructor with arguments
        public Normal(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //Created a method to Withdraw a amount
        public void Withdraw(double amount)
        {
            Balance -= amount;
            
        }
        //Created a method to Deposit a amount
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
