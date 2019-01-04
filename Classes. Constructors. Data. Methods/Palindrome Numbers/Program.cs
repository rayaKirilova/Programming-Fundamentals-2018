using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isPalindrome = false; 

            int temp = number;
            int reverse = 0;
            int remainder = 0;

            while (number > 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }

            if (temp == reverse)
            {
                isPalindrome = true;
            }

            Console.WriteLine(isPalindrome);
        }
    }
}
