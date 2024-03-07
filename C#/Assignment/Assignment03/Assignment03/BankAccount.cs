using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }
    class BankAccount
    {
        private double balance;

       
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited Amount: {amount}");
        }

       
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Insufficient balance to withdraw.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn Amount: {amount}");
        }

       
        public double CheckBalance()
        {
            Console.WriteLine($"Current Balance: {balance}");
            return balance;
        }
    }

    class question3
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            try
            {
                Console.Write("Enter initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                account.Deposit(initialBalance);

                while (true)
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter amount to deposit: ");
                            double depositAmount = double.Parse(Console.ReadLine());
                            account.Deposit(depositAmount);
                            break;
                        case 2:
                            Console.Write("Enter amount to withdraw: ");
                            double withdrawAmount = double.Parse(Console.ReadLine());
                            account.Withdraw(withdrawAmount);
                            break;
                        case 3:
                            account.CheckBalance();
                            break;
                        case 4:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.Read();
        }
    }
   
}
