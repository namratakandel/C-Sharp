//design an interface IBank with methods Deposit() and withdraw().Create a 
//class Account yhat implements the interaface and performs basic banking operation based on user input.


using System;
// Interface
interface IBank
{
    void Deposit(double amount);
    void Withdraw(double amount);
}

// Class that implements the interface
class Account : IBank
{
    private double balance;

    public Account(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
        Console.WriteLine("Current Balance: " + balance);
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds. Withdrawal failed.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
            Console.WriteLine("Current Balance: " + balance);
        }
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    {
        Account myAccount = new Account(1000); // Initial balance

        myAccount.Deposit(500); // Deposit money
        myAccount.Withdraw(200); // Withdraw money
        myAccount.Withdraw(1500); // Attempt to withdraw more than balance
    }
}

