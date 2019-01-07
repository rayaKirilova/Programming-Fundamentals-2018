using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> sales = new List<Sale>();

            SortedDictionary<string, decimal> salesPerTown = new SortedDictionary<string, decimal>(); 

            for (int i = 0; i < n; i++)
            {
                Sale currentSale = Sale.Parse(Console.ReadLine());

                sales.Add(currentSale); 
            }
            
            foreach (var sale in sales)
            {
                if (!salesPerTown.ContainsKey(sale.Town))
                {
                    salesPerTown.Add(sale.Town, sale.Revenue); 
                }
                else
                {
                    salesPerTown[sale.Town] += sale.Revenue; 
                }
            }

            foreach (var item in salesPerTown)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
}

class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public decimal Revenue
        {
            get
            {
                return Quantity * Price;
            }
        }

        public static Sale Parse(string input)
        {
            var args = input.Split();

            Sale resultSale = new Sale();

            resultSale.Town = args[0];
            resultSale.Product = args[1];
            resultSale.Price = decimal.Parse(args[2]);
            resultSale.Quantity = decimal.Parse(args[3]);

            return resultSale; 
        }
    }
}
