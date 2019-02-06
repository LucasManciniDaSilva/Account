using System;
using System.Text;
using Account.Entities.Enum;
namespace Account.Entities
{
    public class Business : Normal
    {
        public double LoanLimit { get; set; }
        public Operation Status { get; set; }

        public Business()
        {
            Balance = 500;
            LoanLimit = 1000;
            Status = Operation.Ready;
        }


        public Business(int number, string holder, double balance, double loanLimit, Operation status) : base(number, holder, balance)
        {
            Status = status;
        }

       
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
