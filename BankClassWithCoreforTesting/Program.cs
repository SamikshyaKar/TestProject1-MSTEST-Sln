using System;

namespace BankClassWithCoreforTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bank bank = new Bank();
            Bank Source = new Bank();
            Bank destination = new Bank();
            //bank.Deposit(500);
            //bank.Withdrawal(200);
            Source.Deposit(500);
            Source.Withdrawal(300);
            destination.Deposit(300);

            bank.TransferFunds(100,destination, Source);
           Bank result=  bank.TransferMinFunds( destination, 600,Source);
            Bank bank1 = new Bank(500);
            Bank result1 = bank1.TransferMinFunds(destination, 100, Source);
            

        }
    }
}
