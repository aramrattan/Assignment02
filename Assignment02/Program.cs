/*
 * Student Name: Arlina Ramrattan
 * Student Number: 300799246
 * Date Last Modified: 02/06/2015
 * 
 * Program Description: This program creates a superhero, of your name choice,
 * and generates 3 different powers for them and if choosen, shows them to you. 
 * Program can also "engage" in a fight and show if hits were successful.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        
      
        {
            SuperHero myHero = new SuperHero("The Avatar");
            myHero.showPowers();
            myHero.fight();


        }
    }
}
