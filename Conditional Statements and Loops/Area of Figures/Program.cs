using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double side = double.Parse(Console.ReadLine());

            if (figure == "square")
            {
                double area = side * side;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                double area = Math.PI * side * side;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "rectangle")
            {
                double sideB = double.Parse(Console.ReadLine());
                double area = side * sideB;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                double height = double.Parse(Console.ReadLine());
                double area = side * height / 2;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
