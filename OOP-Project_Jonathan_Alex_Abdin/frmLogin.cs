using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    public partial class frmLogin : Form
    {
        List<User> users = new List<User>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists("users.txt"))
            {
                //Reading the file data
                var lines = File.ReadAllLines("users.txt");

                foreach (var line in lines)
                {
                    var data = line.Split(" ");
                    User user = new User();
                    user.Username = data[0];
                    user.Password = data[1];
                    users.Add(user);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool userExists = false;

            if (txtPassword.Text == string.Empty || txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            foreach (var u in users)
            {
                if (u.Username == username && u.Password == password)
                {
                    userExists = true;
                    break;
                }
            }

            if (userExists)
            {
                frmFleetDashboard main = new frmFleetDashboard();

                this.Hide();

                main.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty || txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Wrong username or password");
            }
            else
            {
                User newUser = new User();
                newUser.Username = txtUsername.Text;
                newUser.Password = txtPassword.Text;
                users.Add(newUser);
                using (StreamWriter writer = new StreamWriter("users.txt", false))
                {
                    foreach (var u in users)
                    {
                        writer.WriteLine($"{u.Username} {u.Password}");
                    }
                }
                MessageBox.Show("User added successfully");
            }
        }
    }
}
