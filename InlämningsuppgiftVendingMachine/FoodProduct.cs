using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftVendingMachine
{
    public abstract class FoodProduct : IProduct
    {   
        public string name { get; set; }    
        public string description { get; set; } 
        public decimal price { get; set; }

        
        
    

        public void BuyProduct(List<FoodProduct> y)
        {
                     int i = VendingMachine.i;
                     decimal pay = VendingMachine.machineCredit;
                     decimal price1 = y[i].price;
                     decimal change = pay - price1;
            VendingMachine.machineCredit = change;
            
            Console.WriteLine($"Machine credit balance is {VendingMachine.machineCredit}");

        }
        public void DescribeProduct(string description, decimal price)
        {
            Console.WriteLine();
            Console.WriteLine($"                    {description}");
            Console.WriteLine();
            Console.WriteLine($"                                                  Price is {price}kr");
        }

        public void UseProduct(string name)
        {
            Console.WriteLine();
            Console.WriteLine($"                                                      I am eating {name}");
            Console.WriteLine();
        }


    }



}



