using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class SuperHero : Hero 
    {
        //*****************Private Properties*************************
        private string[] superPowers;
 

        //*****************Constructor Method*************************
        public SuperHero(string name): base (name)
        {
            Hero sHero = new Hero("Athena");
            generateRandomPowers();
        }
    }
}
