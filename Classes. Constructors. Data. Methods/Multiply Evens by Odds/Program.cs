using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int resultOfMultipliedSums = GetSumOfEvenDigits(Math.Abs(number)) * GetSumOfOddDigits(Math.Abs(number));

            Console.WriteLine(resultOfMultipliedSums);


        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0; 

            while (n > 0)
            {
                int lastDigit = n % 10; 

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit; 
                }

                n /= 10; 
            }

            return sum; 
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int lastDigit = n % 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }

            return sum;
        }
    }

}
