using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Number_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte digits = byte.Parse(Console.ReadLine());
            decimal number = decimal.Parse(Console.ReadLine());

            Console.Write(number); 
        }
    }
}
