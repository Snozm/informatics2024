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
            cityComboBox.Enabled = false;
            if (a == "admin")
            {
                adminButton.Visible = true;
            }
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = (DataRowView)countryComboBox.SelectedItem;
            cityComboBox.Enabled = true;
            cityComboBox.ResetText();
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = (DataRowView)cityComboBox.SelectedItem;
            city = cityComboBox.SelectedItem.ToString();
        }

        private void swimmingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (swimmingCheckBox.Checked == true)
                selectedHobbies.Add(swimmingCheckBox.Text.ToLower());
            else
                selectedHobbies.Remove(swimmingCheckBox.Text.ToLower());
            resetInitialLB(selectedHobbies);
        }

        private void guitarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (guitarCheckBox.Checked == true)
                selectedHobbies.Add(guitarCheckBox.Text.ToLower());
            else
                selectedHobbies.Remove(guitarCheckBox.Text.ToLower());
            resetInitialLB(selectedHobbies);
        }

        private void chessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chessCheckBox.Checked == true)
                selectedHobbies.Add(chessCheckBox.Text.ToLower());
            else
                selectedHobbies.Remove(chessCheckBox.Text.ToLower());
            resetInitialLB(selectedHobbies);
        }
        private void musicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (musicCheckBox.Checked == true)
                selectedHobbies.Add(musicCheckBox.Text.ToLower());
            else
                selectedHobbies.Remove(musicCheckBox.Text.ToLower());
            resetInitialLB(selectedHobbies);
        }

        private void gamesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gamesCheckBox.Checked == true)
                selectedHobbies.Add(gamesCheckBox.Text.ToLower());
            else
                selectedHobbies.Remove(gamesCheckBox.Text.ToLower());
            resetInitialLB(selectedHobbies);
        }

        private void readCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (readCheckBox.Checked == true)
                selectedHobbies.Add(readCheckBox.Text.ToLower());
            else
                selectedHobbies.Remove(readCheckBox.Text.ToLower());
            resetInitialLB(selectedHobbies);
        }

        private void sleepCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sleepCheckBox.Checked == true)
                selectedHobbies.Add(sleepCheckBox.Text.ToLower());
            else
                selectedHobbies.Remove(sleepCheckBox.Text.ToLower());
            resetInitialLB(selectedHobbies);
        }
        private void resetInitialLB(List<string> hobbies)
        {
            initialListBox.DataSource = null;
            initialListBox.DataSource = hobbies;
        }
        private void resetFinalLB(List<string> hobbies)
        {
            finalListBox.DataSource = null;
            finalListBox.DataSource = hobbies;
        }

        private void addHobbiesButton_Click(object sender, EventArgs e)
        {
            finalHobbies.Add(initialListBox.SelectedItem.ToString().ToLower());
            selectedHobbies.Remove(initialListBox.SelectedItem.ToString().ToLower());
            resetInitialLB(selectedHobbies);
            resetFinalLB(finalHobbies);
        }

        private void removeHobbiesButton_Click(object sender, EventArgs e)
        {
            selectedHobbies.Add(finalListBox.SelectedItem.ToString().ToLower());
            finalHobbies.Remove(finalListBox.SelectedItem.ToString().ToLower());
            resetInitialLB(selectedHobbies);
            resetFinalLB(finalHobbies);
        }

        private void morningRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            time = morningRadioButton.Text.ToLower();
        }

        private void afternoonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            time = afternoonRadioButton.Text.ToLower();
        }

        private void eveningRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            time = eveningRadioButton.Text.ToLower();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (city == "" || time == "" || finalHobbies.Count == 0)
                MessageBox.Show("Missing Information!");
            else
            {
                string hobbies = $"{finalHobbies[0]}";
                for (int i = 1; i < finalHobbies.Count; i++)
                {
                    hobbies += $", {finalHobbies[i]}";
                }
                MessageBox.Show($"You will visit {b[1]} in {a[1]} and will have the following activities in the {time}: {hobbies}.");
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