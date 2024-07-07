using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelRecordSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogScreen logScreen = new LogScreen();  
            logScreen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRooms frmRooms = new FrmRooms();
            frmRooms.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers(); 
            frmCustomers.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnIncomeAndExpense_Click(object sender, EventArgs e)
        {
            FrmIncomeAndExpense frmIncomeAndExpense = new FrmIncomeAndExpense();    
            frmIncomeAndExpense.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStocks frmStocks = new FrmStocks();  
            frmStocks.Show();
            this.Hide();
        }

        private void BtnBills_Click(object sender, EventArgs e)
        {
            FrmBills frmBills = new FrmBills();
            frmBills.Show();
            this.Hide();
        }

        private void HomePage_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Star Hostel established in 1967 by Fatmanur AYDIN.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmRadio frmRadio = new FrmRadio();
            frmRadio.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmNewspaper frmNewspaper = new FrmNewspaper();
            frmNewspaper.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmUpdatePassword frmUpdatePassword = new FrmUpdatePassword();
            frmUpdatePassword.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmComment frmComment = new FrmComment();
            frmComment.Show();
            this.Hide();
        }
    }
}
