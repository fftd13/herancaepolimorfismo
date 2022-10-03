using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string? Holder { get; set; }
        public double Balance { get;protected set; }

        public Account() { }

        public Account(int number, string? holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw(double amount)
        {
            if(amount < Balance)
            {
                Balance -= amount;
            }            
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
