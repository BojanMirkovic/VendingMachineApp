using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftVendingMachine
{
    public class FridgeMagnet : SouvenierProduct
    {
        public static int parisMagnetCounter = 0;
        


        public FridgeMagnet(string _name, decimal _price, string _description)
        {
            name = _name;
            price = _price;
            description = _description;
            if (name.ToLower() == "paris")
            {
                parisMagnetCounter++;

            }
            
        }

    }
}
