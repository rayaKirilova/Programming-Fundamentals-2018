﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];

            sequence[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                int startIndex = Math.Max(0, i - k);

                for (int j = startIndex; j < i; j++)
                {
                    sum += sequence[j];
                }

                sequence[i] = sum;
            }
            Console.WriteLine(string.Join(" ", sequence));

        }
    }
}
