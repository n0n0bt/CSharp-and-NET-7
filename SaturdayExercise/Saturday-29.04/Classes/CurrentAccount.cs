using Saturday_29._04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_29._04.Classes
{
    public class CurrentAccount : IBankAccount
    {
        private decimal _balance;

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
            else
            {
                _balance -= amount;
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
