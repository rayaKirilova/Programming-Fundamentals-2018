using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int plus15 = minutes + 15;

            if (hours < 23 && plus15 < 60)
            {
                Console.WriteLine($"{hours}:{plus15}");

            }
            else if (hours < 23 && plus15 >= 60)
            {
                if (plus15 - 60 < 10)
                {
                    Console.WriteLine($"{hours + 1}:0{plus15 - 60}");
                }
                else
                {
                    Console.WriteLine($"{hours + 1}:{plus15 - 60}");
                }

            }
            else if (hours >= 23 && plus15 >= 60)
            {
                if (plus15 - 60 < 10)
                {
                    Console.WriteLine($"{hours - 23}:0{plus15 - 60}");
                }
                else
                {
                    Console.WriteLine($"{hours - 23}:{plus15 - 60}");
                }
            }
            else if (hours >= 23 && plus15 < 60)
            {
                Console.WriteLine($"{hours}:{plus15}");
            }
        }
    }
}
