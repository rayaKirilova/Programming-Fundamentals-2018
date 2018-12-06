﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = int.Parse(Console.ReadLine());

            int[] sum = new int[array.Length];


            for (int i = 0; i < r; i++)
            {
                int[] rotated = new int[array.Length];
                rotated[0] = array[array.Length - 1];

                for (int j = 1; j < rotated.Length; j++)
                {
                    rotated[j] = array[j - 1]; 
                }

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += rotated[j]; 
                }

                array = rotated;

            }

            Console.WriteLine(string.Join(" ", sum));

                
        }
    }
}
