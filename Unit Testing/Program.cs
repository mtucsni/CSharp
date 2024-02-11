using System;
using Bank;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account myAccount = new Account("John Doe", 1000.00);

            
            Console.WriteLine($"Initial balance: {myAccount.Balance:C2}");

           
            myAccount.Debit(500);
            Console.WriteLine($"Balance after debit: {myAccount.Balance:C2}");

            myAccount.Credit(200);
            Console.WriteLine($"Balance after credit: {myAccount.Balance:C2}");

           
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
