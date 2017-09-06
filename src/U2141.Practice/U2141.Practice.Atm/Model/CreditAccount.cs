using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.Atm.Model
{
    internal class CreditAccount : Account
    {
        public CreditAccount()
        {
        }


        public int BonusPoint
        {
            get => default(int);
            set {}
        }
        

        public new decimal Withdraw(decimal cash)
        {
            Console.WriteLine("New one");
            return base.Withdraw(cash);
        }

    }
}
