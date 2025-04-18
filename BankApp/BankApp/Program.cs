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

        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            // Initializing Clients
            clients[0] = new Client(1, "Alice Mark", 250000);
            clients[1] = new Client(2, "Bob King", 607000);
            clients[2] = new Client(3, "Charlie Brown",478993);
            clients[3] = new Client(4, "Clara Mayor",83672);
            clients[4] = new Client(5, "David John",231987);

            // Show login form
            Application.Run(fmLog);
           
          
        }
      
    }
}