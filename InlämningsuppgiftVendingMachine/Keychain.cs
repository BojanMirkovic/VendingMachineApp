using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InlämningsuppgiftVendingMachine
{
    public class Keychain : SouvenierProduct
    {

        public static int towerKeychainCounter = 0;



        public Keychain(string _name, decimal _price, string _description)
        {
            name = _name;
            price = _price;
            description = _description;
            if (name.ToLower() == "tower")
            {
                towerKeychainCounter++;

            }

        }
    }
}
