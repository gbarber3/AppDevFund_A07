using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountExample.Tutorial
{
    public class DemoDriver
    {
        public static void Start()
        {
            BankAccount myAccount = new BankAccount(123546, 250.00);
            BankAccount storeAccount = new BankAccount(987654, 5473.28);
            DisplayAccount(myAccount, "My Account");
            DisplayAccount(storeAccount, "Store Account");
            Console.WriteLine("I am purchasing an item for $12.95");
            Bank.Transfer(myAccount, storeAccount, 12.95);
            DisplayAccount(myAccount, "My Account");
            DisplayAccount(storeAccount, "Store Account");
            Console.WriteLine("Purchase complete");
        } // end of Start() method
        private static void DisplayAccount(BankAccount account, string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("-- Account Info --");
            Console.WriteLine("Acct. #: " + account.AccountNumber);
            Console.WriteLine("Balance: $ " + account.Balance);
            Console.WriteLine("-- ------------ --");
            Console.WriteLine();
        } // end of DisplayAccount() method
    }
}
