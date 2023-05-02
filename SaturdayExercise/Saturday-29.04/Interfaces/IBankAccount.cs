using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_29._04.Interfaces
{
    public interface IBankAccount
    {
        public bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
        public decimal Balance { get; }
    }
}
