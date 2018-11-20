using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (count <= n)
                    {
                        Console.Write(count + " ");
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
