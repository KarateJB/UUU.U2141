using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.Domain
{
    public abstract class AbsBook
    {
        public abstract string Name { get; }
        public abstract int Price { get; }
        public abstract int Take(string name);
    }
}
