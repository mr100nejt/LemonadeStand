using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Easy:Customer
    {

        public Easy()
        {
            chanceToBuy = RandomNumber(7, 10);
        }

        public override void ChanceToBuy()
        {
            if (chanceToBuy < 8)
            {
                Buy(); 
            }

        }

        
    }
}
