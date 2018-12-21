using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>(); 

            foreach (double number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, 1); 
                }
                else
                {
                    dictionary[number]++; 
                }
            }

            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine($"{item} -> {dictionary[item]}");
            }
 
        }
    }
}
