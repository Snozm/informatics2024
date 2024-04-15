using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ListsApp
{
    public partial class Form3 : Form
    {
        int users = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "admin")
            {
                Form1 myForm = new Form1("admin");
                myForm.Show();
                return;
            }
            if (usernameTextBox.Text == "user" && passwordTextBox.Text == "user")
            {
                Form1 myForm = new Form1("user");
                myForm.Show();
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
