using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2141.Practice.Domain
{
    public class LordOfRings : AbsBook
    {
        public override string Name {
            get => "Lord of rings";
        }
        public override int Price { get =>1000;  }

        public override int Take(string name)
        {
            return this.Price;
        }
    }
}
