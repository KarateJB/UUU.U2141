using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<string> { "JB", "Lily", "Leia" };

            var target = from x in data
                     where x.Equals("JB")
                     select x;

            Console.WriteLine($"My name is {target.FirstOrDefault()}");

        }
    }
}
