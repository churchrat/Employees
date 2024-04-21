using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class BankAcountPerson
    {
        private int id;
        private double balance;
        public int Id { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }
        public void Print()
        {
            Console.WriteLine($"Account {this.Id}, Balance {this.balance}");
        }
    }
}
