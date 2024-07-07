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
    public partial class FrmComment : Form
    {
        public FrmComment()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-H9055HU\SQLEXPRESS;Initial Catalog=StarHostel;Integrated Security=True");

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void dataShow()
        {
            listView1.Items.Clear();

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CustomerComments", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listView = new ListViewItem();

                listView.Text = reader["ID"].ToString();
                listView.SubItems.Add(reader["Name"].ToString());
                listView.SubItems.Add(reader["Surname"].ToString());
                listView.SubItems.Add(reader["Comment"].ToString());

                listView1.Items.Add(listView);
            }

            sqlConnection.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO CustomerComments (ID, Name, Surname, Comment) VALUES (@P1, @P2, @P3)", sqlConnection);
            
            SqlDataReader reader = sqlCommand.ExecuteReader();
            
            while(reader.Read())
            {
                TxtBoxName.Text = reader["Name"].ToString();
                TxtBoxSurname.Text = reader["Surname"].ToString();
                rTxtBoxComment.Text = reader["Comment"].ToString();
            }

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            dataShow();
        }

        private void FrmComment_Load(object sender, EventArgs e)
        {
            dataShow();
        }

        int id;
        private void listView1_Click(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtBoxName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtBoxSurname.Text = listView1.SelectedItems[0].SubItems[2].Text;
            rTxtBoxComment.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
    }
}