using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTA
{
    public class Store              //This place contains the Aggregation method, yup the entire thing(Store and TaxSystem).
    {
        public static int storeMoney = 40;
        public static int storeSpace = 4;

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
        public static int storeMoney;
        public static int storeSpace;
        public static bool storeTax;
        public static string storeName;
        public StoreInfo()
        {
            storeMoney = 40;
            storeSpace = 4;
            storeTax = true;
            storeName = "ThriftStore";
            Console.WriteLine($"The name of the establishment goes by {storeName} and its resizable space of {storeSpace}.\n The store currently has {storeMoney} Coins who's tax system is {storeTax}. ");
        }
        public StoreInfo(string name, int space, int cash, bool tax)
        {
            storeName = name;
            storeSpace = space;
            storeMoney = cash;
            storeTax = tax;
            Console.WriteLine($"The name of the establishment goes by {storeName} and its resizable space of {storeSpace}.\n The store currently has {storeMoney} Coins who's tax system is {storeTax}. ");
        }
      

    }
}

