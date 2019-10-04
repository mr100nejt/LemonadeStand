using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : items
    {

        public Sugar()
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
