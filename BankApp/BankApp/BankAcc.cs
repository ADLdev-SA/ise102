using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
// STUDENTS WRITE YOUR CODE HERE
/*
    TO DO:
    Build the BankAcc class here. 
    Inherit from the base class Client. 
    1. Add properties: 
        Account opening date, initial deposit amount to the account. 
        Constructor is created based on the constructor of the base class, 
        initializing the initial value of the account. 
    2. Add methods: 
        transfer, deposit, withdraw. Check the validity of the transaction. 
        Only transfer or withdraw money when the current amount is greater than or 
        equal to the amount transferred. Deposit must be an amount greater than 0.
    3. Add Testcases: 
        Write Unit Tests for these methods.
    */
namespace BankApp
{
    internal class BankAcc
    {
        private decimal balance; // stores the account balance

        // Account constructor initializes instance variable balance
        public BankAcc(decimal initialBalance)
        {
            Balance = initialBalance; // validate balance via property
        }

        // credit the account balance by amount
        public virtual bool Credit(decimal amount)
        {
            Balance += amount; // add amount to balance
            return true;
        }

        // debit the account balance by amount;
        // return bool indicating whether debit was successful
        public virtual bool Debit(decimal amount)
        {
            if (amount > Balance) // debit amount exceeds balance
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
            else // debit amount does not exceed balance
            {
                Balance -= amount;
                return true;
            }
        }

        // property that gets and sets the account balance
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                // if value is greater than or equal to 0.0, 
                // set value as the balance of the Account
                if (value < 0.0M)
                {
                    throw new ArgumentOutOfRangeException();
                }

                balance = value;
            }
        }

    }
}
