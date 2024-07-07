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
    public partial class FrmUpdatePassword : Form
    {
        public FrmUpdatePassword()
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

        private void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("DELETE FROM AccessScreen", sqlConnection);

            SqlCommand sqlCommand1 = new SqlCommand("INSERT INTO AccessScreen (UserName, Password) VALUES (@P1, @P2)", sqlConnection);

            sqlCommand1.Parameters.AddWithValue("@P1", TxtBoxUserName.Text);

            sqlCommand1.Parameters.AddWithValue("@P2", TxtBoxPassword.Text);

            sqlCommand.ExecuteNonQuery();

            sqlCommand1.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("UserName and Password updated.");
        }
    }
}
