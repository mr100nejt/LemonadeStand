using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   static class Invetory
    {
        static public int ammountOfLemons;
        static public int ammountOfIce;
        static public int ammountOfSugar;
        static public int ammountOfPitchers;
        static public int priceOfCups;
        public static List<Pitcher> pitcherList = new List<Pitcher>();
        public static int totalCupsToSell; 

       
        
        public static void SetAmmountsForPitchers()
        {
            Console.WriteLine("you have " + Wallet.money + " dollars");
            Console.WriteLine("how many lemons");
           ammountOfLemons = Int32.Parse(Console.ReadLine());
            Wallet.money = Wallet.money - lemons.totalPriceOfItem * ammountOfLemons;
           
            Console.WriteLine("how much ice");
            ammountOfIce = Int32.Parse(Console.ReadLine());
            Wallet.money = Wallet.money - lemons.totalPriceOfItem * ammountOfIce;
           
            Console.WriteLine("how much sugar");
            ammountOfSugar = Int32.Parse(Console.ReadLine());
            Wallet.money = Wallet.money - Sugar.totalPriceOfItem * ammountOfSugar;
           
            Console.WriteLine("how much per cup");
            priceOfCups = Int32.Parse(Console.ReadLine());

        }
        public static void CreatePitcher()
        {
            while ((ammountOfSugar > 2) && (ammountOfLemons > 3) && (ammountOfIce > 3))
            {
                ammountOfIce = ammountOfIce - 3;
                ammountOfLemons = ammountOfLemons - 3;
                ammountOfSugar = ammountOfSugar - 2; 
                ammountOfPitchers++; 
      
            }
            totalCupsToSell = ammountOfPitchers * 15; 
            for (int i = 1; i <= ammountOfPitchers; i++)
            {
                string Name = "pitcher" + i.ToString();
                pitcherList.Add(new Pitcher() { name = Name });


            }

            Console.WriteLine("you have made " + ammountOfPitchers + " pitchers");
            Console.WriteLine("Each Pitcher cost $6");
        }


    }
}
