using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Two_Point.Second
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1Coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 3 4
            int[] p2Coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 6 8

            Point point1 = new Point();
            point1.X = p1Coordinates[0];
            point1.Y = p1Coordinates[1];

            Point point2 = new Point();
            point2.X = p2Coordinates[0];
            point2.Y = p2Coordinates[1];

            double sideA = Math.Abs(point1.X - point2.X);
            double sideB = Math.Abs(point1.Y - point2.Y);

            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

            Console.WriteLine($"{distance:F3}");


        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
