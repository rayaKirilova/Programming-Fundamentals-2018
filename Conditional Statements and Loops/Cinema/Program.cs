using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double row = double.Parse(Console.ReadLine());
            double col = double.Parse(Console.ReadLine());

            double hallArea = row * col;
            double profitFromTickets = 0;

            if (type == "Premiere")
            {
                profitFromTickets = hallArea * 12;
            }
            else if (type == "Normal")
            {
                profitFromTickets = hallArea * 7.50;
            }
            else if (type == "Discount")
            {
                profitFromTickets = hallArea * 5;
            }

            Console.WriteLine($"{profitFromTickets:F2}");
        }
    }
}
