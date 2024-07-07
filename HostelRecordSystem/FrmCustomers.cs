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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'starHostelDataSet.AddCustomer' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.addCustomerTableAdapter.Fill(this.starHostelDataSet.AddCustomer);
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-H9055HU\SQLEXPRESS;Initial Catalog=StarHostel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        int id;

        private void listView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtBoxName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtBoxSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskTxtBoxPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtBoxMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            mskTxtBoxSSN.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtBoxRoomNumber.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtBoxPrice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpEntry.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpExit.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void ShowInformation()
        {
            listView1.Items.Clear();

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM AddCustomer", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listView = new ListViewItem();
                
                listView.Text = reader["ID"].ToString();
                listView.SubItems.Add(reader["Name"].ToString());
                listView.SubItems.Add(reader["Surname"].ToString());
                listView.SubItems.Add(reader["Gender"].ToString());
                listView.SubItems.Add(reader["PhoneNumber"].ToString());
                listView.SubItems.Add(reader["Mail"].ToString());
                listView.SubItems.Add(reader["SSN"].ToString());
                listView.SubItems.Add(reader["RoomNumber"].ToString());
                listView.SubItems.Add(reader["Price"].ToString());
                listView.SubItems.Add(reader["DateOfEntry"].ToString());
                listView.SubItems.Add(reader["DateOfExit"].ToString());

                listView1.Items.Add(listView); 
            }

            sqlConnection.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand =
                new SqlCommand("UPDATE AddCustomer SET Name = @P1, Surname = @P2, Gender = @P3, PhoneNumber = @P4, Mail = @P5, SSN  = @P6, RoomNumber = @P7, Price = @P8, DateOfEntry = @P9, DateOfExit  = @P10 WHERE ID = @P11", sqlConnection);

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
            sqlCommand.Parameters.AddWithValue("@P11", id);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            ShowInformation();

            MessageBox.Show("Data updated.");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("DELETE FROM CustomerRooms WHERE CustomerName = @P2", sqlConnection);            

            sqlCommand.Parameters.AddWithValue("@P2", TxtBoxName.Text);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            ShowInformation();

            MessageBox.Show("Data deleted.");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM AddCustomer WHERE Name LIKE '%" + TxtSearchName.Text + "%'", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while(reader.Read())
            {
                ListViewItem listView = new ListViewItem();

                listView.Text = reader["ID"].ToString();
                listView.SubItems.Add(reader["Name"].ToString());
                listView.SubItems.Add(reader["Surname"].ToString());
                listView.SubItems.Add(reader["Gender"].ToString());
                listView.SubItems.Add(reader["PhoneNumber"].ToString());
                listView.SubItems.Add(reader["Mail"].ToString());
                listView.SubItems.Add(reader["SSN"].ToString());
                listView.SubItems.Add(reader["RoomNumber"].ToString());
                listView.SubItems.Add(reader["Price"].ToString());
                listView.SubItems.Add(reader["DateOfEntry"].ToString());
                listView.SubItems.Add(reader["DateOfExit"].ToString());

                listView1.Items.Add(listView);
            }

            reader.Close();

            sqlConnection.Close();
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
            TxtSearchName.Clear();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ShowInformation();
        }

    }
}
