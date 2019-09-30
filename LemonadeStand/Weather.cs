using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //create 7 day  forcast(in a list)(have a random chance to affect that weather for the acutual day)  
        //acutual weather that day(random numbers that refrence that forcast and edit variables in it.) 
        //tempeture(int)
        //condition(sunny,cloudy,raining)(in a list) 
        public string tempture; 
        public List<string> condition;
        public List<string> forcast;
        public string allWeather; 
        public Weather()
        {
            Conditions(); 
            Forcast(); 

        }

        public string SetTemp(string temp)
        {

           return tempture = temp;  
            
           
            
            
        }

        public void Conditions()
        {
            condition = new List<string>() { "Sunny","cloudy","rainy" };
           
            
        }

        public string SetWeatherConditions(string temp, int num)
        {
           allWeather = SetTemp(temp) + condition[num];
            Console.WriteLine(allWeather);
            return Console.ReadLine(); 
        }
        public void Forcast()
        {
            forcast = new List<string>() {SetWeatherConditions("70 ",0), SetWeatherConditions("75 ", 0), SetWeatherConditions("65 ", 1), SetWeatherConditions("71 ", 1), SetWeatherConditions("70 ", 0), SetWeatherConditions("80 ", 2), SetWeatherConditions("60 ", 2), SetWeatherConditions("90 ", 2), };
            forcast.ForEach(Console.WriteLine);
        }
    
    }
}
