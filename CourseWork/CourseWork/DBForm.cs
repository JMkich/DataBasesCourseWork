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
    public partial class DBForm : Form
    {
        SqlConnection sqlConn;
        SqlDataAdapter adapterClient = null;
        SqlDataAdapter adapterDealer = null;
        SqlDataAdapter adapterContract = null;
        DataSet dsClient = new DataSet();
        DataSet dsDealer = new DataSet();
        DataSet dsContract = new DataSet();

        public DBForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DBForm_Load(object sender, EventArgs e)
        {
            //this.contractTableAdapter.Fill(this.database1DataSet.Contract);
            //this.dealerTableAdapter.Fill(this.database1DataSet.Dealer);
            //this.clientTableAdapter.Fill(this.database1DataSet.Client);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\GitHubRep\DataBasesCourseWork\CourseWork\CourseWork\Database1.mdf;Integrated Security=True;Current Language=Russian";
            adapterClient = new SqlDataAdapter("SELECT * FROM Client", new SqlConnection(connectionString));
            adapterDealer = new SqlDataAdapter("SELECT * FROM Dealer", new SqlConnection(connectionString));
            adapterContract = new SqlDataAdapter("SELECT * FROM Contract", new SqlConnection(connectionString));
            SqlCommandBuilder builderClient = new SqlCommandBuilder(adapterClient);
            SqlCommandBuilder builderDealer = new SqlCommandBuilder(adapterDealer);
            SqlCommandBuilder builderContract = new SqlCommandBuilder(adapterContract);
            adapterClient.UpdateCommand = builderClient.GetUpdateCommand();
            adapterClient.InsertCommand = builderClient.GetInsertCommand();
            adapterClient.DeleteCommand = builderClient.GetDeleteCommand();
            adapterDealer.UpdateCommand = builderDealer.GetUpdateCommand();
            adapterDealer.InsertCommand = builderDealer.GetInsertCommand();
            adapterDealer.DeleteCommand = builderDealer.GetDeleteCommand();
            adapterContract.UpdateCommand = builderContract.GetUpdateCommand();
            adapterContract.InsertCommand = builderContract.GetInsertCommand();
            adapterContract.DeleteCommand = builderContract.GetDeleteCommand();
            adapterClient.Fill(dsClient);
            adapterDealer.Fill(dsDealer);
            adapterContract.Fill(dsContract);
            dataGridView1.DataSource = dsClient.Tables[0];
            dataGridView2.DataSource = dsContract.Tables[0];
            dataGridView3.DataSource = dsDealer.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            clientTableAdapter.Update(database1DataSet);

            dealerBindingSource.EndEdit();
            dealerTableAdapter.Update(database1DataSet);

            contractBindingSource.EndEdit();
            contractTableAdapter.Update(database1DataSet);

            adapterClient.Update(dsClient.Tables[0]);
            adapterDealer.Update(dsDealer.Tables[0]);
            adapterContract.Update(dsContract.Tables[0]);
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\VS Projects\CourseWork\CourseWork\Database1.mdf;Integrated Security=True;Current Language=Russian";
            //using (SqlConnection sqlConn = new SqlConnection(connectionString))
            //{
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT IdClient, FirstName, SecondName, Patronymic, City, ResidentialAddress, PhoneNumber FROM Clients", sqlConn);
            //    dataAdapter.UpdateCommand = new SqlCommand("UPDATE Clients SET FirstName = @FirstName, SecondName = @SecondName, Patronymic = @Patronymic, City = @City, ResidentialAddress = @ResidentialAddress, PhoneNumber = @PhoneNumber WHERE IdClient = @IdClient",sqlConn);
            //    dataAdapter.UpdateCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            //    dataAdapter.UpdateCommand.Parameters.Add("@SecondName", SqlDbType.NVarChar, 50, "SecondName");
            //    dataAdapter.UpdateCommand.Parameters.Add("@Patronymic", SqlDbType.NVarChar, 50, "Patronymic");
            //    dataAdapter.UpdateCommand.Parameters.Add("@City", SqlDbType.NVarChar, 50, "City");
            //    dataAdapter.UpdateCommand.Parameters.Add("@ResidentialAddress", SqlDbType.NVarChar, 50, "ResidentialAddress");
            //    dataAdapter.UpdateCommand.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar, 50, "PhoneNumber");

            //    SqlParameter parameter = dataAdapter.UpdateCommand.Parameters.Add("@IdClient", SqlDbType.Int);
            //    parameter.SourceVersion = DataRowVersion.Original;

            //    DataTable clientTable = new DataTable();
            //    dataAdapter.Fill(clientTable);
            //}
        }
    }
}
