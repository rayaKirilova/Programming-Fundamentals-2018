using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double score = 0;

            if (number <= 100)
            {
                score += 5;
            }
            else if (number > 100 && number < 1000)
            {
                score += number * 0.2;
            }
            else if (number >= 1000)
            {
                score += number * 0.1;
            }

            if (number % 2 == 0)
            {
                score += 1;
            }
            else if (number % 5 == 0)
            {
                score += 2;
            }

            Console.WriteLine(score);
            Console.WriteLine(number + score);
        }
    }
}
