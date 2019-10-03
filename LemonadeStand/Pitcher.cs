using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        public  int cups = 15;
        public bool full;
        public string name;
        public void CheckIfFull()
        {
            if(cups == 0)
            {
                full = false;  
            }
        }
       
        
    
    }
}
