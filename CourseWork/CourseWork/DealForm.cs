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
    public partial class DealForm : Form
    {

        SqlConnection sqlConnection;
        DBForm dBForm = new DBForm();
        Database1DataSet ds = new Database1DataSet();

        public DealForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || maskedTextBox3.Text == "" || textBox8.Text == "" ||textBox9.Text == ""|| listBox1.SelectedItems.Count == 0 || listBox2.SelectedItems.Count == 0)
            {
                label2.Visible = true;
            }
            else
            {
                SqlCommand clientInsert = new SqlCommand("INSERT into [Contract] (IdClient, IdDealer, DateOfConclusion, Brand, PhotoOfAuto, ReleaseDate, Mileage, SaleDate, Price, CommissionAmount, Note) VALUES (@IdClient, @IdDealer, @DateOfConclusion, @Brand, @PhotoOfAuto, @ReleaseDate, @Mileage, @SaleDate, @Price, @CommissionAmount, @Note)", sqlConnection);

                string dealerStr = listBox1.SelectedItem.ToString();
                string[] massDealer = dealerStr.Split(' ');
                
                clientInsert.Parameters.AddWithValue("IdDealer", Convert.ToInt32(massDealer[2]));
                ////clientInsert.Parameters.AddWithValue("IdDealer", Convert.ToInt32(idDealerNumber.Substring(13, 1)));
                //clientInsert.Parameters.Add("@IdDealer", SqlDbType.Int).SourceColumn = "IdDealer";

                string clientStr = listBox2.SelectedItem.ToString();
                string[] massClient = clientStr.Split(' ');
                
                clientInsert.Parameters.AddWithValue("IdClient", Convert.ToInt32(massClient[2]));
                ////clientInsert.Parameters.AddWithValue("IdClient", Convert.ToInt32(idClientNumber.Substring(14,1)));
                //clientInsert.Parameters.Add("@IdClient", SqlDbType.Int).SourceColumn = "IdClient";

                clientInsert.Parameters.AddWithValue("DateOfConclusion", maskedTextBox1.Text).SourceColumn = "DateOfConclusion";
                //clientInsert.Parameters.Add("@DateOfConclusion", SqlDbType.DateTime).SourceColumn = "DateOfConclusion";

                clientInsert.Parameters.AddWithValue("Brand", textBox5.Text).SourceColumn = "Brand";
                //clientInsert.Parameters.Add("@Brand", SqlDbType.NVarChar).SourceColumn = "Brand";

                clientInsert.Parameters.AddWithValue("PhotoOfAuto", checkBox1.Checked).SourceColumn = "PhotoOfAuto";
                //clientInsert.Parameters.Add("@PhotoOfAuto",SqlDbType.Bit).SourceColumn = "PhotoOfAuto";

                clientInsert.Parameters.AddWithValue("ReleaseDate", maskedTextBox2.Text).SourceColumn = "ReleaseDate";
                //clientInsert.Parameters.Add("@ReleaseDate",SqlDbType.DateTime).SourceColumn = "ReleaseDate";

                clientInsert.Parameters.AddWithValue("Mileage", textBox4.Text).SourceColumn = "Mileage";
                //clientInsert.Parameters.Add("@Mileage", SqlDbType.NVarChar).SourceColumn = "Mileage";

                clientInsert.Parameters.AddWithValue("SaleDate", maskedTextBox3.Text).SourceColumn = "SaleDate";
                //clientInsert.Parameters.Add("@SaleDate",SqlDbType.DateTime).SourceColumn = "SaleDate";

                clientInsert.Parameters.AddWithValue("Price", textBox3.Text).SourceColumn = "Price";
                //clientInsert.Parameters.Add("@Price", SqlDbType.NVarChar).SourceColumn = "Price";

                clientInsert.Parameters.AddWithValue("CommissionAmount", textBox8.Text).SourceColumn = "CommissionAmount";
                //clientInsert.Parameters.Add("@CommissionAmount", SqlDbType.NVarChar).SourceColumn = "CommissionAmount";

                clientInsert.Parameters.AddWithValue("Note", textBox9.Text).SourceColumn = "Note";
                //clientInsert.Parameters.Add("@Note", SqlDbType.NVarChar).SourceColumn = "Note";
                clientInsert.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = clientInsert;
                adapter.Update(ds,"Contract");

                //Database1DataSet.ContractTableAdapter contractTableAdapter = new Database1DataSet.ContractTableAdapter();
                //ds.contractTableAdapter.Fill(this.database1DataSet1.Contract);
                //contractTableAdapter.Update(database1DataSet1);
                sqlConnection.Close();
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                maskedTextBox3.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                dBForm.dataGridView2.Refresh();
                dBForm.dataGridView2.Update();
            }
        }

        private async void DealForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CourseWork\CourseWork\Database1.mdf;Integrated Security=True;Current Language=Russian";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

            //Вывод списка клиентов в listBox 
            SqlCommand clientsListSelect = new SqlCommand("SELECT IdClient, FirstName, SecondName, Patronymic FROM [Client]", sqlConnection);
            SqlDataReader clientsReader = clientsListSelect.ExecuteReader();
            while (clientsReader.Read())
            {
                listBox2.Items.Add("(Код клиента: " + Convert.ToString(clientsReader["IdClient"])+ " ) " + Convert.ToString(clientsReader["FirstName"]) + " " +Convert.ToString(clientsReader["SecondName"]) + " " + Convert.ToString(clientsReader["Patronymic"]));
            }
            clientsReader.Close();

            //Вывод списка дилеров в listBox 
            SqlCommand dealersListSelect = new SqlCommand("SELECT IdDealer, FirstName, SecondName, Patronymic FROM [Dealer]", sqlConnection);
            SqlDataReader dealersReader = dealersListSelect.ExecuteReader();
            while (dealersReader.Read())
            {
                listBox1.Items.Add("(Код дилера: " + Convert.ToString(dealersReader["IdDealer"]) + " ) " + Convert.ToString(dealersReader["FirstName"]) + " " + Convert.ToString(dealersReader["SecondName"]) + " " + Convert.ToString(dealersReader["Patronymic"]));
            }
            dealersReader.Close();
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DealForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
