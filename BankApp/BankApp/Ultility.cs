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

namespace BankApp
{

    // Students can use the code here for project, dont change
    internal class Ultility
    {
        public string CreateHash(string input)
        {
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
    }

}
