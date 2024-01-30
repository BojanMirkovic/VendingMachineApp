using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace InlämningsuppgiftVendingMachine
{
    public static class VendingMachine
    {
        // variabel int i sparar position av produkt som vi behöver att hitta i listan 
        public static int i = 0; 
        // produkter lagring platser
        public static List<FoodProduct> foodProductsList = new List<FoodProduct>();
        public static List<DrinkProduct> drinkProductsList = new List<DrinkProduct>();
        public static List<SouvenierProduct> souvenierProductsList = new List<SouvenierProduct>();

       //variabler som hjälper att beräkna automat kredit,när vi trycker på en av tio sedlar counter sparar info
        private static decimal counter1000 =0;
        private static decimal counter500 =0;
        private static decimal counter200 =0;
        private static decimal counter100 =0;
        private static decimal counter50 =0;
        private static decimal counter20 =0;
        private static decimal counter10 =0;
        private static decimal counter5 = 0;
        private static decimal counter1 = 0;
        private static decimal counter05 = 0;
       //sparar credit som vi matade i automaten
        public static decimal machineCredit = 0;
        //uppdaterad plånboken värde efter matning 
        public static decimal newWalletMoney=0;


       


        //skriver ut menyn 
        public static void ProductsMenu()
        {
            string choice = "";
           

            do
                {
                Console.Clear();
                Console.WriteLine($"Machine credit balance is {VendingMachine.machineCredit}");


                    Console.WriteLine("                                                 Welcome to Vending Machine App");
                    Console.WriteLine("                                            *****************************************");
                    Console.WriteLine("                                            Please choose one of the folowing options");
                    Console.WriteLine();
                    Console.WriteLine("                                                         1.Food Products");
                    Console.WriteLine("                                                         2.Drink Products");
                    Console.WriteLine("                                                         3.Souvenier Products");
                    Console.WriteLine("                                                         4.Money Exchange");
                    Console.WriteLine("                                                         5.Exit Vending Machine");
                    Console.WriteLine("                                            ******************************************");
                    choice = Console.ReadLine();
                    Console.Clear();
                    FoodProductMenu(choice);
                    DrinkProductMenu(choice);
                    SouvenierProductMenu(choice);
                    MoneyExchange(choice);
                if (choice == "5")
                {
                    break;
                }

            } while (choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5");
            
           

        }
        //Anropar metod UseProduct() och skriver ut info,beroende av list av objekt. 
        private static void UseProduct1(List<FoodProduct> x, string name)
        {
            for (int i = 0; i < x.Count; i++)
            {

                if (x[i].name.ToLower() == (name))
                {
                    x[i].UseProduct(name);
                    break;
                }

            }
        }
        private static void UseProduct1(List<DrinkProduct> x, string name)
        {
            for (int i = 0; i < x.Count; i++)
            {

                if (x[i].name.ToLower() == (name))
                {
                    x[i].UseProduct(name);
                    break;
                }

            }
        }
        private static void UseProduct1(List<SouvenierProduct> x, string name)
        {
            for (int i = 0; i < x.Count; i++)
            {

                if (x[i].name.ToLower() == (name))
                {
                    x[i].UseProduct(name);
                    break;
                }

            }
        }

        //Anropar metod DescibeProduct() och skriver ut info,beroende av list av objekt.
        private static void ProductDescription(List<FoodProduct> x, string name)
        {
            for (int i = 0; i < x.Count; i++)
            {

                if (x[i].name.ToLower() == (name))

                {
                    string description1 = x[i].description;
                    decimal price1 = x[i].price;
                    x[i].DescribeProduct(description1, price1);
                    break;
                }

            }

        }
        private static void ProductDescription(List<DrinkProduct> x, string name)
        {
            for (int i = 0; i < x.Count; i++)
            {

                if (x[i].name.ToLower() == (name))

                {
                    string description1 = x[i].description;
                    decimal price1 = x[i].price;
                    x[i].DescribeProduct(description1, price1);
                    break;
                }

            }

        }
        private static void ProductDescription(List<SouvenierProduct> x, string name)
        {
            for (int i = 0; i < x.Count; i++)
            {

                if (x[i].name.ToLower() == (name))

                {
                    string description1 = x[i].description;
                    decimal price1 = x[i].price;
                    x[i].DescribeProduct(description1, price1);
                    break;
                }

            }

        }

        //raderar köpt produkten
        private static void ProductRemoval(List<FoodProduct> x, string name)
        {
            for (int i = 0; i < x.Count; i++)
            {

                if (x[i].name.ToLower() == (name))
                {
                    x.Remove(x[i]);
                    break;
                }
              
            }
        }
        private static void ProductRemoval(List<DrinkProduct> x, string name)
        {
            for (int i = 0; i < x.Count; i++)
            {

                if (x[i].name.ToLower() == (name))
                {
                    x.Remove(x[i]);
                    break;
                }

            }
        }
        private static void ProductRemoval(List<SouvenierProduct> x, string name)
        {
            for (int i = 0; i < x.Count; i++)
            {

                if (x[i].name.ToLower() == (name))
                {
                    x.Remove(x[i]);
                    break;
                }

            }
        }


        private static void FoodProductMenu(string choice)
        {
            string answer = "";
            while (choice == "1")
            {
               
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                           We can offer you 3 diferent products");
                Console.WriteLine("                                      ********************************************");
                Console.WriteLine("                                       Please choose one of the following options");
                Console.WriteLine();
                Console.WriteLine("                                                1.Chocolate bar Mars");
                Console.WriteLine("                                                2.Chocolate bar Snickers");
                Console.WriteLine("                                                3.Chips Pringles");
                Console.WriteLine("                                                4.Exit Food Products Menu");
                Console.WriteLine();
                Console.WriteLine("                                      *********************************************");
                string foodChoice = Console.ReadLine();
                Console.Clear();

                



                if (foodChoice == "1")
                {
                    ProductDescription(foodProductsList, "mars");
                    Console.WriteLine();
                    Console.Write("                                   Would you like to buy this product? Yes/No: ");
                    answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "yes" && (ChocolateBar.MarsCounter > 0)&&(VendingMachine.machineCredit>24))
                    {

                        PayProduct(foodProductsList, "mars");
                        UseProduct1(foodProductsList, "mars");
                        ProductRemoval(foodProductsList, "mars");
                        ChocolateBar.MarsCounter--;
                        Console.WriteLine("                                   Type any key to go back to the food product menu");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                         You have choose not to buy this product or the product is no longer available");
                        Console.WriteLine();
                        Console.WriteLine("                      Check your Machine Credit status! If your credit is below product price select EXIT");
                        Console.WriteLine();
                        Console.WriteLine("                                        Please select something else or EXIT  ");
                        Console.WriteLine();
                        Console.WriteLine("                              ************************************************************");
                        Console.WriteLine();
                                        
                    }

                    


                }
                else if (foodChoice == "2" )
                {
                    ProductDescription(foodProductsList, "snickers");
                    Console.WriteLine();
                    Console.Write("                                   Would you like to buy this product? Yes/No: ");
                    answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "yes" && (ChocolateBar.SnickersCounter > 0) && (VendingMachine.machineCredit > 24))
                    {
                        PayProduct(foodProductsList, "snickers");
                        UseProduct1(foodProductsList, "snickers"); 
                        ProductRemoval(foodProductsList, "snickers");
                        ChocolateBar.SnickersCounter--;
                        Console.WriteLine();
                        Console.WriteLine("                                   Type any key to go back to the food product menu");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                         You have choose not to buy this product or the product is no longer available");
                        Console.WriteLine();
                        Console.WriteLine("                      Check your Machine Credit status! If your credit is below product price select EXIT");
                        Console.WriteLine();
                        Console.WriteLine("                                        Please select something else or EXIT  ");
                        Console.WriteLine();
                        Console.WriteLine("                              ************************************************************");
                        Console.WriteLine(); 

                    }

                }
                else if (foodChoice == "3" )
                {
                    ProductDescription(foodProductsList, "pringles");
                    Console.WriteLine();
                    Console.Write("                                   Would you like to buy this product? Yes/No: ");
                    answer = Console.ReadLine();
                    Console.Clear();

                    if (answer.ToLower() == "yes" && (Chips.chipsCount > 0) && (VendingMachine.machineCredit > 28))
                    {
                        PayProduct(foodProductsList,  "pringles");
                        UseProduct1(foodProductsList, "pringles");
                        ProductRemoval(foodProductsList, "pringles");
                        Chips.chipsCount--;
                        Console.WriteLine("                                   Type any key to go back to the food product menu");
                        Console.ReadKey();
                        Console.Clear();


                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                         You have choose not to buy this product or the product is no longer available");
                        Console.WriteLine();
                        Console.WriteLine("                      Check your Machine Credit status! If your credit is below product price select EXIT");
                        Console.WriteLine();
                        Console.WriteLine("                                        Please select something else or EXIT  ");
                        Console.WriteLine();
                        Console.WriteLine("                              ************************************************************");
                        Console.WriteLine();
                    }
                }
                else if (foodChoice == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                          Thank you for checking our Food Product Menu");
                    Console.WriteLine("                                                     Type any key to exit");
                    choice = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("                                                This is invalid enter!!!");
                    Console.WriteLine("                                            You have to use one of 4 options!!!");
                }
                
            }
        }
        private static void DrinkProductMenu(string choice) 
        {
            string answer = "";
            while (choice == "2")
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                           We can offer you 4 diferent products");
                Console.WriteLine("                                      ********************************************");
                Console.WriteLine("                                       Please choose one of the following options");
                Console.WriteLine();
                Console.WriteLine("                                                   1.Red Bull ");
                Console.WriteLine("                                                   2.Monster ");
                Console.WriteLine("                                                   3.Coca Cola");
                Console.WriteLine("                                                   4.Fanta");
                Console.WriteLine("                                                   5.Exit Drink Products Menu");
                Console.WriteLine();
                Console.WriteLine("                                      *********************************************");
                string drinkChoice = Console.ReadLine();
                Console.Clear();





                if (drinkChoice == "1")
                {
                    ProductDescription(drinkProductsList, "red bull");
                    Console.WriteLine();
                    Console.Write("                                   Would you like to buy this product? Yes/No: ");
                    answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "yes" && (EnergyDrink.redBullCounter > 0) && (VendingMachine.machineCredit > 22))
                    {

                        PayProduct(drinkProductsList, "red bull");
                        UseProduct1(drinkProductsList, "red bull");
                        ProductRemoval(drinkProductsList, "red bull");
                        EnergyDrink.redBullCounter--;
                        Console.WriteLine("                                   Type any key to go back to the food product menu");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                         You have choose not to buy this product or the product is no longer available");
                        Console.WriteLine();
                        Console.WriteLine("                      Check your Machine Credit status! If your credit is below product price select EXIT");
                        Console.WriteLine();
                        Console.WriteLine("                                        Please select something else or EXIT  ");
                        Console.WriteLine();
                        Console.WriteLine("                              ************************************************************");
                        Console.WriteLine();
                    }




                }
                else if (drinkChoice == "2")
                {
                    ProductDescription(drinkProductsList, "monster");
                    Console.WriteLine();
                    Console.Write("                                   Would you like to buy this product? Yes/No: ");
                    answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "yes" && (EnergyDrink.monsterCounter > 0) && (VendingMachine.machineCredit > 26))
                    {
                        PayProduct(drinkProductsList, "monster");
                        UseProduct1(drinkProductsList, "monster");
                        ProductRemoval(drinkProductsList, "monster");
                        EnergyDrink.monsterCounter--;
                        Console.WriteLine();
                        Console.WriteLine("                                   Type any key to go back to the food product menu");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                         You have choose not to buy this product or the product is no longer available");
                        Console.WriteLine();
                        Console.WriteLine("                      Check your Machine Credit status! If your credit is below product price select EXIT");
                        Console.WriteLine();
                        Console.WriteLine("                                        Please select something else or EXIT  ");
                        Console.WriteLine();
                        Console.WriteLine("                              ************************************************************");
                        Console.WriteLine();

                    }

                }
                else if (drinkChoice == "3")
                {
                    ProductDescription(drinkProductsList, "cocacola");
                    Console.WriteLine();
                    Console.Write("                                   Would you like to buy this product? Yes/No: ");
                    answer = Console.ReadLine();
                    Console.Clear();

                    if (answer.ToLower() == "yes" && (SoftDrink.cocaColaCounter > 0) && (VendingMachine.machineCredit > 12))
                    {
                        PayProduct(drinkProductsList, "cocacola");
                        UseProduct1(drinkProductsList, "cocacola");
                        ProductRemoval(drinkProductsList, "cocacola");
                        SoftDrink.cocaColaCounter--;
                        Console.WriteLine("                                   Type any key to go back to the food product menu");
                        Console.ReadKey();
                        Console.Clear();


                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                         You have choose not to buy this product or the product is no longer available");
                        Console.WriteLine();
                        Console.WriteLine("                      Check your Machine Credit status! If your credit is below product price select EXIT");
                        Console.WriteLine();
                        Console.WriteLine("                                        Please select something else or EXIT  ");
                        Console.WriteLine();
                        Console.WriteLine("                              ************************************************************");
                        Console.WriteLine();
                    }
                }
                else if (drinkChoice == "4")
                {


                    ProductDescription(drinkProductsList, "fanta");
                    Console.WriteLine();
                    Console.Write("                                   Would you like to buy this product? Yes/No: ");
                    answer = Console.ReadLine();
                    Console.Clear();

                    if (answer.ToLower() == "yes" && (SoftDrink.cocaColaCounter > 0) && (VendingMachine.machineCredit > 12))
                    {
                        PayProduct(drinkProductsList, "fanta");
                        UseProduct1(drinkProductsList, "fanta");
                        ProductRemoval(drinkProductsList, "fanta");
                        SoftDrink.fantaCounter--;
                        Console.WriteLine("                                   Type any key to go back to the food product menu");
                        Console.ReadKey();
                        Console.Clear();


                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                         You have choose not to buy this product or the product is no longer available");
                        Console.WriteLine();
                        Console.WriteLine("                      Check your Machine Credit status! If your credit is below product price select EXIT");
                        Console.WriteLine();
                        Console.WriteLine("                                        Please select something else or EXIT  ");
                        Console.WriteLine();
                        Console.WriteLine("                              ************************************************************");
                        Console.WriteLine();
                    }

                }

                else if (drinkChoice == "5")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                          Thank you for checking our Drinks Product Menu");
                    Console.WriteLine("                                                     Type any key to exit");
                    choice = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("                                                This is invalid enter!!!");
                    Console.WriteLine("                                            You have to use one of 5 options!!!");
                }

            }
        }
        private static void SouvenierProductMenu(string choice)
        {
            string answer = "";
            while (choice == "3")
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                           We can offer you 2 diferent products");
                Console.WriteLine("                                      ********************************************");
                Console.WriteLine("                                       Please choose one of the following options");
                Console.WriteLine();
                Console.WriteLine("                                                   1.Paris fridge magnet ");
                Console.WriteLine("                                                   2.Eiffel Tower keychain ");
                Console.WriteLine("                                                   3.Exit Souvenier Products Menu");
                Console.WriteLine();
                Console.WriteLine("                                      *********************************************");
                string souvenierChoice = Console.ReadLine();
                Console.Clear();





                if (souvenierChoice == "1")
                {
                    ProductDescription(souvenierProductsList, "paris");
                    Console.WriteLine();
                    Console.Write("                                   Would you like to buy this product? Yes/No: ");
                    answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "yes" && (FridgeMagnet.parisMagnetCounter > 0) && (VendingMachine.machineCredit > 29))
                    {

                        PayProduct(souvenierProductsList, "paris");
                        UseProduct1(souvenierProductsList, "paris");
                        ProductRemoval(souvenierProductsList, "paris");
                        FridgeMagnet.parisMagnetCounter--;
                        Console.WriteLine("                                   Type any key to go back to the food product menu");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                         You have choose not to buy this product or the product is no longer available");
                        Console.WriteLine();
                        Console.WriteLine("                      Check your Machine Credit status! If your credit is below product price select EXIT");
                        Console.WriteLine();
                        Console.WriteLine("                                        Please select something else or EXIT  ");
                        Console.WriteLine();
                        Console.WriteLine("                              ************************************************************");
                        Console.WriteLine();
                    }




                }
                else if (souvenierChoice == "2")
                {
                    ProductDescription(souvenierProductsList, "tower");
                    Console.WriteLine();
                    Console.Write("                                   Would you like to buy this product? Yes/No: ");
                    answer = Console.ReadLine();
                    Console.Clear();
                    if (answer.ToLower() == "yes" && (Keychain.towerKeychainCounter > 0) && (VendingMachine.machineCredit > 289))
                    {
                        PayProduct(souvenierProductsList, "tower");
                        UseProduct1(souvenierProductsList, "tower");
                        ProductRemoval(souvenierProductsList, "tower");
                        Keychain.towerKeychainCounter--;
                        Console.WriteLine();
                        Console.WriteLine("                                   Type any key to go back to the food product menu");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                         You have choose not to buy this product or the product is no longer available");
                        Console.WriteLine();
                        Console.WriteLine("                      Check your Machine Credit status! If your credit is below product price select EXIT");
                        Console.WriteLine();
                        Console.WriteLine("                                        Please select something else or EXIT  ");
                        Console.WriteLine();
                        Console.WriteLine("                              ************************************************************");
                        Console.WriteLine();

                    }

                }
                else if (souvenierChoice == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                          Thank you for checking our Souvenier Product Menu");
                    Console.WriteLine("                                                     Type any key to exit");
                    choice = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("                                                This is invalid enter!!!");
                    Console.WriteLine("                                            You have to use one of 5 options!!!");
                }

            }
        }
        private static void MoneyExchange(string choice)
        {
            
            if (choice == "4")
            {
                //Wallet.ChangeCalculator();
                Console.WriteLine();
                Console.WriteLine("                       Exchanging is complete,EXIT application and colect your change");
                Console.ReadLine(); 
            }
        }
       


        public static decimal InsertMonyIntoMachine() 
        {
            string ansver = "";
            
            decimal walletMoney = Wallet.TotalWalletAmount();
           
            Console.WriteLine($"Wallet money balance is {walletMoney}");
            
            Console.WriteLine();
            do
            {             
                
                InsertMoneyMenu(walletMoney);
                Console.WriteLine();
                Console.Write("                                   Would you like to deposit more money? yes/no: ");
                ansver = Console.ReadLine();
                Console.Clear();
                               
            } while (ansver.ToLower()=="yes");
            machineCredit = (counter1000 * 1000)+(counter500 * 500)+(counter200 * 200)+ (counter100 * 100)+ (counter50 * 50)+
                (counter20 * 20)+ (counter10 * 10)+ (counter5 * 5)+ (counter1 * 1)+ (counter05 * 0.5M);

            newWalletMoney = walletMoney - machineCredit;

            //return ny plånboken värde utan inmatat kredit
            return newWalletMoney;


        }


        //Hittar produkten som vi behöv och anropar BuyProduct()
        private static void PayProduct(List<FoodProduct> y, string name)
        {
            for (i = 0; i < y.Count; i++)
            {
                if (y[i].name.ToLower() == (name))
                {

                    y[i].BuyProduct(y);

                    break;
                }
            }



        }
        private static void PayProduct(List<DrinkProduct> y, string name)
        {
            for ( i = 0; i < y.Count; i++)
            {
                if (y[i].name.ToLower() == (name))
                {

                    y[i].BuyProduct(y);

                    break;
                }
            }



        }
        private static void PayProduct(List<SouvenierProduct> y, string name)
        {
            for ( i = 0; i < y.Count; i++)
            {
                if (y[i].name.ToLower() == (name))
                {

                    y[i].BuyProduct(y);

                    break;
                }
            }



        }

        //Skriver ut menyn och sparar vilken sedlar har vi matat i automat
        private static void InsertMoneyMenu(decimal walletMoney)
        {
            string selectedNumber="";
            do
            {
                Console.WriteLine("                                    ***************************************************");
                Console.WriteLine("                                          Select number to insert desired amount");
                Console.WriteLine("                                           Please insert banknotes into machine");
                Console.WriteLine();              
                Console.WriteLine("                                                        1. 1000kr ");
                Console.WriteLine("                                                        2. 500kr ");
                Console.WriteLine("                                                        3. 200kr ");
                Console.WriteLine("                                                        4. 100kr ");
                Console.WriteLine("                                                        5. 50kr ");
                Console.WriteLine("                                                        6. 20kr ");
                Console.WriteLine("                                                        7. 10kr ");
                Console.WriteLine("                                                        8. 5kr ");
                Console.WriteLine("                                                        9. 1kr ");
                Console.WriteLine("                                                       10. 50öre ");
                Console.WriteLine();              
                Console.WriteLine("                                    ***************************************************");
                selectedNumber = Console.ReadLine();
                Console.Clear();
                if (selectedNumber == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");
                   
                    counter1000++;
                    break;
                }
               else if (selectedNumber == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");
                    counter500++;
                    break;
                }
               else if (selectedNumber == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");

                    counter200++;
                    break;
                }
                else if (selectedNumber == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");

                    counter100++;
                    break;
                }
                else if (selectedNumber == "5")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");

                    counter50++;
                    break;
                }
                else if (selectedNumber == "6")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");

                    counter20++;
                    break;
                }
                else if (selectedNumber == "7")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");

                    counter10++;
                    break;
                }
                else if (selectedNumber == "8")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");

                    counter5++;
                    break;
                }
                else if (selectedNumber == "9")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");

                    counter1++;
                    break;
                }
                else if (selectedNumber == "10")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Vendin Machine App has accepted your deposit");

                    counter05++;
                    break;
                }
                else {
                    Console.WriteLine();
                    Console.WriteLine("                                                This is invalid enter!!!");
                    Console.WriteLine("                                            You have to use one of 10 options!!!"); ; }   


            } while (selectedNumber !="1"|| selectedNumber != "2" || selectedNumber != "3" || selectedNumber != "4" || selectedNumber != "5" || selectedNumber != "6" ||
            selectedNumber != "7" || selectedNumber != "8" || selectedNumber != "9" || selectedNumber != "10");

        }

       


    }
}
