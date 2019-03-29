using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SNHUber_Eats
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public Login(string username, string password)
        {
            if (InitialLoginVerification.ValidCredentials(username,password) == true)
            {
                File.WriteAllText(@"CurrentLogIn.txt", username + ':' + password + ':' + "Logged_in");
                launchMainpage();
            }
        }

        private void Signup_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup sp = new Signup();
            sp.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(InitialLoginVerification.ValidCredentials(Username_entry.Text, Password_entry.Text) == true)
            {
                File.WriteAllText(@"CurrentLogIn.txt", Username_entry.Text + ':' + Password_entry.Text + ':' + "Logged_in");

                launchMainpage();
            }
        }
        private void launchMainpage()
        {
            Console.WriteLine("Success");
            this.Hide();
                        
        }

    }
}
