using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(number));


        }

        static bool IsPrime(long n)
        {
            if (n <= 1 || n % 2 == 0)
            {
                return false; 
            }
            if (n == 2)
            {
                return true; 
            }
           

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (n % i == 0)
                {
                    return false; 
                }
            }
            return true;
        }
    }
}
