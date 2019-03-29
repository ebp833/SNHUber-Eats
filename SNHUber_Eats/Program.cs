using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SNHUber_Eats
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string credentialsExist = @"CurrentLogIn.txt";
            bool credentials = File.Exists(credentialsExist);
            if (credentials)
            {
                var fileStream = new FileStream(@"CurrentLogIn.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    line = streamReader.ReadLine();
                    fileStream.Close();
                    string[] info = line.Split(':');
                    if (line.Contains("Logged_in"))
                    {
                        Login ln = new Login(info[0], info[1]);
                       
                    }

                    else { Application.Run(new Login()); }
                }
            }
            else { Application.Run(new Signup()); }
        }
    }
}
