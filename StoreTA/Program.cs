using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StoreTA
{
    public class Program
    {
        public static void Main()
        {
            GConsoles console1 = new GConsoles();
            Outfits outfits1 = new Outfits();   //This IIIIIIS the reference for non-static fields, methods, and properties   a.k.a an object.
            Merch merch1 = new Merch();

            string name = "";
            StreamReader streamReader = new StreamReader(@"lines.txt");

            name = streamReader.ReadLine();


            Console.WriteLine("What's your name, dear customer?");

            name = Console.ReadLine();

            streamReader.Close();


            StreamWriter streamWriter = new StreamWriter(@"lines.txt");

      

            streamWriter.WriteLine(name);

            Console.WriteLine("");

            streamWriter.Close();


            Console.WriteLine($"Well Hello {name}! and welcome to my Store!");
            
            

            Console.WriteLine();

            bool gamerunning = true;


            while (gamerunning)
            {
                Console.WriteLine("\n\nWe've Got three separate sections such as  the, 'Outfits' section, The 'Merch' section, and the 'GConsoles'" +
                              " section!\nOr you can also ask about the 'StoreInfo'.");
                Console.WriteLine("What are you looking for?");

                string read = Console.ReadLine().ToLower();

                if(read == "storeinfo")
                {
                    Console.WriteLine();
                    StoreInfo storeInfo = new StoreInfo();
                    Console.WriteLine();
                }

                if (read == "outfits")
                {

                    Console.WriteLine();
                    Console.WriteLine("Ok which one of the three would you like?");
                    outfits1.PrintStock();
                    Console.WriteLine("the 'Jacket' costs 15 Coins, the 'Pants' cost 10 Coins, and the 'Shoes' cost 5 Coins.");
                    Console.WriteLine("\nOr if you have a tax ticket, you could buy without paying tax by putting " +
                                      "in your desired\n item's name with 'Tax' directly following it. \n");
                    read = Console.ReadLine().ToLower();

                    if(read == "exit")
                    {
                        gamerunning = false;
                    }

                    else if (read == "jacket")
                    {
                        Console.WriteLine("");
                        outfits1.BuyJacket();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "jackettax")
                    {
                        Console.WriteLine("");
                        outfits1.BuyJacketTax();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "pants")
                    {
                        Console.WriteLine("");
                        outfits1.BuyPants();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "pantstax")
                    {
                        Console.WriteLine("");
                        outfits1.BuyPantsTax();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "shoes")
                    {
                        Console.WriteLine("");
                        outfits1.BuyShoes();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "shoestax")
                    {
                        Console.WriteLine("");
                        outfits1.BuyShoesTax();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else
                    {
                        Console.WriteLine("We don't have that here. Please choose something else.");
                    }
                    
                }

                if (read == "merch")
                {
                    Console.WriteLine();
                    Console.WriteLine("Ok which one of the three would you like? The GoldWatch, Scarf, or TopHat?");
                    merch1.PrintStock();
                    Console.WriteLine("the 'GoldWatch' costs 15 Coins, the 'Scarf' cost 10 Coins, and the 'TopHat' cost 10 Coins.");
                    Console.WriteLine("Or if you have a tax ticket, you could buy without paying tax by putting " +
                                      "in your desired\n item's name with 'Tax' being right in front of it. \n");
                    read = Console.ReadLine().ToLower();

                    if (read == "exit")
                    {
                        gamerunning = false;
                    }

                    else if (read == "goldwatch")
                    {
                        Console.WriteLine("");
                        merch1.BuyGoldWatch();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "goldwatchtax")
                    {
                        Console.WriteLine("");
                        merch1.BuyGoldWatchTax();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "scarf")
                    {
                        Console.WriteLine("");
                        merch1.BuyScarf();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "scarftax")
                    {
                        Console.WriteLine("");
                        merch1.BuyScarfTax();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }
                    else if (read == "tophat")
                    {
                        Console.WriteLine("");
                        merch1.BuyTopHat();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "tophattax")
                    {
                        Console.WriteLine("");
                        merch1.BuyTopHatTax();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else
                    {
                        Console.WriteLine("We don't have that here. Please choose something else.");
                    }
                }

                if (read == "gconsole")
                {
                    Console.WriteLine();
                    Console.WriteLine("Ok which one of the three would you like? The PS3, Xbox360, or Wii?");
                    console1.PrintStock();
                    Console.WriteLine("the 'PS3' costs 20 Coins, the 'Xbox360' cost 25 Coins, and the 'Wii' cost 20 Coins.");
                    Console.WriteLine("Or if you have a tax ticket, you could buy without paying tax by putting " +
                                      "in your desired\n item's name with 'Tax' being right in front of it. \n");
                    read = Console.ReadLine().ToLower();

                    if (read == "exit")
                    {
                        gamerunning = false;
                    }

                    else if (read == "ps3")
                    {
                        Console.WriteLine("");
                        console1.BuyPS3();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "ps3tax")
                    {
                        Console.WriteLine("");
                        console1.BuyPS3Tax();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "xbox360")
                    {
                        Console.WriteLine("");
                        console1.BuyXbox();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "xbox360tax")
                    {
                        Console.WriteLine("");
                        console1.BuyXboxTax();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "wii")
                    {
                        Console.WriteLine("");
                        console1.BuyWii();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else if (read == "wiitax")
                    {
                        Console.WriteLine("");
                        console1.BuyWiiTax();
                        Console.WriteLine("");
                        Console.WriteLine($"What else would you like to buy, {name}?");
                    }

                    else
                    {
                        Console.WriteLine("We don't have that here. Please choose something else.");
                    }

                }
            }
            
            Console.WriteLine($"OK {name},Come again soon!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

















            //if (read == "Outfit")
            //{
            //    Console.WriteLine("Ok which one of the three would you like?");
            //    outfits1.PrintStock();
            //    Console.ReadKey(true);
            //    if (read == 'A')
            //        {
            //            Console.WriteLine("Choose");
            //            Console.WriteLine("Choose w/o tax");
            //            outfits1.BuyJacket();
            //            Console.ReadLine();

            //        }

            //        if (read == "Jacket Tax")
            //        {
            //            outfits1.BuyJacketTax();
            //        }

            //        if(read == "Pants")
            //        {
            //            outfits1.BuyPants();
            //        }

            //        if (read == "Pants Tax")
            //        {
            //            outfits1.BuyPantsTax();
            //        }

            //        if (read == "Shoes")
            //        {
            //            outfits1.BuyShoes();
            //        }

            //        if (read == "Shoes Tax")
            //        {
            //            outfits1.BuyShoesTax();
            //        }

            //}

            //string caseswitch = "";

            //if(read == "End")
            //{

            //}
            //while (selection == 0)
            //{

            //    if (read == "Jacket")
            //    {
            //        selection = 1;
            //        outfits1.BuyJacket();


            //    }
            //    else if (read == "Pants")
            //    {
            //        selection = 1;
            //        outfits1.BuyPants();

            //    }
            //    else if (read == "Shoes")
            //    {
            //        selection = 1;
            //        outfits1.BuyShoes();

            //    }

            //    else if (read == "JacketTax")
            //    {
            //        selection = 1;
            //        outfits1.BuyJacketTax();
            //    }
            //    else if (read == "PantsTax")
            //    {
            //        selection = 1;
            //        outfits1.BuyPantsTax();
            //    }
            //    else if (read == "ShoesTax")
            //    {
            //        selection = 1;
            //        outfits1.BuyShoesTax();
            //    }
            //    else if (read == "StoreInfo")
            //    {
            //        selection = 1;
            //        StoreInfo store = new StoreInfo("Thrift Store", 4, 40, true);
            //        Console.ReadLine();
            //    }

            //    if (selection == 1)
            //    {
            //        Console.WriteLine("Anything else, you'd like to buy?");
            //        Console.WriteLine("Choose");
            //        Console.WriteLine("Choose w/o tax");
            //        outfits1.PrintStock();
            //        merch1.PrintStock();
            //        Console.ReadLine(); 
            //        if(read == "Pants")
            //        {
            //            outfits1.BuyPants();

            //        }


            //    }

            //    break;
            //}
            //if (read == "Outfit")
            //{

            //    outfits1.BuyJacket();
            //}

            //switch (read)
            //{
            //    case "Jacket":
            //        selection = "Jacket";
            //        break;

            //    case "JacketTax":
            //        outfits1.BuyJacketTax();
            //        break;

            //    case "Pants":
            //         outfits1.BuyPants();
            //         break;

            //    case "PantsTax":
            //          outfits1.BuyPantsTax();
            //          break;

            //    case "Shoes":
            //          outfits1.BuyShoes();
            //          break;

            //    case "ShoesTax":
            //          outfits1.BuyShoesTax();
            //          break;
            //    default:
            //        break;
            //}

            //}
            //Console.ReadLine();


            //if(read == "Jacket")
            //{
            //    outfits1.BuyJacket();
            //}
            //else if(read == "Pants")
            //{
            //    outfits1.BuyPants();
            //}
            //else if(read == "Shoes")
            //{
            //    outfits1.BuyShoes();
            //}

            //if (selection == "Jacket")
            //{
            //    outfits1.BuyJacket();
            //}
            //switch (read)                                   ////////////////////////////////PROBLEM
            //{
            //    case "Outfit":

            //        selection = "outfit";
            //        //Console.WriteLine("Ok which one of the three would you like?");
            //        //outfits1.PrintStock();
            //        //Console.WriteLine("Choose");
            //        //Console.WriteLine("Choose w/o tax");

            //        break;
            //switch (read)
            //{
            //    case "Jacket":
            //        outfits1.BuyJacket();

            //        break;

            //    case "JacketTax":
            //        outfits1.BuyJacketTax();
            //        break;

            //    case "Pants":
            //        outfits1.BuyPants();
            //        break;

            //    case "PantsTax":
            //        outfits1.BuyPantsTax();
            //        break;

            //    case "Shoes":
            //        outfits1.BuyShoes();
            //        break;

            //    case "ShoesTax":
            //        outfits1.BuyShoesTax();
            //        break;

            //}


            //    case "Merch":
            //        selection = "merch";
            //        Console.WriteLine("Ok which one of the three would you like?");
            //        merch1.PrintStock();
            //        Console.WriteLine("Choose");
            //        Console.WriteLine("Choose w/o tax");
            //        break;

            //    case "GConsole":
            //        Console.WriteLine("Ok which one of the three would you like?");
            //        console1.PrintStock();
            //        Console.WriteLine("Choose");
            //        Console.WriteLine("Choose w/o tax");
            //        break;
            //}

            //if (selection == "outfit")
            //{
            //    Console.WriteLine("Ok which one of the three would you like?");
            //    outfits1.PrintStock();
            //    Console.WriteLine("Choose");
            //    Console.WriteLine("Choose w/o tax");

            //}
            //if (selection == "merch")
            //{
            //    Console.WriteLine("Ok which one of the three would you like?");
            //    merch1.PrintStock();
            //    Console.WriteLine("Choose");
            //    Console.WriteLine("Choose w/o tax");
            //}

            //if (read == "Jacket")
            //{
            //    outfits1.BuyJacket();
            //}

            //if (read == "Jacket Tax")
            //{
            //    outfits1.BuyJacketTax();
            //}

            //if (read == "Pants")
            //{
            //    outfits1.BuyPants();
            //}

            //if (read == "Pants Tax")
            //{
            //    outfits1.BuyPantsTax();
            //}

            //if (read == "Shoes")
            //{
            //    outfits1.BuyShoes();
            //}

            //if (read == "Shoes Tax")
            //{
            //    outfits1.BuyShoesTax();
            //}




            //if (read == "GoldWatch")
            //{
            //    merch1.BuyGoldWatch();
            //}

            //if (read == "GoldWatch Tax")
            //{
            //    merch1.BuyGoldWatchTax();
            //}

            //if (read == "Scarf")
            //{
            //    merch1.BuyScarf();
            //}

            //if (read == "Scarf Tax")
            //{
            //    merch1.BuyScarfTax();
            //}
            //if (read == "TopHat")
            //{
            //    merch1.BuyTopHat();
            //}

            //if (read == "TopHat Tax")
            //{
            //    merch1.BuyTopHatTax();
            //}



            //if (read == "PS3")
            //{
            //    console1.BuyPS3();
            //}

            //if (read == "PS3 Tax")
            //{
            //    console1.BuyPS3Tax();
            //}

            //if (read == "Xbox")
            //{
            //    console1.BuyXbox();
            //}

            //if (read == "Xbox Tax")
            //{
            //    console1.BuyXboxTax();
            //}

            //if (read == "Wii")
            //{
            //    console1.BuyWii();
            //}

            //if (read == "Wii Tax")
            //{
            //    console1.BuyWiiTax();
            //}

            //if (read == "Outfit")
            //{
            //    Console.WriteLine("Ok which one of the three would you like?");
            //    outfits1.PrintStock();
            //    Console.WriteLine("Choose");
            //    Console.WriteLine("Choose w/o tax");

            //    if (read == "Jacket")
            //    {
            //        outfits1.BuyJacket();

            //    }

            //    if (read == "Jacket Tax")
            //    {
            //        outfits1.BuyJacketTax();
            //    }

            //    if(read == "Pants")
            //    {
            //        outfits1.BuyPants();
            //    }

            //    if (read == "Pants Tax")
            //    {
            //        outfits1.BuyPantsTax();
            //    }

            //    if (read == "Shoes")
            //    {
            //        outfits1.BuyShoes();
            //    }

            //    if (read == "Shoes Tax")
            //    {
            //        outfits1.BuyShoesTax();
            //    }

            //}

            //if (read == "Merch")
            //{
            //    Console.WriteLine("Ok which one of the three would you like?");
            //    Console.WriteLine("Choose");
            //    if (read == "GoldWatch")
            //    {
            //        merch1.BuyGoldWatch();
            //    }

            //    if (read == "GoldWatch Tax")
            //    {
            //        merch1.BuyGoldWatchTax();
            //    }

            //    if (read == "Scarf")
            //    {
            //        merch1.BuyScarf();
            //    }

            //    if (read == "Scarf Tax")
            //    {
            //        merch1.BuyScarfTax();
            //    }
            //    if (read == "TopHat")
            //    {
            //        merch1.BuyTopHat();
            //    }

            //    if (read == "TopHat Tax")
            //    {
            //        merch1.BuyTopHatTax();
            //    }
            //}

            //if (read == "GConsole")
            //{
            //    Console.WriteLine("Ok which one of the three would you like?");
            //    Console.WriteLine("Choose");
            //    if (read == "PS3")
            //    {
            //        console1.BuyPS3();
            //    }

            //    if (read == "PS3 Tax")
            //    {
            //        console1.BuyPS3Tax();
            //    }

            //    if (read == "Xbox")
            //    {
            //        console1.BuyXbox();
            //    }

            //    if (read == "Xbox Tax")
            //    {
            //        console1.BuyXboxTax();
            //    }

            //    if (read == "Wii")
            //    {
            //        console1.BuyWii();
            //    }

            //    if (read == "Wii Tax")
            //    {
            //        console1.BuyWiiTax();
            //    }

            // }

            

        }

    }

}
