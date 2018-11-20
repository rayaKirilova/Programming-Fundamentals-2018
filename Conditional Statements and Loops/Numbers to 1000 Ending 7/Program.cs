using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_1000_Ending_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 1000; i += 10)
            {
                Console.Write(i + " ");
            }
        }
    }
}
