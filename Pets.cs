using System;


namespace Pet
{
    class Pets
    {
        public string type, name, owner;
        public double weight;

        public Pet(string petype, string petname, string ownername, double petweight)
        {
            type=petype;
            name=petname;
            owner=ownername;
            weight=petweight;
        }

        public string getTag()
        {
            string tag= "If lost, call " +owner;
            return tag;
            
        }
    }
}