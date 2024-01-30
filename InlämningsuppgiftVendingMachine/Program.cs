using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace InlämningsuppgiftVendingMachine
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
           //Fyller upp automat med produkter
            FillUppMachine(VendingMachine.foodProductsList, VendingMachine.drinkProductsList,VendingMachine.souvenierProductsList);
           
            //anropar hello och info. methoden
            Greatings();
            GenAppInfoStatus();

            //Fyller upp pengarna
            VendingMachine.InsertMonyIntoMachine();

            // skriver ut menyn
            VendingMachine.ProductsMenu();

           //Beräkna växel
            Wallet.ChangeCalculator();

            Goodbye();

            Console.ReadLine();


        }
        //välkommen meddelande
        private static void Greatings()
        {
            Console.WriteLine("                                  ******* WELCOME TO THE VENDING MACHINE APP *******              ");
            Console.WriteLine("                                              Created by Bojan Mirkovic");
            Console.WriteLine("                                  **************************************************");
            Console.WriteLine();
        }
        //Hej då meddelande
        private static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                  ******* THANK YOU FOR USING VENDING MACHINE APP *******              ");
            Console.WriteLine("                                                 WE WISH YOU WONDERFUL DAY");
            Console.WriteLine("                                  *******************************************************");
            Console.WriteLine();
        }
        //Info meddelande
        private static void GenAppInfoStatus() 
        {
            
         
            Console.WriteLine($"                 At the moment we have: {VendingMachine.foodProductsList.Count} food products, {VendingMachine.drinkProductsList.Count} drink products and {VendingMachine.souvenierProductsList.Count} souvenier products");
            Console.WriteLine();
            Console.WriteLine("                              In ordet to buy products,insert money into Vending Machine App");
            Console.WriteLine();
            Console.WriteLine("                                                 Minimum deposit is 13kr");
            Console.WriteLine("              ***********************************************************************************************");
            Console.ReadLine();
   

        }
        //Listor med olika objekt (produkter) 
        private static void FillUppMachine(List<FoodProduct> foods,List<DrinkProduct> drinks,List<SouvenierProduct> souvenier) 
        {
           

            foods.Add(item: new ChocolateBar("mars", 25, "The Mars chocolate bar consists of caramel and nougat coated with milk chocolate."));
            foods.Add(new ChocolateBar("mars", 25, "The Mars chocolate bar consists of caramel and nougat coated with milk chocolate."));
            foods.Add(new ChocolateBar("mars", 25, "The Mars chocolate bar consists of caramel and nougat coated with milk chocolate."));
            foods.Add(new ChocolateBar("mars", 25, "The Mars chocolate bar consists of caramel and nougat coated with milk chocolate."));
            foods.Add(new ChocolateBar("snickers", 24, "The Snickers chocolate bar consists of nougat, peanuts, and caramel with a chocolate coating"));
            foods.Add(new ChocolateBar("snickers", 24, "The Snickers chocolate bar consists of nougat, peanuts, and caramel with a chocolate coating"));
            foods.Add(new ChocolateBar("snickers", 24, "The Snickers chocolate bar consists of nougat, peanuts, and caramel with a chocolate coating"));
            foods.Add(new ChocolateBar("snickers", 24, "The Snickers chocolate bar consists of nougat, peanuts, and caramel with a chocolate coating"));
            foods.Add(new Chips("pringles", 29, "   190gr potato-based crisps,produced from eko potato and sea salt"));
            foods.Add(new Chips("pringles", 29, "   190gr potato-based crisps,produced from eko potato and sea salt"));
            foods.Add(new Chips("pringles", 29, "   190gr potato-based crisps,produced from eko potato and sea salt"));
            foods.Add(new Chips("pringles", 29, "   190gr potato-based crisps,produced from eko potato and sea salt"));

            drinks.Add(new EnergyDrink("red bull", 23, "Red Bull is energy drink with ingredients of high quality,250ml can contains 80mg of coffein."));
            drinks.Add(new EnergyDrink("red bull", 23, "Red Bull is energy drink with ingredients of high quality,250ml can contains 80mg of coffein."));
            drinks.Add(new EnergyDrink("red bull", 23, "Red Bull is energy drink with ingredients of high quality,250ml can contains 80mg of coffein."));
            drinks.Add(new EnergyDrink("monster", 27, "Monster is energy drink with ingredients of high quality,nutritional value per 100ml is 201 kJ."));
            drinks.Add(new EnergyDrink("monster", 27, "Monster is energy drink with ingredients of high quality,nutritional value per 100ml is 201 kJ."));
            drinks.Add(new EnergyDrink("monster", 27, "Monster is energy drink with ingredients of high quality,nutritional value per 100ml is 201 kJ."));
            drinks.Add(new SoftDrink("cocacola", 15, "CocaCola is carbonated soft drink manufactured by the Coca-Cola company.Contains suger and coffein"));
            drinks.Add(new SoftDrink("cocacola", 15, "CocaCola is carbonated soft drink manufactured by the Coca-Cola company.Contains suger and coffein"));
            drinks.Add(new SoftDrink("cocacola", 15, "CocaCola is carbonated soft drink manufactured by the Coca-Cola company.Contains suger and coffein"));
            drinks.Add(new SoftDrink("fanta", 13, "Fanta is fruit-flavored carbonated soft drink manufactured by the Coca-Cola Deutschland company"));
            drinks.Add(new SoftDrink("fanta", 13, "Fanta is fruit-flavored carbonated soft drink manufactured by the Coca-Cola Deutschland company"));
            drinks.Add(new SoftDrink("fanta", 13, "Fanta is fruit-flavored carbonated soft drink manufactured by the Coca-Cola Deutschland company"));

            souvenier.Add(new FridgeMagnet("paris",30,"Fridge magnet Paris is unique piece of art,hand craft in wood with motives like Eiffel Tower and Notre-Dame cathedral"));
            souvenier.Add(new FridgeMagnet("paris",30,"Fridge magnet Paris is unique piece of art,hand craft in wood with motives like Eiffel Tower and Notre-Dame cathedral"));
            souvenier.Add(new FridgeMagnet("paris",30,"Fridge magnet Paris is unique piece of art,hand craft in wood with motives like Eiffel Tower and Notre-Dame cathedral"));
            souvenier.Add(new Keychain("tower",290, "Keychain Eiffel Tower is unique piece of jewelry,keychain is limited edition from silver and gold made in France"));
            souvenier.Add(new Keychain("tower",290, "Keychain Eiffel Tower is unique piece of jewelry,keychain is limited edition from silver and gold made in France"));
            souvenier.Add(new Keychain("tower",290, "Keychain Eiffel Tower is unique piece of jewelry,keychain is limited edition from silver and gold made in France"));
        }
       




    }
}