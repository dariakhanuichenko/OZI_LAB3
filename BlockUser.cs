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
    public partial class BlockUser : Form
    {
        UserContext userContext = new UserContext();

        public BlockUser()
        {
            InitializeComponent();
        }

        private void blockEnteredUser_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                MessageBox.Show("Input username.");
            }
            else if (userContext.UserList.Find(userName.Text) == null)
            {
                MessageBox.Show("User with this username does not exist.");
            }
            else if (userContext.UserList.Find(userName.Text).Blocked == true)
            {
                MessageBox.Show("User is already blocked.");
            }
            else
            {
                userContext.UserList.Find(userName.Text).Blocked = true;
                MessageBox.Show("User was blocked sucessfuly.");
            }
            userContext.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                MessageBox.Show("Input username.");
            }
            else if (userContext.UserList.Find(userName.Text) == null)
            {
                MessageBox.Show("User with this username does not exist.");
            }
            else if (userContext.UserList.Find(userName.Text).Blocked == false)
            {
                MessageBox.Show("User is not blocked.");
            }
            else
            {
                userContext.UserList.Find(userName.Text).Blocked = false;
                MessageBox.Show("User was unblocked sucessfuly.");
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
    }
}
