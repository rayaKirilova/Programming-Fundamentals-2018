using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int maxFromTwoNums = GetMax(x, y); 

            if (maxFromTwoNums < z)
            {
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine(maxFromTwoNums);
            }

        }

        static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a; 
            }
            else
            {
                return b; 
            }
        }
    }
}
