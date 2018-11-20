using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string dayOfWeek = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            bool workingDays = dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday"
            || dayOfWeek == "thursday" || dayOfWeek == "friday";

            bool daysOff = dayOfWeek == "saturday" || dayOfWeek == "sunday";

            double price = 0;

            if (fruit == "banana")
            {
                if (workingDays)
                {
                    price = quantity * 2.50;
                    Console.WriteLine($"{price:F2}");
                }
                else if (daysOff)
                {
                    price = quantity * 2.70;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "apple")
            {
                if (workingDays)
                {
                    price = quantity * 1.20;
                    Console.WriteLine($"{price:F2}");
                }
                else if (daysOff)
                {
                    price = quantity * 1.25;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "orange")
            {
                if (workingDays)
                {
                    price = quantity * 0.85;
                    Console.WriteLine($"{price:F2}");
                }
                else if (daysOff)
                {
                    price = quantity * 0.90;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapefruit")
            {
                if (workingDays)
                {
                    price = quantity * 1.45;
                    Console.WriteLine($"{price:F2}");
                }
                else if (daysOff)
                {
                    price = quantity * 1.60;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "kiwi")
            {
                if (workingDays)
                {
                    price = quantity * 2.70;
                    Console.WriteLine($"{price:F2}");
                }
                else if (daysOff)
                {
                    price = quantity * 3.00;
                    Console.WriteLine($"{price:F2}");               
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "pineapple")
            {
                if (workingDays)
                {
                    price = quantity * 5.50;
                    Console.WriteLine($"{price:F2}");
                }
                else if (daysOff)
                {
                    price = quantity * 5.60;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (fruit == "grapes")
            {
                if (workingDays)
                {
                    price = quantity * 3.85;
                    Console.WriteLine($"{price:F2}");
                }
                else if (daysOff)
                {
                    price = quantity * 4.20;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
   