using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Spawner
    {
       public static List<Customer> customerList = new List<Customer>();
        public Spawner()
        {
            SpawnList();
        }
        public static void SpawnList()
        {
           
               
                for (int i = 1; i < 33; i++)
                {
                    string Name = "easyCustomer" + i.ToString();
                    customerList.Add( new Easy() { name = Name });
                      
                       if(i == 33)
                       {
                            for ( i = 1; i < 33; i++)
                            {
                                Name = "mediumCustomer" + i.ToString();
                                customerList.Add(new Easy() { name = Name });
                            }
                                if (i == 33)
                                {
                                    for (i = 1; i < 33; i++)
                                    {
                                        Name = "hardCustomer" + i.ToString();
                                        customerList.Add(new Easy() { name = Name });
                                    }
                                }
                       }    
                       
                }

               
            
        }

    
    
    }
}
