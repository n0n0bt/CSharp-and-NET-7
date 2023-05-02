using Saturday_29._04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_29._04.Classes
{
        public class SavingAccount : IBankAccount
    {
        private decimal _balance;
        private decimal _perDayLimit;

        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (_balance < amount) 
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            } 
            else if(_perDayLimit + amount > 5000) // limit is 5000
            {
                Console.WriteLine("Withdrawl attempt failed!");
                return false;
            }
            else
            {
                _balance -= amount;
                _perDayLimit += amount;
                Console.WriteLine($"Successfully withdraw: {amount,6:C}");
                return true;
            }
        }

        public decimal Balance { get { return _balance; } }

        public override string ToString()
        {
            return String.Format($"Saving account Balance = {_balance,6:C}");
        }
    }
}
