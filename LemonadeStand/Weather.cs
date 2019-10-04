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
        public static  bool wet;
        public static bool cold;
        public static bool sad;
        public  string tempture; 
        public static List<string> condition;
        public static string dailyTemp;
        public static int dailyTempNumber;
        public static string dailyCondition;
        public static List<string> dailyConditionList = new List<string>();
        public static List<int> dailyTempNumberList = new List<int>();
        public static List<string> forcast;
        public static string allWeather;
        
        

        public string SetTemp(string temp)
        {

           return tempture = temp;  
            
           
            
            
        }

        public void Conditions()
        {
            condition = new List<string>() { "Sunny","cloudy","rainy" };
           
            
        }
        public void Forcast()
        {
            forcast = new List<string>() { SetWeatherConditions("70 ", 0), SetWeatherConditions("75 ", 0), SetWeatherConditions("65 ", 1), SetWeatherConditions("71 ", 1), SetWeatherConditions("70 ", 0), SetWeatherConditions("80 ", 2), SetWeatherConditions("60 ", 2), SetWeatherConditions("90 ", 2), };

            if (Days.dayCounter == 0)
            {
                forcast.ForEach(Console.WriteLine);
            }
            if (Days.dayCounter > 1)
            {
                Console.WriteLine("Would you like to see the forcast?");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "yes":
                        forcast.ForEach(Console.WriteLine);
                        break; 
                    case "no":
                        break;
                    default:
                        Forcast();
                        break;

                }
            }
                      
        }
        public  string SetWeatherConditions(string temp, int num)
        {
            
            tempture = SetTemp(temp);
            int tempNumber = Int32.Parse(tempture);
            dailyCondition = condition[num];
            dailyTempNumber = tempNumber + Customer.RandomNumber(1, 11); ;
            dailyTempNumberList.Add(dailyTempNumber);
            dailyConditionList.Add(dailyCondition);
            dailyTemp = Convert.ToString(dailyTemp);

            allWeather = SetTemp(temp) + condition[num];

            return allWeather; 
            
            
        }
        public static void GetDailyWeather(int num)
        {

            Console.WriteLine("Your daily weather is " + dailyConditionList[num] + " " + dailyTempNumberList[num]);
            if (dailyConditionList[num] == "rainy")
            {
                wet = true;
            }
            else
            {
                wet = false;
            }
            if (dailyConditionList[num] == "cloudy")
            {
                sad = true;
            }
            else
            {
                sad = false;
            }
            if (dailyTempNumberList[num] < 70)
            {
                cold = true;
            }
            else if (dailyTempNumberList[num] > 70)
            {
                cold = false;
            }

        }
    
    }
}
