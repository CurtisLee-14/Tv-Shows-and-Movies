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
using Microsoft.Data.SqlClient;

namespace Shows_and_movies_watched
{
    public partial class NewAddition : Form
    {
        public NewAddition()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CURTIS\SQLMOVIEDATABASE;Initial Catalog=MovieDatabase;Integrated Security=True;trusted_connection=true;encrypt=false;");
            string insertQuey = "Insert into [Table] (Title, Catagory, Rating, Description)Values('" + txtTitle.Text + "','" + txtCatagory.Text + "','" + txtRating.Text + "','" + txtDescription.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(insertQuey, con);
            cmd.ExecuteNonQuery();
            con.Close();

            Clear();
        }

        private void NewAddition_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            txtDescription.Clear();
            txtTitle.Clear();
            txtCatagory.Clear();
            txtRating.Clear();
        }

    }
}
