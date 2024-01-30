using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftVendingMachine
{
    public   static class Wallet

    {
        // vi skapade list så vi kan beräkna total värde av alla element
        static List<decimal> valueSedlarList = new List<decimal>();

        // klas property med hard kodad verde som representerar plånboken värde
      static public decimal sedlar1000st=10M;
      static public decimal sedlar500st =10M;
      static public decimal sedlar200st =10M;
      static public decimal sedlar100st =10M;
      static public decimal sedlar50st  =10M;
      static public decimal sedlar20st  =10M;
      static public decimal mynt10st    =10M;
      static public decimal mynt5st     =10M;
      static public decimal mynt1st     =10M;
      static public decimal mynt05st    = 10M;


        //variabel som ska hjälpa oss at beräkna och spara total plånbok värde
        public static decimal totalMoney = 0M;
        //Beräkning process
        public static decimal TotalWalletAmount()
        {

            decimal valuSedlar1000st = 1000 * sedlar1000st;
            decimal valuSedlar500st = 500 * sedlar500st;
            decimal valuSedlar200st = 200 * sedlar200st;
            decimal valuSedlar100st = 100 * sedlar100st;
            decimal valuSedlar50st = 50 * sedlar50st;
            decimal valuSedlar20st = 20 * sedlar20st;
            decimal valuMynt10st = 10 * mynt10st;
            decimal valuMynt5st = 5 * mynt5st;
            decimal valuMynt1st = 1 * mynt1st;
            decimal valuMynt05st = 0.5M * mynt05st;

            valueSedlarList.Add(valuSedlar1000st);
            valueSedlarList.Add(valuSedlar500st);
            valueSedlarList.Add(valuSedlar200st);
            valueSedlarList.Add(valuSedlar100st);
            valueSedlarList.Add(valuSedlar50st);
            valueSedlarList.Add(valuSedlar20st);
            valueSedlarList.Add(valuMynt10st);
            valueSedlarList.Add(valuMynt5st);
            valueSedlarList.Add(valuMynt1st);
            valueSedlarList.Add(valuMynt05st);
            //med foreach loop,loopar vi genom list och adderar värde av alla sedlar
            foreach (var valu in valueSedlarList)
            {
                totalMoney += valu;
            }
            return totalMoney;
        }
        //växel beräkning
        public static void ChangeCalculator()
        {
            Console.Clear();
            //Tilldelar machine credit värde till ny variabel som ska hjälpa oss att uppdatera plånboken 
            decimal newSaldo = VendingMachine.machineCredit;
            decimal myntChange = Math.Truncate(VendingMachine.machineCredit / 1);

            decimal öreChange = VendingMachine.machineCredit - myntChange;

            decimal lowerChange = VendingMachine.machineCredit - öreChange;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                                             Your real change is: {VendingMachine.machineCredit}");
            // 50 öre växel beräkning
            if (öreChange < 0.25M)
            {
                VendingMachine.machineCredit = lowerChange;
                Console.WriteLine($"                                             Your rounded change is: {VendingMachine.machineCredit}");

            }
            else if (öreChange >= 0.25M && öreChange <= 0.75M)
            {
                //change = change;
                decimal raundedChange = VendingMachine.machineCredit - (öreChange - 0.50M);
                Console.WriteLine($"                                             Your rounded change is: {VendingMachine.machineCredit}");
            }
            else if (öreChange > 0.75M)
            {
                VendingMachine.machineCredit = myntChange + 1;
                Console.WriteLine($"                                             Your rounded change is: {VendingMachine.machineCredit}");
            }


            // updelning för varje sedlar

            sedlar1000st = Math.Truncate(VendingMachine.machineCredit / 1000);
            VendingMachine.machineCredit = VendingMachine.machineCredit % 1000;
            sedlar500st = Math.Truncate(VendingMachine.machineCredit / 500);
            VendingMachine.machineCredit = VendingMachine.machineCredit % 500;
            sedlar200st = Math.Truncate(VendingMachine.machineCredit / 200);
            VendingMachine.machineCredit = VendingMachine.machineCredit % 200;
            sedlar100st = Math.Truncate(VendingMachine.machineCredit / 100);
            VendingMachine.machineCredit = VendingMachine.machineCredit % 100;
            sedlar50st = Math.Truncate(VendingMachine.machineCredit / 50);
            VendingMachine.machineCredit = VendingMachine.machineCredit % 50;
            sedlar20st = Math.Truncate(VendingMachine.machineCredit / 20);
            VendingMachine.machineCredit = VendingMachine.machineCredit % 20;
            mynt10st = Math.Truncate(VendingMachine.machineCredit / 10);
            VendingMachine.machineCredit = VendingMachine.machineCredit % 10;
            mynt5st = Math.Truncate(VendingMachine.machineCredit / 5);
            VendingMachine.machineCredit = VendingMachine.machineCredit % 5;
            mynt1st = Math.Truncate(VendingMachine.machineCredit / 1);
            VendingMachine.machineCredit = VendingMachine.machineCredit % 1;
            mynt05st = Math.Truncate(VendingMachine.machineCredit / 0.5M);
            VendingMachine.machineCredit = VendingMachine.machineCredit;

            // skriva ut final resultat

            Console.WriteLine($"                                                 Sedlar 1000kr = {sedlar1000st}");
            Console.WriteLine($"                                                 Sedlar 500kr = {sedlar500st}");
            Console.WriteLine($"                                                 Sedlar 200kr = {sedlar200st}");
            Console.WriteLine($"                                                 Sedlar 100kr = {sedlar100st}");
            Console.WriteLine($"                                                 Sedlar 50kr = {sedlar50st}");
            Console.WriteLine($"                                                 Sedlar 20kr = {sedlar20st}");
            Console.WriteLine($"                                                 Mynt 10kr = {mynt10st}");
            Console.WriteLine($"                                                 Mynt 5kr = {mynt5st}");
            Console.WriteLine($"                                                 Mynt 1kr = {mynt1st}");
            Console.WriteLine($"                                                 Mynt 50 öre = {mynt05st}");

            Console.WriteLine("                             ****************************************************");
            Console.WriteLine();
            Console.WriteLine("                                                 Colect yor change");
            Console.WriteLine($"                                       Your updated wallet balance is {VendingMachine.newWalletMoney + newSaldo}");

            Console.ReadLine();
        }



    }
}
