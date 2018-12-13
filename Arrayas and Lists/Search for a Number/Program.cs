using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            int taker = 0;
            int reaper = 0;
            int wanted = 0;
            List<int> takenNum = new List<int>();

            int[] saintThree = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            reaper = saintThree[1];
            wanted = saintThree[2];


            for (int i = 0; i < numbers.Count; i++)
            {
                takenNum.Add(numbers[i]);
            }

            takenNum.RemoveRange(0, reaper);

            if (takenNum.Contains(wanted))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
