using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftVendingMachine
{
    public class ChocolateBar : FoodProduct
    {    public static int SnickersCounter=0;
        public static int MarsCounter = 0;


        public ChocolateBar(string _name,decimal _price, string _description) 
        {
            name = _name;  
            price = _price; 
            description = _description;
            if (name.ToLower()=="mars")
            {
                SnickersCounter++;
            }
            else { MarsCounter++; }
        }

    }
}
