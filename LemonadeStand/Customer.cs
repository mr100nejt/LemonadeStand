using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   abstract class Customer
    
    
    { 
        public string name;
        protected int chanceToBuy;
        public static int buyCounter;
        public static int soldOutCounter; 
        public static int RandomNumber(int num1,int num2)// here i used the single use of solid all this does is make a random number and i use it in multiple places throughout my program
        {
            Random random = new Random();
            return random.Next(num1,num2);
        }
        public abstract void  ChanceToBuy();
       








    }   
}
