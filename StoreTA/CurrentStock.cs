using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreTA
{
    class CurrentStock  //This will be the class that declares.
    {
        protected int[] stock = new int[9]; //Regular Array with the bag set to int. Protected vars can also be accessed by the children.
                                            // This also declares the vars.

        protected TaxSystem taxsystem1 = new TaxSystem();

        virtual public void PrintStock() //This is connected to the other children along with the Array above, Also this is another way of calling it Polymorphism.
        {                                //The use of override is Polymorphism, its purpose is to make Parent-Child relationships be more in reach. 

        }


    }


    class Outfits : CurrentStock //A child can be the parent of a child.
    {

        public Outfits() //This Constructor initiates the Array's vars by giving them a number.
        {
            stock[0] = 5;//jackets
            stock[1] = 3;//pants
            stock[2] = 4;//shoes

        }

        public Outfits(int _jacket, int _pants, int _shoes) //This constructor inits the vars but doesn't give it a number, doing this  
        {                                                   //gives the option to change the numbers that would've been assigned to the 
            stock[0] = _jacket;                             //stocks peviously.
            stock[1] = _pants;
            stock[2] = _shoes;
        }

        public Outfits(int _jacket, int _pants) //This Constructor does the same thing as the one above it, but "stock2" contains an
        {                                       //assigned number that cannot be changed.
            stock[0] = _jacket;
            stock[1] = _pants;
            stock[2] = 4;
        }

        override public void PrintStock() //This void is an override for the other "PrintStock" at the "CurrentStock" class.
        {                    //Consider a Bowl(void) for each Dog(child), the Owner(parent) procceeds to refill the Bowls for all 3 Dogs.
            Console.WriteLine($"Jackets in stock: {stock[0]}"); //for all 3 Dogs.
            Console.WriteLine($"Pants in stock: {stock[1]}");
            Console.WriteLine($"Shoes in stock: {stock[2]}");

        }

        public void BuyPants()
        {

            //do stuff to choose pants
            //confirm purchase
            if (Player.playerMoney >= 10 + taxsystem1.Tax[1])//check price vs player money          
            {
                if (Player.pocketSpace > 0)
                {


                    Console.WriteLine($"Great! That'll be {10} Dollars plus {3} more in Tax, Here is your Pants");
                    //error message not enough money
                    Player.taxTicket++;
                    Store.storeSpace++;
                    Store.storeMoney++;
                    Player.currentItems++;
                    Player.pocketSpace--;
                    Player.playerMoney--;
                    stock[1]--;
                    Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                    Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                    Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                    Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                    Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                    Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                    Console.WriteLine($"Thanks for the purchase!");
                }
                else
                {
                    Console.WriteLine("Seems like your already carrying too much at the moment.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public void BuyPantsTax()
        {

            //do stuff to choose pants
            //confirm purchase
            if (Player.playerMoney >= 10)//check price vs player money
            {
                if (Player.taxTicket >= 1)
                {
                    if (Player.pocketSpace > 0)
                    {



                        Console.WriteLine($"Great! That'll be {10} Dollars, Here is your Pants");
                        //error message not enough money
                        Player.taxTicket--;
                        Store.storeSpace++;
                        Store.storeMoney++;
                        Player.currentItems++;
                        Player.pocketSpace--;
                        Player.playerMoney--;
                        stock[1]--;
                        Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                        Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                        Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                        Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                        Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                        Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                        Console.WriteLine($"Thanks for the purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Seems like your already carrying too much at the moment.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but you don't have any tickets to use. Purchase anything with tax to receive a free ticket.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }

        }

        public int GetPants()
        {
            return stock[0];
        }


        public void BuyJacket()
        {
            if (Player.playerMoney >= 15 + taxsystem1.Tax[0])//check price vs player money
            {
                if (Player.pocketSpace > 0)
                {


                    Console.WriteLine($"Great! That'll be {15} Dollars plus {2} more in Tax, Here is your Jacket!");
                    //error message not enough money
                    Player.taxTicket++;
                    Store.storeSpace++;
                    Store.storeMoney++;
                    Player.currentItems++;
                    Player.pocketSpace--;
                    Player.playerMoney--;
                    stock[0]--;
                    Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                    Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                    Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                    Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                    Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                    Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                    Console.WriteLine($"Thanks for the purchase!");
                }
                else
                {
                    Console.WriteLine("Seems like your already carrying too much at the moment.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public void BuyJacketTax()
        {
            if (Player.playerMoney >= 15)//check price vs player money
            {
                if (Player.taxTicket >= 1)
                {
                    if (Player.pocketSpace > 0)
                    {


                        Console.WriteLine($"Ok that will be {15} Dollars.");
                        //error message not enough money
                        Player.taxTicket--;
                        Store.storeSpace++;
                        Store.storeMoney++;
                        Player.currentItems++;
                        Player.pocketSpace--;
                        Player.playerMoney--;
                        stock[0]--;
                        Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                        Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                        Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                        Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                        Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                        Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                        Console.WriteLine($"Thanks for the purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Seems like your already carrying too much at the moment.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but you don't have any tickets to use. Purchase anything with tax to receive a free ticket.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public int GetJacket()
        {
            return stock[2];
        }


        public void BuyShoes()
        {
            if (Player.playerMoney >= 5 + taxsystem1.Tax[2])
            {
                if (Player.pocketSpace > 0)
                {



                    Console.WriteLine($"Great! That'll be {5} Dollars plus {4} more in Tax");
                    Player.taxTicket++;
                    Store.storeSpace++;
                    Store.storeMoney++;
                    stock[2]--;
                    Player.playerMoney--;
                    Player.currentItems++;
                    Player.pocketSpace--;
                    Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                    Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                    Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                    Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                    Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                    Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                    Console.WriteLine($"Thanks for the purchase!");
                }
                else
                {
                    Console.WriteLine("Seems like your already carrying too much at the moment.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public void BuyShoesTax()
        {
            if (Player.playerMoney > 5)
            {
                if (Player.taxTicket >= 1)
                {
                    if (Player.pocketSpace > 0)
                    {


                        Console.WriteLine($"Ok that will be {5} Dollars.");
                        Player.taxTicket--;
                        Store.storeSpace++;
                        Store.storeMoney++;
                        stock[2]--;
                        Player.playerMoney--;
                        Player.currentItems++;
                        Player.pocketSpace--;
                        Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                        Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                        Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                        Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                        Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                        Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                        Console.WriteLine($"Thanks for the purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Seems like your already carrying too much at the moment.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but you don't have any tickets to use. Purchase anything with tax to receive a free ticket.");
                    return;
                }

            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public int GetShoes()
        {
            return stock[3];
        }

    }


    class Merch : CurrentStock
    {
        public Merch()
        {
            stock[3] = 2; //goldWatch
            stock[4] = 3; //scarf
            stock[5] = 4; //topHat
        }

        public Merch(int goldWatch, int scarf, int topHat)
        {
            stock[3] = goldWatch;
            stock[4] = scarf;
            stock[5] = topHat;
        }
        override public void PrintStock()
        {
            Console.WriteLine($"GoldWatches in stock: {stock[3]}");
            Console.WriteLine($"Scarfs in stock: {stock[4]}");
            Console.WriteLine($"TopHats in stock: {stock[5]}");
        }

        public void BuyGoldWatch()
        {
            if (Player.playerMoney >= 15 + taxsystem1.Tax[3])
            {
                if (Player.pocketSpace > 0)
                {


                    Console.WriteLine($"Great! That'll be {15} Dollars plus {2} more in Tax");
                    Player.taxTicket++;
                    Store.storeSpace++;
                    Store.storeMoney++;
                    stock[3]--;
                    Player.playerMoney--;
                    Player.currentItems++;
                    Player.pocketSpace--;
                    Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                    Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                    Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                    Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                    Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                    Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                    Console.WriteLine($"Thanks for the purchase!");
                }
                else
                {
                    Console.WriteLine("Seems like your already carrying too much at the moment.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public void BuyGoldWatchTax()
        {
            if (Player.playerMoney > 15)
            {
                if (Player.taxTicket >= 1)
                {
                    if (Player.pocketSpace > 0)
                    {


                        Console.WriteLine($"Ok that will be {15} Dollars.");
                        Player.taxTicket--;
                        Store.storeSpace++;
                        Store.storeMoney++;
                        stock[3]--;
                        Player.playerMoney--;
                        Player.currentItems++;
                        Player.pocketSpace--;
                        Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                        Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                        Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                        Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                        Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                        Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                        Console.WriteLine($"Thanks for the purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Seems like your already carrying too much at the moment.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but you don't have any tickets to use. Purchase anything with tax to receive a free ticket.");
                    return;
                }

            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }

        public int GetGoldWatch()
        {
            return stock[3];
        }

        public void BuyScarf()
        {
            if (Player.playerMoney >= 10 + taxsystem1.Tax[4])
            {
                if (Player.pocketSpace > 0)
                {


                    Console.WriteLine($"Great! That'll be {10} Dollars plus {3} more in Tax");
                    Player.taxTicket++;
                    Store.storeSpace++;
                    Store.storeMoney++;
                    stock[4]--;
                    Player.playerMoney--;
                    Player.currentItems++;
                    Player.pocketSpace--;
                    Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                    Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                    Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                    Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                    Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                    Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                    Console.WriteLine($"Thanks for the purchase!");
                }
                else
                {
                    Console.WriteLine("Seems like your already carrying too much at the moment.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public void BuyScarfTax()
        {
            if (Player.playerMoney > 10)
            {
                if (Player.taxTicket >= 1)
                {

                    if (Player.pocketSpace > 0)
                    {


                        Console.WriteLine($"Ok that will be {10} Dollars.");
                        Player.taxTicket--;
                        Store.storeSpace++;
                        Store.storeMoney++;
                        stock[4]--;
                        Player.playerMoney--;
                        Player.currentItems++;
                        Player.pocketSpace--;
                        Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                        Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                        Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                        Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                        Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                        Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                        Console.WriteLine($"Thanks for the purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Seems like your already carrying too much at the moment.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but you don't have any tickets to use. Purchase anything with tax to receive a free ticket.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }

        public int GetScarf()
        {
            return stock[4];
        }

        public void BuyTopHat()
        {
            if (Player.playerMoney >= 10 + taxsystem1.Tax[5])
            {
                if (Player.pocketSpace > 0)
                {


                    Console.WriteLine($"Great! That'll be {10} Dollars plus {4} more in Tax");
                    Player.taxTicket++;
                    Store.storeSpace++;
                    Store.storeMoney++;
                    stock[5]--;
                    Player.playerMoney--;
                    Player.currentItems++;
                    Player.pocketSpace--;
                    Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                    Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                    Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                    Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                    Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                    Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                    Console.WriteLine($"Thanks for the purchase!");
                }
                else
                {
                    Console.WriteLine("Seems like your already carrying too much at the moment.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public void BuyTopHatTax()
        {
            if (Player.playerMoney > 10)
            {
                if (Player.taxTicket >= 1)
                {

                    if (Player.pocketSpace > 0)
                    {


                        Console.WriteLine($"Ok that will be {10} Dollars.");
                        Player.taxTicket--;
                        Store.storeSpace++;
                        Store.storeMoney++;
                        stock[5]--;
                        Player.playerMoney--;
                        Player.currentItems++;
                        Player.pocketSpace--;
                        Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                        Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                        Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                        Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                        Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                        Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                        Console.WriteLine($"Thanks for the purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Seems like your already carrying too much at the moment.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but you don't have any tickets to use. Purchase anything with tax to receive a free ticket.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }

        public int GetTopHat()
        {
            return stock[5];
        }
    }

    class GConsoles : CurrentStock
    {
        public GConsoles()
        {
            stock[6] = 6;//PS3
            stock[7] = 5;//Xbox360
            stock[8] = 7;//Wii
        }
        public GConsoles(int PS3, int Xbox360, int Wii)
        {
            stock[6] = PS3;
            stock[7] = Xbox360;
            stock[8] = Wii;
        }
        override public void PrintStock()
        {
            Console.WriteLine($"We have PS3s in stock: {stock[6]}");
            Console.WriteLine($"We have Xbox360s in stock: {stock[7]}");
            Console.WriteLine($"We have Wiis in stock: {stock[8]}");

        }
        public void BuyPS3()
        {
            if (Player.playerMoney >= 20 + taxsystem1.Tax[6])
            {
                if (Player.pocketSpace > 0)
                {


                    Console.WriteLine($"Great! That'll be {20} Dollars plus {2} more in Tax");
                    Player.taxTicket++;
                    Store.storeSpace++;
                    Store.storeMoney++;
                    stock[6]--;
                    Player.playerMoney--;
                    Player.currentItems++;
                    Player.pocketSpace--;
                    Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                    Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                    Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                    Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                    Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                    Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                    Console.WriteLine($"Thanks for the purchase!");
                }
                else
                {
                    Console.WriteLine("Seems like your already carrying too much at the moment.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public void BuyPS3Tax()
        {
            if (Player.playerMoney > 20)
            {
                if (Player.taxTicket >= 1)
                {

                    if (Player.pocketSpace > 0)
                    {


                        Console.WriteLine($"Ok that will be {20} Dollars.");
                        Player.taxTicket--;
                        Store.storeSpace++;
                        Store.storeMoney++;
                        stock[6]--;
                        Player.playerMoney--;
                        Player.currentItems++;
                        Player.pocketSpace--;
                        Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                        Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                        Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                        Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                        Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                        Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                        Console.WriteLine($"Thanks for the purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Seems like your already carrying too much at the moment.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but you don't have any tickets to use. Purchase anything with tax to receive a free ticket.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }

        public int GetPS3()
        {
            return stock[6];
        }

        public void BuyXbox()
        {
            if (Player.playerMoney >= 25 + taxsystem1.Tax[7])
            {
                if (Player.pocketSpace > 0)
                {


                    Console.WriteLine($"Great! That'll be {25} Dollars plus {3} more in Tax");
                    Player.taxTicket++;
                    Store.storeSpace++;
                    Store.storeMoney++;
                    stock[7]--;
                    Player.playerMoney--;
                    Player.currentItems++;
                    Player.pocketSpace--;
                    Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                    Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                    Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                    Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                    Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                    Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                    Console.WriteLine($"Thanks for the purchase!");
                }
                else
                {
                    Console.WriteLine("Seems like your already carrying too much at the moment.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public void BuyXboxTax()
        {
            if (Player.playerMoney > 25)
            {
                if (Player.taxTicket >= 1)
                {

                    if (Player.pocketSpace > 0)
                    {


                        Console.WriteLine($"Ok that will be {25} Dollars.");
                        Player.taxTicket--;
                        Store.storeSpace++;
                        Store.storeMoney++;
                        stock[7]--;
                        Player.playerMoney--;
                        Player.currentItems++;
                        Player.pocketSpace--;
                        Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                        Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                        Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                        Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                        Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                        Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                        Console.WriteLine($"Thanks for the purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Seems like your already carrying too much at the moment.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but you don't have any tickets to use. Purchase anything with tax to receive a free ticket.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }

        public int GetXbox()
        {
            return stock[7];
        }

        public void BuyWii()
        {
            if (Player.playerMoney >= 20 + taxsystem1.Tax[8])
            {
                if (Player.pocketSpace > 0)
                {


                    Console.WriteLine($"Great! That'll be {20} Dollars plus {4} more in Tax");
                    Player.taxTicket++;
                    Store.storeSpace++;
                    Store.storeMoney++;
                    stock[8]--;
                    Player.playerMoney--;
                    Player.currentItems++;
                    Player.pocketSpace--;
                    Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                    Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                    Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                    Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                    Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                    Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                    Console.WriteLine($"Thanks for the purchase!");
                }
                else
                {
                    Console.WriteLine("Seems like your already carrying too much at the moment.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }
        public void BuyWiiTax()
        {
            if (Player.playerMoney > 20)
            {
                if (Player.taxTicket >= 1)
                {

                    if (Player.pocketSpace > 0)
                    {


                        Console.WriteLine($"Ok that will be {20} Dollars.");
                        Player.taxTicket--;
                        Store.storeSpace++;
                        Store.storeMoney++;
                        stock[8]--;
                        Player.playerMoney--;
                        Player.currentItems++;
                        Player.pocketSpace--;
                        Console.WriteLine($"You have {Player.playerMoney} Dollars.");
                        Console.WriteLine($"You have {Player.currentItems} items in your inventory. ");
                        Console.WriteLine($"You have {Player.pocketSpace} Pocket Space left. ");
                        Console.WriteLine($"You have {Player.taxTicket} Tickets.");
                        Console.WriteLine($"The Store contains {Store.storeMoney} Dollars.");
                        Console.WriteLine($"The Store contains {Store.storeSpace} Storage Space left. ");
                        Console.WriteLine($"Thanks for the purchase!");
                    }
                    else
                    {
                        Console.WriteLine("Seems like your already carrying too much at the moment.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, but you don't have any tickets to use. Purchase anything with tax to receive a free ticket.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Sorry, but you don't have enough to buy this.");
                return;
            }
        }

        public int GetWii()
        {
            return stock[8];
        }
    }
}