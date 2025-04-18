using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    // USE THIS CODE TO SHOW INFOR OF CLIENTS
    internal class Client
    {
     //   private string _ID;
      //  private string _name;
            // Properties
            public int Id { get; set; }
            public string Name { get; set; }

            public int Balance { get; set; }

        // Constructor

        // Constructor
        public Client(int id, string name, int balance)
            {
                Id = id;
                Name = name;
                Balance = balance;
            }
    }
    
}
