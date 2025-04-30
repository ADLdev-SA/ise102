using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankApp
{
    // USE THIS CODE TO SHOW INFOR OF CLIENTS
    internal class Client
    {
        private string _name = "";
        private string _id = "";
        public string Name 
        { 
            get { return _name; }        
            set 
            {
                if (value != null)
                    _name = value;
                else
                    throw new ArgumentException("Invalid Name");
            }
        }

        public string ID 
        {
            get { return _id; }
            set
            {
                if (value != null)
                    _id = value;
                else
                    throw new ArgumentException("Invalid ID");
            }
        }

        public Client(string strID, string strName)
        {
            _name = strName;
            _id = strID;
        }

        // Virtual method that can be overridden
        public virtual void SetID(string strID)
        {
            // This is very simple SetID() method, student can add their code here
            _id = strID; 
        }
    }
    
}
