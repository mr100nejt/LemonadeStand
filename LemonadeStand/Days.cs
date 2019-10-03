using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Days
    {
        public static int dayCounter = 0;
        




      
            
            public static void DayCycle()
            {
              
                for (int i = 0;i <= 7;  i++)
                {
                    dayCounter++;
                    string dailyWeather = Weather.dailyCondition + Weather.dailyTemp; 
                    Console.WriteLine("Your daily weather is " + dailyWeather);
                    Invetory.SetAmmountsForPitchers();
                    Invetory.CreatePitcher();
                    Spawner.SpawnList(); 
                    Console.WriteLine(Wallet.moneyForTheDay); 
                    
            
                } 
            
               
            
            } 
    
    }
}
