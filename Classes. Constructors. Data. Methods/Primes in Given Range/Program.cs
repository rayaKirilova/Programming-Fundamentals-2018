using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(", " , CheckingPrimeNumsinRange(x, y))); 
        }

        static bool IsPrime(int n)
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

        static List<int> CheckingPrimeNumsinRange(int start, int end) // there is a problem with number 2 
        {
            List<int> primeNumbers = new List<int>(); 

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i); 
                }
            }

            return primeNumbers; 
        }
    }
}
