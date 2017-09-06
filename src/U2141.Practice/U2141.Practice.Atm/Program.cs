using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U2141.Practice.Atm.Model;

namespace U2141.Practice.Atm
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Account sAcct = new SavingAccount())
            using (Account acAcct = new CreditAccount())
            using (CreditAccount cAcct = new CreditAccount()) //With "new" 
            {
                //if (sAcct is Account)
                if (sAcct.GetType().Equals(typeof(SavingAccount)))
                {

                    sAcct.Deposit(100);
                    sAcct.Withdraw(50);
                    Console.WriteLine($"餘額={sAcct.Balance}");
                }


                if (acAcct is CreditAccount)
                {
                    acAcct.Deposit(200);
                    acAcct.Withdraw(100);
                    Console.WriteLine($"餘額={acAcct.Balance}");
                }

                if (cAcct is CreditAccount)
                {
                    cAcct.Deposit(300);
                    cAcct.Withdraw(100);
                    Console.WriteLine($"餘額={cAcct.Balance}");
                }
            }

            Console.ReadKey();

        }
    }
}
