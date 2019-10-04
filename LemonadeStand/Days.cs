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
                 Weather weather = new Weather();
            for (int i = 1;i <= 7;  i++)
                {
                    dayCounter++;
                   
                    Weather.GetDailyWeather(i);
                    weather.Forcast(); 
                    Invetory.SetAmmountsForPitchers();
                    Invetory.CreatePitcher();
                    Spawner.SpawnList(); 
                    Console.WriteLine(Wallet.moneyForTheDay); 
                    
            
                } 
                        
            } 
    }
}
