using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTA
{
    public class Store              //This place contains the Aggregation method, yup the entire thing(Store and TaxSystem).
    {
        public static int storeMoney = 300;

        //public static int storeRestock;
        //public static int Tax = 3;
        public static TaxSystem taxsystem;

        public void Update()
        {
            taxsystem.Update();
        }


    }
    public class TaxSystem
    {
        public int[] Tax = new int[9];

        public void Update()
        {
            Tax[0] = 2;
            Tax[1] = 3;
            Tax[2] = 4;

            Tax[3] = 2;
            Tax[4] = 3;
            Tax[5] = 4;

            Tax[6] = 2;
            Tax[7] = 3;
            Tax[8] = 4;
        }
    }

    public class StoreInfo      
    {
        public static string storeCondition;
        public static int storeYear;
        public static string storeOwner;
        public static string storeName;
        public StoreInfo()
        {
            storeCondition = "Sturdy";
            storeYear = 1983;
            storeOwner = "Source";
            storeName = "ThriftStore";
            Console.WriteLine($"The name of the establishment goes by {storeName}, it was created in the year of {storeYear} by the current owner {storeOwner}. \nFor an old store like this, it's still considered to be in rather {storeCondition} condition.");
        }
        public StoreInfo(string name, int year, string owner, string condition)
        {
            storeName = name;
            storeYear = year;
            storeCondition = condition;
            storeOwner = owner;
            Console.WriteLine($"The name of the establishment goes by {storeName}, it was created in the year of {storeYear} by the current owner {storeOwner}. \nFor an old store like this, it's still considered to be in rather {storeCondition} condition.");
        }
      

    }
}

