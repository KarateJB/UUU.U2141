using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.Domain
{
    public class Calculator
    {
        public static int Add(int a, int b) =>  a+b;
        public static int Minus(int a, int b) => a - b;
        public static int Divide(int a, int b) => a / b;
        public static int Multiplicate(int a, int b) => a * b;
    }
}
