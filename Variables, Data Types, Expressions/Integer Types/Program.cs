using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1 = byte.Parse(Console.ReadLine());
            uint num2 = uint.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            long num4 = long.Parse(Console.ReadLine());

            Console.Write($"{num1} {num2} {num3} {num4}"); 
        }
    }
}
