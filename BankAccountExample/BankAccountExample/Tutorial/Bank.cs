using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountExample.Tutorial
{
    public class Bank
    {
        public static void Transfer(BankAccount fromAccount, BankAccount toAccount,
       double amount)
        {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
        }
    }
}