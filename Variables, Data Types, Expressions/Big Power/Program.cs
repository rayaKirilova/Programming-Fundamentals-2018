using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; 

namespace Big_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger bigPower = BigInteger.Pow(n, n);

            Console.WriteLine(bigPower);
        }
    }
}
