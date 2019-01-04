using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(number));

        }

        static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;

            while (n > 0)
            {
                factorial *= n;
                n-- ;
            }

            return factorial; 
        }
    }
}
