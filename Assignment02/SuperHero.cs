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
            int randomNum;
            
            //array to keep track of random numbers used
            int[] check = new int[3];
         
            
                for (int index = 0; index < herosPowers.Length; index++)
                {
                    randomNum = this.rnd.Next(0, stringLength);
                    //for loop to pick powers
                    for (int checkIndex =0; checkIndex<check.Length; checkIndex++)
                    {
                        //using check array to make sure that there is no duplicates 
                        if (randomNum==check[checkIndex])
                        {
                            randomNum = this.rnd.Next(0, stringLength);
                            //resetting the index so that this one is not skipped
                            checkIndex -= 1;
                        }
                        else
                        {
                            herosPowers[index] = superPowers[randomNum];
                            //adding randomNum to check so that we can check for duplicates
                            check[checkIndex] = randomNum;
                            
                        }
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
