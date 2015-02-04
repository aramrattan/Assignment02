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
            string[] powersChange = superPowers;

            for (int index = 0; index < herosPowers.Length; index++)
            {
                int num = rnd.Next(superPowers.Length);
                if (powersChange[index] == "USED")
                {
                    num = rnd.Next(superPowers.Length);
                }
                else 
                {
                    herosPowers[index] = superPowers[index];
                    powersChange[index] = "USED";
                }
                
                

            }

             
        }

        //****************Public Methods******************************
        public void show()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("{0}'s powers are:", this.name);
            for (int index = 0; index < herosPowers.Length; index++)
            {
                Console.WriteLine("     -{0}", herosPowers[index]);
            }                
            Console.WriteLine("***********************************************");
   
        }

    }
}
