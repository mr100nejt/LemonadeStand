using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class medium : Customer
    {

        public medium()
        {
            chanceToBuy = RandomNumber(6, 10);
            ChanceToBuy();
        }
       
        public override void ChanceToBuy()
        {
           
            if(Weather.cold == true)
            {
                chanceToBuy = chanceToBuy - 1; 
            }
            
            if (chanceToBuy >= 8)
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
                    else
                    {
                        if (soldOutCounter >= 1)
                        {
                            return;
                        }
                        soldOutCounter = soldOutCounter++;
                        Console.WriteLine("sold out");
                    }
                }
            }

        }


    }

}

// i think change these all to diffrent consturctors on the easy class