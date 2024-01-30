using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftVendingMachine
{
    internal class SoftDrink : DrinkProduct
    {

        public static int cocaColaCounter = 0;
        public static int fantaCounter = 0;


        public SoftDrink(string _name, decimal _price, string _description)
        {
            name = _name;
            price = _price;
            description = _description;
            if (name.ToLower() == "fanta")
            {
                fantaCounter++;
                
            }
            else { cocaColaCounter++; }
        }
    }
}
