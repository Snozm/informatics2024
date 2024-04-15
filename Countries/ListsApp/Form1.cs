using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace ListsApp
{
    public partial class Form1 : Form
    {
        DataRowView a;
        DataRowView b;
        string country = "";
        string city = "";
        string time = "";
        string[] BulgariaCities = { "Sofia", "Plovdiv", "Varna", "Burgas" };
        string[] GreeceCities = { "Athens", "Thessaloniki", "Patras", "Heraklion" };
        string[] NetherlandsCities = { "Amsterdam", "Rotterdam", "The Hague", "Utrecht" };
        //make a strring list called selectedHobbies
        List<string> selectedHobbies = new List<string>();
        List<string> finalHobbies = new List<string>();
        public Form1(string a)
        {
            InitializeComponent();
            if (a == "admin")
            {
                adminButton.Visible = true;
            }
        }



        private void adminButton_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            myForm.Show();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC15\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT id, country FROM Countries", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable countriesTable = new DataTable();
            adapter.Fill(countriesTable);
            countryComboBox.DataSource = countriesTable;
            countryComboBox.DisplayMember = "country";
            countryComboBox.ValueMember = "id";

            cmd = new SqlCommand("SELECT id, city FROM Cities", con);
            adapter.SelectCommand = cmd;
            DataTable citiesTable = new DataTable();
            adapter.Fill(citiesTable);
            cityComboBox.DataSource = citiesTable;
            cityComboBox.DisplayMember = "city";
            cityComboBox.ValueMember = "id";

            con.Close();
        }
    }
}