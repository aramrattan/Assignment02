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
        private string[] superPowers = {"Super Speed", "Super Strength","Body Armour", "Flight", "Fire Generation","Weather Control"};
        private Random rnd = new Random();
 

        //*****************Constructor Method*************************
        public SuperHero(string name): base (name)
        {
            Hero sHero = new Hero("The Avatar");
            generateRandomPowers();
        }

        //*****************Private Methods****************************
        private string[] generateRandomPowers()
        {
            string[] herosPowers = new string[3];


        }

    }
}
