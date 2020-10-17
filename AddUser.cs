using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OZI_lab1
{
    public partial class AddUser : Form
    {        
        UserContext userContext = new UserContext();

        public AddUser()
        {
            InitializeComponent();
        }

        private bool IsPasswordPossible(string password)
        {
            if ((password.Any(c => char.IsLetter(c))) && (password.Any(c => char.IsNumber(c))) && (password.Any(c => CheckCyrilic(c))))
                return true;
            else return false;
        }


        private bool CheckCyrilic(char c)
        {
            string cyrilicString = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return !cyrilicString.Contains(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userContext.UserList.Find(userName.Text) != null)
                MessageBox.Show("User with this username existed");
            else if (IsPasswordPossible(password.Text))
            {
                userContext.UserList.Add(new User { Name = userName.Text, Password = password.Text, PasswordLength = password.Text.Length, Blocked = false, Restriction = true, Role = "user" });
                MessageBox.Show("User is added");
            }
            else MessageBox.Show("Password should contains latin and cyrillic letters and numbers");
            userContext.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userContext.UserList.Find(userName.Text) != null)
                MessageBox.Show("User with this username does not exist");
            else if (password.Text != "")
                MessageBox.Show("Password should be empty");
            else
            {
                userContext.UserList.Add(new User { Name = userName.Text, Password = null, PasswordLength = 0, Blocked = false, Restriction = false, Role = "user" });
                MessageBox.Show("User is added");
            }
            userContext.SaveChanges();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
