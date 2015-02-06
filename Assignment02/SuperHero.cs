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
        private string[] superPowers = {"Super Speed", "Super Strength","Body Armour", "Flight", "Fire Generation","Weather Control", "Water Control", "Laser Vision"};
        private Random rnd = new Random();
       
        private string[] herosPowers = new string[3];

        //*****************Constructor Method*************************
        public SuperHero(string name): base (name)
        {
            generateRandomPowers();
        }

        //*****************Private Methods****************************
        private void generateRandomPowers()
        {
            int stringLength = superPowers.Length;
            //temp array
            string[] powersChange = new string[stringLength];
            for (int copyIndex = 0; copyIndex < stringLength; copyIndex++)
            {
                powersChange[copyIndex] = superPowers[copyIndex];
            }

                for (int index = 0; index < herosPowers.Length; index++)
                {
                    int randomNum = this.rnd.Next(0, stringLength);
                    // Console.WriteLine(randomNum);
                    if (powersChange[randomNum] != "USED")
                    {
                       herosPowers[index] = powersChange[randomNum];
                        powersChange[index] = "USED";
                        randomNum = 0;
                    }
                    else
                    {
                         randomNum = this.rnd.Next(0, stringLength);
                    }



                }

             
        }

   
        //****************Public Methods******************************
        public void showPowers()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("*****         {0}'s Powers        ******", this.name);
            Console.WriteLine("***********************************************");
            for (int index = 0; index < herosPowers.Length; index++)
            {
                Console.WriteLine("     -{0}", herosPowers[index]);
            }                
            Console.WriteLine("***********************************************");
   
        }

    }
}
