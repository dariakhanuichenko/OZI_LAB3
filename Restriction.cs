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
    public partial class Restriction : Form
    {
        UserContext userContext = new UserContext();

        public Restriction()
        {
            InitializeComponent();
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
            else if (userContext.UserList.Find(userName.Text).Restriction == true)
            {
                MessageBox.Show("Restriction is already done.");
            }
            else
            {
                userContext.UserList.Find(userName.Text).Restriction = true;
                MessageBox.Show("User is restrict in passwords succesfully.");
            }

            userContext.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
            {
                MessageBox.Show("Input username.");
            }
            else if (userContext.UserList.Find(userName.Text) == null)
            {
                MessageBox.Show("User with this username does not exist.");
            }
            else if (userContext.UserList.Find(userName.Text).Restriction == false)
            {
                MessageBox.Show("User is not restricted.");
            }
            else
            {
                userContext.UserList.Find(userName.Text).Restriction = false;
                MessageBox.Show("Restriction is removed sucessfully.");
            }

            userContext.SaveChanges();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
