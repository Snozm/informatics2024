using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SignupForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUp(object sender, RoutedEventArgs e)
        {
            string user = txtUsername.Text;
            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            string password = pass.Password;
            string email = txtEmail.Text;
            string special = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            foreach (char symbol in password)
            {
                if (special.Contains(symbol) || pass.Password.Length < 8)
                {
                    MessageBox.Show("You have not fulfilled the password requirements.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if (firstName == "" || lastName == "")
            {
                MessageBox.Show("You have not fulfilled the name requirements.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("You have not fulfilled the email requirements.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS; Initial Catalog=Signup; Integrated Security=True;");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show("User already exists.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                query = $"INSERT INTO Users(Username, FirstName, LastName, Email, Password) VALUES('{user}', '{firstName}', '{lastName}', '{email}', '{password}');";
                cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have created an account.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Update(object sender, RoutedEventArgs e)
        {
            string user = txtUsername.Text;
            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            string password = pass.Password;
            string email = txtEmail.Text;
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS; Initial Catalog=Signup; Integrated Security=True;");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                string query = $"UPDATE Users SET Username='{user}', FirstName='{firstName}', LastName='{lastName}', Password = '{password}' WHERE Email='{email}';";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have updated your account.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS; Initial Catalog=Signup; Integrated Security=True;");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                string query = $"DELETE FROM Users WHERE Email='{email}';";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have deleted your account.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearUser(object sender, RoutedEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void ClearFirst(object sender, RoutedEventArgs e)
        {
            txtFirstname.Text = "";
        }

        private void ClearLast(object sender, RoutedEventArgs e)
        {
            txtLastname.Text = "";
        }

        private void ClearEmail(object sender, RoutedEventArgs e)
        {
            txtEmail.Text = "";
        }

        private void RestoreUser(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }
        private void RestoreFirst(object sender, RoutedEventArgs e)
        {
            if (txtFirstname.Text == "")
            {
                txtFirstname.Text = "First Name";
            }
        }
        private void RestoreLast(object sender, RoutedEventArgs e)
        {
            if (txtLastname.Text == "")
            {
                txtLastname.Text = "Last Name";
            }
        }
        private void RestoreEmail(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }
    }
}
