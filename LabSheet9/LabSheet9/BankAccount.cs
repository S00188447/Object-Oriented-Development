using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet9
{
    public class BankAccount
    {
        public decimal Balance { get; set; }

        public decimal OverdraftLimit { get; set; }

        

        public void Desposit (decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            decimal availableFunds = Balance + OverdraftLimit;
            if(amount <= availableFunds) //ensuring there is enough money
            Balance -= amount;
        }


    }
}
