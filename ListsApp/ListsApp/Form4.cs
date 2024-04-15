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
    public partial class Form4 : Form
    {
        string email;
        public Form4(string givenEmail)
        {
            email = givenEmail;
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string picturePath = openFileDialog.FileName;
                    Image selectedPicture = Image.FromFile(picturePath);
                    byte[] pictureData = ImageToByteArray(selectedPicture);
                    SqlConnection con = new SqlConnection(@"Data Source=IDEAPAD-SNOZM;Initial Catalog=Login;Integrated Security=True;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE UserProfiles SET picture=@picture, firstName=@firstname, lastName=@lastname, country=@country, gender=@gender WHERE email=@email", con);
                    cmd.Parameters.AddWithValue("@picture", pictureData);
                    cmd.Parameters.AddWithValue("@firstname", firstNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@lastname", lastNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@country", countryTextBox.Text);
                    cmd.Parameters.AddWithValue("@gender", genderTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    pictureBox1.Image = selectedPicture;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private byte[] ImageToByteArray(Image picture)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                picture.Save(ms, picture.RawFormat);
                return ms.ToArray();
            }
        }
        private Image ByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=IDEAPAD-SNOZM;Initial Catalog=Login;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserProfiles WHERE email=@email", con);
            cmd.Parameters.AddWithValue("@email", email);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            pictureBox1.Image = ByteArrayToImage((byte[])table.Rows[0]["picture"]);
            firstNameTextBox.Text = table.Rows[0]["firstName"].ToString();
            lastNameTextBox.Text = table.Rows[0]["lastName"].ToString();
            countryTextBox.Text = table.Rows[0]["country"].ToString();
            genderTextBox.Text = table.Rows[0]["gender"].ToString();
            con.Close();
        }
    }
}
