using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cashier
{
    class Program
    {
        static void Main(string[] args)
        {
            double twentyRemainder = 0;
            double tenRemainder = 0;
            double fiveRemainder = 0;
            //double oneRemainder = 0;
            double quarterRemainder = 0;
            double dimeRemainder = 0;
            double nickelRemainder = 0;
            //double pennyRemainder = 0;

            Console.WriteLine("How much is it?");
            double cost = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("How much did they pay?");
            double pay = Convert.ToDouble (Console.ReadLine());

            double change = (pay-cost);
            Console.WriteLine(change);

            // calculate change $20; 10; 5 ; 1
            // calculate coin 25;10;5;1

            int billsTotal = (int)Math.Floor(change);
            Console.WriteLine("bills total $" + billsTotal);
            double coinTotal = Math.Round((change - billsTotal),2);
            Console.WriteLine("Coin total " + coinTotal);

            if (billsTotal >= 0)
            {
                //determine # of 20's
                double twenty = billsTotal / 20;
                Console.WriteLine("Twenty's = " + (int)twenty);
                twentyRemainder = billsTotal % 20;
                //Console.WriteLine("twenty remainder " + twentyRemainder); 
                //determine # of 10's
            }
            if (twentyRemainder > 0)
            {
                double ten = twentyRemainder / 10;
                Console.WriteLine("Ten's = " + (int)ten);
                tenRemainder = twentyRemainder % 10;
                //Console.WriteLine("ten remainder " + tenRemainder);

            }
            if (tenRemainder > 0)
            {
                //determine # of fives
                double five = tenRemainder / 5;
                Console.WriteLine("Five's = " + (int)five);
                fiveRemainder = tenRemainder % 5;
                //Console.WriteLine("five remainder " + fiveRemainder);
            }
            if (fiveRemainder > 0)
            {
                double one = fiveRemainder;
                Console.WriteLine("One's = " + (int)one);
            }
            if (coinTotal > 0)
            {
                double quarter = Math.Round((coinTotal / .25),2);
                Console.WriteLine("Quarters = " + (int)quarter);
                quarterRemainder = (coinTotal % .25);
                //Console.WriteLine("Quarter Remainder = " + quarterRemainder);
            }
            if (quarterRemainder > 0)
            {
                double dime = Math.Round((quarterRemainder / .1),2);
                Console.WriteLine("Dimes = " + (int)dime);
                dimeRemainder = (quarterRemainder % .1);
                //Console.WriteLine("Dime Remainder = " + dimeRemainder);
            }
            if (dimeRemainder > 0)
            {
                double nickel = Math.Round((dimeRemainder / .05),2);
                Console.WriteLine("Nickels = " + (int)nickel);
                nickelRemainder = (dimeRemainder % .05);
                //Console.WriteLine("Nickel Remainder = " + nickelRemainder);
            }
            if (nickelRemainder > 0)
            {
                double penny = Math.Round((nickelRemainder),2);
                Console.WriteLine("Pennies = " + (penny * 100));
            }
            Console.ReadLine();

        






        }

    }
}
