using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.Domain
{
    public class StaticBook
    {
        private static int _count;
        public static int Count { get => _count; }

        public string Name { get; set; }

        public StaticBook()
        {
            _count++;
        }

        public override string ToString()
        {
            return $"Book : {Name}, Count : {Count}";
        }
    }
}
