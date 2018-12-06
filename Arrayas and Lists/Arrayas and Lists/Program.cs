using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayas_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int number = int.Parse(Console.ReadLine()); 

            if (number >= 1 && number <= 7)
            {
                Console.WriteLine(daysOfWeek[number - 1]); 
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            {

            }
        }
    }
}
