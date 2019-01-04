using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digits_Divisible_By_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool sumDivisibleBy7 = false;

            int sum = 0; 

            while (number > 0)
            {

                int digit = number % 10;

                sum += digit;

                number /= 10;
            }

            if (sum % 7 == 0)
            {
                sumDivisibleBy7 = true;
            }

            Console.WriteLine(sumDivisibleBy7);
        }
    }
}
