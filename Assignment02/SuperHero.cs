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
        private string[] herosPowers = new string[3];

        //*****************Constructor Method*************************
        public SuperHero(string name): base (name)
        {
            Hero sHero = new Hero("The Avatar");
            this.name = name;
            generateRandomPowers();
        }

        //*****************Private Methods****************************
        private void generateRandomPowers()
        {
           

             
        }

        //****************Public Methods******************************
        public void show()
        {
            Console.WriteLine("{0}'s powers are:");
            Console.WriteLine("-{0}", herosPowers[0]);
            Console.WriteLine("-{0}", herosPowers[1]);
            Console.WriteLine("-{0}", herosPowers[2]);
   
        }

    }
}
