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
        deposit, withdraw. Check the validity of the transaction. 
        Only transfer or withdraw money when the current amount is greater than or 
        equal to the amount transferred. Deposit must be an amount greater than 0. 
        When done, the money in balance will be changed. 
    3. Add Testcases: 
        Write Unit Tests for these methods.
    */
namespace BankApp
{  
        internal class BankAcc : Client
        {
            public decimal Balance { get; set; }

            public BankAcc(string strID, string name, decimal initialBalance) : base(strID, name) 
            {
                Balance = initialBalance;
            }

            // Override Deposit to include some extra behavior
            public override void SetID(string strID)
            {
                //TODO: Override this method,     

            }
            public bool Withdraw(decimal amount)
            {
                
                // write the code for withdraw

                return true;
            }

            public bool Deposit(decimal amount)
            {
                // write the code for deposit here
                return true;
            }


            public void Transfer(decimal amount)
            {
                // No need; if you want to transfer $10 from A to B, then do like this
                // A.WithDraw(10)
                // B.Deposit(10)
            }

    }
}
