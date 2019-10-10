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
        public string accountNumber { get; set; }
        public string customerName { get; set; }
        public int balance;
        public int deposit;
        public int withdraw;

        public int Deposit()
        {
            return deposit;
        }

        public int Withdraw()
        {
            //int tBalance = deposit - withdraw;
            return withdraw;
        }

        public int TotalBalance()
        {
            balance = deposit - withdraw;
            return balance;
        }
       
    }
}
