using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace OZI_lab1
{
    public partial class Form1 : Form
    {
        UserContext db = new UserContext();
        User user = new User();
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        private bool IsUserNameValid()
        {
            if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Input username.");
                return false;
            }
            else if (db.UserList.Find(usernameTextBox.Text) == null)
            {
                MessageBox.Show("User with this username does not exist.");
                return false;
            }
            else if (db.UserList.Find(usernameTextBox.Text).Blocked == true)
            {
                MessageBox.Show("User is blocked.");
                return false;
            }
            else
            {
                user = db.UserList.Find(usernameTextBox.Text);
                return true;
            }
        }

        private bool IsPasswordValid()
        {

            if (user.Password != passwordTextBox.Text)
            {
                MessageBox.Show("Wrong prassword.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (IsUserNameValid())
            {
                if (IsPasswordValid())
                {
                    if (user.Role == "admin")
                    {
                        Administrator administrator = new Administrator(user);
                        administrator.Show();
                    }
                    else if (user.Role == "user")
                    {
                        UserForm userForm = new UserForm(user);
                        userForm.Show();
                    }
                }
                else
                {
                    if (counter == 3)
                    {
                        Close();
                    }                    
                    counter++;
                }
            }
                

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            UserContext db = new UserContext();
            UserCopyContext dbc = new UserCopyContext();
            foreach (var user_ in db.UserList)
            {
                db.UserList.Remove(user_);
            }
            db.SaveChanges();
            foreach (var user in dbc.Users)
            {
                db.UserList.Add(user);
            }
            db.SaveChanges();
            EncryptUserInfo.EncryptFile("users.mdf");
        }
    }
}

