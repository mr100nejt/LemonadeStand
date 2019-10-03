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
            ChanceToBuy();
        }
        public override void Buy()
        {
            Console.WriteLine("i bought"); 
        }
        public override void ChanceToBuy()
        {
            if (chanceToBuy < 8)
            {
                Wallet.money = Wallet.money + Invetory.priceOfCups;
                Wallet.moneyForTheDay = Wallet.moneyForTheDay + Invetory.priceOfCups;
            }

        }

        
    }
}
