using System;

public class BankAccount
{
    // Private member variables
    private string _accountHolder;
    private string _accountNumber;
    private double _balance;

    // Constructor to initialize the BankAccount object
    public BankAccount(string accountHolder, string accountNumber, double initialBalance)
    {
        _accountHolder = accountHolder;
        _accountNumber = accountNumber;
        _balance = initialBalance;
    }

    // Private method to validate a withdrawal amount
    private bool CanWithdraw(double amount)
    {
        return _balance >= amount;
    }

    // Public method to deposit money into the account
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {_balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Public method to withdraw money from the account
    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (CanWithdraw(amount))
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }

    // Public method to check the current balance
    public void CheckBalance()
    {
        Console.WriteLine($"Account balance for {_accountHolder}: {_balance:C}");
    }

    // Public method to display account details
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Holder: {_accountHolder}");
        Console.WriteLine($"Account Number: {_accountNumber}");
        Console.WriteLine($"Current Balance: {_balance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the BankAccount class
        BankAccount myAccount = new BankAccount("Amogelang Maredi Mazwi", "123456789", 1000);

        // Display account information
        myAccount.DisplayAccountInfo();

        // Check balance
        myAccount.CheckBalance();

        // Deposit money
        myAccount.Deposit(200);

        // Withdraw money
        myAccount.Withdraw(150);

        // Attempt to withdraw more than the balance
        myAccount.Withdraw(1200);

        // Display final account information
        myAccount.DisplayAccountInfo();
    }
}

