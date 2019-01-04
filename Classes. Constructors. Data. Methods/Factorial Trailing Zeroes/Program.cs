using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i; 
            }

            Console.WriteLine(CalculatingTrailingZeroes(factorial));
        }

        static int CalculatingTrailingZeroes(BigInteger n)
        {
            int zeroCounter = 0; 

            while (n % 10 == 0)
            {
                zeroCounter++;
                n /= 10 ; 
            }

            return zeroCounter ; 
        }
    }
}
