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

namespace HostelRecordSystem
{
    public partial class FrmIncomeAndExpense : Form
    {
        public FrmIncomeAndExpense()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-H9055HU\SQLEXPRESS;Initial Catalog=StarHostel;Integrated Security=True");

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int minWage = 1500;

            int personal = Convert.ToInt32(TxtBoxPersonalNo.Text);

            LblPersonalSalary.Text = (personal * minWage).ToString();


            int totalSafe =  Convert.ToInt32(LblTotalSafe.Text);

            int personalSalary = Convert.ToInt32(LblPersonalSalary.Text);

            int totalKitchen = Convert.ToInt32(LblKitchen.Text);

            int totalBill = Convert.ToInt32(LblBill.Text);

            int result = totalSafe - (personalSalary + totalKitchen + totalBill);

            LblResult.Text = result.ToString();

            if (result > 0)
                MessageBox.Show("Hostel is making a profit.");
            else
                MessageBox.Show("Hostel is making a loss.");
           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage(); 
            homePage.Show();
            this.Hide();
        }

        private void FrmIncomeAndExpense_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT SUM(Price) AS Total FROM AddCustomer", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                LblTotalSafe.Text = reader["Total"].ToString();
            }

            reader.Close();        


            SqlCommand sqlCommand1 = new SqlCommand("SELECT SUM(Electric + Internet + Water + NaturalGas) AS TotalBills FROM Bills", sqlConnection);

            SqlDataReader reader1 = sqlCommand1.ExecuteReader();

            while (reader1.Read())
            {
                LblBill.Text = reader1["TotalBills"].ToString();
            }

            reader1.Close();


            SqlCommand sqlCommand2 = new SqlCommand("SELECT SUM(Drinks + Snacks + Foods) AS TotalKitchen FROM Products", sqlConnection);

            SqlDataReader reader2 = sqlCommand2.ExecuteReader();

            while (reader2.Read())
            {
                LblKitchen.Text = reader2["TotalKitchen"].ToString();
            }

            reader2.Close();

            sqlConnection.Close();
        }
    }
}
