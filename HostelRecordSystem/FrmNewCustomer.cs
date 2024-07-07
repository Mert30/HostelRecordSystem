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
using System.Data.Sql;

namespace HostelRecordSystem
{
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-H9055HU\SQLEXPRESS;Initial Catalog=StarHostel;Integrated Security=True");

        private void Btn101_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "101";
        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "102";
        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "103";
        }

        private void Btn104_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "104";
        }

        private void Btn201_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "201";
        }

        private void Btn202_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "202";
        }

        private void Btn203_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "203";
        }

        private void Btn204_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "204";
        }

        private void Btn301_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "301";
        }

        private void Btn302_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "302";
        }

        private void Btn303_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "303";
        }

        private void Btn304_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "304";
        }

        private void Btn401_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "401";
        }

        private void Btn402_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "402";
        }

        private void Btn403_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "403";
        }

        private void Btn404_Click(object sender, EventArgs e)
        {
            TxtBoxRoomNumber.Text = "404";
        }

        private void dtpExit_ValueChanged(object sender, EventArgs e)
        {
            int perDayMoney = 50;
           
            DateTime smallTime = Convert.ToDateTime(dtpEntry.Value);
            DateTime bigTime = Convert.ToDateTime(dtpExit.Value);

            TimeSpan timeSpan = bigTime - smallTime;

            double price = timeSpan.TotalDays * perDayMoney;

            TxtBoxPrice.Text = price.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = 
                new SqlCommand("INSERT INTO AddCustomer (Name, Surname, Gender, PhoneNumber, Mail, SSN, RoomNumber, Price, DateOfEntry, DateOfExit) VALUES (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10)", sqlConnection);
                
            sqlCommand.Parameters.AddWithValue("@P1", TxtBoxName.Text);
            sqlCommand.Parameters.AddWithValue("@P2", TxtBoxSurname.Text);
            sqlCommand.Parameters.AddWithValue("@P3", comboBox1.Text);
            sqlCommand.Parameters.AddWithValue("@P4", mskTxtBoxPhone.Text);
            sqlCommand.Parameters.AddWithValue("@P5", TxtBoxMail.Text);
            sqlCommand.Parameters.AddWithValue("@P6", mskTxtBoxSSN.Text);
            sqlCommand.Parameters.AddWithValue("@P7", TxtBoxRoomNumber.Text);
            sqlCommand.Parameters.AddWithValue("@P8", TxtBoxPrice.Text);
            sqlCommand.Parameters.AddWithValue("@P9", dtpEntry.Value.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@P10", dtpExit.Value.ToString("yyyy-MM-dd"));

            sqlCommand.ExecuteNonQuery();

            SqlCommand sqlCommand1 = new SqlCommand("INSERT INTO CustomerRooms (CustomerName, CustomerSurname, RoomNo) VALUES (@P1, @P2, @P3)", sqlConnection);

            sqlCommand1.Parameters.AddWithValue("@P1", TxtBoxName.Text);
            sqlCommand1.Parameters.AddWithValue("@P2", TxtBoxSurname.Text);
            sqlCommand1.Parameters.AddWithValue("@P3", TxtBoxRoomNumber.Text);

            sqlCommand1.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("New Customer added into the system.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtBoxName.Clear();
            TxtBoxSurname.Clear();
            comboBox1.Text = "";
            mskTxtBoxPhone.Clear();
            TxtBoxMail.Clear();
            mskTxtBoxSSN.Clear();
            TxtBoxRoomNumber.Clear();
            TxtBoxPrice.Clear();
            dtpEntry.Text = "";
            TxtBoxName.Text = "";
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {

            // Rom 101

            sqlConnection.Open();

            SqlCommand sqlCommand1 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 101", sqlConnection);

            SqlDataReader reader1 = sqlCommand1.ExecuteReader();

            while (reader1.Read())
                Btn101.Text = "FULL";

            sqlConnection.Close();

            if (Btn101.Text != "101")
            {
                Btn101.BackColor = Color.Red;
                Btn101.Enabled = false;   
            }
                 
            // Room 102

            sqlConnection.Open();

            SqlCommand sqlCommand2 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 102", sqlConnection);

            SqlDataReader reader2 = sqlCommand2.ExecuteReader();

            while (reader2.Read())
                Btn102.Text = "FULL";

            sqlConnection.Close();

            if (Btn102.Text != "102")
            {
                Btn102.BackColor = Color.Red;
                Btn102.Enabled = false;
            }

            // Room 103

            sqlConnection.Open();

            SqlCommand sqlCommand3 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 103", sqlConnection);

            SqlDataReader reader3 = sqlCommand3.ExecuteReader();

            while (reader3.Read())
                Btn103.Text = "FULL";

            sqlConnection.Close();

            if (Btn103.Text != "103")
            {
                Btn103.BackColor = Color.Red;
                Btn103.Enabled = false;
            }

            // Room 104

            sqlConnection.Open();

            SqlCommand sqlCommand4 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 104", sqlConnection);

            SqlDataReader reader4 = sqlCommand4.ExecuteReader();

            while (reader4.Read())
                Btn104.Text = "FULL";

            sqlConnection.Close();

            if (Btn104.Text != "104")
            {
                Btn104.BackColor = Color.Red;
                Btn104.Enabled = false;
            }

            // Room 201

            sqlConnection.Open();

            SqlCommand sqlCommand5 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 201", sqlConnection);

            SqlDataReader reader5 = sqlCommand5.ExecuteReader();

            while (reader5.Read())
                Btn201.Text = "FULL";

            sqlConnection.Close();

            if (Btn201.Text != "201")
            {
                Btn201.BackColor = Color.Red;
                Btn201.Enabled = false;
            }

            // Room 202

            sqlConnection.Open();

            SqlCommand sqlCommand6 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 202", sqlConnection);

            SqlDataReader reader6 = sqlCommand6.ExecuteReader();

            while (reader6.Read())
                Btn202.Text = "FULL";

            sqlConnection.Close();

            if (Btn202.Text != "202")
            {
                Btn202.BackColor = Color.Red;   
                Btn202.Enabled = false;
            }

            // Room 203 

            sqlConnection.Open();

            SqlCommand sqlCommand7 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 203", sqlConnection);

            SqlDataReader reader7 = sqlCommand7.ExecuteReader();

            while (reader7.Read())
                Btn203.Text = "FULL";

            sqlConnection.Close();

            if (Btn203.Text != "203")
            {
                Btn203.BackColor = Color.Red;   
                Btn203.Enabled = false; 
            }

            // Room 204

            sqlConnection.Open();

            SqlCommand sqlCommand8 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 204", sqlConnection);

            SqlDataReader reader8 = sqlCommand8.ExecuteReader();

            while (reader8.Read())
                Btn204.Text = "FULL";

            sqlConnection.Close();

            if (Btn204.Text != "204")
            {
                Btn204.BackColor = Color.Red;
                Btn204.Enabled = false;
            }

            // Room 301

            sqlConnection.Open();

            SqlCommand sqlCommand9 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 301", sqlConnection);

            SqlDataReader reader9 = sqlCommand9.ExecuteReader();

            while (reader9.Read())
                Btn301.Text = "FULL";

            sqlConnection.Close();

            if (Btn301.Text != "301")
            {
                Btn301.BackColor = Color.Red;
                Btn301.Enabled = false;
            }

            // Room 302

            sqlConnection.Open();

            SqlCommand sqlCommand10 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 302", sqlConnection);

            SqlDataReader reader10 = sqlCommand10.ExecuteReader();

            while (reader10.Read())
                Btn302.Text = "FULL";

            sqlConnection.Close();

            if (Btn302.Text != "302")
            {
                Btn302.BackColor = Color.Red;
                Btn302.Enabled = false;
            }

            // Room 303

            sqlConnection.Open();

            SqlCommand sqlCommand11 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 303", sqlConnection);

            SqlDataReader reader11 = sqlCommand11.ExecuteReader();

            while (reader11.Read())
                Btn303.Text = "FULL";

            sqlConnection.Close();

            if (Btn303.Text != "303")
            {
                Btn303.BackColor = Color.Red;
                Btn303.Enabled = false;
            }

            // Room 304

            sqlConnection.Open();

            SqlCommand sqlCommand12 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 304", sqlConnection);

            SqlDataReader reader12 = sqlCommand12.ExecuteReader();

            while (reader12.Read())
                Btn304.Text = "FULL";

            sqlConnection.Close();

            if (Btn304.Text != "304")
            {
                Btn304 .BackColor = Color.Red;
                Btn304 .Enabled = false;
            }

            // Room 401

            sqlConnection.Open();

            SqlCommand sqlCommand13 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 401", sqlConnection);

            SqlDataReader reader13 = sqlCommand13.ExecuteReader();

            while (reader13.Read())
                Btn401.Text = "FULL";

            sqlConnection.Close();

            if (Btn401.Text != "401")
            {
                Btn401.BackColor = Color.Red;
                Btn401.Enabled = false;
            }

            // Room 402

            sqlConnection.Open();

            SqlCommand sqlCommand14 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 402", sqlConnection);

            SqlDataReader reader14 = sqlCommand14.ExecuteReader();

            while (reader14.Read())
                Btn402.Text = "FULL";

            sqlConnection.Close();

            if (Btn402.Text != "402")
            {
                Btn401.BackColor = Color.Red;
                Btn401.Enabled = false;
            }

            // Room 403

            sqlConnection.Open();

            SqlCommand sqlCommand15 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 403", sqlConnection);

            SqlDataReader reader15 = sqlCommand15.ExecuteReader();

            while (reader15.Read())
                Btn403.Text = "FULL";

            sqlConnection.Close();

            if (Btn403.Text != "403")
            {
                Btn404.BackColor = Color.Red;
                Btn404.Enabled = false;
            }

            // Room 404

            sqlConnection.Open();

            SqlCommand sqlCommand16 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 404", sqlConnection);

            SqlDataReader reader16 = sqlCommand16.ExecuteReader();

            while (reader16.Read())
                Btn404.Text = "FULL";

            sqlConnection.Close();

            if (Btn404.Text != "404")
            {
                Btn404.BackColor = Color.Red;
                Btn404.Enabled = false;
            }
        }
    }
}