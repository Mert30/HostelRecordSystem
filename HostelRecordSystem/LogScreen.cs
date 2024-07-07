using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HostelRecordSystem
{
    public partial class LogScreen : Form
    {
        public LogScreen()
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

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM AccessScreen", sqlConnection);

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {  
                string UserName = reader["UserName"].ToString();

                string password = reader["Password"].ToString();

                if((TxtBoxUserName.Text == UserName) && (TxtBoxPassword.Text == password))
                {
                    FrmNewCustomer frmNewCustomer = new FrmNewCustomer();
                    frmNewCustomer.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You entered wrong user name or password.");
                }
            }

            sqlConnection.Close();
        }
    }
}
