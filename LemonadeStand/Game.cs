using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
       static public int ammountOfLemons;
       static public int ammountOfIce;
       static public int ammountOfSugar;
        static public int ammountOfPitchers; 
       //comunicate weather to player
        // what day it is 
        
       // profits since begening game 
      private Weather weather = new Weather();  
        public Game()
        {
            Console.WriteLine(weather.forcast);
            SetAmmountsForPitchers();
            CreatePitcher();  
        }
        public void SetAmmountsForPitchers()
        {
            Console.WriteLine("how many lemons");
            ammountOfLemons = Int32.Parse( Console.ReadLine());
            Console.WriteLine("how much ice");
            ammountOfIce = Int32.Parse(Console.ReadLine());
            Console.WriteLine("how much sugar");
            ammountOfSugar = Int32.Parse(Console.ReadLine());
          
        }
        public void CreatePitcher()
        {
            while ((Game.ammountOfSugar < 2) && (Game.ammountOfLemons < 3) && (Game.ammountOfIce < 3))
            {
                ammountOfPitchers++;  
            }
        }



    }
}
