using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double comission = 0;

            if (sales >= 0 && sales <= 500)
            {
                if (town == "sofia")
                {
                    comission = sales * 0.05;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (town == "varna")
                {
                    comission = sales * 0.045;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (town == "plovdiv")
                {
                    comission = sales * 0.055;
                    Console.WriteLine($"{comission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                if (town == "sofia")
                {
                    comission = sales * 0.07;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (town == "varna")
                {
                    comission = sales * 0.075;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (town == "plovdiv")
                {
                    comission = sales * 0.08;
                    Console.WriteLine($"{comission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                if (town == "sofia")
                {
                    comission = sales * 0.08;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (town == "varna")
                {
                    comission = sales * 0.1;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (town == "plovdiv")
                {
                    comission = sales * 0.12;
                    Console.WriteLine($"{comission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales > 10000)
            {
                if (town == "sofia")
                {
                    comission = sales * 0.12;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (town == "varna")
                {
                    comission = sales * 0.13;
                    Console.WriteLine($"{comission:F2}");
                }
                else if (town == "plovdiv")
                {
                    comission = sales * 0.145;
                    Console.WriteLine($"{comission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (sales < 0)
            {
                Console.WriteLine("error");
            }

        }
    }
}
      