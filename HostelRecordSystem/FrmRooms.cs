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
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-H9055HU\SQLEXPRESS;Initial Catalog=StarHostel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void FrmRooms_Load(object sender, EventArgs e)
        {

            // Rom 101

            sqlConnection.Open();

            SqlCommand sqlCommand1 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 101", sqlConnection);

            SqlDataReader reader1 = sqlCommand1.ExecuteReader();

            while (reader1.Read())
                Btn101.Text = reader1["CustomerName"].ToString() + " " + reader1["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn101.Text != "101")
                Btn101.BackColor = Color.Red;

            // Room 102

            sqlConnection.Open();

            SqlCommand sqlCommand2 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 102", sqlConnection);

            SqlDataReader reader2 = sqlCommand2.ExecuteReader();

            while (reader2.Read())
                Btn102.Text = reader2["CustomerName"].ToString() + " " + reader2["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn102.Text != "102")
                Btn102.BackColor = Color.Red;

            // Room 103

            sqlConnection.Open();

            SqlCommand sqlCommand3 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 103", sqlConnection);

            SqlDataReader reader3 = sqlCommand3.ExecuteReader();

            while (reader3.Read())
                Btn103.Text = reader3["CustomerName"].ToString() + " " + reader3["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn103.Text != "103")
                Btn103.BackColor = Color.Red;

            // Room 104

            sqlConnection.Open();

            SqlCommand sqlCommand4 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 104", sqlConnection);

            SqlDataReader reader4 = sqlCommand4.ExecuteReader();

            while (reader4.Read())
                Btn104.Text = reader4["CustomerName"].ToString() + " " + reader4["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn104.Text != "104")
                Btn104.BackColor = Color.Red;

            // Room 201

            sqlConnection.Open();

            SqlCommand sqlCommand5 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 201", sqlConnection);

            SqlDataReader reader5 = sqlCommand5.ExecuteReader();

            while (reader5.Read())
                Btn201.Text = reader5["CustomerName"].ToString() + " " + reader5["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn201.Text != "201")
                Btn201.BackColor = Color.Red;

            // Room 202

            sqlConnection.Open();

            SqlCommand sqlCommand6 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 202", sqlConnection);

            SqlDataReader reader6 = sqlCommand6.ExecuteReader();

            while (reader6.Read())
                Btn202.Text = reader6["CustomerName"].ToString() + " " + reader6["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn202.Text != "202")
                Btn202.BackColor = Color.Red;

            // Room 203 

            sqlConnection.Open();

            SqlCommand sqlCommand7 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 203", sqlConnection);

            SqlDataReader reader7 = sqlCommand7.ExecuteReader();

            while (reader7.Read())
                Btn203.Text = reader7["CustomerName"].ToString() + " " + reader7["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn203.Text != "203")
                Btn203.BackColor = Color.Red;

            // Room 204

            sqlConnection.Open();

            SqlCommand sqlCommand8 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 204", sqlConnection);

            SqlDataReader reader8 = sqlCommand8.ExecuteReader();

            while (reader8.Read())
                Btn204.Text = reader8["CustomerName"].ToString() + " " + reader8["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn204.Text != "204")
                Btn204.BackColor = Color.Red;

            // Room 301

            sqlConnection.Open();

            SqlCommand sqlCommand9 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 301", sqlConnection);

            SqlDataReader reader9 = sqlCommand9.ExecuteReader();

            while (reader9.Read())
                Btn301.Text = reader9["CustomerName"].ToString() + " " + reader9["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn301.Text != "301")
                Btn301.BackColor = Color.Red;

            // Room 302

            sqlConnection.Open();

            SqlCommand sqlCommand10 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 302", sqlConnection);

            SqlDataReader reader10 = sqlCommand10.ExecuteReader();

            while (reader10.Read())
                Btn302.Text = reader10["CustomerName"].ToString() + " " + reader10["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn302.Text != "302")
                Btn302.BackColor = Color.Red;

            // Room 303

            sqlConnection.Open();

            SqlCommand sqlCommand11 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 303", sqlConnection);

            SqlDataReader reader11 = sqlCommand11.ExecuteReader();

            while (reader11.Read())
                Btn303.Text = reader11["CustomerName"].ToString() + " " + reader11["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn303.Text != "303")
                Btn303.BackColor = Color.Red;

            // Room 304

            sqlConnection.Open();

            SqlCommand sqlCommand12 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 304", sqlConnection);

            SqlDataReader reader12 = sqlCommand12.ExecuteReader();

            while (reader12.Read())
                Btn304.Text = reader12["CustomerName"].ToString() + " " + reader12["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn304.Text != "304")
                Btn304.BackColor = Color.Red;

            // Room 401

            sqlConnection.Open();

            SqlCommand sqlCommand13 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 401", sqlConnection);

            SqlDataReader reader13 = sqlCommand13.ExecuteReader();

            while (reader13.Read())
                Btn401.Text = reader13["CustomerName"].ToString() + " " + reader13["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn401.Text != "401")
                Btn401.BackColor = Color.Red;

            // Room 402

            sqlConnection.Open();

            SqlCommand sqlCommand14 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 402", sqlConnection);

            SqlDataReader reader14 = sqlCommand14.ExecuteReader();

            while (reader14.Read())
                Btn402.Text = reader14["CustomerName"].ToString() + " " + reader14["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn402.Text != "402")
                Btn402.BackColor = Color.Red;

            // Room 403

            sqlConnection.Open();

            SqlCommand sqlCommand15 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 403", sqlConnection);

            SqlDataReader reader15 = sqlCommand15.ExecuteReader();

            while (reader15.Read())
                Btn403.Text = reader15["CustomerName"].ToString() + " " + reader15["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn403.Text != "403")
                Btn403.BackColor = Color.Red;

            // Room 404

            sqlConnection.Open();

            SqlCommand sqlCommand16 = new SqlCommand("SELECT * FROM CustomerRooms WHERE RoomNo = 404", sqlConnection);

            SqlDataReader reader16 = sqlCommand16.ExecuteReader();

            while (reader16.Read())
                Btn404.Text = reader16["CustomerName"].ToString() + " " + reader16["CustomerSurname"].ToString();

            sqlConnection.Close();

            if (Btn404.Text != "404")
                Btn404.BackColor = Color.Red;
        }

        private void BtnFull_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Red colored rooms are filled.");
        }

        private void BtnEmpty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green colored rooms are empty.");
        }
    }
}
