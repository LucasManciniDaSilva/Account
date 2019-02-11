using System;
using System.Text;
using Account.Entities.Enum;
namespace Account.Entities
{
    //Created the SubClass Business Account
    public class Business : Normal
    {
        //Defined the variables
        public double LoanLimit { get; set; }
        public Operation Status { get; set; }

        //Created the constructor without arguments
        public Business()
        {
            Balance = 500;
            LoanLimit = 1000;
            Status = Operation.Ready;
        }

        //Created the constructor with arguments
        public Business(int number, string holder, double balance, double loanLimit, Operation status) : base(number, holder, balance)
        {
            Status = status;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 100.00;
        }

        public override void Deposit(double amount)
        {
            base.Deposit(amount);
            Balance += 100.00;
        }


        //Created a method to Loan an amount
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
                Status = Operation.Accepted;

            }
            else
            {
                Status = Operation.Canceled;
            }
        }

            //Converted a class to a String
            public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine ("Account number: " + Number);
            sb.AppendLine("Account Enterprise: " + Holder);
            sb.AppendLine("Your New Balance: " + Balance);
            sb.AppendLine("Status:  " + Status);
            return sb.ToString();

        }


    }
    }
