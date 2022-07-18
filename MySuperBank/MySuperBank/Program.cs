using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Bhanu", 200000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(100, DateTime.Now, "For recharge");
            Console.WriteLine($"Balance {account.Balance}");

            try
            {
            account.MakeDeposit(-1000, DateTime.Now, "Fake Deposit");
            } 
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Exception caught creating account with negative balance {e.ToString()}");
            }

            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}