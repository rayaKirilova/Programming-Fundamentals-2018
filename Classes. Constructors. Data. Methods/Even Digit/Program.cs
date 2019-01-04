using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool hasEven = false; 

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    hasEven = true; 
                }
                number /= 10;
            }

            Console.WriteLine(hasEven);

        }
    }
}
