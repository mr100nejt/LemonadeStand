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
        
      

            
           
            public static void Forcast()
            {
                Weather.forcast = new List<string>() { Weather.SetWeatherConditions("70 ", 0), Weather.SetWeatherConditions("75 ", 0), Weather.SetWeatherConditions("65 ", 1), Weather.SetWeatherConditions("71 ", 1), Weather.SetWeatherConditions("70 ", 0), Weather.SetWeatherConditions("80 ", 2), Weather.SetWeatherConditions("60 ", 2), Weather.SetWeatherConditions("90 ", 2), };

            }
            
            public void DayCycle()// figure out day counter its gotts be the sytem for changing days in the whole game 
            {
              
                for (int i = 0;i <= 7; i++)
                {
                    dayCounter++;
                    string dailyWeather = Weather.dailyCondition + Weather.dailyTemp; 
                    Console.WriteLine("Your daily weather is" + dailyWeather);
                    Spawner.customerList = Spawner.customerList;
                    
            
                } 
            
               
            
            } 
    
    }
}
