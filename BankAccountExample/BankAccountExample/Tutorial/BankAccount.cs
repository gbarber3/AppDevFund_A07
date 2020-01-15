using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountExample.Tutorial
{
    public class BankAccount
    {
        #region Fields (always private)
        private int _AccountNumber;
        private double _Balance;
        #endregion
        #region Properties
        public int AccountNumber
        {
            get { return _AccountNumber; }
            private set { _AccountNumber = value; }
        }
        public double Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
        #endregion
        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }
        public void Withdraw(double amount)
        {
            Balance = Balance - amount;
        }
    }
}