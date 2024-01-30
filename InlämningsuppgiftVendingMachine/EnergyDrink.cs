using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftVendingMachine
{
    internal class EnergyDrink : DrinkProduct
    {
        public static int redBullCounter = 0;
        public static int monsterCounter = 0;


        public EnergyDrink(string _name, decimal _price, string _description)
        {
            name = _name;
            price = _price;
            description = _description;
            if (name.ToLower() == "red bull")
            {
                redBullCounter++;
            }
            else { monsterCounter++; }
        }

    }
}
