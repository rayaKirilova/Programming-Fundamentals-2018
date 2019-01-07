using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Point> points = new List<Point>(); 

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                points.Add(Point.ReadPoint(Console.ReadLine()));  
            }

            var minDistance = double.MaxValue;

            Point firstPoint = new Point();
            Point secondPoint = new Point();


            for (int i = 0; i < points.Count; i++)
            {
                for (int k = i + 1; k < points.Count; k++)
                {
                    var distance = CalculateDistanceBetweenPoints(points[i], points[k]);
                    
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPoint = points[i];
                        secondPoint = points[k]; 
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);
        }

        static double CalculateDistanceBetweenPoints(Point a, Point b)
        {
            var sideA = a.X - b.X;
            var sideB = a.Y - b.Y;
            var result = Math.Sqrt(sideA * sideA + sideB * sideB);

            return result; 

        }
    }



    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point ReadPoint(string input)
        {
            int[] coordinates = input.Split().Select(int.Parse).ToArray();

            Point result = new Point();

            result.X = coordinates[0];
            result.Y = coordinates[1];

            return result; 
        }

        public override string ToString()
        {
            return $"({X}, {Y})"; 
        }
    }
}
