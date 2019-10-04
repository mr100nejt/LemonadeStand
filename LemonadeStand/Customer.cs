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
        public static int RandomNumber(int num1,int num2)
        {
            Random random = new Random();
            return random.Next(num1,num2);
        }
        public abstract void  ChanceToBuy();
       








    }   
}
