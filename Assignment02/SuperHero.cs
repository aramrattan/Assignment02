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
            //temp array
            // string[] powersChange = new string[stringLength];
            int[] check = new int[3];
            //copying the superPowers array
            /*for (int copyIndex = 0; copyIndex < stringLength; copyIndex++)
            {
                powersChange[copyIndex] = superPowers[copyIndex];
            }*/
            
                for (int index = 0; index < herosPowers.Length; index++)
                {
                    randomNum = this.rnd.Next(0, stringLength);
                    for (int checkIndex =0; checkIndex<check.Length; checkIndex++)
                    {
                        if (randomNum==check[checkIndex])
                        {
                            randomNum = this.rnd.Next(0, stringLength);
                            checkIndex -= 1;
                        }
                        else
                        {
                            herosPowers[index] = superPowers[randomNum];
                            check[checkIndex] = randomNum;
                            
                        }
                    }

                    // Console.WriteLine(randomNum);
                    /*if (powersChange[randomNum] == "USED")
                    {
                        randomNum = this.rnd.Next(0, stringLength);
                        //herosPowers[index] = powersChange[randomNum];
                        //powersChange[index] = "USED";
                        //randomNum = 0;
                    }
                    else
                    {
                        herosPowers[index] = powersChange[randomNum];
                        powersChange[index] = "USED";
                        //randomNum = 0;
                    }*/
                
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
