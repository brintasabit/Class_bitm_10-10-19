using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        Account account = new Account();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            account.accountNumber = accountNoTextBox.Text;
            account.customerName = customerNameTextBox.Text;
            MessageBox.Show("Account Created!");
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            account.deposit = Convert.ToInt32(amountTextBox.Text);
            account.Deposit();
            MessageBox.Show("Deposited!");
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            account.withdraw = Convert.ToInt32(amountTextBox.Text);
            account.Withdraw();
            MessageBox.Show("Withdrawn!");
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show(account.customerName + "," + "Your Account Number: " +
                            account.accountNumber + " & It's Balance: " + account.TotalBalance());
        }
    }
}