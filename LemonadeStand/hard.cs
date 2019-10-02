using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class hard:Customer//base chance to buy off sad and wet and lower random chance to buy as base 
    {
        public hard()
        {
            chanceToBuy = RandomNumber(5, 10);
        }

        public override void ChanceToBuy()
        {

            if (Weather.cold == true)
            {
                chanceToBuy = chanceToBuy - 1;
            }
            if (Weather.wet == true)
            {
                chanceToBuy = chanceToBuy - 1;
            }
            if (chanceToBuy < 8)
            {
                Buy();
            }




        }
    }
