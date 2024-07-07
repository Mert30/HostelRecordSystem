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
    public partial class FrmStocks : Form
    {
        public FrmStocks()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-H9055HU\SQLEXPRESS;Initial Catalog=StarHostel;Integrated Security=True");
        private void dataShow()
        {

            listView1.Items.Clear();

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listView = new ListViewItem(); 

                listView.Text = reader["Drinks"].ToString();
                listView.SubItems.Add(reader["Snacks"].ToString());
                listView.SubItems.Add(reader["Foods"].ToString());

                listView1.Items.Add(listView);
            }

            sqlConnection.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Products (Drinks, Snacks, Foods) VALUES (@P1, @P2, @P3)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@P1", TxtBoxDrink.Text);
            sqlCommand.Parameters.AddWithValue("@P2", TxtBoxSnack.Text);
            sqlCommand.Parameters.AddWithValue("@P3", TxtBoxFood.Text);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            dataShow();
        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            dataShow();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
