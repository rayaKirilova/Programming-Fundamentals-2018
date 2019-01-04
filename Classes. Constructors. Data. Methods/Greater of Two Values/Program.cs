using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine(); 


            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                Console.WriteLine(GetMax(a, b)); 
            }
            else if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(num1, num2));
            }
            else if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(a, b));
            }
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) >= 0)
            {
                return a; 
            }
            else
            {
                return b; 
            }
        }

        static int GetMax(int x, int y)
        {
            if (x > y)
            {
                return x; 
            }
            else
            {
                return y; 
            }
        }

        static char GetMax(char x, char y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
