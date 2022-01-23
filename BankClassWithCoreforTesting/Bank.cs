using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassWithCoreforTesting
{
    public class Bank
    {
        public float balance;
        public float minbalance = 10;


        //public float Balance { get; set; }
        //public float Minbalance { get; set; }
        public Bank()
        {

        }

        public void Deposit(float amount)
        {
            balance += amount;
            Console.WriteLine($"New Balance is {balance}");
        }

        public void Withdrawal(float amount)
        {
            balance -= amount;
            Console.WriteLine($"New Balance is {balance}");
        }
        public void TransferFunds(float amount, Bank destination, Bank Source)
        {
            destination.Deposit(amount);
            Source.Withdrawal(amount);
            Console.WriteLine($" Now {destination.balance} is at Destination and {Source.balance} is at Source after Transfer");
            
        }

        public Bank TransferMinFunds(Bank destination, float amount, Bank Source)
        {
           if(balance -amount >minbalance)
            {
                destination.Deposit(amount);
                Source.Withdrawal(amount);
                Console.WriteLine("Inside TransferMinFunds");
                Console.WriteLine($" Now {destination.balance} is at Destination and {Source.balance} is at Source after Transfer");


            }
            else
            {
                Console.WriteLine( $" Transfer  Not Possible");
                Console.WriteLine("Transfer MinFunds");
                Console.WriteLine($" Now {destination.balance} is at Destination and {Source.balance} is at Source after Transfer");
            }

            return destination;

        }
        public Bank(int value)
        {
            balance = value;
        }


    }
}
