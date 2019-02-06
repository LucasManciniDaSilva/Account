using System;
using System.Text;
using Account.Entities;
using Account.Entities.Enum;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {

            //Implemented the interaction with the user 
            Console.Write("Enter the enterprise name: ");
            string holder = Console.ReadLine();
            Console.Write("Number of account: ");
            int number = int.Parse(Console.ReadLine());

            //instantiated a Class
            Business b1 = new Business();
            
            //Continue the interaction with the user
            Console.WriteLine("Your Balance: " +b1.Balance);
            Console.WriteLine("Your loan limit: " +b1.LoanLimit);
            Console.WriteLine("Status: " + b1.Status);
            Console.WriteLine("How can I help you?:");
            Console.WriteLine();
            Console.WriteLine("1 for Withdraw");
            Console.WriteLine("2 for Deposit");
            Console.WriteLine("3 for Loan");
            Console.Write("Choose an operation: ");
            int x = int.Parse(Console.ReadLine());

            //Created a switch case 
            switch (x)
            {
                case 1:
                    Console.Write("Insert the amount to withdraw: ");
                    double amount = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (amount <= b1.Balance)
                    {
                        b1.Withdraw(amount);
                        Console.WriteLine("New balance: " + b1.Balance);
                        b1.Status = Operation.Accepted;
                    }
                    else
                    {
                        Console.WriteLine("The withdraw was been denied");
                        b1.Status = Operation.Canceled;

                    }
                    break;

                case 2:
                    Console.Write("Insert the amount to Deposit: ");
                    amount = double.Parse(Console.ReadLine());
                    b1.Deposit(amount);
                    Console.WriteLine("New Balance: " +b1.Balance);
                    b1.Status = Operation.Accepted;
                    break;

                case 3:
                    Console.Write("Insert the amount to Loan: ");
                    amount = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (amount <= b1.LoanLimit)
                    {
                        Console.WriteLine("The loan was been accepted");
                        b1.Loan(amount);
                        Console.WriteLine("New Balance: " + b1.Balance);

                    }
                    else
                    {
                        Console.WriteLine("The loan was been denied");
                        b1.Loan(amount);
                        Console.WriteLine("New Balance: " + b1.Balance);

                    }
                    break;

                default:
                    Console.WriteLine("Error");
                    b1.Status = Operation.Canceled;
                    break;



            }

            //instantiated a Class
            Business b2 = new Business(number, holder, b1.Balance, b1.LoanLimit, b1.Status);

            Console.WriteLine();
            Console.WriteLine("Details of your account: ");
            Console.WriteLine(b2);







        }
    }
    }

