using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class ice:items
    {
        public ice()
        {
            SetPrice();
            totalPriceOfItem = price;
        }
        protected override void SetPrice()
        {
            price = 1;
        }

       
            
        


    }
}
