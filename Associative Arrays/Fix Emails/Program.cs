using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contactList = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                if (email.Contains(".uk") || email.Contains(".us"))
                {

                }
                else
                {
                    contactList.Add(name, email); 
                }
                     
            }

            foreach (var item in contactList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
