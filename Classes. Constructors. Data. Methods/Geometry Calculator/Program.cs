using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string figure = Console.ReadLine(); 

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double area = TriangleArea(side, height); 

                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double area = RectangleArea(width, height);

                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                double area = SquareArea(side);

                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double area = CircleArea(radius);

                Console.WriteLine($"{area:F2}");
            }
        }

        static double TriangleArea(double side, double height)
        {
            return side * height / 2; 
        }

        static double SquareArea(double side)
        {
            return side * side; 
        }

        static double RectangleArea(double width, double height)
        {
            return width * height; 
        }

        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius ;
        }
    }
}
