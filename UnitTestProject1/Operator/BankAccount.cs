using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public class BankAccount
    {
        private readonly string _customerName;
        private double _balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            _customerName = customerName;
            _balance = balance;
        }

        public string CustomerName
        {
            get { return _customerName; }
        }

        public double Balance
        {
            get { return _balance; }
        }


        // to debit amount in account
        public void Debit(double amount)
        {
            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            else if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            else if (amount > 5000)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            _balance -= amount; // intentionally incorrect code

        }


        // to credit amount in account
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            _balance += amount;
        }

        public static void Main()
        {
            BankAccount bankAccount = new BankAccount("Vishesh Kapoor", 11.99);

            bankAccount.Credit(5.77);
            bankAccount.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", bankAccount.Balance); 
        }
    }
}
