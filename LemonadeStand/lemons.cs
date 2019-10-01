using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class lemons:items
    {
        protected override void SetPrice()
        {
            price = 1; 
        }

        protected override void SetQuanity(int num)
        {
            quanity = num;
            totalPriceOfItem = price * num; 
        }
    
    
    
    
    
    }
}
