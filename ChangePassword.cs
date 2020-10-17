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
    public partial class ChangePassword : Form
    {
        User user = new User();
        UserContext userContext = new UserContext();

        public ChangePassword(string name)
        {
            InitializeComponent();
            user.Name = name;
        }

        private bool IsPasswordPossible(string password)
        {
            return ((password.Any(c => char.IsLetter(c))) && (password.Any(c => char.IsNumber(c))) && (password.Any(c => CheckCyrilic(c))));
        }

        private bool CheckCyrilic(char c)
        {
            string cyrilicString = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return !cyrilicString.Contains(c);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oldPassword.Text == userContext.UserList.Find(user.Name).Password.ToString())
            {
                if ((IsPasswordPossible(newPassword.Text) == false) && (userContext.UserList.Find(user.Name).Restriction == true))
                    MessageBox.Show("Password should contains latin and cyrillic letters and numbers");
                else if (newPassword.Text == confirmPassword.Text)
                {
                    user.Password = newPassword.Text;
                    userContext.UserList.Find(user.Name).Password = user.Password;
                    MessageBox.Show("Password was changes succesfuly");
                }
                else MessageBox.Show("Try again!");
            }
            else MessageBox.Show(" Input right old password");
            userContext.SaveChanges();
        }
    }
}
