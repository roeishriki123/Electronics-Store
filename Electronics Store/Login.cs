using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Electronics_Store.classes;

namespace Electronics_Store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string selection = cbSelectRole.SelectedItem?.ToString();

            // Perform validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(selection))
            {
                MessageBox.Show("Please enter username, password, and select a role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform authentication
            bool isAuthenticated = false;
            // Here, you can replace the following hard-coded values with your authentication logic
            if (selection == "Admin" && username == " " && password == " ")
            {
                isAuthenticated = true;
            }
            else if (selection == "Buyer" && username == " " && password == " ")
            {
                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                // Successful login
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to the corresponding page based on the user's selection
                if (selection == "Admin")
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                }
                else if (selection == "Buyer")
                {
                    Buyer buyerForm = new Buyer();
                    buyerForm.Show();
                }

                // Hide or close the login form
                this.Hide(); // or this.Close();
            }
            else
            {
                // Invalid credentials
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
