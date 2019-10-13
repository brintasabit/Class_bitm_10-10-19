using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    public class Account
    {
        private string accountNumber;
        private string customerName;
        private int balance;
        private int deposit;
        private int withdraw;

        public Account()
        {

        }

        public Account(string accountNumber,string customerName)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
        }


        public int Deposit
        {
            //return deposit;
            set { this.deposit = value; }
            get { return this.deposit; }
        }

        public int Withdraw
        {
            //int tBalance = deposit - withdraw;
            // return withdraw;
            set { this.withdraw = value; }
            get { return this.withdraw; }
        }

        public string AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string CustomerName
        {
            set { this.customerName = value; }
            get { return this.customerName; }
        }

        public int TotalBalance()
        {
            balance = deposit - withdraw;
            return balance;
        }
       
    }
}
