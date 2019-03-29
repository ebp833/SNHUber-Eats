using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNHUber_Eats
{
    public partial class Signup : Form
    {
        bool validName, validEmail, validStudentID, validRoom, validBuilding,validPassword;
        void resetBools()
        {
            validName = false;
            validEmail = false;
            validStudentID = false;
            validRoom = false;
            validBuilding = false;
            validPassword = false;
        }
        public Signup()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            resetBools();
        }

        private void room_entry_TextChanged(object sender, EventArgs e)
        {
            if (InitialLoginVerification.valid_Room(room_entry.Text) == true)
            {
                validRoom = true;
                room_entry.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                room_entry.BackColor = System.Drawing.Color.Tomato;
            }
        }

        private void StudentIDEntry_TextChanged(object sender, EventArgs e)
        {
            if (InitialLoginVerification.valid_Number(StudentIDEntry.Text) == true)
            {
                validStudentID = true;
                StudentIDEntry.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                StudentIDEntry.BackColor = System.Drawing.Color.Tomato;
            }
        }

        private void email_entry_TextChanged(object sender, EventArgs e)
        {
            if (InitialLoginVerification.valid_Email(email_entry.Text) == true)
            {
                validEmail = true;
                email_entry.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                email_entry.BackColor = System.Drawing.Color.Tomato;
            }
        }

        private void Password_Re_entry_TextChanged(object sender, EventArgs e)
        {
            if (InitialLoginVerification.ValidatedPassword(Passord_Entry.Text, Password_Re_entry.Text) == true)
            {
                validPassword = true;
                Password_Re_entry.BackColor= System.Drawing.SystemColors.Window;
            }
            else
            {
                Password_Re_entry.BackColor = System.Drawing.Color.Tomato;
            }
        }


        private void name_entry_TextChanged(object sender, EventArgs e)
        {
            if (InitialLoginVerification.Valid_Name(name_entry.Text) == true)
            {
                validName = true;
                name_entry.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                name_entry.BackColor = System.Drawing.Color.Tomato;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(building.Text))
            {
                MessageBox.Show("Selct a building");
            }

            else
            {
                validBuilding = true;
                checkToSubmit();
            }
        }
        private void checkToSubmit()
        {

            if (validName && validEmail && validRoom && validStudentID && validBuilding&&validPassword)
            {
                string[] entries = {email_entry.Text, Passord_Entry.Text, name_entry.Text ,
                 building.Text,
                room_entry.Text , StudentIDEntry.Text};

                StringBuilder builder = new StringBuilder();

                foreach (string value in entries)
                {
                    builder.Append(value);
                    builder.Append(':');
                }


                initialLogin il = new initialLogin(builder.ToString());
                this.Hide();
                Login newlogin = new Login(email_entry.Text, Passord_Entry.Text);
                
            }
            else
            {
                ValidationLabel.Text = ("Please correct entries");
            }
        }
    }
    
}
