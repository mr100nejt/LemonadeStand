using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class medium : Customer// change the chance of buy off either sad or wet. slightly lower chance to buy off of spawn(still random). 
    {

        public medium()
        {
            chanceToBuy = RandomNumber(6, 10);
        }

        public override void ChanceToBuy()
        {
           
            if(Weather.cold == true)
            {
                chanceToBuy = chanceToBuy - 1; 
            }
            
            if (chanceToBuy < 8)
            {
                Buy();
            }

        }


    }

}
}
// i think change these all to diffrent consturctors on the easy class