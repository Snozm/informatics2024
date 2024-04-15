using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ListsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=IDEAPAD-SNOZM; Initial Catalog=Login; Integrated Security=True;");
            //SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS; Initial Catalog=Login; Integrated Security=True;");
            con.Open();
            string query = "SELECT COUNT(*) FROM Users";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "admin" && passwordTextBox1.Text == "admin")
            {
                Form1 myForm = new Form1("admin");
                myForm.Show();
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=IDEAPAD-SNOZM; Initial Catalog=Login; Integrated Security=True;");
            //SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS; Initial Catalog=Login; Integrated Security=True;");
            con.Open();
            string query = "SELECT date FROM Users WHERE email=@email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@email", usernameTextBox.Text);
            string date = Convert.ToString(cmd.ExecuteScalar());
            query = "SELECT COUNT(*) FROM Users WHERE email=@email AND hash=@hash";
            cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@email", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@hash", hashPassword($"{passwordTextBox1.Text}{date}"));
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                Form1 myForm = new Form1(usernameTextBox.Text);
                myForm.Show();
                return;
            }
            MessageBox.Show("Wrong username or password entered");
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (!usernameTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Invalid email entered.");
                return;
            }
            string pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&?*])[A-Za-z0-9!@#$%_&?*]{8,}$";
            if (!Regex.IsMatch(passwordTextBox1.Text, pattern))
            {
                MessageBox.Show("Password needs more special characters");
                return;
            }
            if (!(passwordTextBox1.Text == passwordTextBox2.Text))
            {
                MessageBox.Show("Passwords don't match");
                return;
            }
            string salt = DateTime.Now.ToString();
            string hash = hashPassword($"{passwordTextBox1.Text}{salt}");
            SqlConnection con = new SqlConnection(@"Data Source=IDEAPAD-SNOZM; Initial Catalog=Login; Integrated Security=True;");
            //SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE email=@email", con);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = usernameTextBox.Text;
            if(Convert.ToInt32(cmd.ExecuteScalar()) != 0)
            {
                MessageBox.Show("User already exists");
                return;
            }
            cmd = new SqlCommand("INSERT INTO Users(email, date, hash) VALUES(@email, @date, @hash)", con);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = usernameTextBox.Text;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = salt;
            cmd.Parameters.Add("@hash", SqlDbType.NVarChar).Value = hash;
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("INSERT INTO UserProfiless(email) VALUES(@email)", con);
            cmd.Parameters.AddWithValue("@email", usernameTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User was added!");
            

        }
        private string hashPassword(string password)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(password);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
