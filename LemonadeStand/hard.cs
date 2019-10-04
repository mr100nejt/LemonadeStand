using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class hard : Customer
    {
        public hard()
        {
            chanceToBuy = RandomNumber(7, 10);
            ChanceToBuy();
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
            if(Invetory.exspensive == true)
            {
                chanceToBuy = chanceToBuy - 1;
            }
            if (chanceToBuy >= 7)
            {
                if (Invetory.pitcherList.Count > 0)
                {
                    buyCounter++;
                    Wallet.money = Wallet.money + Invetory.priceOfCups;
                    Wallet.moneyForTheDay = Wallet.moneyForTheDay + Invetory.priceOfCups;
                    if (buyCounter == 15)
                    {
                        Invetory.pitcherList.RemoveAt(0);
                        buyCounter = 0;
                    }
                }
                else
                {
                    Console.WriteLine("sold out");
                }
            }




        }
    }
}