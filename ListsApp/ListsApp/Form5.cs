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
    public partial class Form5 : Form
    {
        private string connectionString = @"Data Source=IDEAPAD-SNOZM;Initial Catalog=Login;Integrated Security=True;";
        private DataTable resultTable;
        private int count;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserProfiles", con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    dataGridView1.DataSource = resultTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL error occured. Please try again. {ex.Message}", "SQL error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unknown error occurred. Please try again. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (count == 1)
            {
                DataView dv = resultTable.DefaultView;
                dv.RowFilter = $"{columnTextBox.Text} LIKE '%{filterTextBox.Text}%'";
            }
        }

        private void columnTextBox_Leave(object sender, EventArgs e)
        {
            count = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'UserProfiles' AND COLUMN_NAME = @column ", con);
                cmd.Parameters.AddWithValue("@column", columnTextBox.Text);
                con.Open();
                count = (Int32)cmd.ExecuteScalar();
            }
            filterTextBox_TextChanged(null, null);
        }
    }
}
