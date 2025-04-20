using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    //
    // TO DO:
    /* 
    Build the client class here. 
    This class will be the base class for the clients including: 
    ID code, name, age, gender, DOB, address, phone number, and email.
    */
    internal class Client
    {
     //   private string _ID;
      //  private string _name;
            // Properties
            public string Id { get; set; }
            public string Name { get; set; }

            public int Balance { get; set; }

        // Constructor

        // Constructor
        public Client(string id, string name, int balance)
            {
                Id = id;
                Name = name;
                Balance = balance;
            }
    }
    
}
