using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.Atm
{
    internal class SavingAccount : Account
    {
        private decimal interestRate;

        public SavingAccount()
        { }


        public override decimal Withdraw(decimal cash)
        {
            if ((base._saving - cash) < 0)
            {
                Console.WriteLine($"提款失敗!餘額不足!");
                return 0;
            }
            else
            {
                return base.Withdraw(cash);
            }
        }
    }
}
