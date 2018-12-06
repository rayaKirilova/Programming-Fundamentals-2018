using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').ToList();  // getting tokens

            List<int> numbers = new List<int>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                int[] tokens = list[i]
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                numbers.AddRange(tokens); 
            }

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
