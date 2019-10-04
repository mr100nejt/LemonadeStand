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
            chanceToBuy = RandomNumber(8, 11);
            ChanceToBuy();
        }
        
        public override void ChanceToBuy()
        {
            if (chanceToBuy >= 8)
            {
               if(Invetory.pitcherList.Count > 0)
                {
                    buyCounter++;
                    Wallet.money = Wallet.money + Invetory.priceOfCups;
                    Wallet.moneyForTheDay = Wallet.moneyForTheDay + Invetory.priceOfCups;
                    if (buyCounter == 15)
                    {
                        Invetory.pitcherList.RemoveAt(0);
                        buyCounter = 0; 
                    }
                    else
                    {
                        Console.WriteLine("sold out");
                    }
                }
               
            }

        }

        
    }
}
