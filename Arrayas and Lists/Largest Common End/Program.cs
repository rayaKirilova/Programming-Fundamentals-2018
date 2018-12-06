using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ').ToArray();
            string[] array2 = Console.ReadLine().Split(' ').ToArray();

            int minLength = Math.Min(array1.Length, array2.Length);

            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (array1[i] == array2[i])
                {
                    leftCounter++; 
                }
            }

            Array.Reverse(array1);
            Array.Reverse(array2);

            for (int i = 0; i < minLength; i++)
            {
                if (array1[i] == array2[i])
                {
                    rightCounter++;
                }
            }


            Console.WriteLine(Math.Max(leftCounter, rightCounter));

        }
    }
}
