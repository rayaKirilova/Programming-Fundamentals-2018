﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (product == "coffee")
            {
                if (town == "Sofia")
                {
                    price = quantity * 0.50;
                }
                else if (town == "Plovdiv")
                {
                    price = quantity * 0.40;
                }
                else if (town == "Varna")
                {
                    price = quantity * 0.45;
                }
            }
            else if (product == "water")
            {
                if (town == "Sofia")
                {
                    price = quantity * 0.80;
                }
                else if (town == "Plovdiv")
                {
                    price = quantity * 0.70;
                }
                else if (town == "Varna")
                {
                    price = quantity * 0.70;
                }
            }
            else if (product == "beer")
            {
                if (town == "Sofia")
                {
                    price = quantity * 1.20;
                }
                else if (town == "Plovdiv")
                {
                    price = quantity * 1.15;
                }
                else if (town == "Varna")
                {
                    price = quantity * 1.10;
                }
            }
            else if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    price = quantity * 1.45;
                }
                else if (town == "Plovdiv")
                {
                    price = quantity * 1.30;
                }
                else if (town == "Varna")
                {
                    price = quantity * 1.35;
                }
            }
            else if (product == "peanuts")
            {
                if (town == "Sofia")
                {
                    price = quantity * 1.60;
                }
                else if (town == "Plovdiv")
                {
                    price = quantity * 1.50;
                }
                else if (town == "Varna")
                {
                    price = quantity * 1.55;
                }
            }

            Console.WriteLine(price);
        }
    }
}
    