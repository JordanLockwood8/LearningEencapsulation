using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationEx1
{
    public class BankAccount
    {
        //field
        private double balance = 0.0;


        //Method
        public void Deposit()
        {
            Console.WriteLine("enter deposit ammount in 00.00 format");
            var deposit = double.Parse(Console.ReadLine());
            balance += deposit;
        }

        public void Withdraw()
        {
            Console.WriteLine("enter withdraw amount in 00.00 format");
            var withdraw = double.Parse(Console.ReadLine());
            balance -= withdraw;

        }
        public void GetBalance()
        {
            Console.WriteLine($"Your current balance is:{balance}");
        }

    }
}
