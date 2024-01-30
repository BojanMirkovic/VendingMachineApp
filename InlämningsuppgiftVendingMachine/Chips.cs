using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftVendingMachine
{
    public class Chips : FoodProduct
    {   
        public static int chipsCount=0;
        public Chips(string _name, decimal _price, string _description) 
        {
            name = _name;
            price = _price; 
            description = _description;
            chipsCount++;

        }
    }
}
