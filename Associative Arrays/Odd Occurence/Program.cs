using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split(' ').ToList();

            Dictionary<string, int> dictionary = new Dictionary<string, int>() ; 

            foreach (var item in words)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 1); 
                }
                else
                {
                    dictionary[item]++; 
                }
            }

            List<string> result = new List<string>(); 

            foreach (var pair in dictionary)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key); 
                }
            }

            Console.WriteLine(string.Join(", ", result));


        }
    }
}
