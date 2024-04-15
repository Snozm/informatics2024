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

namespace ListsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void countryAddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Countries(id, country) VALUES(@id, @name)", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = countryIDTextBox.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = countryNameTextBox.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was added!");
        }

        private void countryUpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Countries SET country = @name WHERE id = @id", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = countryIDTextBox.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = countryNameTextBox.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was updated!");
        }

        private void countryDeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Countries WHERE country = @name", con);
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = countryNameTextBox.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was deleted!");
        }

        private void cityAddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Cities(id, city) VALUES(@id, @name)", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = cityIDTextBox.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cityNameTextBox.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was added!");
        }

        private void cityUpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Cities SET city = @name WHERE id = @id", con);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = cityIDTextBox.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cityNameTextBox.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was updated!");
        }

        private void cityDeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Cities WHERE city = @name", con);
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = cityNameTextBox.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was deleted!");
        }
    }
}
