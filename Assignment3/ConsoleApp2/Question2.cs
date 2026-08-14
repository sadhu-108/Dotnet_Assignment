using System;

class BankAccount
{
    string accountNumber;
    string holderName;
    double balance;

    public BankAccount(string accountNumber, string holderName, double balance)
    {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Holder Name: " + holderName);
        Console.WriteLine("Balance: " + balance);
    }
}