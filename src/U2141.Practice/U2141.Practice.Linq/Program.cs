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
            #region Sample #1
            var data = new List<string> { "JB", "Lily", "Leia" };

            var target = from x in data
                         where x.Equals("JB")
                         select x;

            Console.WriteLine($"My name is {target.FirstOrDefault()}");
            Console.WriteLine("=========================");
            #endregion

            #region Sample #2
            var numData = new List<int>();
            for (var i = 1; i <= 100; i++)
            {
                numData.Add(i);
            }

            var evens = from x in numData
                        where x % 2 == 0
                        select x;

            Console.WriteLine($"Sum = {evens.Sum()}");
            Console.WriteLine($"Average = {evens.Average()}");
            Console.WriteLine("=========================");
            #endregion


            #region Sample #3 - Group
            var dudes = new List<Dude> {

                new Dude{ Name="Luke skywalker", City="Taipei", Age= 25},
                new Dude{ Name="Leia skywalker", City="Tainan", Age= 25},
                new Dude{ Name="Yoda", City="Taipei", Age= 100},
                new Dude{ Name="Motha fuxxer", City="Tainan", Age= 30},
                new Dude{ Name="Stan", City="Taipei", Age= 17}
            };

            var gp = from x in dudes
                     group x by x.City;

            gp.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Key}");
                x.ToList().ForEach(y => { Console.WriteLine($"{y.Name}({y.Age})"); });
            });
            Console.WriteLine("=========================");
            #endregion

            #region Lamda expression

            var sortDudes = dudes.OrderByDescending(x => x.Age);
            sortDudes.ToList().ForEach(x => Console.WriteLine($"{x.Name}({x.Age})"));
            Console.WriteLine("=========================");
            #endregion
        }

        internal class Dude
        {
            public string Name { get; set; }
            public string City { get; set; }
            public int Age { get; set; }
        }
        
    }
}
