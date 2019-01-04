using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (SumOfDigitsDivisibleBy7(i) && OneEvenDigit(i) && isPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isPalindrome(int n)
        {
            int temp = n;
            int remainder = 0;
            int reverse = 0; 

            while (n > 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;

                n /= 10;     
            }

            if (temp == reverse)
            {
                return true;
            }
            return false;
        } 

        static bool SumOfDigitsDivisibleBy7(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit ;
                n /= 10; 
            }

            if (sum % 7 == 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        static bool OneEvenDigit(int n)
        {

            while (n > 0)
            {
                int digit = n % 10;

                if (digit % 2 == 0)
                {
                    return true; 
                }

                n /= 10;
            }

            return false; 
        }
    }
}
