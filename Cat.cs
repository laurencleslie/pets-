using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace pet
{
    class Cat : pet
    {
        public string name, owner, weight;
        public Cat(string petname, string ownername, double petweight) : base("Cat",petame,ownername,petweight)
        {
            name = petname;
            owner = ownername;
            weight = petweight;
        }

         public string bark(int count)
        {
            string meow = null;
            int i;
            for (i = 0; i < count; i++)
                meow += "meow";
            return meow;
        }
    }
}