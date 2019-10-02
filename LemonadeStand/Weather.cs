using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    class  Weather
    {
        //could have been a static class 
        //create 7 day  forcast(in a list)(have a random chance to affect that weather for the acutual day)  
        //acutual weather that day(random numbers that refrence that forcast and edit variables in it.) 
        //tempeture(int)
        //condition(sunny,cloudy,raining)(in a list) 
        public static  bool wet = false;
        public static bool cold = false;
        public static bool sad = false;
        public static string tempture; 
        public static List<string> condition;
        public static string dailyTemp;
        public static int dailyTempNumber;
        public static string dailyCondition;
        public static List<string> forcast;
        public static string allWeather;
        static public int tempNumber = Int32.Parse(Weather.tempture);
        public  Weather()
        {
            Conditions(); 
           

        }

        public static string SetTemp(string temp)
        {

           return tempture = temp;  
            
           
            
            
        }

        public void Conditions()
        {
            condition = new List<string>() { "Sunny","cloudy","rainy" };
           
            
        }

        public static string SetWeatherConditions(string temp, int num)
        {
            tempture = SetTemp(temp);
            dailyCondition = condition[num];
            dailyTempNumber = tempNumber + Customer.RandomNumber(1, 11); ;
            dailyTemp = Convert.ToString(dailyTemp);
            allWeather = SetTemp(temp) + condition[num];
            Console.WriteLine(allWeather);
            if (num == 2)
            {
                 wet = true; 
            }
           else
            {
                wet = false; 
            }
            if(num == 1)
            {
                sad = true; 
            }
            else
            {
                sad = false; 
            }
            if (dailyTempNumber < 70)
            {
                cold = true;
            }
            else if(dailyTempNumber >70)
            {
                cold = false; 
            }
            
            return Console.ReadLine(); 
           
        }
       
    
    }
}
