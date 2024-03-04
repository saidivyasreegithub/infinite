//Create a class called Accounts which has data members/fields like Account no, Customer name, Account type, Transaction type (d/w), amount, balance

//D->Deposit

//W->Withdrawal
 
//-write a function that updates the balance depending upon the transaction type
 
//	-If transaction type is deposit call the function credit by passing the amount to be deposited and update the balance
 
//  Credit(int amount) function

//    - If transaction type is withdraw call call the function debit by passing the amount to be withdrawn and update the balance
 
//  Debit(int amt) function

//- Pass the other information like Acount no, customer name, acc type through constructor
 
//-call the show data method to display the values.//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




 
class Accounts
{
    private int accountNo;
    private string customerName;
    private string accountType;
    public char transactionType;
    public double amount;
    public double balance;

    public Accounts(int accountNo, string customerName, string accountType, char transactionType, double amount)
    {
        this.accountNo = accountNo;
        this.customerName = customerName;
        this.accountType = accountType;
        this.transactionType = transactionType;
        this.amount = amount;
        this.balance = 0; // Initialize balance to zero
    }

    public void Credit(double amount)
    {
        balance += amount; // Increment balance for deposit
    }

    public void Debit(double amount)
    {
        if (balance >= amount)
        {
            balance = balance- amount; // Decrement balance for withdrawal

        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public void ShowData()
    {
        Console.WriteLine($"Account No: {accountNo}");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Account Type: {accountType}");
        Console.WriteLine($"Transaction Type: {transactionType}");
        Console.WriteLine($"Amount: {amount}");
        Console.WriteLine($"Balance: {balance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage:
        Accounts account = new Accounts(123456, "John Doe", "Savings", 'D', 1500);
        account.ShowData(); // Display initial data
        Console.WriteLine();

        // Perform a deposit
        if (account.transactionType == 'D')
        {
            account.Credit(account.amount);
        }

        // Display updated data after deposit
        account.ShowData();
        Console.WriteLine();

        // Perform a withdrawal
        account = new Accounts(123456, "John Doe", "Savings", 'W', 500);
        if (account.transactionType == 'W')
        {
            account.Debit(account.amount);
        }

        // Display updated data after withdrawal
        account.ShowData();
    }
}
