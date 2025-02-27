using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_assignment
{
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();
            Username.TextChanged += Username_TextChanged;
            Password.TextChanged += Password_TextChanged;
        }

        private void Mylink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Sorry, password reset is not working right now.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            ValidateUsername();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            ValidatePassword();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (ValidateUsername() & ValidatePassword())
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateUsername()
        {
            string username = Username.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                errorProvider.SetError(Username, "Username is required.");
                return false;
            }

            errorProvider.SetError(Username, "");
            return true;
        }

        private bool ValidatePassword()
        {
            string password = Password.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider.SetError(Password, "Password is required.");
                return false;
            } else if (password.Length < 6)
            {
                errorProvider.SetError(Password, "Password must be at least 6 characters long.");
                return false;
            } else if (!Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d).+$"))
            {
                errorProvider.SetError(Password, "Password must contain at least one uppercase letter and one number.");
                return false;
            }

            errorProvider.SetError(Password, "");
            return true;
        }
    }
}