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

namespace CourseWork
{
    public partial class DealerForm : Form
    {
        SqlConnection sqlConnection;

        public DealerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""|| textBox6.Text == "" || maskedTextBox1.Text == "")
            {
                label2.Visible = true;
            }
            else
            {
                SqlCommand clientInsert = new SqlCommand("INSERT into [Dealer] (FirstName, SecondName, Patronymic, Photo, ResidentialAddress, PhoneNumber) VALUES (@FirstName, @SecondName, @Patronymic, @Photo, @ResidentialAddress, @PhoneNumber)", sqlConnection);
                clientInsert.Parameters.AddWithValue("FirstName", textBox3.Text);
                clientInsert.Parameters.AddWithValue("SecondName", textBox2.Text);
                clientInsert.Parameters.AddWithValue("Patronymic", textBox4.Text);
                clientInsert.Parameters.AddWithValue("Photo", checkBox1.Checked);
                clientInsert.Parameters.AddWithValue("ResidentialAddress", textBox6.Text);
                clientInsert.Parameters.AddWithValue("PhoneNumber", maskedTextBox1.Text);
                clientInsert.ExecuteNonQuery();
                sqlConnection.Close();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
                maskedTextBox1.Text = "";

            }
        }

        private async void DealerForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GitHubRep\DataBasesCourseWork\CourseWork\CourseWork\Database1.mdf;Integrated Security=True;Current Language=Russian";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }
    }
}
