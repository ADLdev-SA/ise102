using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace BankApp
{

    // Students can use the code here for project, dont change
    internal class Ultility
    {
        public string CreateHash(string input)
        {
            //Create hashpassword from Original Pass, encrypted password
            using (SHA256 sha256 = SHA256.Create())
            {
                // String to byte
                byte[] bytes = Encoding.UTF8.GetBytes(input);

                // Scramble a string into byte
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Convert Byte Array to Hexa
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // format byte to hex
                }
                return sb.ToString();
            }
        }
        public void WriteToFile(string fname, string content)
        {
            //Write password file, save new password
            string fileName = fname;

            // current path
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = Path.Combine(projectPath, fileName);
            try
            {
                File.WriteAllText(fullPath, content);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }
        }
        public string ReadFromFile(string fname)
        {
            //Read password file, return string with Acc#HashPass
            string fileName = fname;

            // current path
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = Path.Combine(projectPath, fileName);

            string content = "";

            try
            {
                if (!File.Exists(fullPath))
                {
                    MessageBox.Show("Config file does not exits", "Alert");
                }

                content = File.ReadAllText(fullPath);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alert");
            }

            return content;
        }
        public string SetID()
        {
            // Generate a long random number, fake Client ID
            string strID = "";
            Random rnd = new Random();
            strID = rnd.Next(100000000, 999999999).ToString();
            return strID;
        }

        public string TransID()
        {
            // Generate a shot random number, fake transaction ID.
            string strID = "";
            Random rnd = new Random();
            strID = rnd.Next(1000, 9999).ToString();
            return strID;
        }

        public bool CheckPassFormat(string txtPass, ref string strMessage)
        {
            //This method check password with conditions:
            // length >=8
            // Uppercase + Lowercase + 0-9 + Symbol
            int minLength = 8;

            if (txtPass.Length < minLength)
            { 
                strMessage = "Password is too short. Minimum 8 characters required.";
                return false;
            }

            if (!Regex.IsMatch(txtPass, "[A-Z]"))
            {
                strMessage = "Password must contain at least one uppercase letter.";
                return false;
            }
 
            if (!Regex.IsMatch(txtPass, "[a-z]"))
            {
                strMessage = "Password must contain at least one lowercase letter.";
                return false;
            }

            if (!Regex.IsMatch(txtPass, "[0-9]"))
            {
                strMessage = "Password must contain at least one number.";
                return false;
            }

            if (!Regex.IsMatch(txtPass, "[^a-zA-Z0-9]"))
            {
                strMessage = "Password must contain at least one special character.";
                return false;
            }

            strMessage = "Password is valid.";
            return true;
        }

    }

}
