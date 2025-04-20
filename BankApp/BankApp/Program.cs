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

        public static Client[] clients = new Client[5];

        public static int intCurrentUser = 1;

        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            // Initializing Clients
            clients[0] = new Client(toolObj.SetID(), "Alice Mark", 250000);
            clients[1] = new Client(toolObj.SetID(), "Bob King", 607000);
            clients[2] = new Client(toolObj.SetID(), "Charlie Brown",478993);
            clients[3] = new Client(toolObj.SetID(), "Clara Mayor",83672);
            clients[4] = new Client(toolObj.SetID(), "David John",231987);

            // Show login form
            Application.Run(fmLog);
           
          
        }
      
    }
}