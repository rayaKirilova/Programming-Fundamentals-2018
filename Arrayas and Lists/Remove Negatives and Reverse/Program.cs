using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> positive = new List<int>() ;

            foreach (int num in numbers)
            {
                if (num >= 0)
                {
                    positive.Add(num); 
                }
            }

           positive.Reverse();

            if (positive.Count > 0)
            {
                Console.WriteLine(String.Join(" ", positive));
            }
            else
            {
                Console.WriteLine("empty");
            }

            
        }
    }
}
