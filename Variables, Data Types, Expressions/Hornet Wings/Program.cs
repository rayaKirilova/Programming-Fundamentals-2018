using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            int rests = wingFlaps / endurance; // how many rests the hornet will have
            long secondsPassed = rests * 5L; // total seconds the hornet will rest / using long 


            double metersTravelled = (wingFlaps / 1000) * distanceInMeters ;
            secondsPassed += wingFlaps / 100 ;

            Console.WriteLine($"{metersTravelled:F2} m.");
            Console.WriteLine($"{secondsPassed:F0} s.");
        }
    }
}
