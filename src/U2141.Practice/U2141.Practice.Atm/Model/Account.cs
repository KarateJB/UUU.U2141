using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.Atm
{
    internal class Account
    {
        public string Id { get; set; }
        public decimal Balance { get; private set; }
        public void Deposit()
        {
            throw new NotImplementedException();
        }

        public decimal Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
