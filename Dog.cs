using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace pet
{
    class Dog : pet
    {
        publig string name, owner, weight;
        public Dog(string petname, string ownername, double petweight) : base("Dog",petame,ownername,petweight)
        {
            name = petname;
            owner = ownername;
            weight = petweight;
        }

         public string bark(int count)
        {
            string bark = null;
            int i;
            for (i = 0; i < count; i++)
                bark += "bark!";
            return bark;
        }
    }
}