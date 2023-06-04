using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms;




namespace Shows_and_movies_watched
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAddition newAddition = new NewAddition();
            newAddition.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=CURTIS\\SQLMOVIEDATABASE;Initial Catalog=MovieDatabase;Integrated Security=True;trusted_connection=true; encrypt=false;"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT Title, Catagory, Rating, Description FROM [Table]", connection);

                SqlDataReader reader = command.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader.GetString(0));

                    item.SubItems.Add((string)reader.GetString(1));
                    item.SubItems.Add((string)reader.GetString(2));
                    item.SubItems.Add((string)reader.GetString(3));

                    listView1.Items.Add(item);
                }

                reader.Close();
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                string identifierValue = selectedItem.SubItems[0].Text;

                using (SqlConnection connection = new SqlConnection("Data Source=CURTIS\\SQLMOVIEDATABASE;Initial Catalog=MovieDatabase;Integrated Security=True;trusted_connection=true;encrypt=false;"))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM [Table] WHERE Title = @IdentifierValue", connection);

                    command.Parameters.AddWithValue("@IdentifierValue", identifierValue);
                    command.ExecuteNonQuery();

                    listView1.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}