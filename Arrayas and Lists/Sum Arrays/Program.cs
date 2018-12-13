using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLength = Math.Max(firstArray.Length, secondArray.Length); 

            int[] sumArray = new int[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                sumArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
            }

            Console.WriteLine(string.Join(" ", sumArray));

        }

    }
    }
