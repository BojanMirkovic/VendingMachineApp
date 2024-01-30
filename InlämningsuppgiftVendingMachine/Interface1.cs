using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftVendingMachine
{
    public interface IProduct
    {


        string name { get; set; }
        string description { get; set; }
        decimal price { get; set; }



        virtual void BuyProduct()
        { }
            
        

            void UseProduct(string name);
            void DescribeProduct(string description,decimal price);

        
    }
}
