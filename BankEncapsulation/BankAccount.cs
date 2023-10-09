using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _balance = 0;

        public BankAccount()
        {
        }
        public BankAccount(double balance)
        {
            _balance = balance;
        }

        public void Deposit(double addMoney)
        {
            _balance += addMoney;
        }
        public void Withdraw(double subtractMoney)
        {
            _balance -= subtractMoney;
        }

        public double GetBalance() 
        {
            Console.WriteLine($"Your bank account has ${_balance}");
            return _balance;
        }

    }
}
