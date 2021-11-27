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
    public partial class ReportsForm : Form
    {
        SqlConnection sqlConnection;

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ReportsForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GitHubRep\DataBasesCourseWork\CourseWork\CourseWork\Database1.mdf;Integrated Security=True;Current Language=Russian";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

            //Вывод списка в листбокс
            SqlCommand clientsListSelect = new SqlCommand("SELECT IdClient, FirstName, SecondName, Patronymic FROM [Client]", sqlConnection);
            SqlDataReader clientsReader = clientsListSelect.ExecuteReader();
            while (clientsReader.Read())
            {
                listBox1.Items.Add("(Код клиента: " + Convert.ToString(clientsReader["IdClient"]) + " ) " + Convert.ToString(clientsReader["FirstName"]) + " " + Convert.ToString(clientsReader["SecondName"]) + " " + Convert.ToString(clientsReader["Patronymic"]));
            }
            clientsReader.Close();
            

            SqlCommand dealersListSelect = new SqlCommand("SELECT IdDealer, FirstName, SecondName, Patronymic FROM [Dealer]", sqlConnection);
            SqlDataReader dealersReader = dealersListSelect.ExecuteReader();
            while (dealersReader.Read())
            {
                listBox2.Items.Add("(Код клиента: " + Convert.ToString(dealersReader["IdDealer"]) + " ) " + Convert.ToString(dealersReader["FirstName"]) + " " + Convert.ToString(dealersReader["SecondName"]) + " " + Convert.ToString(dealersReader["Patronymic"]));
            }
            dealersReader.Close();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand countOfContracts = new SqlCommand("SELECT COUNT(IdContract) FROM Contract WHERE IdClient = @IdClient", sqlConnection);
            string clientStr = listBox1.SelectedItem.ToString();
            string[] massDeal = clientStr.Split(' ');
            int a = Convert.ToInt32(massDeal[2]);
            countOfContracts.Parameters.AddWithValue("IdClient", a);
            SqlDataReader clientsRead = countOfContracts.ExecuteReader();
            while(clientsRead.Read())
            {
                label1.Text = clientsRead[0].ToString(); 
            }
            countOfContracts.Dispose();
            
            clientsRead.Close();

            sqlConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand countOfContracts = new SqlCommand("SELECT COUNT(IdContract) FROM Contract WHERE IdDealer = @IdDealer", sqlConnection);

            string dealerStr = listBox2.SelectedItem.ToString();
            string[] massDeal = dealerStr.Split(' ');
            countOfContracts.Parameters.AddWithValue("IdDealer", massDeal[2]);
            SqlDataReader dealerRead = countOfContracts.ExecuteReader();
            while (dealerRead.Read())
            {
                label2.Text = dealerRead[0].ToString();
            }
            countOfContracts.Dispose();

            dealerRead.Close();
            sqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand clientName = new SqlCommand("SELECT FirstName, SecondName, Patronymic FROM Client WHERE IdClient = @IdClient", sqlConnection);

            clientName.Parameters.AddWithValue("IdClient", Convert.ToInt32(textBox1.Text));
            SqlDataReader clientRead = clientName.ExecuteReader();
            while (clientRead.Read())
            {
                label3.Text = clientRead[1].ToString();
                label4.Text = clientRead[0].ToString();
                label5.Text = clientRead[2].ToString();
            }
            clientName.Dispose();

            clientRead.Close();
            sqlConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand dealerName = new SqlCommand("SELECT FirstName, SecondName, Patronymic FROM Dealer WHERE IdDealer = @IdDealer", sqlConnection);

            dealerName.Parameters.AddWithValue("IdDealer", Convert.ToInt32(textBox2.Text));
            SqlDataReader dealerRead = dealerName.ExecuteReader();
            while (dealerRead.Read())
            {
                label6.Text = dealerRead[2].ToString();
                label7.Text = dealerRead[0].ToString();
                label8.Text = dealerRead[1].ToString();
            }
            dealerName.Dispose();

            dealerRead.Close();
            sqlConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand contractInfo = new SqlCommand("SELECT DateOfConclusion, Brand, idClient, idDealer FROM Contract WHERE DateOfConclusion BETWEEN @DateFrom AND @DateTo", sqlConnection);

            contractInfo.Parameters.AddWithValue("DateFrom", maskedTextBox1.Text.ToString());
            contractInfo.Parameters.AddWithValue("DateTo", maskedTextBox2.Text.ToString());
            SqlDataReader contractRead = contractInfo.ExecuteReader();
            while(contractRead.Read())
            {
                label9.Text = contractRead[0].ToString();
                label10.Text = contractRead[1].ToString();
                label11.Text = contractRead[2].ToString();
                label12.Text = contractRead[3].ToString();
            }
            contractInfo.Dispose();
            contractRead.Close();

            sqlConnection.Close();
        }
    }
}
