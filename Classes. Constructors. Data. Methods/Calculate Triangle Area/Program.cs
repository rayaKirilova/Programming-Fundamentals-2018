﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateTriangleArea(width, height));
        }

        static double CalculateTriangleArea(double x, double y)
        {
            return x * y / 2; 
        }
    }
}
