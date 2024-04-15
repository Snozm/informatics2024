using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pictures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
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
                    SqlCommand cmd = new SqlCommand("UPDATE UserProfiles SET picture=@picture WHERE email=@email", con);
                    cmd.Parameters.AddWithValue("@picture", pictureData);
                    cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
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
            SqlCommand cmd = new SqlCommand("SELECT picture FROM UserProfiles WHERE email=@email", con);
            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            pictureBox1.Image = ByteArrayToImage((byte[])table.Rows[0]["picture"]);
            con.Close();
        }
    }
}
