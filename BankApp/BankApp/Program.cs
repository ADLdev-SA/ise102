using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace BankApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        // put Form as Object here, then we can choose to close, hide much easier
        public static Ultility toolObj = new Ultility(); // create Tool Obj

        public static BankApp fmBank = new BankApp();  // keep this form global, then Show and Close easier.
        public static frmLogin fmLog = new frmLogin();

        public static string userName = "";  // global Username
        public static string hashPassWord = ""; // global Hash Password

        public static BankAcc[] bankAccs = new BankAcc[5];

        public static int intCurrentUser = 0; // current client index

        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Initializing Clients
            bankAccs[0] = new BankAcc(toolObj.SetID(), "Alice Mark", 250000);
            bankAccs[1] = new BankAcc(toolObj.SetID(), "Bob King", 607000);
            bankAccs[2] = new BankAcc(toolObj.SetID(), "Charlie Brown", 478993);
            bankAccs[3] = new BankAcc(toolObj.SetID(), "Clara Mayor", 83672);
            bankAccs[4] = new BankAcc(toolObj.SetID(), "David John", 231987);

            // Show login form
            Application.Run(fmLog);
           
          
        }
      
    }
}