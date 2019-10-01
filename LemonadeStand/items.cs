using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   abstract class items
    {
        protected int price;
        protected int quanity;
        static protected int totalPriceOfItem; 

        protected abstract void SetPrice();
        protected abstract void SetQuanity(int num); 
    
    
    
    
    
    
    }
    

}
